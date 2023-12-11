using InventoryTracker.Data;
using InventoryTracker.Models;
using InventoryTracker.Models.DomainComponents;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InventoryTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly InventoryDbContext _context;

        public HomeController(ILogger<HomeController> logger, InventoryDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var gpuData = _context.GraphicsCards.ToList();

            var gpuChartModel = new GPUtoChart
            {
                Manufactures = gpuData.Select(x => x.Manufacturer).Distinct(),
                Models = gpuData.Select(x => x.Model),
                Prices = gpuData.Select(x => x.Price)
            };

            return View(gpuChartModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
