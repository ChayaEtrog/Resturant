using Microsoft.AspNetCore.Mvc;
using Resturant.classes;

namespace Resturant.Services
{
    public class OrderService
    {
        static List<Order> orders = new List<Order>();

        public List<Order> Get()
        {
            return orders;
        }

        public Order GetById(int id)
        {
            return orders.FirstOrDefault(x => x.Id == id);
        }

        public ActionResult<bool> Add(Order order)
        {
            orders.Add(order);
            return true;
        }

        public ActionResult<bool> Update(int id, Order order)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].Id == id)
                {
                    orders[i] = order;
                    return true;
                }
            }
            return false;
        }

        public ActionResult<bool> Delete(int id)
        {
            return orders.Remove(orders.FirstOrDefault(x => x.Id == id));
        }
    }
}
