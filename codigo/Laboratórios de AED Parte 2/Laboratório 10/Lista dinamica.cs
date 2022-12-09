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

        //Bloco central de cada elemento da lista 
        class Celula
        {
            public string elemento;
            public Celula proximo;
            public int ID;
        }

        //Construtor para criar o sentinela
        public Pilha()
        {

            //Criando o sentinela
            this.primeiro = new Celula();
            this.primeiro.ID = -1;
            this.primeiro.elemento = null;
            this.primeiro.proximo = null;
            this.ultimo = this.primeiro;

        }

        //A lista está vazia?
        public bool Vazia()
        {
            if (this.primeiro.proximo == this.ultimo)
            {
                return true;
            }
            return false;
        }

        //Adicionando sem  posição
        public void Add1(string elemento)
        {
            //Inserindo na última posição por padrão

            Celula novo1 = new Celula();
            this.ultimo.proximo = novo1;
            novo1.elemento = elemento;
            novo1.proximo = null;
            novo1.ID = this.ultimo.ID + 1;
            this.ultimo = novo1;

            if (Vazia() == true)
            {
                this.ultimo = this.primeiro.proximo;
            }
        }

        //Adicionando com uma posição inserida

        public void Add(string elemento, int pos)
        {
            this.auxiliar = this.primeiro;

            //Executará se o valor informado estiver fora da lista
            //O  método irá inserir por padrão no final da lista
            if ((pos > this.ultimo.ID) || (pos < this.primeiro.proximo.ID))
            {
                Celula novo1 = new Celula();
                novo1.elemento = elemento;
                this.ultimo.proximo = novo1;
                novo1.proximo = null;
                novo1.ID = this.ultimo.ID + 1;
                this.ultimo = novo1;

                if (Vazia() == true)
                {
                    this.ultimo = this.primeiro.proximo;
                }
            }
            else //Se a posição informada estiver na lista
            {
                //Enquanto a referencia não for nula e o proximo dela não for nula executa
                while ((this.auxiliar != null) && (this.auxiliar.proximo != null))
                {
                    //Se este é o último elemento
                    if (this.auxiliar.proximo == null)
                    {
                        this.auxiliar.ID++;
                    }
                    else
                    {
                        //Se encontrado a posição desejada inserir na posição
                        if (this.auxiliar.proximo.ID == pos)
                        {

                            Celula inserido = new Celula();
                            this.ultimo.proximo = inserido;
                            inserido.elemento = elemento;
                            inserido.proximo = this.auxiliar.proximo;
                            this.auxiliar.proximo = inserido;
                            this.ultimo.proximo = null;

                            inserido.ID = this.auxiliar.ID + 1;
                            inserido.proximo.ID = inserido.ID + 1;

                            //Atualizando a numeração de todos
                            this.auxiliar = this.primeiro;

                            while (this.auxiliar.proximo != null)
                            {
                                this.auxiliar.proximo.ID = this.auxiliar.ID + 1;
                                this.auxiliar = this.auxiliar.proximo;
                            }
                        }
                    }
                    //Só incrementa se o elemento não for o último
                    if (this.auxiliar.proximo != null)
                    {
                        this.auxiliar = this.auxiliar.proximo;
                    }

                }
            }



        }
        //Método de remoção comum, sem posição
        public void Remove(string elemento)
        {
            this.auxiliar = this.primeiro;
            //Verificador se a posição desejada for encontrada
            bool verif = false;

            //Enquanto a referência não for nula
            while (this.auxiliar != null)
            {
                //Se a referencia for o ultimo elemento
                if (this.auxiliar.proximo != null)
                {
                    //Se a posição foi encontrada
                    if (this.auxiliar.proximo.elemento == elemento)
                    {
                        verif = true;//Sinaliza que foi encontrada

                        //Se a referencia for o penultimo elemento, removendo o ultimo
                        if (this.auxiliar.proximo.proximo == null)
                        {
                            this.auxiliar.proximo = null;
                            this.ultimo = this.auxiliar;
                        }
                        else
                        {
                            Celula teste = new Celula();
                            teste.proximo = this.auxiliar.proximo.proximo;
                            this.auxiliar.proximo.proximo = null;
                            this.auxiliar.proximo = teste.proximo;
                            teste.proximo = null;

                            this.auxiliar = this.primeiro;
                        }

                        //Atualizando o número da posição de cada um depois da reordenação
                        while (this.auxiliar.proximo != null)
                        {
                            this.auxiliar.proximo.ID = this.auxiliar.ID + 1;
                            this.auxiliar = this.auxiliar.proximo;
                        }

                    }
                }
                //Se a referencia não for o último elemento
                else
                {
                    //Se o elemento não foi encontrado
                    if (verif == false)
                    {
                        Console.WriteLine("\n\nOps, Não encontrei o elemento, tente novamente\n\n");
                    }
                }

                this.auxiliar = this.auxiliar.proximo;

            }

        }


        //Removendo a posição
        public void RemovePos(int pos)
        {
            //Verificador de sucesso na busca
            bool verif = false;
            this.auxiliar = this.primeiro;

            //Mesmo funcionamento do Remove, porem a busca é o ID de cada elemento
            while (this.auxiliar != null)
            {
                if (this.auxiliar.proximo != null)
                {
                    if (this.auxiliar.proximo.ID == pos)
                    {
                        verif = true;
                        if (this.auxiliar.proximo.proximo == null)
                        {
                            this.auxiliar.proximo = null;
                            this.ultimo = this.auxiliar;
                        }
                        else
                        {
                            Celula teste = new Celula();
                            teste.proximo = this.auxiliar.proximo.proximo;
                            this.auxiliar.proximo.proximo = null;
                            this.auxiliar.proximo = teste.proximo;
                            teste.proximo = null;

                            this.auxiliar = this.primeiro;
                        }

                        while (this.auxiliar.proximo != null)
                        {
                            this.auxiliar.proximo.ID = this.auxiliar.ID + 1;
                            this.auxiliar = this.auxiliar.proximo;
                        }

                    }
                }
                else
                {
                    if (verif == false)
                    {
                        Console.WriteLine("\n\nOps, Não encontrei a posição na lista, tente novamente\n\n");
                    }
                }



                this.auxiliar = this.auxiliar.proximo;
            }
        }

        //Método Exibir
        public void Exibir()
        {

            this.auxiliar = this.primeiro.proximo;

            Console.WriteLine("--------------------");
            Console.WriteLine("\n\nItens da Lista: ");

            //Passa cada posição exibindo o rótulo do elemento com a posição dele
            while (this.auxiliar != null)
            {
                Console.Write($"{this.auxiliar.elemento} - (Posição: {this.auxiliar.ID}) |  ");
                this.auxiliar = this.auxiliar.proximo;
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("-----------------------");
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

            //Menu completo com opções
            do
            {
                Console.WriteLine("Digite a opção desejada: ");
                Console.WriteLine("\nInserindo sem definir posição:\n(1) para inserir\n(2) para retirar um nome");
                Console.Write("\nInserindo definindo posição:\n(3) para inserir na posição específica\n(4) para retirar um nome na posição específica\n(5) para sair do menu\nInsira aqui a opção: ");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");


                switch (opcao)
                {
                    case 1:
                        {
                            Console.WriteLine("------------------------------");
                            Console.Write("Insira o nome que deseja inserir: ");
                            string nome = Console.ReadLine();
                            teste.Add1(nome);
                            teste.Exibir();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("------------------------------");
                            Console.WriteLine("Insira o nome que deseja remover: ");
                            string nome = Console.ReadLine();
                            teste.Remove(nome);
                            teste.Exibir();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("------------------------------");
                            Console.Write("Insira o nome que deseja inserir: ");
                            string nome = Console.ReadLine();
                            Console.Write($"Ok, inserir {nome} em qual posição? : ");
                            int pos = int.Parse(Console.ReadLine());
                            teste.Add(nome, pos);
                            teste.Exibir();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("------------------------------");
                            Console.Write("Insira a posição da lista que deseja remover: \n");
                            teste.Exibir();
                            int pos = int.Parse(Console.ReadLine());
                            teste.RemovePos(pos);
                            teste.Exibir();
                            break;
                        }
                    case 5:
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
            while (opcao != 5);

        fim:;
        }
    }
}