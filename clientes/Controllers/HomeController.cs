using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using clientes.Models;
using clientes.Context;

namespace clientes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ClientesContext _context;

        public HomeController(ClientesContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Clientes()
        {
            var clientes = _context.Clientes.ToList();
            return View(clientes);
        }
    }
}
