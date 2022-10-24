using System;
using System.Collections.Generic;
using System.Linq;

namespace Parte1
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Exemplo de conjunto com numeros pares e impares
            int[] numeros = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };

            //Exemplo de conjunto com apenas numeros impares para teste
            //int[] numeros = { 1, 3, 5, 13, 21, 33, 55, 89, 147 };

            //Função que verifica se há apenas numeros impares
            analisaArray(numeros);
        }

        public static void analisaArray(int[] numeros)
        {
            IEnumerable<int> enumNumeros = numeros;
            //allImpares recebe true apenas se todos os numeros de enumNumeros forem impares
            bool allImpares = enumNumeros.All(x => x % 2 != 0);

            //se nenhum numero par for encontrado
            if (allImpares)
            {
                Console.WriteLine("Há apenas números ímpares no conjunto analisado!");
            }
            //se houver ao menos um numero par
            else
            {
                Console.WriteLine("Não há apenas números ímpares no conjunto analisado!\n");

                //pares recebe todos os numeros pares de enumNumeros
                var pares = enumNumeros.Where(x => x % 2 == 0);
                Console.Write("Números pares encontrados: ");
                foreach (int num in pares)
                    Console.Write(num + " ");
            }
            Console.WriteLine("\n");
        }
    }
}