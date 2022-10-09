﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controllers;
using Models;

namespace POng_MVC
{
    public class PessoaView
    {
        private PessoaController pessoaController; 

        public PessoaView()
        {
            this.pessoaController = new PessoaController(); //instanciando 
        }
        public void Cadastrar()
        {
            Pessoa pessoa = new Pessoa();
            EnderecoView enderecoView = new EnderecoView();

            Console.WriteLine("Nome: ");
            pessoa.Nome = Console.ReadLine();

            Console.WriteLine("Cpf: ");
            pessoa.Cpf = Console.ReadLine();

            //Tratamento: SELECT para ver se existe um cadastro com esse CPF.
            while (pessoaController.PossuirCPFCadastrado(pessoa.Cpf) == true)
            {
                Console.WriteLine("Já possui CPF cadastrado.");
                Console.WriteLine("Cpf: ");
                pessoa.Cpf = Console.ReadLine();
            }

            Console.WriteLine("Sexo(M/F): ");
            pessoa.Sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Data de Nascimento: ");
            pessoa.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Telefone: ");
            pessoa.Telefone = Console.ReadLine();

            int codigo_endereco = enderecoView.Cadastrar();

            //conexao para inserir 
        }

        public void Editar()
        {
            Console.WriteLine("\nDigite o CPF para localizar o Cadastro : ");
            string cpf = Console.ReadLine();

            //while (pessoaController.PossuirCPFCadastrado(cpf) == false)
            //{
            //    Console.WriteLine("CPF não encontrado!");
            //    Console.WriteLine("Digite outro CPF:");
            //    cpf = Console.ReadLine();
            //}

            int opc;

            do
            {
                Console.WriteLine("\nDigite o número do campo que deseja editar: ");
                Console.WriteLine("1-Nome: ");
                Console.WriteLine("2-Sexo: ");
                Console.WriteLine("3-Data Nascimento: ");
                Console.WriteLine("4-Telefone:  ");
                Console.WriteLine("5-Logradouro:  ");
                Console.WriteLine("6-Bairro:  ");
                Console.WriteLine("7-Numero:  ");
                Console.WriteLine("8-Complemento: ");
                Console.WriteLine("9-CEP:  ");
                Console.WriteLine("10-Cidade:  ");
                Console.WriteLine("11-UF:  ");
                Console.WriteLine("12-Voltar");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        EditarNome();
                        break;
                    case 2:
                        EditarSexo();
                        break;
                    case 3:
                        EditarDataNascimento();
                        break;
                    case 4:
                        EditarTelefone();
                        break;
                    case 5:
                        EditarLogradouro();
                        break;
                    case 6:
                        EditarBairro();
                        break;
                    case 7:
                        EditarNumero();
                        break;
                    case 8:
                        EditarComplemento();
                        break;
                    case 9:
                        EditarCep();
                        break;
                    case 10:
                        EditarCidade();
                        break;
                    case 11:
                        EditarUf();
                        break;
                }
            } while (opc > 0 && opc < 12);

            void EditarNome()
            {
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                
                //Conexao 

            }

            void EditarSexo()
            {
                Console.WriteLine("Sexo: ");
                char sexo = char.Parse(Console.ReadLine());

                //Conexao 

                Console.WriteLine("Edição efetuada com sucesso!");
            }

            void EditarDataNascimento()
            {
                Console.WriteLine("Data Nascimento: ");
                DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

                //Conexao

                Console.WriteLine("Edição efetuada com sucesso!");
            }

            void EditarTelefone()
            {
                Console.WriteLine("Telefone: ");
                string telefone = Console.ReadLine();

                //Conexao

                Console.WriteLine("Edição efetuada com sucesso!");
            }

            void EditarLogradouro()
            {
                Console.WriteLine("Logradouro: ");
                string logradouro = Console.ReadLine();

                //Conexao

                Console.WriteLine("Edição efetuada com sucesso!");
            }

            void EditarBairro()
            {
                Console.WriteLine("Bairro: ");
                string bairro = Console.ReadLine();

               //Conexao

                Console.WriteLine("Edição efetuada com sucesso!");
            }

            void EditarNumero()
            {
                Console.WriteLine("Numero: ");
                int numero = int.Parse(Console.ReadLine());

                //Conexao

                Console.WriteLine("Edição efetuada com sucesso!");
            }

            void EditarComplemento()
            {
                Console.WriteLine("Complemento: ");
                string complemento = Console.ReadLine();

                //Conexao

                Console.WriteLine("Edição efetuada com sucesso!");
            }

            void EditarCep()
            {
                Console.WriteLine("CEP: ");
                int cep = int.Parse(Console.ReadLine());

                //Conexao

                Console.WriteLine("Edição efetuada com sucesso!");
            }

            void EditarCidade()
            {
                Console.WriteLine("Cidade: ");
                string cidade = Console.ReadLine();

                //Conexao

                Console.WriteLine("Edição efetuada com sucesso!");
            }

            void EditarUf()
            {
                Console.WriteLine("Cidade: ");
                string uf = Console.ReadLine();

                //Conexao

                Console.WriteLine("Edição efetuada com sucesso!");
            }
        }
    

        public void Consultar()
        {
            Console.WriteLine("\nDigite o CPF: ");
            string cpf = Console.ReadLine();

            //while (pessoaController.PossuirCPFCadastrado(cpf) == false)
            //{
            //    Console.WriteLine("CPF não encontrado!");
            //    Console.WriteLine("Digite outro CPF:");
            //    cpf = Console.ReadLine();
            //}

            //Conexao para consultar e imprimir 

        }
    }
}
