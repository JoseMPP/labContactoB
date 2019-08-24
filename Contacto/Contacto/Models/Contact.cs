using System.ComponentModel.DataAnnotations;

namespace Contacto.Models
{
    public enum TypeContact
    {
        Telephone,
        Email,
        Facebook
    }
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public TypeContact Type { get; set; }
        [Required]
        [Display(Description ="Contact")]
        public string ContactValue { get; set; }
    }
}