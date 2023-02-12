using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Nazwa jest wymagana!")]
        public string Nazwa { get; set; }

        [Required(ErrorMessage = "Opis jest wymagany!")]
        public string Opis { get; set; }

        [Required(ErrorMessage = "Img jest wymagane!")]
        public string Img { get; set; }

    }
}
