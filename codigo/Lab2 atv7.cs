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
            Console.WriteLine("Removedor de vogais v6.1 \n");
            Console.WriteLine("Insira a frase desejada: ");
            string frase = Console.ReadLine();

            char[] fraseChar = frase.ToCharArray();//Convertendo...

            Console.WriteLine($"Nova frase: {antivogal(fraseChar,0)}");
            Console.ReadKey();
        }

        static string antivogal(char[] fraseChar, int num)
        {

            char[] Vogais = {'a','e','i','o','u'};

            bool vogal = false;

            for (int i = 0; i < 5; i++)
            {
                if (fraseChar[num]==Vogais[i])
                {
                    vogal = true;
                }
            }

            
            if (num == fraseChar.Length-1)
            {
                if (vogal==true)
                {
                  return "";
                }
                else
                {
                    return fraseChar[num].ToString();
                }
            }
            else
            {
                string result = "";

                if (vogal == true)
                {
                    result = "" + antivogal(fraseChar, num + 1);
                    return result;
                }
                else
                {
                    result = "" + fraseChar[num].ToString() + antivogal(fraseChar, num + 1);
                    return result;
                }
            }

        }


    }
}
