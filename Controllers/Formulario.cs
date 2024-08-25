using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PC1_ROJASMARY.Models;

namespace PC1_ROJASMARY.Controllers
{
    [Route("[controller]")]
    public class Formulario : Controller
    {
        private readonly ILogger<Formulario> _logger;

        public Formulario(ILogger<Formulario> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Ejecutar()
        {
            return View(new Inversion()); 
        }

        [HttpPost]
        public IActionResult Ejecutar(Inversion inversion)
        {
            if (ModelState.IsValid)
            {
                return View(inversion);
            }

            return View(inversion);
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}