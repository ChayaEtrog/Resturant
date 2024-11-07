using Microsoft.AspNetCore.Mvc;
using Resturant.classes;

namespace Resturant.Services
{
    public class EmployeeService
    {

        public List<Employee> Get()
        {
            return DataManager.dataContext.employees;
        }
        public Employee GetById(int id)
        {
            return DataManager.dataContext.employees.FirstOrDefault(x => x.Id == id);
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

        public bool Add(Employee employee)
        {
            if (!IsValidTz(employee.Tz))
                return false;
            DataManager.dataContext.employees.Add(new Employee(employee));
            return true;
        }

        public bool Update(int id,Employee employee)
        {
            int index = DataManager.dataContext.employees.FindIndex(x => x.Id == id);
            if (index == -1 || !IsValidTz(employee.Tz))
                return false;
            DataManager.dataContext.employees[index] = new Employee(id, employee);
            return true;
        }

        public bool Delete(int id)
        {
            return DataManager.dataContext.employees.Remove(DataManager.dataContext.employees.FirstOrDefault(x => x.Id == id));
        }
    }
}
