using System;
using System.Collections.Generic;
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
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var parameters = new { CHIP = chip };
                var animal = db.QueryFirst<Animal>(Animal.SELECT_CONSULTAR, parameters);
                return (Animal)animal;
            }
        }

        public void EditarRaca(string raca, int chip)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var parameters = new { CHIP = chip, Raca = raca };
                db.Execute(Animal.UPDATE_RACA, parameters);
            }
        }

        public void EditarSexo(char sexo, int chip)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var parameters = new { CHIP = chip, Sexo = sexo };
                db.Execute(Animal.UPDATE_SEXO, parameters);
            }
        }

        public void EditarNomeAnimal(string nome, int chip)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var parameters = new { CHIP = chip, Nome = nome };
                db.Execute(Animal.UPDATE_NOME, parameters);
            }
        }

        public void EditarCodFamilia(int codFamilia, int chip)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var parameters = new { CHIP = chip, Cod_Familia = codFamilia };
                db.Execute(Animal.UPDATE_CODFAMILIA, parameters);
            }
        }

        public void Adotar(int chip, string cpf)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var parameters = new { CHIP = chip, CPF = cpf };
                db.Execute(Animal.UPDATE_ADOTAR, parameters);
            }
        }

        public List<Animal> ConsultarAdocao(string cpf)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var parameters = new { CPF = cpf };
                var animal = db.Query<Animal>(Animal.SELECT_CONSULTARADOCAO, parameters);
                return (List<Animal>)animal;
            }
        }

        public bool PossuirChipCadastrado(int chip)
        {
            bool possuiChipCadastrado = false;

            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var parameters = new { CHIP = chip };
                var animal = db.QueryFirstOrDefault<Animal>(Animal.SELECT_POSSUIRCHIP, parameters);


                if (animal != null)
                {
                    possuiChipCadastrado = true;
                }

            }
            return possuiChipCadastrado;
        }
    }
}

