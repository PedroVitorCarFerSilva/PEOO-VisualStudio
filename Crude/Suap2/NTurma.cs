using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Suap2
{
    static class NTurma
    {
        private static List<Turma> turmas = new List<Turma>();
        public static void Inserir(Turma t)
        {
            Abrir();
            turmas.Add(t);
            Salvar();
        }
        public static List<Turma> Listar()
        {
            Abrir();
            return turmas;
        }
        public static Turma Listar(string id)
        {
            foreach (Turma obj in turmas)
                if (obj.Id == id) return obj;
            return null;
        }
        public static void Atualizar(Turma t)
        {
            Abrir();
            Turma obj = Listar(t.Id);
            if (obj != null)
            {
                obj.Curso = t.Curso;
                obj.Descricao = t.Descricao;
                obj.AnoLetivo = t.AnoLetivo;
                Salvar();
            }
        }
        public static void Excluir(Turma t)
            {
                turmas.Remove(t);
                Salvar();
            }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Turma>));
                f = new StreamReader("./brasil.xml");
                turmas = (List<Turma>)xml.Deserialize(f);
            }
            catch
            {

            }
            if (f!= null) f.Close();

        }
        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Turma>));
            StreamWriter f = new StreamWriter("./brasil.xml", false);
            xml.Serialize(f, turmas);
            f.Close();
        }
    }
}
