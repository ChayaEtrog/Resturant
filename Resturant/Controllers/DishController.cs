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
        public IEnumerable<Dish> Get()
        {
            return dishService.Get();
        }

        // GET api/<Dish>/5
        [HttpGet("{id}")]
        public Dish Get(int id)
        {
            return dishService.GetById(id);
        }

        // POST api/<Dish>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Dish dish)
        {
            return dishService.Add(dish);
        }

        // PUT api/<Dish>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Dish dish)
        {
            return dishService.Update(id, dish);
        }

        // DELETE api/<Dish>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return dishService.Delete(id);
        }
    }
}
