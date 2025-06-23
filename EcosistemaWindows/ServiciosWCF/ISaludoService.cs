using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiciosWCF
{
    [ServiceContract]
    public interface ISaludoService
    {
        [OperationContract]
        string Saludar(string nombre);
    }
}
