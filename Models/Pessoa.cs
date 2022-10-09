using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Pessoa
    {
        public readonly static string INSERT = "INSERT INTO Pessoa(Nome, CPF, Sexo, Data_Nascimento, Telefone, Cod_Endereco) VALUES(@Nome, @CPF, @Sexo, @Data_Nascimento,@Telefone, @Cod_Endereco);";

        public readonly static string SELECT = "SELECT Pessoa.Nome, Pessoa.CPF, Pessoa.Sexo, Pessoa.Data_Nascimento, Pessoa.Telefone, Endereco.Logradouro," +
                "Endereco.Bairro, Endereco.Numero, Endereco.Complemento, Endereco.CEP, Endereco.Cidade, Endereco.UF FROM Pessoa, Endereco " +
                "WHERE Pessoa.Cod_Endereco = Endereco.Cod_Endereco AND Pessoa.CPF = @CPF";

        public readonly static string UPDATE_NOME = "UPDATE Pessoa SET Nome = @Nome WHERE Pessoa.CPF = @CPF;";

        public readonly static string UPDATE_SEXO = "UPDATE Pessoa SET Sexo = @Sexo WHERE Pessoa.CPF = @CPF;";

        public readonly static string UPDATE_DATANASCIMENTO = "UPDATE Pessoa SET Data_Nascimento = @Data_Nascimento WHERE Pessoa.CPF = @CPF;";
        
        public readonly static string UPDATE_TELEFONE = "UPDATE Pessoa SET Telefone = @Telefone WHERE Pessoa.CPF = @CPF;";

        public readonly static string UPDATE_LOGRADOURO = "UPDATE Endereco SET Logradouro = @Logradouro FROM Pessoa WHERE Pessoa.Cod_Endereco = Endereco.Cod_Endereco AND Pessoa.CPF = @CPF;";

        public readonly static string UPDATE_BAIRRO = "UPDATE Endereco SET Bairro= @Bairro FROM Pessoa WHERE Pessoa.Cod_Endereco = Endereco.Cod_Endereco AND Pessoa.CPF = @CPF;";

        public readonly static string UPDATE_NUMERO= "UPDATE Endereco SET Numero= @Numero FROM Pessoa WHERE Pessoa.Cod_Endereco = Endereco.Cod_Endereco AND Pessoa.CPF = @CPF;";

        public readonly static string UPDATE_COMPLEMENTO = "UPDATE Endereco SET Complemento= @Complemento FROM Pessoa WHERE Pessoa.Cod_Endereco = Endereco.Cod_Endereco AND Pessoa.CPF = @CPF;";

        public readonly static string UPDATE_CEP = "UPDATE Endereco SET CEP= @CEP FROM Pessoa WHERE Pessoa.Cod_Endereco = Endereco.Cod_Endereco AND Pessoa.CPF = @CPF;";

        public readonly static string UPDATE_CIDADE = "UPDATE Endereco SET Cidade= @Cidade FROM Pessoa WHERE Pessoa.Cod_Endereco = Endereco.Cod_Endereco AND Pessoa.CPF = @CPF;";
        
        public readonly static string UPDATE_UF = "UPDATE Endereco SET UF= @UF FROM Pessoa WHERE Pessoa.Cod_Endereco = Endereco.Cod_Endereco AND Pessoa.CPF = @CPF;";

        public readonly static string SELECT_POSSUIRCPF = "SELECT CPF FROM Pessoa WHERE CPF = @CPF";

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public char Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public Endereco endereco { get; set; }
        public Endereco cod_Endereco { get; set; }
    }
}
