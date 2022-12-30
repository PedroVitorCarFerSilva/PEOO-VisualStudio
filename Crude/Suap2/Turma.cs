using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suap2
{
    public class Turma
    {
        public string Id { get; set; }
        public string Curso { get; set; }
        public string Descricao { get; set; }
        public int AnoLetivo { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Curso} - {AnoLetivo} - {Descricao}";
        }
    }
}
