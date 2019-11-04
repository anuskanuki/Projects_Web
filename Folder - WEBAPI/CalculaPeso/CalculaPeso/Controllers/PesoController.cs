using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculaPeso.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PesoController : ControllerBase
    {
        // GET: api/Peso
        [HttpGet]
        public IEnumerable<string> Get(double Massa,double Volume)
        {
            double ValorResultadoCalculoWTF = Massa * Volume;
            return new string[] { "Valor da massa do area do volume do peso do massa do planeta terra da gravidade = ", ValorResultadoCalculoWTF.ToString()};
        }

        // GET: api/Peso/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Peso
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Peso/5
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
