using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace CalculadoraBasica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BotonCalcular_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                switch (textoOperador.Text)
                {
                    case "+":
                        textoResultado.Text = (float.Parse(textoOperando1.Text) + float.Parse(textoOperando2.Text)).ToString();
                        break;
                    case "-":
                        textoResultado.Text = (float.Parse(textoOperando1.Text) - float.Parse(textoOperando2.Text)).ToString();
                        break;
                    case "*":
                        textoResultado.Text = (float.Parse(textoOperando1.Text) * float.Parse(textoOperando2.Text)).ToString();
                        break;
                    case "/":
                        textoResultado.Text = (float.Parse(textoOperando1.Text) / float.Parse(textoOperando2.Text)).ToString();
                        break;

                }
            }
            catch (Exception) 
            {
                MessageBox.Show("Se ha producido un error. Revise los operandos", "Error", MessageBoxButton.OK);
            }
        }   
           

        private void BotonLimpiar_Click(object sender, RoutedEventArgs e)
        {
            textoOperando1.Text = "";
            textoOperando2.Text = "";
            textoOperador.Text = "";
            textoResultado.Text = "";
        }

        private void TextoOperador_TextChanged(object sender, TextChangedEventArgs e)
        {
            switch (textoOperador.Text)
            {
                case "+":
                    botonCalcular.IsEnabled = true;
                    break;
                case "-":
                    botonCalcular.IsEnabled = true;
                    break;
                case "*":
                    botonCalcular.IsEnabled = true;
                    break;
                case "/":
                    botonCalcular.IsEnabled = true;
                    break;
                default:
                    botonCalcular.IsEnabled = false;
                    break;
            }
        }       
    }
}
