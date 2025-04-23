using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcfConversorGrados
{
    public class Service1 : IService1
    {
        public double convertirCentígradosAFahrenheit(double cantidadA)
        {
            return ((cantidadA * 1.8) + 32);
        }

        public double convertirFahrenheitACentígrados(double cantidadA)
        {
            return ((cantidadA - 32) * 0.555);
        }
    }
}
