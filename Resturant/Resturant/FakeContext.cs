using Resturant.classes;
using Resturant.Services;

namespace Resturant
{
    public class FakeContext:IDataContext
    {
       
        public List<Customer> LoadData()
        {
            List<Customer>customers=new List<Customer>();
            customers.Add(new Customer("327863254",null,null,null,null,false,false,true,new DateTime()));
            return customers;
        }

        public bool SaveData(List<Customer> customers)
        {
            return true;
        }
    }
}
