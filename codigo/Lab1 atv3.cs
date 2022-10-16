//Atividade 3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
                int[] A = new int[5];
                int[] B = new int[5];

                Console.WriteLine("OPERAÇÃO COM VETORES");
                Console.WriteLine(" ");
                Console.Write("REGRAS:");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("- Não podem ser inseridos no mesmo vetor, números repetidos");
                Console.WriteLine("- Preencha os vetores apenas com números inteiros");
                Console.WriteLine("- Caso isto ocorra, será necessário inserir novamente o valor");
                Console.WriteLine("- O programa verificará os elementos em comum entre os vetores, e exibirá os elementos em A que não estão contidos em B");
                Console.WriteLine("-------------------------------");

                Console.WriteLine("Insira os dados para o vetor 1");

                //Criando o vetor 1
                for (int i = 0; i < A.Length; i++)
                {
                    int num = 0;
                retomada:
                    Console.WriteLine("Insira o {0}º número.", i + 1);
                    num = int.Parse(Console.ReadLine());

                    //Sistema verificador de número repetidos
                    for (int j = 0; j < A.Length; j++)
                    {
                        if (num == A[j])
                        {
                            goto retomada;
                        }
                    }

                    //Atribuição após verificação do valor
                    A[i] = num;

                    //Zerando novamente a variavel para receber novo valor
                    num = 0;
                }

                Console.WriteLine("------------------------------");
                Console.WriteLine("Vetor 1 criado com sucesso!");
                Console.WriteLine("------------------------------");

                Console.WriteLine("Insira os dados para o vetor 2");

                //Criando o vetor 2
                for (int j = 0; j < B.Length; j++)
                {
                    int num2 = 0;
                retomada2:
                    Console.WriteLine("Insira o {0}º número.", j + 1);
                    num2 = int.Parse(Console.ReadLine());

                    //Sistema verificador de número repetidos
                    for (int k = 0; k < B.Length; k++)
                    {
                        if (num2 == B[k])
                        {
                            goto retomada2;
                        }
                    }

                    //Atribuição após verificação do valor
                    B[j] = num2;

                    //Zerando novamente a variavel para receber novo valor
                    num2 = 0;
                }

                Console.WriteLine("------------------------------");
                Console.WriteLine("Vetor 2 criado com sucesso!");
                Console.WriteLine("------------------------------");

                //Comparando os elementos dos dois vetores
                int[] C = new int[5];
                int[] D = new int[5];

                for (int x = 0; x < 5; x++)
                {
                    for (int y = 0; y < 5; y++)
                    {
                        if (A[x] == B[y])
                        {
                            C[y] = B[y];
                        }
                    }
                }

                bool cont;
                
                for (int x = 0; x < 5; x++)
                {
                    cont = true;

                    for (int y = 0; y < 5; y++)
                    {
                        if (A[x]==B[y])
                        {
                            cont = false;
                        }

                        if ((y == 4) && (cont == true))
                        {
                            D[x] = A[x];
                        }
                    }


                }
                   

                Console.WriteLine("==================");
                Console.WriteLine("Resultados");
                Console.WriteLine("==================");

                Console.Write("Elementos iguais entre os vetores: ");

                //Exibindo C
                for (int ad = 0; ad < C.Length; ad++)
                {
                    if (C[ad] != 0)
                    {
                        Console.Write("{0} ", C[ad]);
                    }

                }
                Console.WriteLine("==================");

                Console.Write("Elementos em A não contidos em B: ");

                //Exibindo D
                for (int ad = 0; ad < D.Length; ad++)
                {
                    if (D[ad] != 0)
                    {
                        Console.Write("{0} ", D[ad]);
                    }

                }

                Console.ReadKey();
        }
    }
}


