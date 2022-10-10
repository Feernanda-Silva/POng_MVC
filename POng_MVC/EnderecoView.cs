using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controllers;
using Models;

namespace POng_MVC
{
    public class EnderecoView
    {
        private EnderecoController enderecoController;

        public EnderecoView()
        {
            this.enderecoController = new EnderecoController(); //instanciando 
        }
        public int Cadastrar()
        {
            Endereco endereco = new Endereco();

            Console.WriteLine("Logradouro: ");
            endereco.Logradouro = Console.ReadLine();
            Console.WriteLine("Bairro: ");
            endereco.Bairro = Console.ReadLine();
            Console.WriteLine("Número: ");
            endereco.Numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Complemento:");
            endereco.Complemento = Console.ReadLine();
            Console.WriteLine("CEP: ");
            endereco.Cep = int.Parse(Console.ReadLine());
            Console.WriteLine("Cidade: ");
            endereco.Cidade = Console.ReadLine();
            Console.WriteLine("UF: ");
            endereco.Uf = (Console.ReadLine());

            int codigoEndereco = enderecoController.Cadastrar(endereco); 

            return codigoEndereco;
        }
        public void Consultar(int codigo)
        {
            Endereco endereco = enderecoController.Consultar(codigo);
            Console.WriteLine("Logradouro: {0}", endereco.Logradouro);
            Console.WriteLine("Bairro: {0}", endereco.Bairro);
            Console.WriteLine("Numero: {0}", endereco.Numero);
            Console.WriteLine("Complemento: {0}", endereco.Complemento);
            Console.WriteLine("CEP: {0}", endereco.Cep);
            Console.WriteLine("Cidade: {0}", endereco.Cidade);
            Console.WriteLine("UF: {0}", endereco.Uf);
        }
    }
}
