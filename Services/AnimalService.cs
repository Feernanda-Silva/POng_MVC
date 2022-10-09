using System;
using System.Data.SqlClient;
using Dapper;
using Models;

namespace Services
{
    public class AnimalService
    {
        private string _conn;
        
        public AnimalService()
        {
            _conn = ConexaoBanco.Get();
        }
        public void Cadastrar(Animal animal)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(Animal.INSERT, animal);
            }
        }

        public Animal Consultar(int chip)
        {
            return null;
        }

        public void Editar(Animal animal)
        {

        }

        public void Adotar(int chip, string cpf)
        {

        }

        public Animal ConsultarAdocao(string cpf)
        {
            return null;
        }

        public bool PossuirChipCadastrado(int chip)
        {
            return false;

        }
    }
}
