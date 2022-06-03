using Microsoft.AspNetCore.Mvc;
using ServicesWeb.Modelos;
using ServicesWeb.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesWeb.Controllers
{
    [ApiController]
    public class AsigRutaCondController : Controller
    {
        [HttpPost]
        [Route("api/[controller]/asignar")]
        public bool Post([FromBody] AsigRutaCond oAsigRutaCond)
        {
            return AsigRutaCondRepositorio.AsignarRutaConductor(oAsigRutaCond);
        }
    }
}
