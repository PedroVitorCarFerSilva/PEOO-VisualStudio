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

namespace tester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Bingo b = new Bingo();
        private void slider_valuechanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtnumbolas.Text = slider.Value.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            b.Iniciar(int.Parse(txtnumbolas.Text));
            inicia.IsEnabled = false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int bola = b.Proximo();
            if (bola == -1)
            {
                txtsort.IsEnabled = false;
                txtsort.Text = "cabou";
                inicia.IsEnabled = true;
            }
            else
            {
                txtsort.Text = bola.ToString();
                foreach (int ha in b.Sorteados())
                {
                    sorteades.Text += " " + ha.ToString();
                }
            }
        }
    }
}
