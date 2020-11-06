using System.Collections.Generic;

namespace TrabajoPracticoObligatorio2.Models
{
    public class Categories
    {
        public int ID { get; set; }
        public string Category { get; set; }
        public List<string> SubCategory { get; set; }
    }
}