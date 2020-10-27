using System.ComponentModel.DataAnnotations;

namespace TrabajoPracticoObligatorio2.Models
{
    public class FormData
    {
        [Required(ErrorMessage = "Por favor colocar un nombre ")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        
        [Required]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        
        [Required]
        [Display(Name = "Message")]
        public string Message { get; set; }
        
    }
}