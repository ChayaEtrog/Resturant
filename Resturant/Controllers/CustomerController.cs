using Microsoft.AspNetCore.Mvc;
using Resturant.Services;
using Resturant.classes;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Resturant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        CustomerService customerService = new CustomerService();
        // GET: api/<Customers>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return customerService.Get();
        }

        // GET api/<Customers>/5
        [HttpGet("{id}")]
        public Customer Get(string id)
        {
            return customerService.GetById(id);
        }

        // POST api/<Customers>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Customer customer)
        {
            return customerService.Add(customer);
        }

        // PUT api/<Customers>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(string id, [FromBody] Customer customer)
        {
            return customerService.Update(id, customer);
        }

        // DELETE api/<Customers>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(string id)
        {
            return customerService.Delete(id);
        }
    }
}
