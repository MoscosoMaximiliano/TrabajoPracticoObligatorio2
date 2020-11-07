using System.Web.Mvc;

namespace TrabajoPracticoObligatorio2.Models
{
    public class SubCategoriesModel
    {
        public int ID { get; set; }
        
        public int IdCategory { get; set; }
        
        public string Name { get; set; }
    }
}