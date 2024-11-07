using Microsoft.AspNetCore.Mvc;
using Resturant.classes;

namespace Resturant.Services
{
    public class OrderService
    {

        public List<Order> Get()
        {
            return DataManager.dataContext.orders;
        }

        public Order GetById(int id)
        {
            return DataManager.dataContext.orders.FirstOrDefault(x => x.Id == id);
        }

        public bool Add(Order order)
        {
            DataManager.dataContext.orders.Add(new Order(order));
            return true;
        }

        public bool Update(int id, Order order)
        {
            int index = DataManager.dataContext.orders.FindIndex(x => x.Id == id);
            if (index == -1)
                return false;
            DataManager.dataContext.orders[index] = new Order(id, order);
            return true;
        }

        public bool Delete(int id)
        {
            return DataManager.dataContext.orders.Remove(DataManager.dataContext.orders.FirstOrDefault(x => x.Id == id));
        }
    }
}
