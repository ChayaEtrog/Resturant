namespace Resturant.classes
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public DateTime DateAndTimeOrder { get; set; }
        public bool IsSitting { get; set; }
        public int IdTable { get; set; }
        public int AmountOfSitters { get; set; }
        public double PriceBeforePremise { get; set; }
        public double FinallyPrice { get; set; }
        public string IdWaiter { get; set; }
        public int OrderId { get; set; }
        public bool IsActiveOrder { get; set; }
    }
}
