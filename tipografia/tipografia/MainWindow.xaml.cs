using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace tipografia
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Public Constructors

        public MainWindow()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Private Methods

        private void proporcion_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9,]+");
            if (regex.IsMatch(e.Text))
            {
                e.Handled = true;
            }

        }

        #endregion Private Methods



        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            proporcion.Text = "1,6180339887489";
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

            var s = "Progama realizado por Jorge Duran (aka ganchito55)\nEl programa permite generar una escala tipográfica usando un tamaño como base y una proporcion en la que se realizará el aumento\nSegún algunos estudios la mejor proporcion es la del número Phi\nPara más informacion visita www.somosbinarios.es\n";

            MessageBoxButton b = MessageBoxButton.OK;
            MessageBox.Show(s, "Ayuda", b);


        }



        private void proporcion_TextInput(object sender, TextChangedEventArgs textChangedEventArgs)
        {
            Console.Write("aaa");
            if (fuenteBase != null && proporcion != null && fuenteBase.Text.Count() != 0 && proporcion.Text.Count() != 0)
            {
                Double prop, bases;
                prop = Convert.ToDouble(proporcion.Text);
                bases = Convert.ToDouble(fuenteBase.Text);
                H3Block.Text = (prop * bases).ToString();
                H2Block.Text = (prop * prop * bases).ToString();
                H1Block.Text = (prop * prop * prop * bases).ToString();
            }
        }
    }
}
