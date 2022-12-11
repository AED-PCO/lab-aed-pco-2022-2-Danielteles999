using System;

namespace ConsoleApp99
{
    class Program
    {
        public static int[] Adicionar(int[] Vet, int num)
        {
            Array.Resize(ref Vet, Vet.Length + 1);
            Vet[Vet.Length - 1] = num;
            return Vet;
        }


        public static int[] RemoveVetor(int[] Vet)
        {
            if (Vet.Length == 1)
            {
                Array.Resize(ref Vet, Vet.Length - 1);
                return Vet;
            }
            else
            {
                for (int i = 0; i < Vet.Length - 1; i++)
                {
                    Vet[i] = Vet[i + 1];
                }
                Array.Resize(ref Vet, Vet.Length - 1);
                return Vet;
            }
        }

        public static void ExibirVetor(int[] Vetor)
        {
            for (int i = 0; i < Vetor.Length; i++)
            {
                Console.Write($"{Vetor[i]} | ");
            }
        }

        static void Main(string[] args)
        {
            int[] Vet1 = {1,2,3,4,5,6,7,8,9,10};

            int[] Vet2 = new int[Vet1.Length];

            Console.Write("Exibindo o vetor 1: ");
            ExibirVetor(Vet1);
            Console.WriteLine(" ");
            Console.Write("Exibindo o vetor 2: ");
            ExibirVetor(Vet2);

            int aux = Vet2.Length - 1;

            for (int i = 0; i < Vet1.Length; i++)
            {
                Vet2[aux] = Vet1[i];
                aux = aux - 1;

            }

            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Preenchendo o vetor 2\n");

            Console.Write("Exibindo o vetor 1: ");
            ExibirVetor(Vet1);
            Console.WriteLine(" ");
            Console.Write("Exibindo o vetor 2: ");
            ExibirVetor(Vet2);


            Console.ReadKey();

        }


    }
}