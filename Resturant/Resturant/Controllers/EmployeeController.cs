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
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return employeeService.Get();
        }

        // GET api/<Employee>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Employee employee = employeeService.GetById(id);
            if(employee == null) 
                return NotFound();
            return Ok(employee);
        }

        // POST api/<Employee>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Employee employee)
        {

            return employeeService.Add(employee);
        }

        // PUT api/<Employee>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Employee employee)
        {
            if(!employeeService.Update(id, employee))
                return NotFound();
            return Ok(true);
        }

        // DELETE api/<Employee>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            if (!employeeService.Delete(id))
                return NotFound();
            return Ok(true);
        }
    }
}
