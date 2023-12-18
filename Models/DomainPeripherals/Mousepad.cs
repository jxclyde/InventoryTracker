using System.ComponentModel.DataAnnotations;

namespace InventoryTracker.Models.DomainPeripherals
{
    public class Mousepad // На діаграмі класів діаграма - (4)
    {
        [Key]
        public int MousepadId { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public string Dimensions { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string Material { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Impossible to set negative values !")]
        public double Price { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Impossible to set negative values !")]
        public int AmountInStock { get; set; }
    }
}
