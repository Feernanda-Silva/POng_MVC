using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controllers;
using Models;

namespace POng_MVC
{
    public class FamiliaView
    {
        private FamiliaController familiaController;

        public FamiliaView()
        {
            this.familiaController = new FamiliaController(); //instanciando 
            
        }
        public void Cadastrar()
        {
            Familia familia = new Familia();

            Console.WriteLine("Tipo: ");
            familia.Tipo = Console.ReadLine();

            //Conexao Insert

            Console.WriteLine("\nCadastro efetuado com sucesso!");

        }



        public void Editar()
        {
            Console.WriteLine("Digite o Código da Familia: ");
            int codigoFamilia = int.Parse(Console.ReadLine());

            while (familiaController.PossuirCodFamiliaCadastrado(codigoFamilia) == false)
            {
                Console.WriteLine("Código da familia não encontrado!");
                Console.WriteLine("Digite o código da familia: ");
                codigoFamilia = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Tipo: ");
            string tipo = Console.ReadLine();

            //Conexao update 

        }

        public void Consultar()
        {
            //Conexão imprimir todas 
        }
    }
}
