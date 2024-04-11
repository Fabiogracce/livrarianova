using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria2
{
    class ModelLivro
    {

        private int Codigo;
        private string Titulo;
        private string Autor;
        private string Editora;
        private string Genero;
        private string Isbn;
        private int Quantidade;
        private int Preco;
        private string situacao;//Ativo ou Inativo

        public ModelLivro()

        {

            ConsultarCodigo = 0;
            ConsultarTitulo = "";
            ConsultarAutor = "";
            ConsultarEditora = "";
            ConsultarGenero = "";
            ConsultarIsbn = "";
            ConsultarQuantidade = 0;
            ConsultarPreco = 0;
            Modificarsituacao = "";//Ativo ou Inativo
    }//Fim do construtor

        //Métodos modificados = Gets e Sets

        public int ConsultarCodigo

        {

            get { return this.Codigo; }

            set { this.Codigo = value; }

        }//Fim do modificar

        public string ConsultarTitulo

        {

            get { return this.Titulo; }

            set { this.Titulo = value; }

        }//Fim do modificar

        public string ConsultarAutor

        {

            get { return this.Autor; }

            set { this.Autor = value; }

        }//Fim do modificar

        public string ConsultarEditora

        {

            get { return this.Editora; }

            set { this.Editora = value; }

        }//Fim do modificar

        public string ConsultarGenero

        {

            get { return this.Genero; }

            set { this.Genero = value; }

        }//Fim do modificar

        public string ConsultarIsbn

        {

            get { return this.Isbn; }

            set { this.Isbn = value; }

        }//Fim do modificar

        public int ConsultarQuantidade

        {

            get { return this.Quantidade; }

            set { this.Quantidade = 0; }

        }//Fim do modificar

        public int ConsultarPreco

        {

            get { return this.Preco; }

            set { this.Preco = value; }

        }//Fim do modificar

        public string Modificarsituacao
        {
            get { return this.situacao; }
            set { this.situacao = value; }

        }//fim do modificar

        public void CadastrarLivro(int Codigo, string Titulo, string Autor, string Editora, string Genero, string Isbn, int Quantidade, int Preco)
        {

            ConsultarCodigo = Codigo;
            ConsultarTitulo = Titulo;
            ConsultarAutor = Autor;
            ConsultarEditora = Editora;
            ConsultarGenero = Genero;
            ConsultarIsbn = Isbn;
            ConsultarQuantidade = Quantidade;
            ConsultarPreco = Preco;
            Modificarsituacao = "Ativo";

        }//fim do metodo

        public string ConsultarLivro(string titulo)
        {
            string consulta = "";
            if (ConsultarTitulo == titulo)
            {
                consulta = "\nCodigo: " + ConsultarCodigo +
                                  "\nTitulo: " + ConsultarTitulo +
                                  "\nAutor: " + ConsultarAutor +
                                  "\nEditora: " + ConsultarEditora +
                                  "\nGenero: " + ConsultarGenero +
                                  "\nIsbn: " + ConsultarIsbn +
                                  "\nQuantidade: " + ConsultarQuantidade +
                                  "\nPreço:  " + ConsultarPreco +
                                  "\nSituação" + Modificarsituacao;
            }
            else
            {
                consulta = "Título não é válido!!";

            }
            return consulta;

        }

        public void AtualizarQuantidade(string Titulo, int Quantidade)
        {
            if (ConsultarTitulo == Titulo)
            {

                ConsultarQuantidade = Quantidade;
            }


        }//fim do método


        public void AtualizarPreco(string Titulo, int preco)
        {
            if (ConsultarTitulo == Titulo)
            {

                ConsultarPreco = preco;
            }


        }//fim do método



        public void Excluir(string Titulo)
        {
            if (ConsultarTitulo == Titulo)
            {
                Modificarsituacao = "Inativo";


            }


        }//fim do método
    }

}
