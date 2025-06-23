using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionSocketCliente
{
	internal class SocketCliente
    {
        const string IP_SERVIDOR = "127.0.0.1";
        const int PUERTO = 1002;

        public void IniciarSocketCliente()
        {
            IPEndPoint direccionServidor = new IPEndPoint(IPAddress.Parse(IP_SERVIDOR), PUERTO);
            Socket socketCliente =
                new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                socketCliente.Connect(direccionServidor);
                Console.WriteLine("Conexión realizada con exito al servidor...");
                string mensaje = "";
                do
                {
                    Console.WriteLine("\nEscribe un mensaje para enviar al servidor (o escribe 'salir'):  ");
                    mensaje = Console.ReadLine();
                    byte[] bytesSalida = Encoding.UTF8.GetBytes(mensaje);
                    socketCliente.Send(bytesSalida, 0, bytesSalida.Length, 0);
                    Console.WriteLine("Mensaje enviado al servidor..." );

                    byte[] bytesEntrada= new byte[1024];
                    int bytesRecibidos = socketCliente.Receive(bytesEntrada, 0, bytesEntrada.Length, 0);
                    Array.Resize(ref bytesEntrada, bytesRecibidos);
                    string mensajeRespuesta = Encoding.UTF8.GetString(bytesEntrada);
                    Console.Write("Servidor: " + mensajeRespuesta);
                } while (!mensaje.ToLower().Equals("salir"));
                socketCliente.Shutdown(SocketShutdown.Both);
            }catch (Exception ex)
            {
                Console.WriteLine("Cierre de conexion: " + ex.Message);
            }finally
            {
                socketCliente.Close();
            }
            Console.WriteLine("Cierre de la conexión...");
        }

        public void IniciarChat()
        {
            IPEndPoint direccionServidor = new IPEndPoint(IPAddress.Parse(IP_SERVIDOR), PUERTO);
            Socket socketCliente = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                socketCliente.Connect(direccionServidor);
                Console.WriteLine("Conexión realizada con exito al servidor...");
                Console.WriteLine("\nChat iniciado, escribe un mensaje para enviar (o escribe 'salir'):  ");
                string mensaje = "";

                Task.Run(() =>
                {
                    while (true)
                    {
                        try
                        {
                            byte[] bytesEntrada = new byte[1024];
                            int bytesRecibidos = socketCliente.Receive(bytesEntrada, 0, bytesEntrada.Length, 0);
                            if (bytesRecibidos > 0)
                            {
                                Array.Resize(ref bytesEntrada, bytesRecibidos);
                                string mensajeRespuesta = Encoding.UTF8.GetString(bytesEntrada);
                                Console.WriteLine("\n{0}", mensajeRespuesta);
                                Console.WriteLine("Tú: ");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error en la recepción de mensajes: " + ex.Message);
                            break;
                        }
                    }
                });

                do
                {
                    Console.WriteLine("Tú: ");
                    mensaje = Console.ReadLine();
                    byte[] bytesSalida = Encoding.UTF8.GetBytes(mensaje);
                    socketCliente.Send(bytesSalida, 0, bytesSalida.Length, 0);
                } while (!mensaje.ToLower().Equals("salir"));
                socketCliente.Close();
                Console.WriteLine("Cierre de la conexión...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cierre de conexion: " + ex.Message);
            }
        }
    }
}