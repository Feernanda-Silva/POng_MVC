using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Models;

namespace Services
{
    public class FamiliaService
    {
        private string _conn;

        public FamiliaService()
        {
            _conn = ConexaoBanco.Get();
        }

        public void Cadastrar(Familia familia)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(Familia.INSERT, familia);
            }
        }

        public List<Familia> Consultar()
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var familia = db.Query<Familia>(Familia.SELECT);
                return (List<Familia>)familia;

            }
        }

        public void Editar(Familia familia)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(Familia.UPDATE, familia);
            }
        }

        public bool PossuirCodFamiliaCadastrado(int codigo)
        {
            bool possuiCodFamiliaCadastrado = false;

            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var parameters = new { Cod_Familia = codigo };
                var familia = db.QueryFirstOrDefault<Familia>(Familia.SELECT_POSSUIRCODFAMILIA, parameters);


                if (familia != null)
                {
                    possuiCodFamiliaCadastrado = true;
                }

            }
            return possuiCodFamiliaCadastrado;
        }
    }
}
