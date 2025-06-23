namespace EjercicioLINQ
{
    public class Alumno
    {
        public int Id { get; set; }

        public string? Nombre { get; set; }

        public string? Apellidos { get; set; }

        public int Edad { get; set; }

        public Carrera? Carrera { get; set; }
    }
}
