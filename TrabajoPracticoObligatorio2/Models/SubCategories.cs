using System.Web.Mvc;

namespace TrabajoPracticoObligatorio2.Models
{
    public class SubCategories
    {
        public int ID { get; set; }
        
        public SelectList IdCategory { get; set; }
        
        public string Name { get; set; }
    }
}