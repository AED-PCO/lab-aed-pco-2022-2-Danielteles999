using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp99
{
    class Fila
    {
        private Celula primeiro, ultimo, auxiliar;

        //Estrutura básica dos elementos
        class Celula
        {
            public string elemento;
            public Celula proximo;
        }

        public Fila()
        {

            //Criando o sentinela
            this.primeiro = new Celula();
            this.primeiro.elemento = null;
            this.primeiro.proximo = null;
            this.ultimo = this.primeiro;
        }

        //A Fila está vazia?
        public bool Vazia()
        {
            if (this.primeiro.proximo == this.ultimo)
            {
                return true;
            }
            return false;
        }

        //Método adicionar, padrão na última posição
        public void Add(string elemento)
        {
            if (Vazia() == true)
            {
                this.ultimo = this.primeiro.proximo;
            }

            //Crio uma cópia para guardar a sequência
            Celula novo1 = new Celula();
            this.ultimo.proximo = novo1;
            novo1.elemento = elemento;
            novo1.proximo = null;
            this.ultimo = novo1;


        }

        //Método de remoção
        public void Remove()
        {

            //Se a fila estiver vazia
            if (this.primeiro.proximo == null)
            {
                Console.WriteLine("não é possível retirar itens");
            }
            else
            {
                //Fila vazia
                if (this.primeiro.proximo.proximo == null)
                {
                    this.primeiro.proximo = null;
                    this.ultimo = this.primeiro;

                    Console.Write("Fila vazia, ");
                }
                else
                {
                    //Adicionando no final por padrão

                    Celula aux = new Celula();
                    aux = this.primeiro.proximo;
                    this.primeiro.proximo = null;
                    this.primeiro.proximo = aux.proximo;
                    aux.proximo = null;

                    //Removendo o último da lista
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

            Console.WriteLine("Itens da Fila:");

            while (this.auxiliar != null)
            {
                Console.Write($"{this.auxiliar.elemento} | ");
                this.auxiliar = this.auxiliar.proximo;
            }

            Console.WriteLine(" ");
            Console.WriteLine("---------------------------");

        }
    }


    class Program
    {
        static void Main(string[] args)
        {

        int opcao = 0;
         Fila teste = new Fila();



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