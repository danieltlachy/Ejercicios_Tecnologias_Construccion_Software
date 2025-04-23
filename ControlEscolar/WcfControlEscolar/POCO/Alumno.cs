using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfControlEscolar.POCO
{
    public class Alumno
    {
        public int IdAlumno { get; set; }
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public double Promedio { get; set; }
        public int IdCarrera { get; set; }
    }
}