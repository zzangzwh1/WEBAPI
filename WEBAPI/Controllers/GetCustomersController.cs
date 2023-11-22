using Microsoft.AspNetCore.Mvc;
using WEBAPI.TechService;
using WEBAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetCustomersController : ControllerBase
    {
        // GET: api/<GetCustomersController>
        [HttpGet]
        public List<GetNorthwindCustomers> Get()
        {
            NorthWind NorthWind = new NorthWind();
            List<GetNorthwindCustomers> ExampleNorthWind = NorthWind.GetCustomers();

            return ExampleNorthWind;
        }
        // GET api/<GetCustomersController>/5
        [HttpGet("{customerID}")]
        public GetNorthwindCustomers Get(string customerID)
        {
            NorthWind northWind = new NorthWind();
            GetNorthwindCustomers exampleNorthWind = northWind.GetCustomer(customerID);
            return exampleNorthWind;
        }

        // POST api/<GetCustomersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GetCustomersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GetCustomersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
