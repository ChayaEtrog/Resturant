namespace Resturant.classes
{
    public class Order
    {
        static int id = 1;
        public int Id { get; private set; }
        public string CustomerId { get; set; }
        public DateTime DateAndTimeOrder { get; set; }
        public double PriceBeforePremise { get; set; }
        public double FinallyPrice { get; set; }
        public string WaiterId { get; set; }
        public bool IsActiveOrder { get; set; }

        public Order(int id, Order other)
        {
            CustomerId = other.CustomerId;
            DateAndTimeOrder = other.DateAndTimeOrder;
            PriceBeforePremise = other.PriceBeforePremise;
            FinallyPrice = other.FinallyPrice;
            WaiterId = other.WaiterId;
            Id = id;
            IsActiveOrder = other.IsActiveOrder;
        }
        public Order(Order other)
        {
            CustomerId = other.CustomerId;
            DateAndTimeOrder = other.DateAndTimeOrder;
            PriceBeforePremise = other.PriceBeforePremise;
            FinallyPrice = other.FinallyPrice;
            WaiterId = other.WaiterId;
            Id = id;
            id++;
            IsActiveOrder = other.IsActiveOrder;
        }

        public Order()
        {

        }

        public double PriceBefore()
        {
            double sum = 0;int i;
            List<OrderLine>ol= DataManager.dataContext.orderLines.FindAll(i=> i.OrderId == Id);
            sum += ol.Sum(o =>
            {
                i = DataManager.dataContext.dishes.FindIndex(item => item.Id == o.DishId);
                return DataManager.dataContext.dishes[i].Price;
            });
            return sum;
        }
    }
}
