using System.ComponentModel.DataAnnotations;

namespace InventoryTracker.Models.DomainComponents
{
    public class Motherboard
    {
        [Key]
        public int MotherboardId { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Socket { get; set; }
        [Required]
        public string FormFactor { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Impossible to set mnegative values !")]
        public int RAMSlots { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Impossible to set negative values !")]
        public double Price { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Impossible to set negative values !")]
        public int AmountInStock { get; set; }
    }
}
