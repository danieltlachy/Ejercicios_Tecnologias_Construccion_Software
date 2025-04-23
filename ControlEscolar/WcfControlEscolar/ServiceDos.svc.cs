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
    public class ServiceDos : IService1
    {
        public List<Alumno> ObtenerAlumnos()
        {
            return AlumnoDTO.ObtenerAlumnosRegistrados();
        }

        public List<Alumno> ObtenerAlumnosBeca(double promedioMinimo)
        {
            if(promedioMinimo < 0 || promedioMinimo > 10)
                throw new ArgumentException("El valor del promedio es incorrecto"); //para y no retorna
            return AlumnoDTO.ObtenerAlumnosCandidatosBeca(promedioMinimo);
        }

        public List<Alumno> ObtenerAlumnosPromedio()
        {
            return AlumnoDTO.ObtenerAlumnosPromedioEspecifico();
        }

        public int[] ObtenerCantidadAlumnosPorCarrera()
        {
            return AlumnoDTO.ObtenerCantidadAlumnosPorCarrera();
        }

        public List<Alumno> ObtenerNombreAlumnoYCarrera()
        {
            return AlumnoDTO.ObtenerNombreAlumnoYCarrera();
        }

        public List<Alumno> ObtenerNombreYPromedioPorCarrera(string carrera)
        {
            return AlumnoDTO.ObtenerAlumnosCarreraEspecifica(carrera);
        }

        public double ObtenerPromedioGlobalTodos()
        {
            return AlumnoDTO.ObtenerPromedioGlobal();
        }

    }
}
