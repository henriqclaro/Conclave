using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conclave
{
    public class Functions
    {
        public static int Lenght(string[][] vet)
        {
            int q = 0;
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] != null)
                    q++;
            }

            return q;
        }

        public static int Buscar(string[][]vetor, string nome)
        {
            int indice = 0;
            for (indice = 0; indice < Functions.Lenght(vetor) && vetor[indice][0] != nome; indice++) ;

            if (indice < Functions.Lenght(vetor))
                return indice;
            return -1;
        }
    }
}
