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
        readonly CustomerService _customerService;

        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }
        // GET: api/<Customers>
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            return _customerService.Get();
        }

        // GET api/<Customers>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Customer c = _customerService.GetById(id);
            if (c==null)
                return NotFound();
            return Ok(_customerService.GetById(id));
        }

        // POST api/<Customers>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Customer customer)
        {
            return _customerService.Add(customer);
        }

        // PUT api/<Customers>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Customer customer)
        {
            if(_customerService.Update(id, customer)==false)
                return NotFound();
            return Ok(true);
        }

        // DELETE api/<Customers>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if(_customerService.Delete(id)==false) 
                return NotFound();
            return Ok(true);
        }
    }
}
