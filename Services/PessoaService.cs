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
    public class PessoaService
    {
        private string _conn;

        public PessoaService()
        {
            _conn = ConexaoBanco.Get();
        }

        public void Cadastrar(Pessoa pessoa)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(Pessoa.INSERT, pessoa);
            }
        }

        public Pessoa Consultar(string cpf)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var parameters = new { CPF = cpf };
                var pessoa = db.QueryFirst<Pessoa>(Pessoa.SELECT, parameters);
                return (Pessoa)pessoa;
            }
        }

        public void EditarNome(string nome, string cpf)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var parameters = new { CPF = cpf, Nome = nome };
                db.Execute(Pessoa.UPDATE_NOME, parameters);
            }
        }

        public void EditarSexo(char sexo, string cpf)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var parameters = new { CPF = cpf, Sexo = sexo };
                db.Execute(Pessoa.UPDATE_SEXO, parameters);
            }
        }

        public void EditarDataNascimento(DateTime dataNascimento, string cpf)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var parameters = new { CPF = cpf, Data_Nascimento = dataNascimento };
                db.Execute(Pessoa.UPDATE_DATANASCIMENTO, parameters);
            }
        }

        public void EditarTelefone(string telefone, string cpf)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var parameters = new { CPF = cpf, Telefone = telefone };
                db.Execute(Pessoa.UPDATE_TELEFONE, parameters);
            }
        }

        public void EditarLogradouro(string logradouro, string cpf)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var parameters = new { CPF = cpf, Logradouro = logradouro };
                db.Execute(Pessoa.UPDATE_LOGRADOURO, parameters);
            }
        }

        public void EditarBairro(string bairro, string cpf)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var parameters = new { CPF = cpf, Bairro = bairro };
                db.Execute(Pessoa.UPDATE_BAIRRO, parameters);
            }
        }

        public void EditarNumero(int numero, string cpf)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var parameters = new { CPF = cpf, Numero = numero };
                db.Execute(Pessoa.UPDATE_NUMERO, parameters);
            }
        }

        public void EditarComplemento(string complemento, string cpf)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var parameters = new { CPF = cpf, Complemento = complemento };
                db.Execute(Pessoa.UPDATE_COMPLEMENTO, parameters);
            }
        }

        public void EditarCep(int cep, string cpf)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var parameters = new { CPF = cpf, CEP = cep };
                db.Execute(Pessoa.UPDATE_CEP, parameters);
            }
        }

        public void EditarCidade(string cidade, string cpf)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var parameters = new { CPF = cpf, Cidade = cidade };
                db.Execute(Pessoa.UPDATE_CIDADE, parameters);
            }
        }

        public void EditarUF(string uf, string cpf)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var parameters = new { CPF = cpf, UF = uf };
                db.Execute(Pessoa.UPDATE_UF, parameters);
            }
        }

        public bool PossuirCpfCadastrado(string cpf)
        {
            bool possuiCpfCadastrado = false;

            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var parameters = new { CPF = cpf };
                var pessoa = db.QueryFirstOrDefault<Pessoa>(Pessoa.SELECT_POSSUIRCPF, parameters);


                if (pessoa != null)
                {
                    possuiCpfCadastrado = true;
                }

            }
            return possuiCpfCadastrado;
        }
    }
}


