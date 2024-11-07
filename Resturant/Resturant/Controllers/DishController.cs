using Microsoft.AspNetCore.Mvc;
using Resturant.Services;
using Resturant.classes;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Resturant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishController : ControllerBase
    {
        DishService dishService=new DishService();
        // GET: api/<Dish>
        [HttpGet]
        public ActionResult<IEnumerable<Dish>> Get()
        {
            return dishService.Get();
        }

        // GET api/<Dish>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Dish dish = dishService.GetById(id);
            if(dish == null) 
                return NotFound();
            return Ok(dish);
        }

        // POST api/<Dish>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Dish dish)
        {
            return dishService.Add(dish);
        }

        // PUT api/<Dish>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Dish dish)
        {
            if(!dishService.Update(id, dish))
                return NotFound();
            return Ok(true);
        }

        // DELETE api/<Dish>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (!dishService.Delete(id))
                return NotFound();
            return Ok(true);
        }
    }
}
