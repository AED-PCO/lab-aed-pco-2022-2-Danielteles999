using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp77
{
    class Program
    {

        static int fibo(int num)
        {
            if (num==0)
            {
                return 0;
            }
            if (num==1)
            {
                return 1;
            }
            else
            {
                return fibo(num-1) + fibo(num-2);
            }
        }
        static void Main(string[] args)
        {
            int num = 0;

            Console.WriteLine("Calculadora fibonacci");
            Console.Write("Insira o número desejado: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine($"O fibonacci de {num} é: {fibo(num)}");
            Console.ReadKey();
        }
    }
}
