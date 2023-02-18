using Microsoft.AspNetCore.Mvc;
using Retailer.API.Commands;
using Retailer.API.DTOs;
using Retailer.API.Queries;
using Retailer.API.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Retailer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RetailerController : ControllerBase
    {
        // GET: api/<RetailerController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<RetailerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            // Query the Employee Domain to get data  
            var employeeQuery = new RetailerQueries(new RetailerQueriesRepository());
            RetailerDTO retailer = employeeQuery.FindByID(100);
            return retailer.ToString();
        }

        // POST api/<RetailerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            var employeeCommand = new RetailerCommands(new RetailerCommandsRepository());
            employeeCommand.SaveRetailerData(new Models.Retailer
            {
                Id = 200,
                FullName = "Vinay Goel"
            });
        }

        // PUT api/<RetailerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RetailerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
