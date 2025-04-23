using System.Collections.ObjectModel;
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

namespace ComboBox;

public partial class MainWindow : Window
{

    private ObservableCollection<string> rams = new ObservableCollection<string>();

    public MainWindow()
    {
        InitializeComponent();

        cmbProcesador.ItemsSource = new List<string> 
        { 
            "Intel i3", "Intel i7", "Intel i9", "AMD Ryzen 3", "AMD Ryzen 6", "AMD Ryzen 9", "M1", "M2", "M3", "M"
        };

        cmbRAM.ItemsSource = rams;
    }

    private void btnClicAgregarRAM_Click(object sender, RoutedEventArgs e)
    {
        string valorRAM = tbRAM.Text;
        if (valorRAM.Length > 0)
        {
            lblErrorRAM.Content = "";
            rams.Add(valorRAM);
            tbRAM.Text = "";
            cmbRAM.SelectedIndex = rams.Count - 1;
        }
        else
        { 
            lblErrorRAM.Content = "¡ERROR! Debes ingresar un valor como \"16 GB\"";
        }
    }

    private void btnConfiguracion_Click(object sender, RoutedEventArgs e)
    {
        string so = "";
        string procesador = "";
        string marca = "";
        string ram = "";

        if (cmbSistema.SelectedIndex >= 0)
        {
            ComboBoxItem comboBoxItem = (ComboBoxItem) cmbSistema.SelectedValue;
            so = comboBoxItem.Content.ToString();
        }

        if (cmbProcesador.SelectedIndex >= 0)
        {
            procesador = "" + cmbProcesador.SelectedValue;
        }

        if (cmbMarca.SelectedIndex >= 0)
        {
            ComboBoxItem comboBoxItem = (ComboBoxItem) cmbMarca.SelectedValue;
            StackPanel stackPanel = (StackPanel) comboBoxItem.Content;
            TextBlock textBlock = (TextBlock) stackPanel.Children[1];
            marca = textBlock.Text;
        }

        if(cmbRAM.SelectedIndex >= 0)
        {
            ram = "" + cmbRAM.SelectedValue;
        }

        if(so.Length == 0 || procesador.Length == 0 || marca.Length == 0 || ram.Length == 0)
        {
            MessageBox.Show("Faltan datos por seleccionar", "¡ERROR!");
            return;
        }

        string configuracion = String.Format("Sistema Operativo: {0}\nProcesador: {1}\nMarca: {2}\nRAM: {3}", 
            so, procesador, marca, ram);
        MessageBox.Show(configuracion, "Configuración ");
    }
}