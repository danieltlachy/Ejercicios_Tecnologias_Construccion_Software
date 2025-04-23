using System.Collections.ObjectModel;
using System.Reflection.Emit;
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

namespace Prueba
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> memoriaRAM = new ObservableCollection<string>();
        public MainWindow()
        {
            InitializeComponent();
            //cuando cargue la ventana con los componentes, carga los elementos del combo
            cmb_procesador.ItemsSource = obtenerProcesadores();

            cmb_ram.ItemsSource = memoriaRAM;
            
        }

        private void CambiaEstadoCheckBoxEstatico()
        {
            List<CheckBox> checkBoxes = new List<CheckBox>();
            checkBoxes.Add(chbGato);
            checkBoxes.Add(chbAraña);
            checkBoxes.Add(chbLoro);
            checkBoxes.Add(chbPerro);
            checkBoxes.Add(chbPez);
            checkBoxes.Add(chbHamster);

            bool banderaCheck = true;
            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.IsChecked == false)
                {
                    banderaCheck = false;
                }
            }
            chbTodos.IsChecked = banderaCheck;
        }

        private void BtnSeleccionMascota(object sender, RoutedEventArgs e)
        {
            String opciones = "";
            if (chbGato.IsChecked == true) {
                opciones += chbGato.Content + "\n";
            }
            if (chbAraña.IsChecked == true)
            {
                opciones += chbAraña.Content + "\n";
            }
            if (chbLoro.IsChecked == true)
            {
                opciones += chbLoro.Content + "\n";
            }
            if (chbPerro.IsChecked == true)
            {
                opciones += chbPerro.Content + "\n";
            }
            if (chbPez.IsChecked == true)
            {
                opciones += chbPez.Content + "\n";
            }
            if (chbHamster.IsChecked == true)
            {
                opciones += chbHamster.Content + "\n";
            }
            if(opciones.Length == 0)
            {
                opciones = "Ninguna opcion seleccionada";
            }
            MessageBox.Show(opciones, "Mascotas seleccionadas");

        }

        private void checkTodos(object sender, RoutedEventArgs e)
        {
            cambiaEstadoCheckBox(true);
        }
        /*private void uncheckTodos(object sender, RoutedEventArgs e)
        {
            cambiaEstadoCheckBox(false);
        }*/
        private void cambiaEstadoCheckBox(bool isSeleccionado)
        {
            chbGato.IsChecked = isSeleccionado;
            chbAraña.IsChecked = isSeleccionado;
            chbLoro.IsChecked = isSeleccionado;
            chbPerro.IsChecked = isSeleccionado;
            chbPez.IsChecked = isSeleccionado;
            chbHamster.IsChecked = isSeleccionado;
        }



        private void btn_generarClic(object sender, RoutedEventArgs e)
        {
            if(txt_opciones != null && txt_opciones.Text.Length > 0)
            {
                String[] separador = { ";", "," };
                String[] opciones = txt_opciones.Text.Split(separador, StringSplitOptions.RemoveEmptyEntries);

                wp_opciones.Children.Clear();
                foreach(string opcion in opciones){
                    CheckBox check = new CheckBox();
                    check.Content = opcion;
                    check.Margin = new Thickness(10);
                    wp_opciones.Children.Add(check);
                    Console.WriteLine(check.Content);
                    check.Checked += CambiarCheckTodosDinamico;
                    check.Unchecked += CheckBox_Unchecked;
                }
                txt_opciones.Text = "";
            }
            else
            {
                MessageBox.Show("Para generar los componentes debes agregar por lo menos un valor", "Campos requeridos");
            }
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            chbSeleccionTodos.IsChecked = false;
        }

        private void CambiarCheckTodosDinamico(object sender, RoutedEventArgs e)
        {
            UIElementCollection elementos = wp_opciones.Children;
            List<CheckBox> checkBoxes = elementos.Cast<CheckBox>().ToList();
            bool banderaCheck = true;
            foreach (CheckBox checkBox in checkBoxes)
            {
                if(checkBox.IsChecked == false)
                {
                    banderaCheck = false;
                }
            }
            chbSeleccionTodos.IsChecked = banderaCheck;
        }

        private void chb_todos_dinamico_Checked(object sender, RoutedEventArgs e)
        {
            CambiaEstadoCheckBoxDinamicos(true);
        }


        private void CambiaEstadoCheckBoxDinamicos(bool isSeleccionado)
        {
            UIElementCollection elementos = wp_opciones.Children;
            List<CheckBox> checkBoxes = elementos.Cast<CheckBox>().ToList();
            foreach(CheckBox checkBox in checkBoxes)
            {
                checkBox.IsChecked = isSeleccionado;
            }
        }

        private void btn_seleccion_Dinamica(object sender, RoutedEventArgs e)
        {
            string opciones = "";
            UIElementCollection elementos = wp_opciones.Children;
            List<CheckBox> checkBoxes = elementos.Cast<CheckBox>().ToList();
            foreach(CheckBox checkBox in checkBoxes)
            {
                if(checkBox.IsChecked == true)
                {
                    opciones += checkBox.Content + "/n";
                    
                }
                if(opciones.Length == 0)
                {
                    opciones = "Ninguna opcion fue seleccionada.";
                }
                MessageBox.Show(opciones, "Opciones dinamicas seleccionadas");
            }
        }

        private void Unchecked_Arana(object sender, RoutedEventArgs e)
        {
            chbTodos.IsChecked = false;
        }

        private void Unchecked_Pez(object sender, RoutedEventArgs e)
        {
            chbTodos.IsChecked = false;
        }

        private void Unchecked_Hamster(object sender, RoutedEventArgs e)
        {
            chbTodos.IsChecked = false;
        }

        private void Unchecked_Perro(object sender, RoutedEventArgs e)
        {
            chbTodos.IsChecked = false;
        }

        private void Unchecked_Gato(object sender, RoutedEventArgs e)
        {
            chbTodos.IsChecked = false;
        }

        private void Unchecked_Loro(object sender, RoutedEventArgs e)
        {
            chbTodos.IsChecked = false ;
        }
        private void Checked_Arana(object sender, RoutedEventArgs e)
        {
            CambiaEstadoCheckBoxEstatico();
        }

        private void Checked_Pez(object sender, RoutedEventArgs e)
        {
            CambiaEstadoCheckBoxEstatico();
        }

        private void Checked_Hamster(object sender, RoutedEventArgs e)
        {
            CambiaEstadoCheckBoxEstatico();
        }

        private void Checked_Perro(object sender, RoutedEventArgs e)
        {
            CambiaEstadoCheckBoxEstatico();
        }

        private void Checked_Gato(object sender, RoutedEventArgs e)
        {
            CambiaEstadoCheckBoxEstatico();
        }

        private void Checked_Loro(object sender, RoutedEventArgs e)
        {
            CambiaEstadoCheckBoxEstatico();
        }

        //implementacion del combobox
        private List<string> obtenerProcesadores() 
        {
            List<string> datosProcesadores = new List<string>();
            datosProcesadores.Add("Intel - i3");
            datosProcesadores.Add("Intel - i5");
            datosProcesadores.Add("Intel - i7");
            datosProcesadores.Add("AMD 3");
            datosProcesadores.Add("AMD 5");
            datosProcesadores.Add("AMD 9");
            return datosProcesadores;
        }

        private void btn_nueva_ram_Click(object sender, RoutedEventArgs e)
        {
            if(txt_ram.Text.Length > 0) 
            {
                memoriaRAM.Add(txt_ram.Text);
                txt_ram.Text = "";
                //Un elemento agregado se pone en la seleccion del combo
                cmb_ram.SelectedIndex = memoriaRAM.Count - 1; //similar a .size, devuelve el numero de items
            }
            else //no se agrega nada
            {
                MessageBox.Show("Debes ingresar el tamaño de la memoria RAM", "Campo requerido");
            }
        }

        private void btn_ver_configuracion_Click(object sender, RoutedEventArgs e)

        {

            string so = "";

            string procesador = "";

            string marca = "";

            string ram = "";

            if (cmb_sistemas.SelectedIndex > -1) //si hay un elemento seleccionado

            {

                ComboBoxItem cbi = (ComboBoxItem)cmb_sistemas.SelectedValue; //castea

                so = "" + cbi.Content; //se puede castear, concatenar o darle una asignacion

            }
            else
            {
                MessageBox.Show("Debe seleccionar un sistema operativo.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (cmb_procesador.SelectedIndex > -1)

            {

                procesador += cmb_procesador.SelectedValue;

            }
            else
            {
                MessageBox.Show("Debe seleccionar un procesador.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (cmb_marca.SelectedIndex > -1)

            {

                ComboBoxItem cbi = (ComboBoxItem)cmb_marca.SelectedValue;

                StackPanel stackPanel = cbi.Content as StackPanel;

                TextBlock textBlock = (TextBlock)stackPanel.Children[1];

                marca = textBlock.Text;

            }
            else
            {
                MessageBox.Show("Debe seleccionar una marca.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (cmb_ram.SelectedIndex > -1)

            {

                ram = memoriaRAM[cmb_ram.SelectedIndex];

            }
            else
            {
                MessageBox.Show("Debe seleccionar una memoria RAM.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            string info = String.Format("Sistema Operativo: {0} \nProcesador: {1} \nMarca: {2} \nMemoria RAM: {3}", so, procesador, marca, ram);

            MessageBox.Show(info, "Opciones seleccionadas");

        }
    }
}