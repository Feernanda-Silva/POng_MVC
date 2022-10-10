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

            familiaController.Cadastrar(familia);

            Console.WriteLine("\nCadastro efetuado com sucesso!");

        }

        public void Editar()
        {
            Familia familia = new Familia();
            Console.WriteLine("Digite o Código da Familia: ");
            familia.Cod_Familia = int.Parse(Console.ReadLine());

            while (familiaController.PossuirCodFamiliaCadastrado(familia.Cod_Familia) == false)
            {
                Console.WriteLine("Código da familia não encontrado!");
                Console.WriteLine("Digite o código da familia: ");
                familia.Cod_Familia = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Tipo: ");
            familia.Tipo = Console.ReadLine();

            familiaController.Editar(familia);

            Console.WriteLine("Edição efetuada com sucesso!");

        }

        public void Consultar()
        {
            

            List<Familia> familias = familiaController.Consultar();

            foreach (var familia in familias)
            {
                Console.WriteLine("\nCodigo Familia: {0}", familia.Cod_Familia);
                Console.WriteLine("Tipo: {0}", familia.Tipo);
            }
        }
    }
}
