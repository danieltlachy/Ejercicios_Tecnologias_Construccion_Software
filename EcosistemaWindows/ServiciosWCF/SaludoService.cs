using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiciosWCF
{
    public class SaludoService : ISaludoService
    {
        public string Saludar(string nombre)
        {
            return $"Hola {nombre}, Bienvenido(a) a WCF";
        }
    }
}
