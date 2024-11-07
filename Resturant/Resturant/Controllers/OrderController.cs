using Microsoft.AspNetCore.Mvc;
using Resturant.Services;
using Resturant.classes;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Resturant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        OrderService orderService=new OrderService();
        // GET: api/<Orders>
        [HttpGet]
        public ActionResult<IEnumerable<Order>> Get()
        {
            return orderService.Get();
        }

        // GET api/<Orders>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Order order = orderService.GetById(id);
            if(order == null) 
                return NotFound();
            return Ok(order);
        }

        // POST api/<Orders>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Order order)
        {
            return orderService.Add(order);
        }

        // PUT api/<Orders>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Order order)
        {
            if(!orderService.Update(id, order))
                return NotFound();
            return Ok(true);
        }

        // DELETE api/<Orders>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (!orderService.Delete(id))
                return NotFound();
            return Ok(true);
        }
    }
}
