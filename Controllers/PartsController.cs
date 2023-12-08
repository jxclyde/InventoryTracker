using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InventoryTracker.Data;
using InventoryTracker.Models.DomainComponents;

namespace InventoryTracker.Controllers
{
    public class PartsController : Controller
    {
        private readonly InventoryDbContext _db;

        public PartsController(InventoryDbContext db)
        {
            _db = db;
        }

        public IActionResult PartsIndex()
        {
            var cases = _db.Cases.ToList();
            var drives = _db.Drives.ToList();
            var graphicsCards = _db.GraphicsCards.ToList();
            var motherboards = _db.Motherboards.ToList();
            var powerSupplies = _db.PowerSupplies.ToList();
            var processors = _db.Processors.ToList();
            var rams = _db.RAMs.ToList();

            PartsList partsList = new PartsList
            {
                Cases = cases,
                Drives = drives,
                GraphicsCards = graphicsCards,
                Motherboards = motherboards,
                PowerSupplies = powerSupplies,
                Processors = processors,
                RAMs = rams
            };
            return View(partsList);
        }


    }
}
