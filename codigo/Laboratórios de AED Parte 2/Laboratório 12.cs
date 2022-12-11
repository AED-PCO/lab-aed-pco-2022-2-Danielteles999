using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp105
{
    public class ABB
    {
        private no auxiliar, sentinela, raiz;


        public class no
        {
            public string elemento;
            public int ID;
            public int data = 0;
            public no direita;
            public no esquerda;
            public bool raiz = false;
            public bool folha = false;
            public bool pai = false;

        }

        public class Raiz : no
        {

        }

        public ABB()
        {
            no sentinela = new no();
            this.sentinela = sentinela;
            this.sentinela.ID = -1;
            this.sentinela.elemento = null;
            this.sentinela.direita = null;
            this.sentinela.esquerda = null;
            this.auxiliar = this.sentinela;

        }

        public void Adicionar(string elemento, int data)
        {
            //Se o sentinela não tem filhos
            if ((this.sentinela.esquerda==null)&&(this.sentinela.direita == null))
            {
                Raiz raiz = new Raiz();
                this.raiz = raiz;
                this.auxiliar = this.raiz;
                this.auxiliar.elemento = elemento;
                this.auxiliar.data = data;
            }
            //Se o sentinela tem filhos
            else
            {
                if (data > this.auxiliar.data)
                {
                    while (this.auxiliar != null)
                    {
                        if (this.auxiliar.folha == true)
                        {
                            no novo1 = new no();
                            this.auxiliar.direita = novo1;
                            novo1.elemento = elemento;
                            novo1.direita = null;
                            novo1.esquerda = null;
                            novo1.data = data;
                            this.auxiliar.pai = true;
                            novo1.folha = true;
                        }
                        this.auxiliar = this.auxiliar.direita;
                    }
                    this.auxiliar = this.raiz;
                }
                else
                {
                    while (this.auxiliar != null)
                    {
                        if (this.auxiliar.folha == true)
                        {
                            no novo1 = new no();
                            this.auxiliar.direita = novo1;
                            novo1.elemento = elemento;
                            novo1.direita = null;
                            novo1.esquerda = null;
                            novo1.data = data;
                            this.auxiliar.pai = true;
                            novo1.folha = true;
                        }
                        this.auxiliar = this.auxiliar.esquerda;
                    }
                    this.auxiliar = this.raiz;
                }
            }
        }

        public void Remove(string elemento, int data)
        {
            no teste = new no();
            no Noencontrado = Busca(elemento, data, teste);



        }



        public int AlturaNo(string elemento ,no nodo)
        {
            no Buscado = Busca(elemento, nodo);
            this.auxiliar = Buscado;

            if (true)
            {

            }

            //Condição de parada

            if (this.auxiliar.esquerda != null)
            {
                return 1 + AlturaNo(elemento, this.auxiliar.esquerda);
            }
            else if(this.auxiliar.direita != null)
            {
                return -1 + AlturaNo(elemento, this.auxiliar.direita);
            }
        }


        public no Busca(string elemento, no Rec)
        {
            this.auxiliar = this.raiz;
            int ID = this.auxiliar.ID;

            if (this.auxiliar.folha==true)
            {
                return this.raiz;
            }
            if (this.auxiliar.elemento==elemento)
            {
                return this.auxiliar;
            }

            if (ID > this.auxiliar.data)
            {
                this.auxiliar = this.auxiliar.direita;
                return Busca(elemento, this.auxiliar);
            }
            else
            {
                this.auxiliar = this.auxiliar.esquerda;
                return Busca(elemento, this.auxiliar);
            }
        }

        /*
        public bool Vazia()
        {
            if (this.raiz.folha == true)
            {
                return true;
            }
            return false;
        }
        */

    }//Fechamento da classe ABB



    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
