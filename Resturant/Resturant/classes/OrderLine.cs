namespace Resturant.classes
{
    public class OrderLine
    {
        static int id = 1;
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int DishId { get; set; }
        public int Count { get; set; }

        public OrderLine(int orderId, OrderLine other)
        {
            Id = id;
            OrderId = other.OrderId;
            DishId = other.DishId;
            Count = other.Count;
        }
        public OrderLine( OrderLine other)
        {
            Id = id;
            id++;
            OrderId = other.OrderId;
            DishId = other.DishId;
            Count = other.Count;
        }
        public OrderLine()
        {
            
        }
    }
}
