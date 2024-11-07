using Resturant.classes;

namespace Resturant
{
    public class DataContext
    {
        public List<Customer> customers = new List<Customer>();
        public List<Employee> employees = new List<Employee>();
        public List<Dish> dishes = new List<Dish>();
        public List<Order> orders = new List<Order>();
        public List<OrderLine> orderLines = new List<OrderLine>();
    }
}
