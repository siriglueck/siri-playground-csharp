using ListeWebJsonMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ListeWebJsonMVC.Controllers
{
    public class TermineController : Controller
    {
        private readonly JsonFileController<Termin> _service;

        public TermineController()
        {
            _service = new JsonFileController<Termin>("Data/termine.json");
        }

        public IActionResult Index()
        {
            return View(_service.Load());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Termin termin)
        {
            var data = _service.Load();
            data.Add(termin);
            _service.Save(data);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(Guid id)
        {
            var termin = _service.Load().First(t => t.Id == id);
            return View(termin);
        }

        [HttpPost]
        public IActionResult Edit(Termin termin)
        {
            var data = _service.Load();
            var index = data.FindIndex(t => t.Id == termin.Id);
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
    }
}
