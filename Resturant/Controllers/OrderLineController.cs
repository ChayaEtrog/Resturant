using Microsoft.AspNetCore.Mvc;
using Resturant.Services;
using Resturant.classes;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Resturant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderLineController : ControllerBase
    {
        OrderLineService orderLineService=new OrderLineService();
        // GET: api/<OrderLine>
        [HttpGet]
        public IEnumerable<OrderLine> Get()
        {
            return orderLineService.Get();
        }

        // GET api/<OrderLine>/5
        [HttpGet("{id}")]
        public OrderLine Get(int id)
        {
            return orderLineService.GetById(id);
        }

        // POST api/<OrderLine>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] OrderLine orderLine)
        {
            return orderLineService.Add(orderLine);
        }

        // PUT api/<OrderLine>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] OrderLine orderLine)
        {
            return orderLineService.Update(id, orderLine);
        }

        // DELETE api/<OrderLine>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return orderLineService.Delete(id);
        }
    }
}
