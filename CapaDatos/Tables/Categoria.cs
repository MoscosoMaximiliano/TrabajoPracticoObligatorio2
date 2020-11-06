using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CapaDatos.Tables
{
    [Table("Categoria")]
    public class Categoria
    {
        public Categoria()
        {
            
        }
        
        [Key, Required, Column("ID_Categoria", Order = 1)]
        public int IDCategory { get; set; }
        
        [Required, MaxLength(50), Column("Name", Order = 2)]
        public string Name { get; set; }
    }
}
