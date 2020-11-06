using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CapaDatos.Tables
{
    [Table("Consulta")]
    public class Consulta
    {
        public Consulta()
        {
            
        }
        
        
        [Key, Required, Column("ID_Consulta", Order = 1)]
        public int IDQuery { get; set; }
        
        [Required, MaxLength(50), Column("Name", Order = 2)]
        public string Name { get; set; }

        [Required, MaxLength(50), Column("Mail", Order = 3)]
        public string Mail { get; set; }

        [Required, Column("NumberPhone", Order = 4)]
        public string NumberPhone { get; set; }

        [Required, MaxLength(100), Column("Message", Order = 5)]
        public string Message { get; set; }
    }
}