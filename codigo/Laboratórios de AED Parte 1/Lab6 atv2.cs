namespace ConsoleApp5
{
    class Program
    {
        static int[] rt(int[] Vet)
        {
            for (int i = 0; i < Vet.Length - 1; i++)
            {
                int menor = i;

                for (int j = i + 1; j < Vet.Length; j++)
                {
                    if (Vet[j] < Vet[menor])
                    {
                        menor = j;
                    }
                }

                int aux = Vet[menor];
                Vet[menor] = Vet[i];
                Vet[i] = aux;

            }
            return Vet;
        }


        static void Main(string[] args)
        {

            int[] Vet = new int[10];
            Random random1 = new Random();

            for (int i = 0; i < 10; i++)
            {
                Vet[i] = random1.Next(0, 10);
            }


            //Exibindo o vetor original

            for (int j = 0; j < Vet.Length; j++)
            {
                Console.Write($"{Vet[j]}, ");
            }

            Console.Write("\n");


            //Exibindo o vetor ordenado
            for (int i = 0; i < rt(Vet).Length; i++)
            {
                Console.Write($"{rt(Vet)[i]}, ");
            }
            Console.ReadKey();


        }

    }
}
