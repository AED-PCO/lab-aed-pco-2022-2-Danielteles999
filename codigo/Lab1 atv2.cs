//Atividade 2

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
                if (num % i == 0)
                {
                    cont++;
                }
            }

            if (cont <= 2)
            {
                Console.WriteLine("O número {0} é primo!", num);
            }
            else
            {
                Console.WriteLine("O número {0} NÃO é primo!", num);
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("Números perfeitos de 1 a 1000: ");

            //Parte2
            int soma = 0, num2 = 1;

            while (num2 <= 1000)
            {
                soma = 0;

                for (int i = 1; i < num2; i++)
                {
                    if (num2 % i == 0)
                        soma = soma + i;
                }

                if (soma == num2)
                    Console.Write($"{num2}, ");

                num2++;
            }

            Console.ReadKey();
        }

    }
}
