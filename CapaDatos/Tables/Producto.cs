using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CapaDatos.Tables
{
    [Table("Producto")]
    public class Producto
    {
        public Producto()
        {

        }

        [Key, Required, Column("ID_Producto", Order = 1)]
        public int IDProduct { get; set; }

        [Required, MaxLength(50)]
        [Column("Name", Order = 2)]
        public string Name { get; set; }

        [Required, Column("Price", Order = 3)]
        public float Price { get; set; }

        [Required, Column("URL", Order = 4), MaxLength(100)]
        public string UrlImage { get; set; }

        [Required, Column("Offer", Order = 5)]
        public bool IsOffer { get; set; }

        [Required, Column("Featured", Order = 6)]
        public bool IsFeatured { get; set; }

    }
}
