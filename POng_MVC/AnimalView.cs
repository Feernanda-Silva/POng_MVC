﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controllers;
using Models;

namespace POng_MVC
{
    public class AnimalView
    {
        private AnimalController animalController;

        private FamiliaController familiaController;

        private PessoaController pessoaController;

        public AnimalView()
        {
            this.animalController = new AnimalController();
            this.familiaController = new FamiliaController();
            this.pessoaController = new PessoaController();
        }
        public void Cadastrar()
        {
            Animal animal = new Animal();

            Console.WriteLine("Numero do Chip: ");
            animal.Chip = int.Parse(Console.ReadLine());

            while (animalController.PossuirChipCadastrado(animal.Chip) == true)
            {
                Console.WriteLine("Já possui esse CHIP cadastrado!");
                Console.WriteLine("Digite outro CHIP: ");
                animal.Chip = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Raça: ");
            animal.Raca = Console.ReadLine();

            Console.WriteLine("Sexo(M/F): ");
            animal.Sexo = char.Parse(Console.ReadLine());
            while (animal.Sexo != 'M' && animal.Sexo != 'F')
            {
                Console.WriteLine("Campo inválido");
                Console.WriteLine("Digite novamente!");
                animal.Sexo = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("O animal já possui um nome? Digite : 1-Sim ou 2-Não: ");
            int opc = int.Parse(Console.ReadLine());
            while (opc != 1 && opc != 2)
            {
                Console.WriteLine("Opção inválida");
                Console.WriteLine("Digite novamente!");
                opc = int.Parse(Console.ReadLine());
            }

            if (opc == 1)
            {
                Console.WriteLine("Nome: ");
                animal.Nome = Console.ReadLine();
            }

            else
            {
                animal.Nome = "Sem Nome";
            }

            Console.WriteLine("Código Familia: ");
            animal.Cod_Familia = int.Parse(Console.ReadLine());

            while (familiaController.PossuirCodFamiliaCadastrado(animal.Cod_Familia) == false)
            {
                Console.WriteLine("Código da familia não encontrado!");
                Console.WriteLine("Digite o código da familia: ");
                animal.Cod_Familia = int.Parse(Console.ReadLine());
            }

            animalController.Cadastrar(animal);
        }

        public void Editar()
        {
            Console.WriteLine("\nDigite o código do CHIP para localizar o animal: ");
            int chip = int.Parse(Console.ReadLine());

            while (animalController.PossuirChipCadastrado(chip) == false)
            {
                Console.WriteLine("CHIP não encontrado!");
                Console.WriteLine("Digite outro CHIP: ");
                chip = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nDigite o número do campo que deseja editar: ");
            Console.WriteLine("1-Raça: ");
            Console.WriteLine("2-Sexo: ");
            Console.WriteLine("3- Nome do Animal: ");
            Console.WriteLine("4-Código Familia: ");
            int opc = int.Parse(Console.ReadLine());

            if (opc < 1 || opc > 4)
            {
                Console.WriteLine("Opção inválida!");
                Console.WriteLine("Digite a opção novamente: ");
                opc = int.Parse(Console.ReadLine());
            }

            switch (opc)
            {
                case 1:
                    EditarRaca();
                    break;
                case 2:
                    EditarSexo();
                    break;
                case 3:
                    EditarNomeAnimal();
                    break;
                case 4:
                    EditarCod_Familia();
                    break;
            }

            void EditarRaca()
            {
                Console.WriteLine("Raça: ");
                string raca = Console.ReadLine();

                //Conexao Update 

                Console.WriteLine("Edição efetuada com sucesso!");
            }

            void EditarSexo()
            {
                Console.WriteLine("Sexo: ");
                string sexo = Console.ReadLine();

                //Conexão update

                Console.WriteLine("Edição efetuada com sucesso!");
            }

            void EditarNomeAnimal()
            {
                Console.WriteLine("Nome do Animal: ");
                string nome = Console.ReadLine();

                //Conexao update

                Console.WriteLine("Edição efetuada com sucesso!");
            }

            void EditarCod_Familia()
            {
                Console.WriteLine("Código Familia: ");
                int codigoFamilia = int.Parse(Console.ReadLine());

                while (familiaController.PossuirCodFamiliaCadastrado(codigoFamilia) == false)
                {
                    Console.WriteLine("Código da familia não encontrado!");
                    Console.WriteLine("Digite o código da familia: ");
                    codigoFamilia = int.Parse(Console.ReadLine());
                }

                //Conexao update 

                Console.WriteLine("Edição efetuada com sucesso!");
            }

        }

        public void Consultar()
        {
            Console.WriteLine("\nDigite o código do chip para localizar o animal: ");
            int chip = int.Parse(Console.ReadLine());


            while (animalController.PossuirChipCadastrado(chip) == false)
            {
                Console.WriteLine("CHIP não encontrado!");
                Console.WriteLine("Digite outro CHIP: ");
                chip = int.Parse(Console.ReadLine());
            }
            animalController.Consultar(chip);
        }

        public void AdotarAnimal()
        {

            Console.WriteLine("Digite o CPF do futuro Tutor: ");
            string cpf = Console.ReadLine();

            //while (pessoaController.PossuirCPFCadastrado(cpf) == false)
            //{
            //    Console.WriteLine("CPF não encontrado!");
            //    Console.WriteLine("Digite outro CPF:");
            //    cpf = Console.ReadLine();
            //}

            Console.WriteLine("Digite o CHIP do Animal: ");
            int chip = int.Parse(Console.ReadLine());

            while (animalController.PossuirChipCadastrado(chip) == false)
            {
                Console.WriteLine("CHIP não encontrado!");
                Console.WriteLine("Digite outro CHIP: ");
                chip = int.Parse(Console.ReadLine());
            }

            //Conexao update 

            Console.WriteLine("\nAdoção efetuada com sucesso!");
        }

        public void ConsultarAdocao()
        {
            Console.WriteLine("Digite o CPF do Tutor: ");
            string cpf = Console.ReadLine();

            //while (pessoaController.PossuirCPFCadastrado(cpf) == false)
            //{
            //    Console.WriteLine("CPF não encontrado!");
            //    Console.WriteLine("Digite outro CPF:");
            //    cpf = Console.ReadLine();
            //}

        }
    }
}
