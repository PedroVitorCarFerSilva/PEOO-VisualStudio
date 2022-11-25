using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pequenas_empresas
{
    class cliente
    {
        private string nome;
        private double limite;
        public cliente(string n, double l)
        {
            nome = n;
            if (l > 0) limite = l;
        }
        public override string ToString()
        {
            return $"nome do cliente: {nome} - limite: {limite}";
        }
    }
}
