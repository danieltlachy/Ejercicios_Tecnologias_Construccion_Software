using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfControlEscolar.DTO;
using WcfControlEscolar.POCO;

namespace WcfControlEscolar
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public List<Alumno> ObtenerAlumnos()
        {
            return AlumnoDTO.obtenerAlumnosRegistrados();
        }

        public List<Alumno> ObtenerAlumnosBeca(double promedioMinimo)
        {
            if (promedioMinimo < 0 || promedioMinimo > 10)
            {
                throw new ArgumentException("El promedio minimo debe ser mayor a 0 y menor a 10");
            }else
                return AlumnoDTO.obtenerAlumnosCandidatosBeca(promedioMinimo);
        }
    }
}

