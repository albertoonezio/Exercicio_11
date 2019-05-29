using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Parte2_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiroNumero = 0;
            int segundoNumero = 0;
            int terceiroNumero = 0;
            int quartoNumero = 0;
            int somaTotalPar = 0;

            if (primeiroNumero % 2 == 0)
            {
                somaTotalPar += primeiroNumero;
            }

            if (segundoNumero % 2 == 0)
            {
                somaTotalPar += segundoNumero;
            }

            if (terceiroNumero % 2 == 0)
            {
                somaTotalPar += terceiroNumero;
            }

            if (quartoNumero % 2 == 0)
            {
                somaTotalPar += quartoNumero;
            }

            Console.WriteLine("A soma dos números pares é: {0}", somaTotalPar);
        }
    }
}
