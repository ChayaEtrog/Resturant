using Microsoft.AspNetCore.Mvc;
using Resturant.classes;

namespace Resturant.Services
{
    public class CustomerService
    {
        readonly IDataContext _dataContext;

        public CustomerService(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Customer> Get()
        {
            var data = _dataContext.LoadData();
            if (data == null)
                return null;
            return data.ToList();
        }

        public Customer GetById(int id)
        {
            var data = _dataContext.LoadData();
            if (data == null)
                return null;
            //return data.Where(c => c.id == id).FirstOrDefault();
            return data.FirstOrDefault(x => x.Id == id);
        }

        public bool IsValidTz(string tz)
        {
            if (tz.Length != 9)
                return false;
            int sum = 0, i = 0, plus;
            while (i < tz.Length - 1)
            {
                if (tz[i] < '0' || tz[i] > '9')
                    return false;
                plus = tz[i] - '0';
                if (i % 2 == 1)
                    plus *= 2;
                if (plus > 9)
                    plus = plus / 10 + plus % 10;
                sum += plus;
                i++;
            }
            sum %= 10;
            if (10 - sum == tz[tz.Length - 1] - '0')
                return true;
            return false;
        }

        public bool Add( Customer customer)
        {
            var data=_dataContext.LoadData();
            if (IsValidTz(customer.Tz))
            {
                data.Add(new Customer(customer));
                _dataContext.SaveData(data);
                return true;
            }
            return false;
        }

        public bool Update(int id,Customer customer)
        {
            var data= _dataContext.LoadData();
            int index = data.FindIndex(x => x.Id == id);
            if (index == -1 || !IsValidTz(customer.Tz))
                return false;
            data[index] = new Customer(id,customer);
            _dataContext.SaveData(data);
            return true;
        }

        public bool Delete(int id)
        {
            var data= _dataContext.LoadData();
            if (data.Remove(data.FirstOrDefault(x => x.Id == id)))
            {
                _dataContext.SaveData(data);
                return true;
            }
            return false;
        }

    }
}
