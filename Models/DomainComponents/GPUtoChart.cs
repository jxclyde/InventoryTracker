namespace InventoryTracker.Models.DomainComponents
{
    public class GPUtoChart
    {
        public IEnumerable<string> Manufactures { get; set; }
        public IEnumerable<string> Models { get; set; }
        public IEnumerable<double> Prices { get; set; }
    }
}
