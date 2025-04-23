using System;

namespace wcfcalculadora
{
    public class Service1 : IService1
    {
        public string calcularOperaciones(double cantidadA, double cantidadB, double cantidadC, double cantidadD, double cantidadE)
        {
            if (cantidadA < 0 || cantidadB < 0 || cantidadC < 0 || cantidadD < 0 || cantidadE < 0)
            {
                throw new ArgumentException("Alguno de los valores enviados es menor a cero. Intentélo de nuevo");
            }
            else
            {
                return ("Suma: " + ((((cantidadA + cantidadB) + cantidadC) + cantidadD) + cantidadE))
                    + (" Resta: " + ((((cantidadA - cantidadB) - cantidadC) - cantidadD) - cantidadE))
                    + (" Multiplicacion: " + ((((cantidadA * cantidadB) * cantidadC) * cantidadD) * cantidadE))
                    + (" Division: " + ((((cantidadA / cantidadB) / cantidadC) / cantidadD) / cantidadE));
            }
        }
    }
}
