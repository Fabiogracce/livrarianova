using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria2
{
    class ControlLivro
    {
        ModelLivro model;//Conectar com a classe pessoa
        private int opcao;
        public ControlLivro()
        {

            model = new ModelLivro();//Acesso a todos os métodos da classe pessoa
            ModificarOpcao = 0;

        }// fim do construtor

        public int ModificarOpcao
        {
            get { return opcao; }
            set { opcao = value; }

        }// fim do modificarOpcao


        public void Menu()
        {
            Console.WriteLine("Menu - Livro" +
                              "\nEscolha uma das opçoes abaixo: " +
                              "\n1. Cadastrar Livro" +
                              "\n2. Consultar Livro" +
                              "\n3. Atualizar Quantidade" +
                              "\n4. Atualizar Preço" +
                              "\n5. Atulizar Excluir");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());

        }//fim do menu


        public void Operacao()
        {
            Menu();//Mostrar Menu
            switch (ModificarOpcao)
            {
                case 1:
                    Console.WriteLine("Informe o Codigo do livro: ");
                    int Codigo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Informe o  Titulo do livro: ");
                    string Titulo = Console.ReadLine();

                    Console.WriteLine("Informe o Autor: ");
                    string Autor = Console.ReadLine();

                    Console.WriteLine("Informe a Editora: ");
                    string Editora = Console.ReadLine();

                    Console.WriteLine("Informe o genero do Livro: ");
                    string Genero = (Console.ReadLine());

                    Console.WriteLine("Informe o ISBN do Livro: ");
                    string Isbn = (Console.ReadLine());

                    Console.WriteLine("Informe a Quantidade de livros: ");
                    int Quantidade = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Informe o preço do Livro: ");
                    int preco = Convert.ToInt32(Console.ReadLine());

                    model.CadastrarLivro(Codigo,Titulo,Autor,Editora,Genero,Isbn,Quantidade,preco);
                    break;

                    

                case 2:
                    Console.WriteLine("Informe o Titulo que deseja consultar: ");
                    Titulo = Console.ReadLine();

                    Console.WriteLine(model.ConsultarLivro(Titulo));
                    break;

                case 3:
                    Console.WriteLine("Informe o Titulo: ");
                    Titulo = Console.ReadLine();

                    Console.WriteLine("Informe a Quantidade de Livros: ");
                    Quantidade = Convert.ToInt32(Console.ReadLine());

                    //Atualizar
                    model.AtualizarQuantidade(Titulo, Quantidade);
                    break;

                case 4:
                    Console.WriteLine("Informe o Titulo: ");
                    Titulo = Console.ReadLine();

                    Console.WriteLine("Informe o Preço dos Livros: ");
                    preco = Convert.ToInt32(Console.ReadLine());

                    //Atualizar
                    model.AtualizarQuantidade(Titulo, preco);
                    break;

                case 5:
                    Console.WriteLine("Informe o Titulo: ");
                    Titulo = Console.ReadLine();

                    //Excluir
                    model.Excluir(Titulo);
                    break;
                    



            }
        }
    }

}