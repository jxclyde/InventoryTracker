using InventoryTracker.Models.DomainComponents;

namespace InventoryTracker.Models.DomainPeripherals
{
    public class PeripheralsList
    {
        public List<Keyboard> Keyboards { get; set; }
        public List<Mouse> Mice { get; set; }
        public List<Mousepad> Mousepads { get; set; }
    }
}
