using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionSocketServidor
{
    internal class SocketServidor
    {
        const string IP_SERVIDOR = "127.0.0.1";
        const int PUERTO = 1002;
        private int contadorClientes = 0;
        private static List<Socket> clientesConectados = new List<Socket>();
        private static object locker = new object(); // detiene el recurso para evitar condiciones de carrera

        public void ConectarMultiplesClientes()
        {
            IPEndPoint direccionIP = new IPEndPoint(IPAddress.Parse(IP_SERVIDOR), PUERTO);
            Socket socketServidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socketServidor.Bind(direccionIP);
            socketServidor.Listen();
            Console.WriteLine("Servidor listo para aceptar conexiones...");
            while (true)
            {
                try
                {
                    Socket socketClienteRemoto = socketServidor.Accept();
                    contadorClientes++;
                    IPEndPoint direccionIPCliente = (IPEndPoint)socketClienteRemoto.RemoteEndPoint;
                    Console.WriteLine("Cliente {0} conectado desde IP {1}", contadorClientes, direccionIPCliente.Address);
                    Task.Run(() => AtenderCliente(socketClienteRemoto, contadorClientes));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error aceptando cliente: " + ex.Message);
                }
            }
        }

        public void ConectarClientesChat()
        {
            IPEndPoint direccionIP = new IPEndPoint(IPAddress.Parse(IP_SERVIDOR), PUERTO);
            Socket socketServidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socketServidor.Bind(direccionIP);
            socketServidor.Listen();
            Console.WriteLine("Servidor listo para aceptar conexiones...");
            while (true)
            {
                try
                {
                    Socket socketClienteRemoto = socketServidor.Accept();
                    contadorClientes++;
                    IPEndPoint direccionIPCliente = (IPEndPoint)socketClienteRemoto.RemoteEndPoint;
                    Console.WriteLine("Cliente {0} conectado desde IP {1}", contadorClientes, direccionIPCliente.Address);
                    lock (locker)
                    {
                        clientesConectados.Add(socketClienteRemoto);
                    }
                    Task.Run(() => AtenderCliente(socketClienteRemoto, contadorClientes));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error aceptando cliente: " + ex.Message);
                }
            }
        }

        private void AtenderCliente(Socket socketCliente, int numeroCliente)
        {
            string mensaje = "";
            try
            {
                do
                {
                    byte[] bytesEntrada = new byte[1024];
                    int bytesRecibidos = socketCliente.Receive(bytesEntrada, 0, bytesEntrada.Length, 0);
                    if (bytesRecibidos <= 0)
                        break;
                    Array.Resize(ref bytesEntrada, bytesRecibidos);
                    mensaje = Encoding.UTF8.GetString(bytesEntrada);
                    Console.WriteLine("Mensaje del Cliente {0}: {1}", numeroCliente, mensaje);
                    if (!mensaje.ToLower().Equals("salir"))
                    {
                        string mensajeConIdentificador = $"Cliente {numeroCliente}: {mensaje}";
                        EnviarATodosLosClientes(mensajeConIdentificador, socketCliente);
                    }
                } while (!mensaje.ToLower().Equals("salir"));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error con el Cliente {0}: {1}", numeroCliente, ex.Message);
            }
            finally
            {
                socketCliente.Close();
                lock (locker)
                {
                    clientesConectados.Remove(socketCliente);
                }
                Console.WriteLine("Cliente {0} se ha desconectado...", numeroCliente);
            }
        }

        private void EnviarATodosLosClientes(string mensaje, Socket socketCliente)
        {
            byte[] bytesMensaje = Encoding.UTF8.GetBytes(mensaje);
            lock (locker)
            {
                foreach (Socket socketClienteRemoto in clientesConectados)
                {
                    if (socketClienteRemoto != socketCliente)
                    {
                        try
                        {
                            socketClienteRemoto.Send(bytesMensaje);
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine("Error enviando mensaje a cliente: " + ex.Message);
                        }
                    }
                }
            }
        }
    }
}
