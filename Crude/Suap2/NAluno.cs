using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Suap2
{
    static class NAluno
    {
        private static List<Aluno> alunos = new List<Aluno>();
        public static void Inserir(Aluno t)
        {
            Abrir();
            alunos.Add(t);
            Salvar();
        }
        public static List<Aluno> Listar()
        {
            Abrir();
            return alunos;
        }
        public static Aluno Listar(string id)
        {
            foreach (Aluno obj in alunos)
                if (obj.Id == id) return obj;
            return null;
        }
        public static void Atualizar(Aluno t)
        {
            Abrir();
            Aluno obj = Listar(t.Id);
            if (obj != null)
            {
                obj.Nome = t.Nome;
                obj.Matricula = t.Matricula;
                obj.Email = t.Email;
                Salvar();
            }
        }
        public static void Excluir(Aluno t)
        {
            alunos.Remove(t);
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Aluno>));
                f = new StreamReader("./bahia.xml");
                alunos = (List<Aluno>)xml.Deserialize(f);
            }
            catch
            {

            }
            if (f != null) f.Close();

        }
        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Aluno>));
            StreamWriter f = new StreamWriter("./bahia.xml", false);
            xml.Serialize(f, alunos);
            f.Close();
        }
    }
}
