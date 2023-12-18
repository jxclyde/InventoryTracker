using Microsoft.AspNetCore.Mvc;
using InventoryTracker.Data;
using InventoryTracker.Models.DomainComponents;
using InventoryTracker.Models.DomainPeripherals;


namespace InventoryTracker.Controllers
{
    public class PeripheralsController : Controller // На діаграмі класів діаграма - (1)
    {
        private readonly InventoryDbContext _db;

        public PeripheralsController(InventoryDbContext db)
        {
            _db = db;
        }

        public IActionResult PeripheralsIndex()
        {
            var keyboards = _db.Keyboards.ToList();
            var mice = _db.Mice.ToList();
            var mousepads = _db.Mousepads.ToList();

            PeripheralsList peripheralsList = new PeripheralsList
            {
                Keyboards = keyboards,
                Mice = mice,
                Mousepads = mousepads,
            };
            return View(peripheralsList);


        }

        //Клавіатури-----------------------------------------------------------------------------------------------------------------
        //Створення клавіатури
        public IActionResult CreateKeyboard()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateKeyboard(Keyboard obj)
        {
            if (ModelState.IsValid)
            {
                _db.Keyboards.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Товар успішно додано";
                return RedirectToAction("PeripheralsIndex");
            }
            return View(obj);
        }

        //Редагування клавіатури
        public IActionResult UpdateKeyboard(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var keyboardFromDb = _db.Keyboards.Find(id);
            if (keyboardFromDb == null)
            {
                return NotFound();
            }
            return View(keyboardFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateKeyboard(Keyboard obj)
        {
            if (ModelState.IsValid)
            {
                _db.Keyboards.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Товар успішно оновлено";
                return RedirectToAction("PeripheralsIndex");
            }
            return View(obj);
        }

        //Видалення клавіатури
        public IActionResult DeleteKeyboard(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var keyboardFromDb = _db.Keyboards.Find(id);
            if (keyboardFromDb == null)
            {
                return NotFound();
            }
            return View(keyboardFromDb);
        }

        [HttpPost("DeleteKeyboardPOST")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteKeyboardPOST(int? id)
        {
            var obj = _db.Keyboards.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Keyboards.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Товар успішно видалено";
            return RedirectToAction("PeripheralsIndex");
        }

        //Миші-----------------------------------------------------------------------------------------------------------------
        //Створення мишок
        public IActionResult CreateMice()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateMice(Mouse obj)
        {
            if (ModelState.IsValid)
            {
                _db.Mice.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Товар успішно додано";
                return RedirectToAction("PeripheralsIndex");
            }
            return View(obj);
        }

        //Редагування мишок
        public IActionResult UpdateMouse(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var mouseFromDb = _db.Mice.Find(id);
            if (mouseFromDb == null)
            {
                return NotFound();
            }
            return View(mouseFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateMouse(Mouse obj)
        {
            if (ModelState.IsValid)
            {
                _db.Mice.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Товар успішно оновлено";
                return RedirectToAction("PeripheralsIndex");
            }
            return View(obj);
        }

        //Видалення мишок
        public IActionResult DeleteMouse(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var mouseFromDb = _db.Mice.Find(id);
            if (mouseFromDb == null)
            {
                return NotFound();
            }
            return View(mouseFromDb);
        }

        [HttpPost("DeleteMousePOST")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteMousePOST(int? id)
        {
            var obj = _db.Mice.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Mice.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Товар успішно видалено";
            return RedirectToAction("PeripheralsIndex");
        }

        //Килимки-----------------------------------------------------------------------------------------------------------------
        //Створення килимків
        public IActionResult CreateMousepad()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateMousepad(Mousepad obj)
        {
            if (ModelState.IsValid)
            {
                _db.Mousepads.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Товар успішно додано";
                return RedirectToAction("PeripheralsIndex");
            }
            return View(obj);
        }

        //Редагування килимків
        public IActionResult UpdateMousepad(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var mpadFromDb = _db.Mousepads.Find(id);
            if (mpadFromDb == null)
            {
                return NotFound();
            }
            return View(mpadFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateMousepad(Mousepad obj)
        {
            if (ModelState.IsValid)
            {
                _db.Mousepads.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Товар успішно оновлено";
                return RedirectToAction("PeripheralsIndex");
            }
            return View(obj);
        }

        //Видалення килимків
        public IActionResult DeleteMousepad(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var mpadFromDb = _db.Mousepads.Find(id);
            if (mpadFromDb == null)
            {
                return NotFound();
            }
            return View(mpadFromDb);
        }

        [HttpPost("DeleteMousepadPOST")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteMousepadPOST(int? id)
        {
            var obj = _db.Mousepads.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Mousepads.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Товар успішно видалено";
            return RedirectToAction("PeripheralsIndex");
        }


    }
}
