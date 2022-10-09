using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public  class Familia
    {
        public readonly static string INSERT = "INSERT INTO Familia(Tipo) OUTPUT INSERTED.Cod_Familia VALUES (@Tipo);";
        
        public readonly static string SELECT = "SELECT Familia.Cod_Familia, Familia.Tipo FROM Familia;";
        
        public readonly static string UPDATE = "UPDATE Familia SET Tipo= @Tipo WHERE Familia.Cod_Familia = @Cod_Familia;";
       
        public readonly static string SELECT_POSSUIRCODFAMILIA = "SELECT Cod_Familia FROM Familia WHERE Cod_Familia = @Cod_Familia";

        public int Cod_Familia { get; set; }
        public string Tipo { get; set; }
    }
}
