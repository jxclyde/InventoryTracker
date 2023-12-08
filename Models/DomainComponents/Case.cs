using System.ComponentModel.DataAnnotations;

namespace InventoryTracker.Models.DomainComponents
{
    public class Case
    {
        [Key]
        public int CaseId { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string MotherboardFormFactor { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Impossible to set negative values !")]
        public double Price { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Impossible to set negative values !")]
        public int AmountInStock { get; set; }
    }
}
