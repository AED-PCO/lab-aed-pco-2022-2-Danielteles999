using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp99
{
    class Pilha
    {
        private Celula primeiro, ultimo, auxiliar;

        //Estrutura básica dos elementos
        class Celula
        {
            public string elemento;
            public Celula proximo;
        }

        //Construtor criando o sentinela
        public Pilha()
        {

            //Criando o sentinela
            this.primeiro = new Celula();
            this.primeiro.elemento = null;
            this.primeiro.proximo = null;
            this.ultimo = this.primeiro;
        }

        //A pilha está vazia?
        public bool Vazia()
        {
            if (this.primeiro.proximo == this.ultimo)
            {
                return true;
            }
            return false;
        }
        //Adicionando por padrão na última posição
        public void Add(string elemento)
        {
            //Criando uma nova célula e guardando nela a sequencia dos demais elementos
            Celula novo1 = new Celula();
            this.ultimo.proximo = novo1;
            novo1.elemento = elemento;
            novo1.proximo = null;
            this.ultimo = novo1;

            if (Vazia() == true)
            {
                this.ultimo = this.primeiro.proximo;
            }
        }

        //Removendo o último inserido
        public void Remove()
        {
            //Se a pilha estiver vazia
            if (this.primeiro.proximo == null)
            {
                Console.WriteLine("não é possível retirar itens");
            }
            else
            {
                //Pilha vazia
                if (this.primeiro.proximo.proximo == null)
                {
                    this.primeiro.proximo = null;
                    this.ultimo = this.primeiro;
                    Console.WriteLine("Pilha vazia, ");
                }
                else
                {

                    //Removendo do final
                    //Bem simples, apenas pegando o pénultimo e apontando o proximo dele par nulo
                    this.auxiliar = this.primeiro.proximo;

                    while (this.auxiliar != null)
                    {
                        if (this.auxiliar.proximo == this.ultimo)
                        {
                            this.auxiliar.proximo = null;
                            this.ultimo = this.auxiliar;
                        }
                        this.auxiliar = this.auxiliar.proximo;
                    }
                }


            }

        }

        public void Exibir()
        {

            this.auxiliar = this.primeiro.proximo;
            Console.WriteLine("------------------------------");
            Console.WriteLine("\nItens da Pilha: ");

            while (this.auxiliar != null)
            {
                Console.Write($"{this.auxiliar.elemento} | ");
                this.auxiliar = this.auxiliar.proximo;
            }
            Console.WriteLine("\n");
            Console.WriteLine("------------------------------");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            Pilha teste = new Pilha();

            Console.WriteLine("Pilha de nomes v2.3");
            Console.WriteLine(" ");

            //Menu
            do
            {
                Console.WriteLine("Digite a opção desejada: ");
                Console.Write("(1) para inserir\n(2) para retirar\n(3) para sair do menu\n\nInsira aqui a opção: ");
                opcao = int.Parse(Console.ReadLine());


                switch (opcao)
                {
                    case 1:
                        {
                            Console.WriteLine("------------------------------");
                            Console.Write("Insira o nome que deseja inserir: ");
                            string nome = Console.ReadLine();
                            teste.Add(nome);
                            teste.Exibir();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("------------------------------");
                            Console.WriteLine("Removendo");
                            teste.Remove();
                            teste.Exibir();
                            break;
                        }
                    case 3:
                        {
                            goto fim;
                        }
                    default:
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Insira novamente a opcao");
                        opcao = int.Parse(Console.ReadLine());
                        break;
                }
            }
            while (opcao != 3);

        fim:;

        }
    }
}