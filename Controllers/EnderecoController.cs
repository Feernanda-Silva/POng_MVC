using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Services;

namespace Controllers
{
    public class EnderecoController
    {
        private EnderecoService enderecoService;

        public EnderecoController()
        {
            this.enderecoService = new EnderecoService();
        }

        public int Cadastrar(Endereco endereco)
        {
            return enderecoService.Cadastrar(endereco);
        }

        public Endereco Consultar(int codigo)
        {
            return enderecoService.Consultar(codigo);
        }
    }
}
