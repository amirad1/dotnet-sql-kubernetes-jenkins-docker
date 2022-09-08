using clientes.Interfaces;
using clientes.Models;
using Microsoft.AspNetCore.Mvc;

namespace clientes.Controllers
{
    public class ClientesController: Controller
    {
        private readonly IClienteRepository _clienteRepository;

        public ClientesController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IActionResult Index()
        {
            var clientes = _clienteRepository.GetAll();
            return View(clientes);
        }

        public IActionResult Adicionar(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(Cliente cliente)
        {
            if(ModelState.IsValid)
            {
                _clienteRepository.Add(cliente);
                return RedirectToAction("Index");
            }
            
            return View();
        }
    }
}