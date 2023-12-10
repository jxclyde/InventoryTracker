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
        public IActionResult CreateMotherboard()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateMotherboard(Motherboard obj)
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
        //Створення відеокарти
        public IActionResult CreateGPU()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateGPU(GraphicsCard obj)
        {
            if (ModelState.IsValid)
            {
                _db.GraphicsCards.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("PartsIndex");
            }
            return View(obj);
        }

        //Редагування відеокарти
        public IActionResult UpdateGPU(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var graphicsCardFromDb = _db.GraphicsCards.Find(id);
            if (graphicsCardFromDb == null)
            {
                return NotFound();
            }
            return View(graphicsCardFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateGPU(GraphicsCard obj)
        {
            if (ModelState.IsValid)
            {
                _db.GraphicsCards.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("PartsIndex");
            }
            return View(obj);
        }

        //Видалення відеокарти
        public IActionResult DeleteGPU(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var graphicsCardFromDb = _db.GraphicsCards.Find(id);
            if (graphicsCardFromDb == null)
            {
                return NotFound();
            }
            return View(graphicsCardFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteGPUPost(int? id)
        {
            var obj = _db.GraphicsCards.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.GraphicsCards.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("PartsIndex");
        }

        //Пристрої накопичення----------------------------------------------------------------------------------------------------------
        //Створення пристрою накопичення
        public IActionResult CreateDrive()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatDrive(Drive obj)
        {
            if (ModelState.IsValid)
            {
                _db.Drives.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("PartsIndex");
            }
            return View(obj);
        }

        //Редагування відеокарти
        public IActionResult UpdateDrive(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var drivesFromDb = _db.Drives.Find(id);
            if (drivesFromDb == null)
            {
                return NotFound();
            }
            return View(drivesFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateDrive(Drive obj)
        {
            if (ModelState.IsValid)
            {
                _db.Drives.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("PartsIndex");
            }
            return View(obj);
        }

        //Видалення пристрою накопичення
        public IActionResult DeleteDrive(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var drivesFromDb = _db.Drives.Find(id);
            if (drivesFromDb == null)
            {
                return NotFound();
            }
            return View(drivesFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteDrivePost(int? id)
        {
            var obj = _db.Drives.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Drives.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("PartsIndex");
        }


        //Оперативна пам'ять----------------------------------------------------------------------------------------------------------
        //Створення RAM
        public IActionResult CreateRAM()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatRAM(RAM obj)
        {
            if (ModelState.IsValid)
            {
                _db.RAMs.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("PartsIndex");
            }
            return View(obj);
        }

        //Редагування відеокарти
        public IActionResult UpdateRAM(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var ramsFromDb = _db.RAMs.Find(id);
            if (ramsFromDb == null)
            {
                return NotFound();
            }
            return View(ramsFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateRAM(RAM obj)
        {
            if (ModelState.IsValid)
            {
                _db.RAMs.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("PartsIndex");
            }
            return View(obj);
        }

        //Видалення пристрою накопичення
        public IActionResult DeleteRAM(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var ramsFromDb = _db.RAMs.Find(id);
            if (ramsFromDb == null)
            {
                return NotFound();
            }
            return View(ramsFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteRAMPost(int? id)
        {
            var obj = _db.RAMs.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.RAMs.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("PartsIndex");
        }

        //Блоки живлення----------------------------------------------------------------------------------------------------------
        //Створення блоку живлення
        public IActionResult CreatePS()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatPS(PowerSupply obj)
        {
            if (ModelState.IsValid)
            {
                _db.PowerSupplies.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("PartsIndex");
            }
            return View(obj);
        }

        //Редагування блоку живлення
        public IActionResult UpdatePS(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var psFromDb = _db.PowerSupplies.Find(id);
            if (psFromDb == null)
            {
                return NotFound();
            }
            return View(psFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdatePS(PowerSupply obj)
        {
            if (ModelState.IsValid)
            {
                _db.PowerSupplies.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("PartsIndex");
            }
            return View(obj);
        }

        //Видалення блоку живлення
        public IActionResult DeletePS(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var psFromDb = _db.PowerSupplies.Find(id);
            if (psFromDb == null)
            {
                return NotFound();
            }
            return View(psFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePSPost(int? id)
        {
            var obj = _db.PowerSupplies.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.PowerSupplies.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("PartsIndex");
        }

        //Корпуси----------------------------------------------------------------------------------------------------------
        //Створення корпусу
        public IActionResult CreateCase()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatCase(Case obj)
        {
            if (ModelState.IsValid)
            {
                _db.Cases.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("PartsIndex");
            }
            return View(obj);
        }

        //Редагування корпусу
        public IActionResult UpdateCase(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var casesFromDb = _db.Cases.Find(id);
            if (casesFromDb == null)
            {
                return NotFound();
            }
            return View(casesFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateCase(Case obj)
        {
            if (ModelState.IsValid)
            {
                _db.Cases.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("PartsIndex");
            }
            return View(obj);
        }

        //Видалення корпусу
        public IActionResult DeleteCase(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var casesFromDb = _db.Cases.Find(id);
            if (casesFromDb == null)
            {
                return NotFound();
            }
            return View(casesFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteCasePost(int? id)
        {
            var obj = _db.Cases.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Cases.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("PartsIndex");
        }




    }

}

