using Microsoft.AspNetCore.Mvc;
using Resturant.classes;

namespace Resturant.Services
{
    public class CustomerService
    {
        static List<Customer> customers = new List<Customer>();
        public List<Customer> Get()
        {
            return customers;
        }
        public Customer GetById(string id)
        {        
            return customers.FirstOrDefault(x => x.Id == id);
        }

        public ActionResult<bool> Add([FromBody] Customer customer)
        {
            customers.Add(customer);
            return true;
        }

        public ActionResult<bool> Update(string id,Customer customer)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Id == id)
                {
                    customers[i] = customer;
                    return true;
                }
            }
            return false;
        }

        public ActionResult<bool> Delete(string id)
        {
            return customers.Remove(customers.FirstOrDefault(x => x.Id == id));
        }

    }
}
