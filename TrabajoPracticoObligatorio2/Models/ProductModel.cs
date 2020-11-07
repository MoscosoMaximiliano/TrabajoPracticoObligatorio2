namespace TrabajoPracticoObligatorio2.Models
{
    public class ProductModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        
        public string ImgUrl { get; set; }
        
        public bool IsOffer { get; set; }
        
        public bool IsFeatured { get; set; }
    }
}