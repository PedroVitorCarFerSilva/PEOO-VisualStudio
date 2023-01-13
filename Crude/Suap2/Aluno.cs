using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suap2
{
    public class Aluno
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Nome} - {Email} - {Matricula}";
        }
    }
}
