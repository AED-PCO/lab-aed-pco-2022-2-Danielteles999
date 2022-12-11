using System;

namespace ConsoleApp99
{
    class Program
    {
        public static int[] AdicionarPos(int[] Vet, int pos, int num)
        {
            //Shiftando
            Array.Resize(ref Vet, Vet.Length + 1);

            for (int j = Vet.Length - 1; j > pos; j--)
            {
                Vet[j] = Vet[j - 1];
            }
            Vet[pos] = num;

            return Vet;
        }

        public static int[] Adicionar(int[] Vet, int num)
        {
            Array.Resize(ref Vet, Vet.Length + 1);
            Vet[Vet.Length - 1] = num;
            return Vet;
        }


        public static int[] RemoveVetor(int[] Vet, int aux, int num)
        {
            //Fazendo o shift
            for (int j = aux; j < Vet.Length - 1; j++)
            {
                Vet[j] = Vet[j + 1];
            }
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
                Console.WriteLine("{1}Adicionar item sem posição específica\n{2}Remover item");
                Console.WriteLine("{3}Adicionar item com posição específica\n{4}Sair\n");
                Console.Write("Insira a opção desejada: ");
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
                                Console.WriteLine("Não é possível remover itens.");
                            }
                            else
                            {

                                Console.WriteLine("Insira o número para remoção: ");
                                int num = int.Parse(Console.ReadLine());

                                bool verif1 = false;
                                int aux1 = 0;

                                //Verificando se o elemento desejado está no vetor
                                for (int i = 0; i < Vet.Length; i++)
                                {
                                    if (Vet[i] == num)
                                    {
                                        verif1 = true;
                                        aux1 = i;
                                    }
                                }

                                if (verif1 == true)
                                {
                                    Vet = RemoveVetor(Vet, aux1, num);
                                    ExibirVetor(Vet);
                                }
                                else
                                {
                                    Console.WriteLine("Número não encontrado, tente novamente");
                                }


                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Insira o número que deseja inserir: ");
                            int num = int.Parse(Console.ReadLine());
                            Console.WriteLine("Insira a posição que deseja inserir: ");
                            int pos = int.Parse(Console.ReadLine());

                            if ((pos < Vet.Length - 1) && (pos > 0))
                            {

                                Vet = AdicionarPos(Vet, pos, num);
                                ExibirVetor(Vet);

                            }
                            else
                            {
                                Console.WriteLine("Posição não existe no vetor, tente novamente.");
                            }
                            break;
                        }
                    case 4:
                        {
                            int[] Vet21 = new int[Vet.Length * 2];

                            for (int i = 0; (i < Vet.Length) && (i != null); i++)
                            {
                                Vet21[i] = Vet[i];
                            }

                            int aux = Vet.Length - 1;
                            for (int j = Vet.Length; j < Vet21.Length; j++)
                            {
                                Vet21[j] = Vet[aux];

                                aux = aux - 1;
                            }

                            Console.WriteLine("Vetor original: ");
                            ExibirVetor(Vet);
                            Console.WriteLine(" ");
                            Console.WriteLine("Vetor customizado: ");
                            ExibirVetor(Vet21);

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Desculpe, opção inválida, tente novamente");
                            break;
                        }
                }

            } while (opcao != 5);

            Console.ReadKey();

        }


    }
}