using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp85
{
    class Program
    {
        static int BuscaBinariaPos(int[] Vet, int num, int inic, int fim)
        {
            int meio;

            meio = (fim + inic) / 2;

            //Condição de parada
            if (inic>fim)
            {
                return -1;
            }

            //Se o número da posição for menor que o número buscado
            if (Vet[meio]<num)
            {
               return BuscaBinariaPos(Vet, num, meio + 1, fim);
            }

            else if (Vet[meio]>num)
            {
                return BuscaBinariaPos(Vet, num, inic, meio - 1);
            }
            else
            {
                return Vet[meio];
            }
        }

        static void Main(string[] args)
        {
            int num;
            int[] Vet = {1,2,6,8,9,23,43,56,78,100};

            Console.WriteLine("Insira o número que deseja encontrar");
            num = int.Parse(Console.ReadLine());

            if (BuscaBinariaPos(Vet, num, 0, 10) > 0)
            {
                Console.WriteLine("O número encontra-se no vetor");
            }
            else
            {
                Console.WriteLine("O número não encontra-se no vetor");
            }

            Console.ReadKey();

        }
    }
}
