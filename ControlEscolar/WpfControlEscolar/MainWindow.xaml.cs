using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ServiceReferenceWCF;

namespace WpfControlEscolar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Click_Consultar(object sender, RoutedEventArgs e)
        {
            String promedio = TbPromedio.Text;
            if (promedio.Length > 0 )
            {
                double promedioSeleccionado = double.Parse(promedio);
                ObtenerAlumnosPorPromedio(promedioSeleccionado);
            }
            else
            {
                ObtenerAlumnosCompletos();
                
            }
            
        }
        private void ObtenerAlumnosCompletos()
        {
            Service1Client client = new Service1Client();
            Alumno[] alumnos = client.ObtenerAlumnosAsync().Result;
            List<string> nombreAlumnos = new List<string>();
            foreach (var alumno in alumnos)
            {
                nombreAlumnos.Add(alumno.Nombre);
            }
            CbAlumnos.ItemsSource = nombreAlumnos;
        }
        private void ObtenerAlumnosPorPromedio(double promedio)
        {
            Service1Client client = new Service1Client();
            Alumno[] alumnos = client.ObtenerAlumnosBecaAsync(promedio).Result;
            List<string> nombreAlumnos = new List<string>();
            foreach (var alumno in alumnos)
            {
                nombreAlumnos.Add(alumno.Nombre + " - promedio: " + alumno.Promedio);
            }
            CbAlumnos.ItemsSource = nombreAlumnos;
        }
    }
}