using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria2
{
    class ControlReserva
    {

        Pessoa model;//Conectar com a classe pessoa
        private int opcao;
        public ControlReserva()
        {

            model = new Pessoa();//Acesso a todos os métodos da classe pessoa
            ModificarOpcao = 0;


        }

        public int ModificarOpcao
        {
            get { return opcao; }
            set { opcao = value; }

        }// fim do modificarOpcao

        public void Menu()
        {
            Console.WriteLine("Menu - Reserva" +
                              "\nEscolha uma das opçoes abaixo: " +
                              "\n1. Registrar Reserva" +
                              "\n2. Consultar Reserva" +
                              "\n5. Atulizar Excluir");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());

        }//fim do menu

        public void Operacao()
        {
            Menu();//Mostrar Menu
            switch (ModificarOpcao)
            {
                case 1:
                    Console.WriteLine("Deseja fazer uma reserva: ");
                    int Reserva = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Deseja verificar a reserva: ");
                    string Verificar = Console.ReadLine();


                    model.ConsultarReserva(Reserva, Verificar);
                    break;





            }


        }
    }

}