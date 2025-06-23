using System.Windows;
using System.Windows.Data;

namespace EjercicioLINQ
{
    public partial class MainWindow : Window
    {

        List<Alumno> alumnos = new List<Alumno>();
        List<Carrera> carreras = new List<Carrera>();

        public MainWindow()
        {
            InitializeComponent();
            cargarDatos();
            MostrarAlumnosAgrupados(alumnos);
        }

        private void MostrarAlumnosAgrupados(List<Alumno> lista)
        {
            var alumnosOrdenados = lista.OrderBy(a => a.Apellidos).ToList();

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(alumnosOrdenados);
            view.GroupDescriptions.Clear();
            view.GroupDescriptions.Add(new PropertyGroupDescription("Carrera.Nombre"));

            listViewAlumnos.ItemsSource = view;
        }

        private void cargarDatos()
        {
            carreras.Add(new Carrera { Id = 1, Nombre = "Ingenieria de Software" });
            carreras.Add(new Carrera { Id = 2, Nombre = "Derecho" });
            carreras.Add(new Carrera { Id = 3, Nombre = "Economia" });

            alumnos.Add(new Alumno { Id = 1, Nombre = "Jose", Apellidos = "Sanchez Perez", Edad = 19, Carrera = carreras[0] });
            alumnos.Add(new Alumno { Id = 2, Nombre = "Juan", Apellidos = "Martinez Rodriguez", Edad = 21, Carrera = carreras[1] });
            alumnos.Add(new Alumno { Id = 3, Nombre = "Luis", Apellidos = "Hernandez Ramirez", Edad = 23, Carrera = carreras[2] });
            alumnos.Add(new Alumno { Id = 4, Nombre = "Maria", Apellidos = "Lopez Garcia", Edad = 20, Carrera = carreras[0] });
            alumnos.Add(new Alumno { Id = 5, Nombre = "Ana", Apellidos = "Gonzalez Torres", Edad = 22, Carrera = carreras[1] });
            alumnos.Add(new Alumno { Id = 6, Nombre = "Laura", Apellidos = "Fernandez Jimenez", Edad = 24, Carrera = carreras[2] });
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            string carreraFiltro = tbFiltro.Text.Trim();

            var alumnosFiltrados = (from a in alumnos
                                    where string.IsNullOrEmpty(carreraFiltro) || a.Carrera.Nombre.Equals(carreraFiltro, StringComparison.OrdinalIgnoreCase)
                                    select a).ToList();

            MostrarAlumnosAgrupados(alumnosFiltrados);
        }
    }
}