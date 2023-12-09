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

        //Процесори-----------------------------------------------------------------------------------------------------------------
        //Створення процесора
        public IActionResult CreateProcessor()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateProcessor(Processor obj)
        {
            if (ModelState.IsValid)
            {
                _db.Processors.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("PartsIndex");
            }
            return View(obj);
        }

        //Редагування процесора
        public IActionResult UpdateProcessor(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var processorFromDb = _db.Processors.Find(id);
            if (processorFromDb == null)
            {
                return NotFound();
            }
            return View(processorFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateProcessor(Processor obj)
        {
            if (ModelState.IsValid)
            {
                _db.Processors.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("PartsIndex");
            }
            return View(obj);
        }

        //Видалення процесора
        public IActionResult DeleteProcessor(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var processorFromDb = _db.Processors.Find(id);
            if (processorFromDb == null)
            {
                return NotFound();
            }
            return View(processorFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteProcessorPost(int? id)
        {
            var obj = _db.Processors.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Processors.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("PartsIndex");
        }


        //Материнські плати----------------------------------------------------------------------------------------------------------
        //Створення материнської плати
        public IActionResult CreatePMotherboard()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePMotherboard(Motherboard obj)
        {
            if (ModelState.IsValid)
            {
                _db.Motherboards.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("PartsIndex");
            }
            return View(obj);
        }

        //Редагування материнської плати
        public IActionResult UpdateMotherboard(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var motherboardFromDb = _db.Motherboards.Find(id);
            if (motherboardFromDb == null)
            {
                return NotFound();
            }
            return View(motherboardFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateMotherboard(Motherboard obj)
        {
            if (ModelState.IsValid)
            {
                _db.Motherboards.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("PartsIndex");
            }
            return View(obj);
        }

        //Видалення материнської плати
        public IActionResult DeleteMotherboard(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var motherboardFromDb = _db.Motherboards.Find(id);
            if (motherboardFromDb == null)
            {
                return NotFound();
            }
            return View(motherboardFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteMotherboardPost(int? id)
        {
            var obj = _db.Motherboards.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Motherboards.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("PartsIndex");
        }


        //Відеокарти----------------------------------------------------------------------------------------------------------


        //Пристрої накопичення----------------------------------------------------------------------------------------------------------

        //Оперативна пам'ять----------------------------------------------------------------------------------------------------------

        //Блоки живлення----------------------------------------------------------------------------------------------------------

        //Корпуси----------------------------------------------------------------------------------------------------------





    }

}

