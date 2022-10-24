using System;
using System.Collections.Generic;
using System.Linq;

namespace Parte1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aguarde! A aplicação está analisando os dados de entrada!");

            //numeros de 1 a 10000; analisa o tamanho da cadeia;
            //compara o tamanho da cadeia gerada pelo numero atual com o maior;
            //armazena o numero que apresenta a maior cadeia
            int numero = Enumerable.Range(1, 1000000)
            .Select(n => new { numero = n, tamanho = analisaCadeia(n) })
            .Aggregate((i, j) => i.tamanho > j.tamanho ? i : j)
            .numero;

            Console.WriteLine("O número de maior cadeia é: " + numero);
        }

        public static int analisaCadeia(long numero)
        {
            int tamanho = 0;

            while (numero != 1)
            {
                if (numero % 2 == 0)
                {
                    numero = numero / 2;
                }
                else
                {
                    numero = (3 * numero) + 1;
                }
                tamanho++;
            }

            return tamanho;
        }
    }
}