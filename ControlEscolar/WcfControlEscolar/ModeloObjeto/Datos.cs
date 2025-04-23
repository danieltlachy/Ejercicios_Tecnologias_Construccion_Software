using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfControlEscolar.POCO;

namespace WcfControlEscolar.ModeloObjeto
{
    public class Datos
    {
        public List<Carrera> carreras;
        public List<Alumno> alumnos;
        public Datos()
        {  
            carreras = new List<Carrera>();
            alumnos = new List<Alumno>();

            carreras.Add(new Carrera { 
                IdCarrera = 1, Nombre = "Ingenieria de software" });//Antes de regresar la instancia de carrera, las llaves permiten asignar valores a las propiedades de la clase carrera
            carreras.Add(new Carrera { IdCarrera = 2, Nombre = "Redes y servicios de computo" });
            carreras.Add(new Carrera { IdCarrera = 3, Nombre = "Ingenieria en ciencia de datos" });

            alumnos.Add(new Alumno { 
                IdAlumno = 1, 
                Nombre = "Juan Vazquez Quinto", 
                Matricula = "s21013896", 
                Promedio = 8.5, 
                IdCarrera = 1 });

            alumnos.Add(new Alumno { 
                IdAlumno = 2, 
                Nombre = "Pedro Pascal Reyes", 
                Matricula = "s21018453", 
                Promedio = 9.5, 
                IdCarrera = 2 });

            alumnos.Add(new Alumno { 
                IdAlumno = 3, 
                Nombre = "Cesar Basilio Gomez", 
                Matricula = "s21013897",
                Promedio = 8.3 ,
                IdCarrera = 3 });

            alumnos.Add(new Alumno { 
                IdAlumno = 4, 
                Nombre = "Daniel Mongeote Tlachy", 
                Matricula = "s21013898", 
                Promedio = 9.0, 
                IdCarrera = 1 });
        }

    }
}