using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrestamosProyect.BLL;
using PrestamosProyect.Models;

namespace APiPrestamo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrestamosController : ControllerBase
    {
        // GET: api/Prestamos
        [HttpGet]
        public ActionResult<List<Prestamos>> Get()
        {
            return PrestamosBLL.GetPrestamos();
        }


        // GET: api/Prestamos/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Prestamos
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Prestamos/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
