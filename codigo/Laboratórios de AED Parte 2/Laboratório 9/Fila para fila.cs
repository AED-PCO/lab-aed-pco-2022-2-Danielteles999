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
            int[] Vet = new int[0];
            int opcao = 0;

            do
            {
                Console.Write("\nOpções: \n");
                Console.WriteLine("{1}Adicionar item\n{2}Remover item\n{3}Copiar para outra fila porem invertida\n{4}Sair\n");
                Console.Write("Insira a opção desajada: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {
                            Console.WriteLine("Insira o número que deseja inserir: ");
                            int num = int.Parse(Console.ReadLine());
                            Vet = Adicionar(Vet, num);
                            ExibirVetor(Vet);
                            break;
                        }
                    case 2:
                        {
                            if (Vet.Length == 0)
                            {
                                Console.WriteLine("Ops, vetor vazio, não é possível remover itens.");
                            }
                            else
                            {
                                Vet = RemoveVetor(Vet);
                                ExibirVetor(Vet);
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Vetor original");
                            ExibirVetor(Vet);

                            int[] Vet21 = new int[Vet.Length];
                            int aux21 = Vet21.Length - 1;

                            for (int i = 0; i < Vet.Length; i++)
                            {
                                Vet21[aux21] = Vet[i];
                                aux21 = aux21 - 1;
                            }

                            Console.WriteLine("\n_________\n");
                            Console.WriteLine("Vetor2 invertido: ");
                            ExibirVetor(Vet21);

                            break;
                        }
                    case 4:
                        {

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Desculpe, opção inválida, tente novamente");
                            break;
                        }
                }

            } while (opcao != 4);

        }

    }
}