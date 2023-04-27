using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ClienteService : IServices<tbCliente>
    {
        private readonly IData<tbCliente> _clienteData;

        public ClienteService(IData<tbCliente> clienteData)
        {
            _clienteData = clienteData;
        }

        public IEnumerable<tbCliente> obtenerTodos()
        {
            return _clienteData.obtenerTodos();
        }
    }
}
