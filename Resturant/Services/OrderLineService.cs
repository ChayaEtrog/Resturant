using Microsoft.AspNetCore.Mvc;
using Resturant.classes;

namespace Resturant.Services
{
    public class OrderLineService
    {
        static List<OrderLine> orderLines = new List<OrderLine>();

        public List<OrderLine> Get()
        {
            return orderLines;
        }

        public OrderLine GetById(int id)
        {
            return orderLines.FirstOrDefault(x => x.OrderId == id);
        }

        public ActionResult<bool> Add(OrderLine orderLine)
        {
            orderLines.Add(orderLine);
            return true;
        }

        public ActionResult<bool> Update(int id,OrderLine orderLine)
        {
            for (int i = 0; i < orderLines.Count; i++)
            {
                if (orderLines[i].OrderId == id)
                {
                    orderLines[i] = orderLine;
                    return true;
                }
            }
            return false;
        }

        public ActionResult<bool> Delete(int id)
        {
            return orderLines.Remove(orderLines.FirstOrDefault(x => x.OrderId == id));
        }

    }
}
