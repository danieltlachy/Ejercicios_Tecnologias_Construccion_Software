using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceReference1;

namespace ClienteConsola
{
    internal class Conexion
    {
        public async Task Saludar()
        {
            Console.WriteLine("Escribe tu nombre para recibir un saludo desde WCF");
            string nombre = Console.ReadLine();

            SaludoServiceClient saludo = new SaludoServiceClient();
            string resultado = await saludo.SaludarAsync(nombre);
            
            Console.WriteLine("Respuesta de WCF: " + resultado);
            Console.ReadLine();
        }
    }
}
