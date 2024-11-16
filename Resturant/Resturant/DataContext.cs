using Resturant.classes;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Text.Json;

namespace Resturant
{
    public class DataContext:IDataContext
    {
        public List<Customer> LoadData()
        {

            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "Data", "CustomerData.json");

                string jsonString = File.ReadAllText(path);
                var customers = JsonSerializer.Deserialize<List<Customer>>(jsonString);// typeof(DataCoins)); ;

                if (customers == null)  return null; 

                return customers;
            }
            catch
            {
                return null;
            }
        }

        public bool SaveData(List<Customer> data)
        {
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "Data", "CustomerData.json");

                string jsonString = JsonSerializer.Serialize<List<Customer>>(data);

                File.WriteAllText(path, jsonString);
                return true;
            }
            catch { return false; }
        }

        //public List<Customer> customers = new List<Customer>();
        public List<Employee> employees = new List<Employee>();
        public List<Dish> dishes = new List<Dish>();
        public List<Order> orders = new List<Order>();
        public List<OrderLine> orderLines = new List<OrderLine>();

    }
}
