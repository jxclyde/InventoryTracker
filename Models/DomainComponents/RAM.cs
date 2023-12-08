using System.ComponentModel.DataAnnotations;

namespace InventoryTracker.Models.DomainComponents
{
    public class RAM
    {
        [Key]
        public int RAMId { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        [Required]
        public string MemoryType { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Impossible to set mnegative values !")]
        public int MemorySize { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Impossible to set mnegative values !")]
        public int ModulesAmount { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Impossible to set negative values !")]
        public int Frequency { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Impossible to set negative values !")]
        public double Price { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Impossible to set negative values !")]
        public int AmountInStock { get; set; }



    }
}
