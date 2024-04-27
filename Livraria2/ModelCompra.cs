
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;
 
namespace Livraria

{

    class Compra

    {

        Livro modelLivro;

        Pessoa modelPessoa;

        private int CPF;

        private string nome;

        private int codigoLivro;

        private int quantidade;

        private double preco;

        private double total;

        private string situacao;

        //Método Construtor

        public Compra()

        {

            ConsultarCPF = 0;

            ConsultarNome = "";

            ConsultarLivro = 0;

            ConsultarQuantidade = 0;

            ConsultarPreco = 0;

            ConsultarTotal = 0;

            ConsultarSituacao = "";

        }//Fim do Construtor

        //Método Modificadores = Gets e Sets

        public int ConsultarCPF

        {

            get { return CPF; }

            set { this.CPF = value; }

        }//Fim do Modificar

        public string ConsultarNome

        {

            get { return nome; }

            set { this.nome = value; }

        }//Fim do Modificar

        public int ConsultarLivro

        {

            get { return codigoLivro; }

            set { this.codigoLivro = value; }

        }//Fim do Modificar

        public int ConsultarQuantidade

        {

            get { return quantidade; }

            set { this.quantidade = value; }

        }//Fim do Modificar

        public double ConsultarPreco

        {

            get { return preco; }

            set { this.preco = value; }

        }//Fim do Modificar

        public double ConsultarTotal

        {

            get { return total; }

            set { this.total = value; }

        }//Fim do Modificar

        public string ConsultarSituacao

        {

            get { return situacao; }

            set { this.situacao = value; }

        }//Fim do Modificar

        //Métodos - CRUD

        public void EfeturarCompra(int CPF, string nome, int codigoLivro, int quantidade, int preco)

        {

            ConsultarCPF = 0;

            ConsultarNome = "";

            ConsultarQuantidade = 0;

            ConsultarPreco = modelLivro.ConsultarPrecoIndividual(codigoLivro);

            ConsultarTotal = ConsultarQuantidade * ConsultarPreco;

        }//Fim do Método

        public string ConsultarIndividual(int CPF)

        {

            string consulta = "";

            if (ConsultarCPF == CPF)

            {

                consulta = "\nCPF: " + ConsultarCPF +

                                  "\nNome: " + ConsultarNome +

                                  "\nLivro: " + ConsultarLivro +

                                  "\nEditora: " + ConsultarQuantidade +

                                  "\nValor Unitário: " + ConsultarPreco +

                                  "\nTotal: " + ConsultarTotal;

            }

            else

            {

                consulta = "Número de ISBN não é valido!";

            }

            return consulta;

        }//Fim do Método

        public void RealizarCompra(int codigoLivro)

        {

            if (ConsultarLivro != codigoLivro)

            {

                ConsultarLivro = codigoLivro;

            }

        }//Fim do Método

        public void AtualizarEstoque(int quantidade)

        {

            if (ConsultarQuantidade == 0)

            {

                ConsultarQuantidade = quantidade;

            }

        }//Fim do Método

        public void ConsultarValor(int preco)

        {

            if (ConsultarPreco != preco)

            {

                ConsultarPreco = preco;

            }//Fim do If

        }//Fim do Método

        public void AtualizarSituacao(int CPF, string situacao)

        {

            if (ConsultarCPF == CPF)

            {

                ConsultarSituacao = situacao;

            }//Fim do If

        }//Fim do Método

        public void Excluir(int CPF)

        {

            if (ConsultarCPF == CPF)

            {

                ConsultarSituacao = "Inativo";

            }//Fim do If

        }//Fim do Excluir

    }

}
