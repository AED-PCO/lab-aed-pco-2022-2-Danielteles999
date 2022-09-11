using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp69
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Números Perfeitos de 1000 a 9999:");

            for (int i = 1000; i <= 9999; i++)
            {
                string num = Convert.ToString(i);

                string PrimeiraMetd = num.Substring(0,2);
                string SegundaMetd = num.Substring(2, 2);

                int PrimeiraPart = int.Parse(PrimeiraMetd);
                int SegundaPart = int.Parse(SegundaMetd);

                int quad = (PrimeiraPart + SegundaPart) * (PrimeiraPart + SegundaPart);

                if (quad==i)
                {
                    Console.Write($" {i} ");
                }
            }
            Console.ReadKey();
        }
    }
}
