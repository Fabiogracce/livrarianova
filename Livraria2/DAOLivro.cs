using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using MySql.Data;

using MySql.Data.MySqlClient;

namespace Livraria

{

    class DAOLivro

    {

        public MySqlConnection conexao;

        public string dados;

        public string comando;

        public int [] Codigo;

        public string [] Titulo;

        public string[] Autor;

        public string[] Editora;

        public string[] Genero;

        public string[] Isbn;

        public int[] Quantidade;

        public int[] Preco;

        public string[] situacao;       

        public int i;

        public int contador;

        public string msg;

        //Construtor

        public DAOLivro()

        {

            conexao = new MySqlConnection("server=localhost;DataBase=livraria2;Uid=root;Password=;Convert Zero DateTime=True");

            try

            {

                conexao.Open();//Abrir a conexão

                Console.WriteLine("Conectado");//Teste

            }

            catch (Exception erro)

            {

                Console.WriteLine("Algo deu errado!\n\n" + erro);

                conexao.Close();//Fechar a conexão com o banco

            }

        }//Fim do Construtor

        public void Inserir(int Codigo, string Titulo, string Autor, string Editora, string Genero, string Isbn, int Quantidade, int Preco, string situacao)

        {

            try

            {

                       

                //Declarei as variáveis e preparei o comando

                dados = "('" + Codigo + "','" + Titulo + "','" + Autor + "','" + Editora + "','" + Genero + "','" + Isbn + "','" + Quantidade + "','" + Preco + "','" + situacao + "')";

                comando = $"Insert into livro(Codigo, Titulo, Autor, Editora, Genero, Isbn, Quantidade, Preco, situacao) values" + dados;

                //Engatilhar a inserção do banco

                MySqlCommand sql = new MySqlCommand(comando, conexao);

                string resultado = "" + sql.ExecuteNonQuery();//ctrl + enter

                //Mostrar na tela

                Console.WriteLine(resultado + " Linha afetada");

            }

            catch (Exception erro)

            {

                Console.WriteLine("Algo deu errado!\n\n" + erro);

            }

        }//Fim do metodo

        public void PreencherVetor()

        {

            string query = "select * from livro";//Coletar os dados do banco

            //instanciar

            Codigo = new int[100];

            Titulo = new string[100];

            Autor = new string[100];

            Editora = new string[100];          

            Genero = new string[100];

            Isbn = new string[100];

            Quantidade = new int[100];

            Preco = new int[100]; 

            situacao = new string[100];

          ;

            //Preencher

            for (i = 0; i < 100; i++)

            {

                Codigo[i] = 0;

                Titulo[i] = "";

                Autor[i] = "";

                Editora[i] = "";                

                Genero[i] = "";

                Isbn[i] = "";

                Quantidade[i] = 0;

                Preco[i] = 0;

                situacao[i] = "";

              

            }//Fim do For

            //Preparar o comando do select

            MySqlCommand coletar = new MySqlCommand(query, conexao);

            //Leitura do banco de dados

            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;

            contador = 0;

            while (leitura.Read())

            {

                Codigo[i] = Convert.ToInt32(leitura["Codigo"]) + 0;

                Titulo[i] = leitura["Titulo"] + "";

                Autor[i] = leitura["Autor"] + "";

                Editora[i] = leitura["Editora"] + "";

                Genero[i] = leitura["Genero"] + "";

                Isbn[i] = leitura["Isbn"] + "";

                Quantidade[i] = Convert.ToInt32(leitura["Quantidade"]) + 0;

                Preco[i] = Convert.ToInt32(leitura["Preco"]) + 0;

                situacao[i] = leitura["situacao"] + "";                

                i++;

                contador++;

            }//Fim do While

            leitura.Close();//Fecha a conexão com o banco

        }//Fim do método

        public string ConsultarTudo()

        {

            PreencherVetor();//Preenchendo os vetores

            msg = "";

            for (i = 0; i < contador; i++)

            {

                msg += "Codigo: " + Codigo[i] +

                       ", Titulo: " + Titulo[i] +

                       ", Autor: " + Autor[i] +

                       ", Editora: " + Editora[i] +
                       
                       ", Genero: " + Genero[i] +

                       ", Isbn: " + Isbn[i] +

                       ", Quantidade: " + Quantidade[i] +

                       ", Preco: " + Preco[i] +

                       ", situacao: " + situacao[i];

            }//Fim do for

            return msg;

        }//Fim do método

        public string ConsultarIndividual(int Codi)

        {

            PreencherVetor();

            for (i = 0; i < contador; i++)

            {

                if (Codigo[i] == Codi)

                {

                    msg = "Codigo: " + Codigo[i] +

                          ", Titulo: " + Titulo[i] +

                          ", Autor: " + Autor +

                          ", Editora: " + Editora +                          

                          ", Genero: " + Genero[i] +

                          ", Isbn: " + Isbn[i] +

                          ", Quantidade: " + Quantidade[i] +

                          ", Preco: " + Preco[i] +

                          ", situacão: " + situacao[i];

                         

                    return msg;

                }//Fim do if

            }//Fim do for

            return "Código informado não é válido!";

        }//Fim do Consultar Individual

        public string Atualizar(int Codi, string campo, string novoDado)

        {

            try

            {

                string query = "update livro set " + campo + " = '" + novoDado + "' where Codigo = '" + Codi + "'";

                //Exercutar comando

                MySqlCommand sql = new MySqlCommand(query, conexao);

                string resultado = "" + sql.ExecuteNonQuery();

                return resultado + "Linha Afetada!";

            }

            catch (Exception ex)

            {

                return "Algo deu errado!\n\n\n" + ex;

            }

        }//Fim do Atualizar

        public string Atualizar(int Codi, string campo, DateTime novoDado)

        {

            try

            {

                string query = "update livro set " + campo + " = '" + novoDado + "' where Codigo = '" + Codi + "'";

                //Exercutar comando

                MySqlCommand sql = new MySqlCommand(query, conexao);

                string resultado = "" + sql.ExecuteNonQuery();

                return resultado + "Linha Afetada!";

            }

            catch (Exception ex)

            {

                return "Algo deu errado!\n\n\n" + ex;

            }

        }//Fim do Atualizar

        public string Excluir(int Codi)

        {

            try

            {

                string query = "update livro set situacao = 'Inativo' where Codigo = '" + Codi + "'";

                //Exercutar comando

                MySqlCommand sql = new MySqlCommand(query, conexao);

                string resultado = "" + sql.ExecuteNonQuery();

                return resultado + "Linha Afetada!";

            }

            catch (Exception ex)

            {

                return "Algo deu errado!\n\n\n" + ex;

            }

        }//Fim do Exluir

    }//Fim da classe

}//Fim do projeto 
