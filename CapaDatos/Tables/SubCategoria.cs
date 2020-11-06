using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CapaDatos.Tables
{
    [Table("SubCategoria")]
    public class SubCategoria
    {
        public SubCategoria()
        {
            
        }
        
        public virtual Categoria CategoryFrom { get; set; }
        
        [Key, Required, Column("ID", Order = 1)]
        public int ID { get; set; }
        
        [Required, ForeignKey("CategoryFrom"), Column("FK_ID_Categoria", Order = 2)]
        public int IdCategory { get; set; }
        
        [Required, MaxLength(50), Column("Name", Order = 3)]
        public string Name { get; set; }
        
    }
}