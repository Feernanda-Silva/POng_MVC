using System;
using System.Collections.Generic;
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

        public List<Familia> Consultar()
        {
            return familiaService.Consultar();
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
