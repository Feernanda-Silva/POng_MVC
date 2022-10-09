using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;

namespace Controllers
{
    public  class EnderecoController
    {
        private EnderecoService enderecoService;

        public EnderecoController()
        {
            this.enderecoService = new EnderecoService();
        }

        public void Cadastrar()
        {
            enderecoService.Cadastrar();    
        }
    }
}
