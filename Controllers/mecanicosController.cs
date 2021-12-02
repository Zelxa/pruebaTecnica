using Microsoft.AspNetCore.Mvc;
using pruebaTecnica.data;
using pruebaTecnica.Models;

namespace pruebaTecnica.Controllers
{
    public class mecanicosController : Controller
    {
        private readonly appDbContext _context;

        public mecanicosController(appDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Mecanico> listMecanicos = _context.Mecanico;
            return View(listMecanicos);
        }

        //httpe get 
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Mecanico mecanico)
        {
            if (ModelState.IsValid)
            {
                _context.Mecanico.Add(mecanico);
                _context.SaveChanges();

                TempData["mensaje"] = "el cliente se creo correctamente";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var cliente = _context.Mecanico.Find(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        [HttpPost]
        public IActionResult Edit(Mecanico mecanico)
        {
            if (ModelState.IsValid)
            {
                _context.Mecanico.Update(mecanico);
                _context.SaveChanges();

                TempData["mensaje"] = "se ha actualizado correctamente correctamente";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var cliente = _context.Mecanico.Find(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        [HttpPost]
        public IActionResult Deletecliente(int? id)
        {
            var cliente = _context.Mecanico.Find(id);
            if (cliente == null)
            {
                return NotFound();

            }

            _context.Mecanico.Remove(cliente);
            _context.SaveChanges();
            TempData["mensaje"] = "se ha eliminado correctamente correctamente";
            return RedirectToAction("Index");

        }
    }
}

