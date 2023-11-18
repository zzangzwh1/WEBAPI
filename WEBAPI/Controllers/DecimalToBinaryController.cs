using Microsoft.AspNetCore.Mvc;
using WEBAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DecimalToBinaryController : ControllerBase
    {
        // GET: api/<DecimalToBinaryController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DecimalToBinaryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            DecimalToBinary dToBinary = new DecimalToBinary();
            dToBinary.Number = id;
            string number = dToBinary.DecimalTOBina(dToBinary.Number);

            return number;
        }

        // POST api/<DecimalToBinaryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DecimalToBinaryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DecimalToBinaryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
