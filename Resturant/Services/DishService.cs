using Microsoft.AspNetCore.Mvc;
using Resturant.classes;

namespace Resturant.Services
{
    public class DishService
    {

        public List<Dish> Get()
        {
            return DataManager.dataContext.dishes;
        }
        public Dish GetById(int id)
        {
            return DataManager.dataContext.dishes.FirstOrDefault(x => x.Id == id);
        }

        public bool Add(Dish dish)
        {
            DataManager.dataContext.dishes.Add(new Dish(dish));
            return true;
        }

        public bool Update(int id,Dish dish)
        {
            int index = DataManager.dataContext.dishes.FindIndex(x => x.Id == id);
            if (index == -1 )
                return false;
            DataManager.dataContext.dishes[index] = new Dish(id, dish);
            return true;
        }

        public bool Delete(int id)
        {
            return DataManager.dataContext.dishes.Remove(DataManager.dataContext.dishes.FirstOrDefault(x => x.Id == id));
        }

    }
}
