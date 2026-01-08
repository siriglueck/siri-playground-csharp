using ListeWebJsonMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ListeWebJsonMVC.Controllers
{
    public class KategorienController : Controller
    {
        private readonly JsonFileController<Kategorie> _service;

        public KategorienController()
        {
            _service = new JsonFileController<Kategorie>("Data/kategorien.json");
        }

        // GET: Kategorien
        public IActionResult Index()
        {
            var kategorien = _service.Load();
            return View(kategorien);
        }

        // GET: Kategorien/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kategorien/Create
        [HttpPost]
        public IActionResult Create(Kategorie kategorie)
        {
            var data = _service.Load();

            if (kategorie.Id == Guid.Empty)
                kategorie.Id = Guid.NewGuid();

            data.Add(kategorie);
            _service.Save(data);

            return RedirectToAction("Index");
        }

        // GET: Kategorien/Edit/{id}
        public IActionResult Edit(Guid id)
        {
            var kategorie = _service.Load().FirstOrDefault(k => k.Id == id);

            if (kategorie == null)
                return NotFound();

            return View(kategorie);
        }

        // POST: Kategorien/Edit
        [HttpPost]
        public IActionResult Edit(Kategorie kategorie)
        {
            var data = _service.Load();
            var index = data.FindIndex(k => k.Id == kategorie.Id);

            if (index == -1)
                return NotFound();

            data[index] = kategorie;
            _service.Save(data);

            return RedirectToAction("Index");
        }

        // GET: Kategorien/Delete/{id}
        public IActionResult Delete(Guid id)
        {
            var data = _service.Load();
            data.RemoveAll(k => k.Id == id);
            _service.Save(data);

            return RedirectToAction("Index");
        }
    }
}
