//Exercício 6

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int Operador(ref int num, ref int expoente)
        {
            int pot = 1, i = 0;

            while (i < expoente)
            {
                pot = pot * num;
                i++;
            }

            return pot;
        }

        static void Main(string[] args)
        {
            int num = 0, expoente = 0;


            Console.WriteLine("Potenciação de números 5.3");

            Console.Write("Insira o valor da base: ");
            num = int.Parse(Console.ReadLine());

            Console.Write("Insira o valor do expoente: ");
            expoente = int.Parse(Console.ReadLine());

            Console.WriteLine($"{num} elevado à {expoente} é {Operador(ref num, ref expoente)}");
            Console.ReadKey();

        }
    }
}
