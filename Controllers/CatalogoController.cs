using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using catstore.Data;//AGREGAR
using catstore.Models;//AGREGAR
using Microsoft.EntityFrameworkCore;//AGREGAR

namespace catstore.Controllers
{
    
    public class CatalogoController : Controller
    {
        private readonly ILogger<CatalogoController> _logger;
        private readonly ApplicationDbContext _context; //AGREGAR

        public CatalogoController(ApplicationDbContext context,ILogger<CatalogoController> logger)  //AGREGAR EL ENTREPARENTESIS
        {
            _logger = logger;
            _context = context; //AGREGAR
        }

        public async Task<IActionResult> Index(string? searchString)   //AGREGAR TODO ESTO //retorno respuesta a la pagina de index catalogo
        {
            var productos = from o in _context.DataProductos select o;
            if(!String.IsNullOrEmpty(searchString)){
                productos = productos.Where(s => s.Name.Contains(searchString));
            }
            
            return View(await productos.ToListAsync()); //retornar la lista de productos
        }

        public async Task<IActionResult> Details(int? id){   //AGREGAR TODO ESTO
            Producto objProduct = await _context.DataProductos.FindAsync(id);
            if(objProduct == null){
                return NotFound();
            }
            return View(objProduct);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}