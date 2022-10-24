using System;
using System.Collections.Generic;
using System.Linq;

namespace Parte1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primeiroArray = { 1, 3, 7, 29, 42, 98, 234, 93 };
            int[] segundoArray = { 4, 6, 93, 7, 55, 32, 3 };

            //funcao que filtra os numeros do primeiro vetor que nao estao no segundo
            verificaNumeros(primeiroArray, segundoArray);
        }

        public static void verificaNumeros(int[] primeiro, int[] segundo)
        {
            IEnumerable<int> numerosPrimeiroDiferentes = primeiro.Except(segundo);

            Console.WriteLine("Números do primeiro array que não estão no segundo array: ");

            foreach (int n in numerosPrimeiroDiferentes)
                Console.Write(n + " ");

            Console.WriteLine("\n");
        }
    }
}