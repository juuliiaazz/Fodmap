using System.ComponentModel.DataAnnotations;

namespace FodmapTest3.Models
{
    public class Article
    {
        [Key]
        [Required(ErrorMessage = "Du måste fylla i fältet!")]
        public string Gtin { get; set; } = null!;
        [Required(ErrorMessage = "Du måste fylla i fältet!")]
        public string PictureUrl { get; set; } = null!;
        [Required(ErrorMessage = "Du måste fylla i fältet!")]
        public string Hyllkantstext { get; set; } = null!;
        [Required(ErrorMessage = "Du måste fylla i fältet!")]
        public string Ingrediensforteckning { get; set; } = null!;
        [Required(ErrorMessage = "Du måste fylla i fältet!")]
        public string Varumarke { get; set; } = null!;
        [Required(ErrorMessage = "Du måste fylla i fältet!")]
        public string RedFodmap { get; set; } = null!;
        [Required(ErrorMessage = "Du måste fylla i fältet!")]
        public string YellowFodmap { get; set; } = null!;
    }
}
