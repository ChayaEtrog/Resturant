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
        public IEnumerable<Order> Get()
        {
            return orderService.Get();
        }

        // GET api/<Orders>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return orderService.GetById(id);
        }

        // POST api/<Orders>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Order order)
        {
            return orderService.Add(order);
        }

        // PUT api/<Orders>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Order order)
        {
            return orderService.Update(id, order);
        }

        // DELETE api/<Orders>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return orderService.Delete(id);
        }
    }
}
