using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public  class Endereco
    {
        public readonly static string INSERT = "INSERT INTO Endereco(Logradouro, Bairro, Numero, Complemento, CEP, Cidade, UF) OUTPUT INSERTED.Cod_Endereco VALUES (@Logradouro, @Bairro, @Numero, @Complemento, @CEP, @Cidade, @UF);";
        public readonly static string SELECT = "SELECT Logradouro, Bairro, Numero, Complemento, CEP, Cidade, UF FROM Endereco WHERE Cod_Endereco = @Cod_Endereco;";
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public int Cep { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public int Cod_Endereco { get; set; }
    }
}
