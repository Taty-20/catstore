using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using catstore.Models;//AGREGAR
using catstore.Data;//AGREGAR DATA 

namespace catstore.Controllers
{
 
    public class ContactoController : Controller
    {
        private readonly ILogger<ContactoController> _logger;
        private readonly ApplicationDbContext _context; //AGREGAR

        public ContactoController(ILogger<ContactoController> logger ,ApplicationDbContext context) //ApplicationDbContext context AGREGAR DESPUES DE LA COMA
        {
            _logger = logger;
            _context= context; //AGREGAR
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(Contacto objContacto)
        {
            _context.Add(objContacto);
            _context.SaveChanges();
                    return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}