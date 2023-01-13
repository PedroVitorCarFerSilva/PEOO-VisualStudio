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
    /// Lógica interna para alunowindows.xaml
    /// </summary>
    public partial class alunowindows : Window
    {
        public alunowindows()
        {
            InitializeComponent();
        }

        private void inserirclick(object sender, RoutedEventArgs e)
        {
            Aluno t = new Aluno { Id = txtid.Text, Nome = txtnome.Text, Matricula = txtmatricula.Text, Email = txtemail.Text };
            NAluno.Inserir(t);

            txtid.Text = null;
            txtnome.Text = null;
            txtmatricula.Text = null;
            txtemail.Text = null;

            listarclick(sender, e);
        }

        private void listarclick(object sender, RoutedEventArgs e)
        {
            listAlunos.ItemsSource = null;
            listAlunos.ItemsSource = NAluno.Listar();
        }

        private void atualizarclick(object sender, RoutedEventArgs e)
        {
            Aluno t = new Aluno { Id = txtid.Text, Nome = txtnome.Text, Matricula = txtmatricula.Text, Email = txtemail.Text };
            NAluno.Atualizar(t);

            listarclick(sender, e);
        }

        private void excluirclick(object sender, RoutedEventArgs e)
        {
            if (listAlunos.SelectedItem != null)
            {
                NAluno.Excluir((Aluno)listAlunos.SelectedItem);
                listarclick(sender, e);
            }
        }
    }
}
