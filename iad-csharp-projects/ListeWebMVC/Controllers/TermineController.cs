using ListeWebJsonMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ListeWebJsonMVC.Controllers
{
    public class TermineController : Controller
    {
        private readonly JsonFileController<Termin> _service;
        private readonly JsonFileController<Kategorie> _kategorieService;

        public TermineController()
        {
            _service = new JsonFileController<Termin>("Data/termine.json");
            _kategorieService = new JsonFileController<Kategorie>("Data/kategorien.json");
        }

        public IActionResult Index()
        {
            // Load categories from JSON
            var kategorieService = new JsonFileController<Kategorie>("Data/kategorien.json");
            var kategorien = kategorieService.Load();

            // Create a dictionary for fast lookup
            ViewBag.KategorienMap = kategorien.ToDictionary(k => k.Id, k => k);
            return View(_service.Load());
        }

        public IActionResult Create()
        {
            LoadCategoriesDropdown();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Termin termin)
        {
            if (!ModelState.IsValid)
            {
                LoadCategoriesDropdown(termin.CategoryId);
                return View(termin);
            }

            var data = _service.Load();
            data.Add(termin);
            _service.Save(data);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(Guid id)
        {
            var termin = _service.Load().FirstOrDefault(t => t.Id == id);
            if (termin == null) return NotFound();

            LoadCategoriesDropdown(termin.CategoryId);
            return View(termin);
        }

        [HttpPost]
        public IActionResult Edit(Termin termin)
        {
            if (!ModelState.IsValid)
            {
                LoadCategoriesDropdown(termin.CategoryId);
                return View(termin);
            }

            var data = _service.Load();
            var index = data.FindIndex(t => t.Id == termin.Id);
            if (index == -1) return NotFound();

            data[index] = termin;
            _service.Save(data);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(Guid id)
        {
            var data = _service.Load();
            data.RemoveAll(t => t.Id == id);
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
