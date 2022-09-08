using System.Collections.Generic;
using System.Linq;
using clientes.Context;
using clientes.Interfaces;
using clientes.Models;

namespace clientes.Repositories
{
    public class ClienteRepository : IClienteRepository
    {

        private readonly ClientesContext _context;

        public ClienteRepository(ClientesContext context)
        {
            _context = context;
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _context.Clientes.ToList();
        }
        public Cliente GetById(int id)
        {
            return _context.Clientes.Find(id);
        }

        public void Add(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Clientes.Remove(GetById(id));
            _context.SaveChanges();
        }

        public void Update(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }
    }
}