using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Divisas
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const double VALOR_DOLAR = 16.80;
        const string PATTERN_NUMEROS = @"^(?:\.\d+|[+-]?[0-9]{1,3}(?:,?[0-9]{3})*(?:\.[0-9]{2})?)$";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_ConvertirDolar(object sender, RoutedEventArgs e)
        {

            string cantidadConvertir = txt_DolarPeso.Text;
            Regex regex = new Regex(PATTERN_NUMEROS);
            Match match = regex.Match(cantidadConvertir);
            if (txt_DolarPeso != null && cantidadConvertir.Length > 0)
            {
                if (!match.Success)
                {
                    MessageBox.Show("Introduzca valores numéricos únicamente", "(Solo numéros)");
                }
                else
                {
                    lbl_DolarPeso.Content = (Double.Parse(cantidadConvertir) * VALOR_DOLAR).ToString("N2") + " MXN.";
                }
            }
            else
            {
                MessageBox.Show("Para realizar la conversión debes insertar una cantidad numérica", "(Campo requerido)");
            }

        }

        private void Btn_ConvertirPeso(object sender, RoutedEventArgs e)
        {
            string cantidadConvertir = txt_PesoDolar.Text;
            Regex regex = new Regex(PATTERN_NUMEROS);
            Match match = regex.Match(cantidadConvertir);
            if (txt_PesoDolar != null && cantidadConvertir.Length > 0)
            {
                if (!match.Success)
                {
                    MessageBox.Show("Introduzca valores numéricos únicamente", "(Solo numéros)");
                }
                else
                {
                    lbl_PesoDolar.Content = (Double.Parse(cantidadConvertir) / VALOR_DOLAR).ToString("N2") + " USD.";
                }
            }
            else
            {
                MessageBox.Show("Para realizar la conversión debes insertar una cantidad numérica", "(Campo requerido)");
            }
        }
    }
}