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
namespace WPFHolaMundo
{
    public partial class MainWindow : Window
    {
        private double valor1;
        private string operacion;
        public MainWindow()
        {
            InitializeComponent();
            valor1 = 0;
            operacion = "";
        }
        private void BotonNumero_Click(object sender, RoutedEventArgs e)
        {
            Button btnClick = (Button)sender;
            lb_resultado.Content += btnClick.Content.ToString();
        }

        private void Operacion_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(lb_resultado.Content.ToString(), out double valor2))
            {
                if (string.IsNullOrEmpty(operacion))  // Primera operación
                {
                    valor1 = valor2;
                }
                else
                {
                    // Realiza la operación acumulativa si ya hay una operación en curso
                    CalcularResultadoAcumulado(valor2);
                }

                // Asigna la nueva operación seleccionada
                Button btn_clic_operacion = (Button)sender;
                operacion = btn_clic_operacion.Content.ToString();

                // Limpia para permitir el siguiente número
                lb_resultado.Content = "";
            }
            else
            {
                lb_resultadoAnterior.Content = "¡Error! Solo se pueden ingresar números.";
            }
        }

        private void CalcularResultadoAcumulado(double valor2)
        {
            switch (operacion)
            {
                case "+":
                    valor1 += valor2;
                    break;
                case "-":
                    valor1-= valor2;
                    break;
                case "*":
                    valor1*= valor2;
                    break;
                case "/":
                    if (valor2 != 0)
                    {
                        valor1/= valor2;
                    }
                    else
                    {
                        lb_resultadoAnterior.Content = "¡Error! No se puede dividir entre 0.";
                        operacion = string.Empty;
                        return;
                    }
                    break;
            }

            // Actualiza el resultado acumulado en pantalla
            lb_resultado.Content = valor1.ToString();
        }


        private void CalcularResultado_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(lb_resultado.Content.ToString(), out double valor2))
            {
                CalcularResultadoAcumulado(valor2);
                operacion = string.Empty;  // Limpia la operación después de presionar "="
            }
            else
            {
                lb_resultadoAnterior.Content = "¡Error! Inténtelo más tarde.";
            }
        }
        private void BotonLimpiar_Click(object sender, RoutedEventArgs e)
        {
            lb_resultado.Content = "";
            valor1 = 0;
            operacion = string.Empty;
        }
    }
}