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
    public class EnderecoService
    {
        private string _conn;

        public EnderecoService()
        {
            _conn = ConexaoBanco.Get();
        }
        public int Cadastrar(Endereco endereco)
        {
            int cod_endereco;
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                cod_endereco = (int)db.ExecuteScalar(Endereco.INSERT, endereco);
            }
            return cod_endereco;
        }

        public Endereco Consultar(int codigo)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var parameters = new { Cod_Endereco = codigo };
                var endereco = db.QueryFirst<Endereco>(Endereco.SELECT, parameters);
                return (Endereco)endereco;
            }
        }
    }
}
