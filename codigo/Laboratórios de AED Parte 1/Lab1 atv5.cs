//Exercício 5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Program
    {
        static int Fatorial(ref int num)
        {
            for (int i = num - 1; i > 0; i--)
            {
                num = num * i;
            }

            return num;
        }


        static void Main(string[] args)
        {
            int num = 0;

            Console.WriteLine("Calculadora de fatorial");
            Console.Write("Insira o número desejado: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Fatorial de {num} é {Fatorial(ref num)}.");
            Console.ReadKey();

        }
    }


}
