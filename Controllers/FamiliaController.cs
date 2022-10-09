using System;
using Models;
using Services;

namespace Controllers
{
    public class FamiliaController
    {
        private FamiliaService familiaService;

        public FamiliaController()
        {
            this.familiaService = new FamiliaService();
        }

        public void Cadastrar(Familia familia)
        {
            familiaService.Cadastrar(familia);
        }

        public Familia Consultar(int codigo)
        {
            return familiaService.Consultar(codigo);
        }

        public void Editar(Familia familia )
        {
            familiaService.Editar(familia);
        }

        public bool PossuirCodFamiliaCadastrado(int codigo)
        {
            return familiaService.PossuirCodFamiliaCadastrado(codigo); 
        }
    }
}
