using System.ComponentModel.DataAnnotations;

namespace InventoryTracker.Models.DomainPeripherals
{
    public class Keyboard // На діаграмі класів діаграма - (2)
    {
        [Key]
        public int KeyboardId { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string FormFactor { get; set; }
        [Required]
        public string KeycapType { get; set; }
        [Required]
        public string KeycapMaterial { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Layout { get; set; }
        [Required]
        public string ConnectionType { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Impossible to set negative values !")]
        public double Price { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Impossible to set negative values !")]
        public int AmountInStock { get; set; }
    }
}
