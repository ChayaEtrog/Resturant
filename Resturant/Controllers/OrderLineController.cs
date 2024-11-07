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
        public ActionResult<IEnumerable<OrderLine>> Get()
        {
            return orderLineService.Get();
        }

        // GET api/<OrderLine>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            OrderLine orderLine = orderLineService.GetById(id);
            if(orderLine == null) 
                return NotFound();
            return Ok(orderLine);
        }

        // POST api/<OrderLine>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] OrderLine orderLine)
        {
            return orderLineService.Add(orderLine);
        }

        // PUT api/<OrderLine>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] OrderLine orderLine)
        {
            if(!orderLineService.Update(id, orderLine))
                return NotFound();
            return Ok(true);
        }

        // DELETE api/<OrderLine>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (!orderLineService.Delete(id))
                return NotFound();
            return Ok(true);
        }
    }
}
