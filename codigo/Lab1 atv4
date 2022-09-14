//Atividade 4

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp74
{
    class Program
    {

        static int LeNum(string msg)
        {
            int num = 0;

            Console.Write(msg);
            num = int.Parse(Console.ReadLine());
            return num;

        }

        static void Main(string[] args)
        {
            int[,] Vetor = new int[5, 3];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Vetor[i, j] = LeNum($" | Linha: {i + 1} | Coluna: {j + 1} - Insira o número: ");
                }

            }

            Console.WriteLine("-----------Soma das linhas-----------");

            int somaLinha = 0, m = 0;
            bool teste1 = true;

            while ((teste1 == true) && (m < 5))
            {
                //Somador de linhas
                for (int j = 0; j < 3; j++)
                {
                    if (m<5)
                    {
                        if ((j == 2))
                        {
                            teste1 = false;
                            Console.WriteLine($"A soma da {m + 1}ª linha é: {somaLinha}");
                            somaLinha = 0;
                            if (m < 4)
                            {
                                m++;
                                teste1 = true;
                            }
                            
                        }
                    }  
                    somaLinha = somaLinha + Vetor[m, j];


                }
            }

            Console.WriteLine("-----------Soma das colunas-----------");

            int somaColuna = 0, n = 0;
            bool teste2 = true;

            while ((teste2 == true) && (n < 3))
            {
                //Somador de Colunas
                for (int j = 0; j < 5; j++)
                {
                    somaColuna = somaColuna + Vetor[j, n];

                    if (n < 3)
                    {

                        if (j == 4)
                        {
                            teste2 = false;
                            Console.WriteLine($"A soma da {n + 1}ª coluna é: {somaColuna}");
                            somaColuna = 0;
                            if (n < 3)
                            {
                                n++;
                                teste2 = true;
                            }

                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
