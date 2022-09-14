using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp77
{
    class Program
    {

        static int fat(int num)
        {
            if (num==1)
            {
                return 1;
            }
            else
            {
                return num * fat(num - 1);
            }

        }
        static void Main(string[] args)
        {
            int num = 0;

            Console.WriteLine("Calculadora recursiva");
            Console.Write("Insira o número desejado: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine($"O fatorial de {num} é: {fat(num)}");
            Console.ReadKey();
        }
    }
}
