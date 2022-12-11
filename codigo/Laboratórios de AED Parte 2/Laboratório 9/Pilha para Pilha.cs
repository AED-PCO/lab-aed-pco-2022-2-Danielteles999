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
            Array.Resize(ref Vet, Vet.Length - 1);
            return Vet;
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
                Console.WriteLine("{1}Adicionar item\n{2}Remover item\n{3}Copiar ordem original para outro vetor auxiliar\n{4}Sair\n");
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
                            int[] Vet31 = Vet;
                            Console.WriteLine("Exibindo o novo vetor copiado: ");
                            ExibirVetor(Vet31);
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

            Console.ReadKey();

        }


    }
}