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

            for (int i = 1000; i <= 9999; i++)
            {
                string numInt = Convert.ToString(i);
                char[] numero  = numInt.ToCharArray();

                string Parte1 = Convert.ToString(numero[0]+numero[1]);
                string Parte2 = Convert.ToString(numero[2]+numero[3]);

                Console.WriteLine(Parte1);

                int Parte1conv = int.Parse(Parte1);
                int Parte2conv = int.Parse(Parte2);

                int somatotal = Parte1conv + Parte2conv;

                if (somatotal == i*i)
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
