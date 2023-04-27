using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace InaApi.Controllers
{
    [ApiController]
    [Route("api/cliente")]
    public class ClienteController : ControllerBase
    {
        private readonly IServices<tbCliente> _IClienteService;

        public ClienteController(IServices<tbCliente> iClienteService)
        {
            _IClienteService = iClienteService;
        }

        [HttpGet]
        public JsonResult get()
        {
            _IClienteService.obtenerTodos();
            string mensaje = "hola";
            return new JsonResult(mensaje);
        }
    }
}
