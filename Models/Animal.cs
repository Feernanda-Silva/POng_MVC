using System;

namespace Models
{
    public class Animal
    {
        public readonly static string INSERT = "INSERT INTO Animal(CHIP, Raca, Sexo, Nome, Cod_Familia) VALUES (@CHIP, @Raca, @Sexo, @Nome, @Cod_Familia);";
       
        public readonly static string SELECT_CONSULTAR = "SELECT Animal.CHIP, Animal.Raca, Animal.Sexo, Animal.Nome, Animal.CPF, Familia.Cod_Familia, Familia.Tipo FROM Animal, Familia WHERE Animal.CHIP = @CHIP;";
        
        public readonly static string UPDATE_RACA = "UPDATE Animal SET Raca = @Raca WHERE Animal.CHIP = @CHIP;";
        
        public readonly static string UPDATE_SEXO = "UPDATE Animal SET Sexo = @Sexo WHERE Animal.CHIP = @CHIP;";
       
        public readonly static string UPDATE_NOME = "UPDATE Animal SET Nome = @Nome WHERE Animal.CHIP = @CHIP;";
        
        public readonly static string UPDATE_CODFAMILIA = "UPDATE Animal SET Cod_Familia = @Cod_Familia WHERE Animal.CHIP = @CHIP;";
        
        public readonly static string UPDATE_ADOTAR = "UPDATE Animal SET CPF = @CPF WHERE Animal.CHIP = @CHIP;";
        
        public readonly static string SELECT_CONSULTARADOCAO = "SELECT Pessoa.Nome, Pessoa.CPF, Animal.CHIP, Animal.Raca, Animal.Sexo, Animal.Nome, Animal.Cod_Familia, Familia.Tipo " +
                "FROM Pessoa, Animal, Familia " +
                "WHERE Pessoa.CPF = Animal.CPF " +
                "AND Familia.Cod_Familia = Animal.Cod_Familia " +
                "AND Pessoa.CPF = @CPF;";
       
        public readonly static string SELECT_POSSUIRCHIP = "SELECT CHIP FROM Animal WHERE CHIP = @CHIP";
        
        public int Chip { get; set; }
        public string Raca { get; set; }
        public char Sexo { get; set; }
        public string Nome { get; set; }
        public Pessoa Cpf { get; set; }
        public int Cod_Familia { get; set; }
    }
}
