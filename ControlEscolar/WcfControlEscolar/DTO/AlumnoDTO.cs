using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfControlEscolar.ModeloObjeto;
using WcfControlEscolar.POCO;

namespace WcfControlEscolar.DTO
{
    public class AlumnoDTO
    {
        public static List<Alumno> obtenerAlumnosRegistrados()
        {
            Datos dataSource = new Datos();
            var resultadoConsulta = from al in dataSource.alumnos select al;
            return resultadoConsulta.ToList();
        }
        public static List<Alumno> obtenerAlumnosCandidatosBeca(double promedioMinimo)
        {
            Datos dataSource = new Datos();
            var resultadoConsulta = from al in dataSource.alumnos where al.Promedio >= promedioMinimo select al;
            return resultadoConsulta.ToList();
        }

    }
}