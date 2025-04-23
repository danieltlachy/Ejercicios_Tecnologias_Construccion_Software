using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfControlEscolar.POCO;

namespace WcfControlEscolar.ModeloObjetos
{
    //manipular y llenar informacion
    public class Datos
    {
        public List<Carrera> carreras;
        public List<Alumno> alumnos;
        public Datos()
        {
            carreras = new List<Carrera>();
            alumnos = new List<Alumno>();

            carreras.Add(new Carrera { IdCarrera = 1, Nombre = "Ingenieria de Software" }); //antes de la instanciacion, configura los valores
            // las {} significa un scope o ventana, antes de ejecutar lo que se esté haciendo previo se ejecuta eso
            carreras.Add(new Carrera { IdCarrera = 2, Nombre = "Tecnologias Computacionales" });

            alumnos.Add(new Alumno { IdAlumno = 1, Nombre = "Juan Sánchez Rodriguez", Matricula = "s0339439843", Promedio = 7.9, IdCarrera = 1});
            alumnos.Add(new Alumno { IdAlumno = 2, Nombre = "Bruno Lozano Morales", Matricula = "s9839389324", Promedio = 9.2, IdCarrera = 1 });
            alumnos.Add(new Alumno { IdAlumno = 3, Nombre = "Valeria Lira Marquez", Matricula = "s4354545435", Promedio = 9.9, IdCarrera = 2 });
            alumnos.Add(new Alumno { IdAlumno = 4, Nombre = "Cesar Basilio Gomex", Matricula = "s0339439846", Promedio = 8.2, IdCarrera = 2 });
        }
    }
}