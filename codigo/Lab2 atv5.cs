using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp77
{
    class Program
    {

        static int ocorrencias(char[] fraseChar, char letra)
        {
            int i = 0;

            while (i != frase.Length)
            {
                if (frase[i] == letra)
                {
                    return 1 + ocorrencias(frase[i + 1], letra);
                }

                i++;
                return 0;
            }
        }

        static void Main(string[] args)
        {
            string frase = "";
            char letra = 'a';

            char[] = new char[]

            Console.WriteLine("Frequencia de caracteres em uma frase Recursivo");
            Console.Write("Insira a frase desejada: ");
            frase = Convert.ToString(Console.ReadLine());

            Console.Write("Insira a letra a ser contada na frase: ");
            letra = Convert.ToChar(Console.ReadLine());

            char[] fraseChar = frase.ToCharArray();

            ocorrencias(fraseChar[], letra);

        }
    }
}
