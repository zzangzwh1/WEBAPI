using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using WEBAPI.TechService;
using WEBAPI.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BinaryToDecimalController : ControllerBase
    {
        // GET: api/<BinaryToDecimalController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BinaryToDecimalController>/5
        [HttpGet("{binary}")]
        public int Get(string binary)
        {
            BinaryToDecimal bToD =new BinaryToDecimal();
            bToD.Binary = binary;
            int result = bToD.BinaryToDec(bToD.Binary);
            return result;
        }

        // POST api/<BinaryToDecimalController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BinaryToDecimalController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BinaryToDecimalController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
