using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Services;

namespace Controllers
{
    public class PessoaController
    {
        private PessoaService pessoaService;

        public PessoaController()
        {
            this.pessoaService = new PessoaService();
        }

        public void Cadastrar(Pessoa pessoa)
        {
            pessoaService.Cadastrar(pessoa);
        }

        public Pessoa Consultar(string cpf)
        {
            return pessoaService.Consultar(cpf);
        }

        public void EditarNome(string nome, string cpf)
        {
            pessoaService.EditarNome(nome, cpf);
        }

        public void EditarSexo(char sexo, string cpf)
        {
            pessoaService.EditarSexo(sexo, cpf);
        }

        public void EditarDataNascimento(DateTime dataNascimento, string cpf)
        {
            pessoaService.EditarDataNascimento(dataNascimento, cpf);
        }

        public void EditarTelefone(string telefone, string cpf)
        {
            pessoaService.EditarTelefone(telefone, cpf);    
        }

        public void EditarLogradouro(string logradouro, string cpf)
        {
            pessoaService.EditarLogradouro(logradouro, cpf);
        }

        public void EditarBairro(string bairro, string cpf)
        {
            pessoaService.EditarBairro(bairro, cpf);
        }

        public void EditarNumero(int numero, string cpf)
        {
            pessoaService.EditarNumero(numero, cpf);
        }

        public void EditarComplemento(string complemento, string cpf)
        {
            pessoaService.EditarComplemento(complemento, cpf);
        }

        public void EditarCep(int cep, string cpf)
        {
            pessoaService.EditarCep(cep, cpf);  
        }

        public void EditarCidade(string cidade, string cpf)
        {
            pessoaService.EditarCidade(cidade, cpf);
        }

        public void EditarUF(string uf, string cpf)
        {
            pessoaService.EditarUF(uf, cpf);    
        }

        public bool PossuirCpfCadastrado(string cpf)
        {
            return pessoaService.PossuirCpfCadastrado(cpf);
        }

    }
}
