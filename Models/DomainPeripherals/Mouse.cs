using System.ComponentModel.DataAnnotations;

namespace InventoryTracker.Models.DomainPeripherals
{
    public class Mouse
    {
        [Key]
        public int MouseId { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string DPIRange { get; set; }
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
