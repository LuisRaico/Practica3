using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practica3.Models;
using Practica3.Data;

using Microsoft.EntityFrameworkCore;

namespace Practica3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
          private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger,ApplicationDbContext  context)
        {
            _logger = logger;
             _context= context;  
        }

        public IActionResult Index()
        {
             var solicitudes = _context.Solicitudes.Include(s => s.Usuario).ToList();
             return View(solicitudes);
        }

        public IActionResult Solicitud()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Solicitud(Solicitud solicitud)
        {
            if (ModelState.IsValid)
            {
                // Guardar el objeto y hacer una redireccion
                var usuario = _context.Usuarios.First(s => s.Id == 1);
                solicitud.Usuario  = usuario;
                _context.Add(solicitud);
                _context.SaveChanges();

                return RedirectToAction("Index");
                
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
