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

        //public Pessoa Consultar(string cpf)
        //{
        //    return pessoaService.Consultar(cpf);
        //}

        public void Editar(Pessoa pessoa)
        {
            pessoaService.Editar(pessoa);
        }

        //public bool PossuirCPFCadastrado(string cpf)
        //{
        //    return pessoaService.PossuirCPFCadastrado(cpf);
        //}


    }
}
