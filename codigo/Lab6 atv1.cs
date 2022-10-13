using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux1, ValRef = 0;

            //Criação do Vetor

            int[] Vet = new int[10];
            Random random1 = new Random();

            for (int i = 0; i < 10; i++)
            {
                Vet[i] = random1.Next(0, 10);
            }

            for (int i = 0; i < Vet.Length; i++)
            {
                Console.Write($"{Vet[i]}, ");
            }

            Console.Write("\n\n");


            for (int i = 0; i < Vet.Length; i++)
            {
                for (int j = 0; j < Vet.Length; j++)
                {
                    if (Vet[j] > Vet[i])
                    {
                        aux1 = Vet[j];
                        Vet[j] = Vet[i];
                        Vet[i] = aux1;
                    }
                }
            }





            Console.WriteLine("Vetor ordenado de 10 elementos: ");

            for (int k = 0; k < Vet.Length; k++)
            {
                Console.Write($"{Vet[k]}, ");
            }

            Console.ReadKey();



        }
    }
}
