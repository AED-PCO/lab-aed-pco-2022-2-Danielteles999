using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp77
{
    class Program
    {

        static double pot(int num, double expoente)
        {
            if (expoente==0)
            {
                return 1;
            }

            if (expoente>0)
            {
                return pot(num, expoente - 1) * num;
            }  
            
            else
            {
                return pot(num, expoente + 1) * num;
            }

        }
        static void Main(string[] args)
        {
            int num = 0;
            double expoente=0;

            Console.WriteLine("Calculadora potenciação recursiva");
            Console.Write("Insira a base da operação: ");
            num = int.Parse(Console.ReadLine());

            Console.Write($"Ó número {num} será eleavado quantas vezes?: ");
            expoente = int.Parse(Console.ReadLine());

            if (expoente>0)
            {
                Console.WriteLine($"{num} elevado à {expoente} é igual à {pot(num, expoente)}");
            }
            else
            {
                Console.WriteLine($"{num} elevado à ({expoente}) é igual à {1 / pot(num, expoente)}");
            }

            Console.ReadKey();
        }
    }
}
