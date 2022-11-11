using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tester
{
    class Bingo
    {
        private int numbolas;
        private int[] numeros;
        private int k;
        public void Iniciar(int numbolas)
        {
            if (numbolas >= 10 && numbolas <= 100)
                this.numbolas = numbolas;
            else
                this.numbolas = 50;
            numeros = new int[numbolas];
            k = 0;
        }
        public int Proximo()
        {
            Random r = new Random();
            int n = r.Next(1, numbolas + 1);
            int pos = Array.IndexOf(numeros, n);
            while (pos != -1)
            {
                n = r.Next(1, numbolas + 1);
                pos = Array.IndexOf(numeros, n);
            }
            numeros[k] = n;
            k++;
            return n;
        }
        public int[] Sorteados()
        {
            int[] vetor = new int[k];
            Array.Copy(numeros, vetor, k);
            Array.Sort(vetor);
            return vetor;
        }
    }
}
