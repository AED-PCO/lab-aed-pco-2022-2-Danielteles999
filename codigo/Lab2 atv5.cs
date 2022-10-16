using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp91
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contabilizador de caracteres v3.6 \n");
            Console.WriteLine("Insira a frase desejada: ");
            string frase = Console.ReadLine();
            Console.WriteLine("Insira a letra para a busca: ");
            char letra = char.Parse(Console.ReadLine());

            char[] fraseChar = frase.ToCharArray();//Convertendo...

            Console.WriteLine($"A letra {letra} aparece {contab(fraseChar, letra, 0)} vezes na frase");
            Console.ReadKey();
        }

        static int contab(char[] fraseChar, char letra, int num)
        {
            int soma = 0;

            if (num == fraseChar.Length-1)
            {
                if (fraseChar[num]==letra)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                if (fraseChar[num] == letra)
                {
                    soma = 1 + contab(fraseChar, letra, num + 1);
                    return soma;
                }
                else
                {
                    soma = 0 + contab(fraseChar, letra, num + 1);
                    return soma;
                }
            }

        }


    }
}
