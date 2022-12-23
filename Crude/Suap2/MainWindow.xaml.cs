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

namespace Suap2
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

        private void turmasbot_Click(object sender, RoutedEventArgs e)
        {
            turmawindows w = new turmawindows();
            w.ShowDialog();
        }

        private void alunosbot_Click(object sender, RoutedEventArgs e)
        {
            alunowindows w = new alunowindows();
            w.ShowDialog();
        }

        private void matriculasbot_Click(object sender, RoutedEventArgs e)
        {
            matriculawindows w = new matriculawindows();
            w.ShowDialog();
        }

        private void diariosbot_Click(object sender, RoutedEventArgs e)
        {
            diariowindows w = new diariowindows();
            w.ShowDialog();
        }
    }
}
