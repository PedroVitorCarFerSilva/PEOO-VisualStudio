﻿using System;
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
    /// Lógica interna para matriculawindows.xaml
    /// </summary>
    public partial class matriculawindows : Window
    {
        public matriculawindows()
        {
            InitializeComponent();
        }

        private void botaolistar(object sender, RoutedEventArgs e)
        {
            NTurma.Listar()
        }

        private void botaomatricula(object sender, RoutedEventArgs e)
        {

        }
    }
}
