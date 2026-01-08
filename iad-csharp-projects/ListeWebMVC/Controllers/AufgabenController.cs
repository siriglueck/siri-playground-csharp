using ListeWebJsonMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ListeWebJsonMVC.Controllers
{
    public class AufgabenController : Controller
    {
        private readonly JsonFileController<Aufgabe> _service;
        private readonly JsonFileController<Kategorie> _kategorieService;

        public AufgabenController()
        {
            _service = new JsonFileController<Aufgabe>("Data/aufgaben.json");
            _kategorieService = new JsonFileController<Kategorie>("Data/kategorien.json");
        }

        // GET: Aufgaben
        public IActionResult Index()
        {
            // Load categories from JSON
            var kategorieService = new JsonFileController<Kategorie>("Data/kategorien.json");
            var kategorien = kategorieService.Load();

            // Create a dictionary for fast lookup
            ViewBag.KategorienMap = kategorien.ToDictionary(k => k.Id, k => k);
            var aufgaben = _service.Load();
            return View(aufgaben);
        }

        // GET: Aufgaben/Create
        public IActionResult Create()
        {
            LoadCategoriesDropdown();
            return View();
        }

        // POST: Aufgaben/Create
        [HttpPost]
        public IActionResult Create(Aufgabe aufgabe)
        {
            if (!ModelState.IsValid)
            {
                LoadCategoriesDropdown(aufgabe.CategoryId);
                return View(aufgabe);
            }

            var data = _service.Load();

            // Ensure ID exists
            if (aufgabe.Id == Guid.Empty)
                aufgabe.Id = Guid.NewGuid();

            data.Add(aufgabe);
            _service.Save(data);

            return RedirectToAction("Index");
        }

        // GET: Aufgaben/Edit/{id}
        public IActionResult Edit(Guid id)
        {
            var aufgabe = _service.Load().FirstOrDefault(a => a.Id == id);
            if (aufgabe == null)
                return NotFound();

            LoadCategoriesDropdown(aufgabe.CategoryId);
            return View(aufgabe);
        }

        // POST: Aufgaben/Edit
        [HttpPost]
        public IActionResult Edit(Aufgabe aufgabe)
        {
            if (!ModelState.IsValid)
            {
                LoadCategoriesDropdown(aufgabe.CategoryId);
                return View(aufgabe);
            }

            var data = _service.Load();
            var index = data.FindIndex(a => a.Id == aufgabe.Id);

            if (index == -1)
                return NotFound();

            data[index] = aufgabe;
            _service.Save(data);

            return RedirectToAction("Index");
        }

        // GET: Aufgaben/Delete/{id}
        public IActionResult Delete(Guid id)
        {
            var data = _service.Load();
            data.RemoveAll(a => a.Id == id);
            _service.Save(data);

            return RedirectToAction("Index");
        }

        /// <summary>
        /// Helper to populate categories dropdown in ViewBag
        /// </summary>
        /// <param name="selectedId">Optional selected category</param>
        private void LoadCategoriesDropdown(Guid? selectedId = null)
        {
            var categories = _kategorieService.Load();
            ViewBag.Categories = new SelectList(categories, "Id", "Title", selectedId);
        }
    }
}
