using Microsoft.AspNetCore.Mvc;
using pruebaTecnica.data;
using pruebaTecnica.Models;

namespace pruebaTecnica.Controllers
{
    public class clientesController : Controller
    {
        private readonly appDbContext _context;

        public clientesController(appDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Cliente> listClientes = _context.Cliente; 
            return View(listClientes);
        }

        //httpe get 
        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Cliente.Add(cliente);
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

            var cliente = _context.Cliente.Find(id); 

            if (cliente == null) 
            {
                return NotFound();
            } 

            return View(cliente);
        }

        [HttpPost]
        public IActionResult Edit(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Cliente.Update(cliente);
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

            var cliente = _context.Cliente.Find(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        [HttpPost]
        public IActionResult Deletecliente(int? id)
        {
            var cliente = _context.Cliente.Find(id);
            if (cliente == null)
            {
                return NotFound();
                
            }

            _context.Cliente.Remove(cliente);
            _context.SaveChanges();
            TempData["mensaje"] = "se ha eliminado correctamente correctamente";
            return RedirectToAction("Index");

        }
    }
}
