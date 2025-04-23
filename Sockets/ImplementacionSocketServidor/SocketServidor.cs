using System;
using System.Collections.Generic;
using System.Linq;
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
        //const double VALORDOLAR = 20.32;

        public void IniciarServidor()
        {
            IPEndPoint direccionIP = new IPEndPoint(IPAddress.Parse(IP_SERVIDOR), PUERTO);
            Socket socketServidor =
                new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            socketServidor.Bind(direccionIP);
            socketServidor.Listen(0);
            Console.WriteLine("Servidor listo para aceptar conexiones...");
            try
            {
                Socket socketClienteRemoto = socketServidor.Accept();
                Console.WriteLine("socketClienteRemoto conectado");
                string mensaje = "";
                do
                {
                    byte[] bytesEntrada = new byte[1024];
                    int bytesRecibidos = socketClienteRemoto.Receive(bytesEntrada, 0, bytesEntrada.Length, 0);
                    Array.Resize(ref bytesEntrada, bytesRecibidos);
                    mensaje = Encoding.UTF8.GetString(bytesEntrada);
                    Console.WriteLine("Cliente: " + mensaje);
                    /*
                    switch(mensaje.ToLower())
                    {
                        case "fecha":
                            mensaje = DateTime.Today.ToString("dd/MM/yyyy\n");
                            break;
                        case "hora":
                            mensaje = DateTime.Now.ToString("hh:mm:ss\n");
                            break;
                        default:
                            mensaje = "Solicitud incorrecta...\n";
                            break;
                    }
                    string mensajeRespuesta = mensaje;*/
                    /*int valor = Int32.Parse(mensaje);
                    double valorConversion = valor * VALORDOLAR;
                    string cadenaConversion = valorConversion.ToString("F2");
                    string mensajeRespuesta = "El valor " + mensaje + " en dolares es: " + cadenaConversion + "\n";*/
                    string mensajeRespuesta = "Mensaje recibido en el servidor...\n";
                    byte[] bytesSalida = Encoding.UTF8.GetBytes(mensajeRespuesta);
                    socketClienteRemoto.Send(bytesSalida, 0, bytesSalida.Length, 0);
                    Console.WriteLine("Mensaje enviado al cliente...\n");
                } while (!mensaje.ToLower().Equals("salir"));               

            }catch (Exception ex)
            {
                Console.WriteLine("Cierre de conexion: " +ex.Message);  
            }finally
            {
                socketServidor.Close();
            }
            Console.WriteLine("Fin de la ejecucion del sevidor...");
        }
    }
}
