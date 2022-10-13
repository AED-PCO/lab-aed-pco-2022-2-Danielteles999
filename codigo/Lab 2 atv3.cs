using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp77
{
    class Program
    {

        static int sum(int num, int mult)
        {
            if (mult==0)
            {
                return 0;
            }
            if (mult>0)
            {
                return sum(num, mult-1)+num;
            }
            else
            {
                return sum(num, mult+1)+num;
            }
        }
        static void Main(string[] args)
        {
            int num = 0, mult=0;

            Console.WriteLine("Calculadora fibonacci");
            Console.Write("Insira o número a ser multiplicado: ");
            num = int.Parse(Console.ReadLine());

            Console.Write($"Ó número {num} será multiplicado quantas vezes?: ");
            mult = int.Parse(Console.ReadLine());

            Console.WriteLine($"{num} x {mult} é igual à {sum(num, mult)}");
            Console.ReadKey();
        }
    }
}
