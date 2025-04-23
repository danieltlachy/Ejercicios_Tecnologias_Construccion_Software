using System.ServiceModel;

namespace wcfcalculadora
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string calcularOperaciones(double cantidadA, double cantidadB, double cantidadC, double cantidadD, double cantidadE);
    }
}