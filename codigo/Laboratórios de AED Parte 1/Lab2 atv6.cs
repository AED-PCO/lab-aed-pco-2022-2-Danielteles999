using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp78
{
    class Program
    {
        static int DevolveValores(int[] Vetor, int i)
        {
            int soma = 0;

            if (i == Vetor.Length)
            {
                return 0;
            }

            if (Vetor[i] % 2 == 0)
            {
                return soma = soma + Vetor[i] + DevolveValores(Vetor, i + 1);
            }
            else
            {
                return DevolveValores(Vetor, i + 1);
            }
        }


        static void Main(string[] args)
        {
            int tam = 0;

            Console.WriteLine("Soma de Elementos pares de um vetor");
            Console.WriteLine("------------------------------------");
            Console.Write("Insira o tamanho do vetor a ser criado: ");
            tam = int.Parse(Console.ReadLine());
            int[] Vetor = new int[tam];
            Console.WriteLine("------------------------------------\n");


            int i = 0, num = 0;
            while (i < tam)
            {             
                Console.WriteLine($"Insira {i+1}º  valor de {tam} números do vetor: ");
                num = int.Parse(Console.ReadLine());
                Vetor[i] = num;
                i++;
            }

            Console.WriteLine("------------------------------------");
            Console.Write("Soma dos números pares do vetor: ");
            Console.WriteLine($"{DevolveValores(Vetor, 0)}");
            Console.WriteLine("------------------------------------");
            Console.ReadKey();

        }
    }
}
