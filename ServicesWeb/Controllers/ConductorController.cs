using Microsoft.AspNetCore.Mvc;
using ServicesWeb.Modelos;
using ServicesWeb.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServicesWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConductorController : ControllerBase
    {
        // GET: api/<ConductorController>
        [HttpGet]
        [Route("api/[controller]/listaconductor")]
        public List<Conductor> ListarConductores()
        {
            return ConductorRepositorio.ListarConductores();
        }

        /*// GET: api/<ConductorController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ConductorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }*/

        // POST api/<ConductorController>
        [HttpPost]
        [Route("api/[controller]")]
        public bool Post([FromBody] Conductor oConductor)
        {
            return ConductorRepositorio.Grabar(oConductor);
        }

        /*// PUT api/<ConductorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ConductorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
