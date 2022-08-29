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
            int cont = 0;

            Console.WriteLine("Verificador de números primos");
            Console.WriteLine(" ");
            Console.Write("Insira o número a ser verificado: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (num%i == 0)
                {
                    cont++;
                }
            }

            if (cont <= 2)
            {
                Console.WriteLine("O número {0} é primo!", num);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("O número {0} NÃO é primo!", num);
                Console.ReadKey();
            }


            //Parte2
            int soma = 0;

            for (int j = 1; j <= 1000; j++)
            {
                for (int k = 1; k <= j; k++)
                {

                    int[] div = new int[k];

                    if (j%k==0)
                    {
                       div[k] = k;
                    }

                    soma += div[k];

                    if (soma==6)
                    {
                        Console.WriteLine(j);
                    }

                }
            }
        }

    }
}
