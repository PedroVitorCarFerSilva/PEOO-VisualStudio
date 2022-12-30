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
using System.Windows.Shapes;

namespace Suap2
{
    /// <summary>
    /// Lógica interna para turmawindows.xaml
    /// </summary>
    public partial class turmawindows : Window
    {
        public turmawindows()
        {
            InitializeComponent();
        }

        private void inserirclick(object sender, RoutedEventArgs e)
        {
            Turma t = new Turma { Id = txtid.Text, Curso = txtcurso.Text, Descricao = txtturma.Text, AnoLetivo = int.Parse(txtano.Text) };
            NTurma.Inserir(t);

            txtid.Text = null;
            txtcurso.Text = null;
            txtturma.Text = null;
            txtano.Text = null;

            listarclick(sender, e);
        }

        private void listarclick(object sender, RoutedEventArgs e)
        {
            listTurmas.ItemsSource = null;
            listTurmas.ItemsSource = NTurma.Listar();
        }

        private void atualizarclick(object sender, RoutedEventArgs e)
        {
            Turma t = new Turma { Id = txtid.Text, Curso = txtcurso.Text, Descricao = txtturma.Text, AnoLetivo = int.Parse(txtano.Text) };
            NTurma.Atualizar(t);

            listarclick(sender, e);
        }

        private void excluirclick(object sender, RoutedEventArgs e)
        {
            if (listTurmas.SelectedItem != null)
            {
                NTurma.Excluir((Turma)listTurmas.SelectedItem);
                listarclick(sender, e);
            }
        }
    }
}
