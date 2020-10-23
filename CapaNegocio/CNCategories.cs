using System.Collections.Generic;

namespace CapaNegocio
{
    public class CNCategories
    {
        public CNCategories()
        {
            SubCategory = new List<string>();
        }
        
        public string ID { get; set; }
        public string Category { get; set; }
        
        public List<string> SubCategory { get; set; }
    }
}