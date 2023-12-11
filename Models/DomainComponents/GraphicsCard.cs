using System.ComponentModel.DataAnnotations;

namespace InventoryTracker.Models.DomainComponents
{
    public class GraphicsCard
    {
        [Key]
        public int GraphicsCardId { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Impossible to set mnegative values !")]
        public int MemorySize { get; set; }
        [Required]
        public string MemoryType { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Impossible to set negative values !")]
        public double Price { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Impossible to set negative values !")]
        public int AmountInStock { get; set; }

    }
}
