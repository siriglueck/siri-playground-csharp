using ListeWebJsonMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ListeWebJsonMVC.Controllers
{
    public class AufgabenController : Controller
    {
        private readonly JsonFileController<Aufgabe> _service;

        public AufgabenController()
        {
            _service = new JsonFileController<Aufgabe>("Data/aufgaben.json");
        }

        // GET: Aufgaben
        public IActionResult Index()
        {
            var aufgaben = _service.Load();
            return View(aufgaben);
        }

        // GET: Aufgaben/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Aufgaben/Create
        [HttpPost]
        public IActionResult Create(Aufgabe aufgabe)
        {
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

            return View(aufgabe);
        }

        // POST: Aufgaben/Edit
        [HttpPost]
        public IActionResult Edit(Aufgabe aufgabe)
        {
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
    }
}
