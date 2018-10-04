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

namespace PracticaPerimetros
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

        private void cbTipoFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ControlPerimetroCirculo.Visibility = Visibility.Collapsed;
            ControlPerimetroCuadrado.Visibility = Visibility.Collapsed;

            switch(cbTipoFigura.SelectedIndex)
            {
                case 0: //Circulo
                    ControlPerimetroCirculo.Visibility = Visibility.Visible;
                    break;
                case 1: //Cuadrado
                    ControlPerimetroCuadrado.Visibility = Visibility.Visible;
                    break;
                default:
                    break;
            }
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            float perimetro = 0.0f;

            switch(cbTipoFigura.SelectedIndex)
            {
                case 0: //Circulo
                    float radio = float.Parse(ControlPerimetroCirculo.txtRadio.Text);
                    perimetro = 2 * radio * 3.1416f;
                    break;
                case 1: //Cuadrado
                    float lado = float.Parse(ControlPerimetroCuadrado.txtLado.Text);
                    perimetro = lado * 4;
                    break;
                default:
                    break;
            }
            lblResultado.Text = perimetro.ToString();

        }
    }
}
