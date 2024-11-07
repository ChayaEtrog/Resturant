using Microsoft.AspNetCore.Mvc;
using Resturant.classes;

namespace Resturant.Services
{
    public class OrderLineService
    {

        public List<OrderLine> Get()
        {
            return DataManager.dataContext.orderLines;
        }

        public OrderLine GetById(int id)
        {
            return DataManager.dataContext.orderLines.FirstOrDefault(x => x.OrderId == id);
        }

        public bool Add(OrderLine orderLine)
        {
            DataManager.dataContext.orderLines.Add(new OrderLine(orderLine));
            return true;
        }

        public bool Update(int id,OrderLine orderLine)
        {
            int index = DataManager.dataContext.orderLines.FindIndex(x => x.Id == id);
            if (index == -1)
                return false;
            DataManager.dataContext.orderLines[index] = new OrderLine(id, orderLine);
            return true;
        }

        public bool Delete(int id)
        {
            return DataManager.dataContext.orderLines.Remove(DataManager.dataContext.orderLines.FirstOrDefault(x => x.OrderId == id));
        }

    }
}
