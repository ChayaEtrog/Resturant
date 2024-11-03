using Microsoft.AspNetCore.Mvc;
using Resturant.classes;

namespace Resturant.Services
{
    public class DishService
    {
        static List<Dish> dishes = new List<Dish>();

        public List<Dish> Get()
        {
            return dishes;
        }
        public Dish GetById(int id)
        {
            return dishes.FirstOrDefault(x => x.Id == id);
        }

        public ActionResult<bool> Add(Dish dish)
        {
            dishes.Add(dish);
            return true;
        }

        public ActionResult<bool> Update(int id,Dish dish)
        {
            for (int i = 0; i < dishes.Count; i++)
            {
                if (dishes[i].Id == id)
                {
                    dishes[i] = dish;
                    return true;
                }
            }
            return false;
        }

        public ActionResult<bool> Delete(int id)
        {
            return dishes.Remove(dishes.FirstOrDefault(x => x.Id == id));
        }

    }
}
