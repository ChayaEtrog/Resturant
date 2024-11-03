using Microsoft.AspNetCore.Mvc;
using Resturant.Services;
using Resturant.classes;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Resturant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeService employeeService = new EmployeeService();
        // GET: api/<Employee>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return employeeService.Get();
        }

        // GET api/<Employee>/5
        [HttpGet("{id}")]
        public Employee Get(string id)
        {
            return employeeService.GetById(id);
        }

        // POST api/<Employee>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Employee employee)
        {

            return employeeService.Add(employee);
        }

        // PUT api/<Employee>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(string id, [FromBody] Employee employee)
        {
            return employeeService.Update(id, employee);
        }

        // DELETE api/<Employee>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(string id)
        {
            return employeeService.Delete(id);
        }
    }
}
