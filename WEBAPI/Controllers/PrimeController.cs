using Microsoft.AspNetCore.Mvc;
using WEBAPI.TechService;
using WEBAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrimeController : ControllerBase
    {
        // GET: api/<PrimeController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PrimeController>/5
        [HttpGet("{id}")]
        public bool Get(int id)
        {
            Prime primeNum = new Prime();
            primeNum.Number = id;
            bool isPrime = primeNum.IsPrime(primeNum.Number);
            return isPrime;
        }

        // POST api/<PrimeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PrimeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PrimeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
