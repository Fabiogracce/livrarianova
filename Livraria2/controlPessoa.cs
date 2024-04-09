using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Livraria2
{
     class controlPessoa
    {

        Pessoa model;//Conectar com a classe pessoa
        private int opcao;
        public controlPessoa()
        { 
        
            model = new Pessoa();//Acesso a todos os métodos da classe pessoa
            ModificarOpcao = 0;
        
        }// fim do construtor

        public int ModificarOpcao
        { 
            get { return opcao; }
            set { opcao = value; }
        
        }// fim do modificarOpcao

        
        public void Menu()
        {
            Console.WriteLine("Menu - Pessoa"                     +
                              "\nEscolha uma das opçoes abaixo: " +
                              "\n1. Cadastrar Pessoa"             +
                              "\n2. Consultar Pessoa"             +
                              "\n3. Atualizar Nome"               +
                              "\n4. Atualizar Telefone"           +
                              "\n5. Atulizar Endeçlo"             +
                              "\n6. Atulizar Data de nascimento"  +
                              "\n7. Atualizar Senha"              +
                              "\n8. Atualizar Situção"            +
                              "\n9. Excluir");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());



        }//fim do menu

        public void Operacao()
        {
            Menu();//Mostrar Menu
            switch (ModificarOpcao) {

                case 1:
                    Console.WriteLine("Informe o CPF: ");
                    long CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe seu nome: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Informe seu telefone: ");
                    string telefone = Console.ReadLine();

                    Console.WriteLine("Informe seu endereço: ");
                    string endereco = Console.ReadLine();

                    Console.WriteLine("Informe sua data de nascimento: ");
                    DateTime data = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("Informe o seu login: ");
                    string login = Console.ReadLine();

                    Console.WriteLine("Informe sua senha: ");
                    string senha = Console.ReadLine();

                    Console.WriteLine("Informe o seu cargo: ");
                    string cargo = Console.ReadLine();

                    // chamar o método cadastrar

                    model.Cadastrar(CPF, nome, telefone, endereco, data, login, senha, cargo);
                    break;

                    case 2:
                    Console.WriteLine("Informe o CPf que deseja consultar: ");
                    CPF = Convert.ToInt64(Console.ReadLine());


                    //mostrar os dados
                    Console.WriteLine(model.ConsultarIndividual(CPF));
                    break;

                    case 3:
                    Console.WriteLine("Informe o CPF");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o novo nome");
                    nome = Console.ReadLine();

                    //atualizar

                    model.AtualizarNome(CPF, nome);
                    break;

                    case 4:
                    Console.WriteLine("Informe o CPF");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o novo telefone");
                    telefone = Console.ReadLine();

                    model.AtualizarTelefone( CPF, telefone );
                    break;

                    case 5:

                    Console.WriteLine("Informe o CPF");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o novo endereço");
                    endereco = Console.ReadLine();

                    model.AtualizarEndereco(CPF, endereco);
                    break;

                    case 6:

                    Console.WriteLine("Informe o CPF");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe a nova data de nascimento");
                    data = Convert.ToDateTime(Console.ReadLine());
                    
                    model.AtualizarDtNascimento(CPF, data);

                    break;
                    
                    case 7:
                    Console.WriteLine("Informe o CPF");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe a nova senha");
                    senha = (Console.ReadLine());

                    model.Atualizarsenha(CPF, senha);
                    break;
                    
                    case 8:
                    Console.WriteLine("Informe o CPF");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o novo cargo");
                    cargo = (Console.ReadLine());

                    model.AtualizarPosicao(CPF, cargo);
                    break; 
                    
                    case 9:

                    Console.WriteLine("Informe o CPF");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    //Excluir

                    model.Excluir(CPF);
                    
                    break; 
            
            }// ffim do switch
            
        
        }// fim da operacao

    }//fim da classe
}//fim do projeto
