using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pequenas_empresas
{
    class empresa
    {
        private string nome;
        private cliente[] c = new cliente[10];
        public empresa(string n)
        {
            nome = n;
        }
        public override string ToString()
        {
            return $"nome da empresa: {nome}";
        }
    }
}
