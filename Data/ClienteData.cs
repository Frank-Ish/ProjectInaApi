using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ClienteData : IData<tbCliente>
    {
        public IEnumerable<tbCliente> obtenerTodos()
        {
            return null;
        }
    }
}
