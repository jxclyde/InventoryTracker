using InventoryTracker.Models.DomainComponents;
namespace InventoryTracker.Models.DomainComponents
{
    public class PartsList
    {
        public List<Case> Cases { get; set; }
        public List<Drive> Drives { get; set; }
        public List<GraphicsCard> GraphicsCards { get; set; }
        public List<Motherboard> Motherboards { get; set; }
        public List<PowerSupply> PowerSupplies { get; set; }
        public List<Processor> Processors { get; set; }
        public List<RAM> RAMs { get; set; }


    }
}
