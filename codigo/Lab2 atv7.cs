using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp78
{
    class Program
    {
        static void RetiraVogal(string frase, int i)
        {
            char[] vogais = { 'a', 'e', 'i', 'o', 'u' };

            if (i == frase.Length)
            {
                
            }

            if (frase[i]==vogais[i])
            {
                frase.Replace('i', ' ') + RetiraVogal(frase, i+1);
            }
            else
            {

            }
        }   


        static void Main(string[] args)
        {

            string frase = "";

            Console.WriteLine("Insira a frase: ");
            frase = Console.ReadLine();

            Console.Write("Frase sem as vogais ");
            Console.WriteLine($"{DevolveValores(Vetor, 0)}");
            Console.ReadKey();

        }
    }
}
