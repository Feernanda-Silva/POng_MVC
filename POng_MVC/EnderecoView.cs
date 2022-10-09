using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace POng_MVC
{
    public class EnderecoView
    {
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

            //Conexao para inserir 

            int codigoEndereco = 0; 
            return codigoEndereco;
        }
    }
}
