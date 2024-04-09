using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria2
{
    internal class Pessoa
    {
        private long CPF;
        private string nome;
        private string endereco;
        private string telefone;
        private DateTime dtNascimento;
        private string login;
        private string senha;
        private string situacao;//Ativo ou Inativo
        private string posicao;//Atendente ou Admisntrador ou Clinete

        //Método construtor

        public Pessoa()
        {
            ModificarCPF = 0;
            Modificarnome = "";
            Modificarendereco = "";
            Modificartelefone = "";
            ModificardtNascimento = new DateTime();//"00/00/0000 00:00"
            Modificarlogin = "";
            Modificarsenha = "";
            Modificarsituacao = "";
            Modificarposicao = "";

        }//fim do construtor

        //Método Modificadores = Gets e Sets = faz consulta da variavel

        public long ModificarCPF
        { 
            get { return this.CPF; }
            set { this.CPF = value; }
        
        }//fim do modificar

        public string Modificarnome
        {
            get { return this.nome; }
            set { this.nome = value; }

        }//fim do modificar

        public string Modificarendereco
        {
            get { return this.endereco; }
            set { this.endereco = value; }

        }//fim do modificar

        public string Modificartelefone
        {
            get { return this.telefone; }
            set { this.telefone = value; }

        }//fim do modificar

        public DateTime ModificardtNascimento
        {
            get { return this.dtNascimento; }
            set { this.dtNascimento = value; }

        }//fim do modificar

        public string Modificarlogin
        {
            get { return this.login; }
            set { this.login = value; }

        }//fim do modificar


        public string Modificarsenha
        {
            get { return this.senha; }
            set { this.senha = value; }

        }//fim do modificar

        public string Modificarsituacao
        {
            get { return this.situacao; }
            set { this.situacao = value; }

        }//fim do modificar


        public string Modificarposicao
        {
            get { return this.posicao; }
            set { this.posicao = value; }

        }//fim do modificar

        // Métodos - CRUD


        public void Cadastrar(long CPF, string nome, string telefone, string endereco,
            DateTime dtNasciemnto, string login, string senha, string posicao)
        {

            ModificarCPF = CPF;

            Modificarnome = nome;
            Modificartelefone = telefone;
            Modificarendereco = endereco;
            ModificardtNascimento = dtNasciemnto;
            Modificarlogin = login;
            Modificarsenha = senha;
            Modificarsituacao = "Ativo";
            Modificarposicao = posicao;
        
        }//fim do metodo

        public string ConsultarIndividual(long CPF)
        {
            string consulta = "";
            if (ModificarCPF == CPF)
            {
                consulta = "\nNome: " + Modificarnome +
                                  "\nTelefone: " + Modificartelefone +
                                  "\nEndereco: " + Modificarendereco +
                                  "\nData de Nascimento: " + ModificardtNascimento +
                                  "\nLogin: " + Modificarlogin +
                                  "\nSenha: " + Modificarsenha +
                                  "\nSituação: " + Modificarsituacao +
                                  "\nPosição:  " + Modificarposicao;
            }
            else 
            {
                consulta = "Número de CPF não é válido!!";
            
            }
            return consulta;
        }//fim do metodo

        public void AtualizarNome(long CPF, string nome)
        { 
            if(ModificarCPF == CPF) 
            { 
            
                Modificarnome = nome;
            }
        
        
        }//fim do método

        
        public void AtualizarTelefone(long CPF, string telefone)
        {
            if (ModificarCPF == CPF)
            {

                Modificartelefone = telefone;
            }


        }//fim do método

        public void AtualizarDtNascimento(long CPF, DateTime dtNasciemnto)
        {
            if (ModificarCPF == CPF)
            {

                ModificardtNascimento = dtNascimento;
            }


        }//fim do método

        public void AtualizarEndereco(long CPF, string endereco)
        {
            if (ModificarCPF == CPF)
            {

                Modificarendereco = endereco;
            }


        }//fim do método

        public void Atualizarsenha(long CPF, string senha)
        {
            if (ModificarCPF == CPF)
            {

                Modificarsenha = senha;
            }


        }//fim do método


        public void Atualizarsituacao(long CPF, string situacao)
        {
            if (ModificarCPF == CPF)
            {

                Modificarsituacao = situacao;
            }


        }//fim do método

        public void AtualizarPosicao(long CPF, string posicao)
        {
            if (ModificarCPF == CPF)
            {

                Modificarposicao = posicao;
            }


        }//fim do método


        public void Excluir(long CPF)
        {
            if (ModificarCPF == CPF)
            {
                Modificarsituacao = "Inativo";
            
            
            }
        
        
        }//fim do método




    }//fim da classe
}//fim do projeto
