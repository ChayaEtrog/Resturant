using Microsoft.AspNetCore.Mvc;
using Resturant.classes;

namespace Resturant.Services
{
    public class EmployeeService
    {
        static List<Employee> employees = new List<Employee>();

        public List<Employee> Get()
        {
            return employees;
        }
        public Employee GetById(string id)
        {
            return employees.FirstOrDefault(x => x.Id == id);
        }

        public ActionResult<bool> Add(Employee employee)
        {
            employees.Add(employee);
            return true;
        }

        public ActionResult<bool> Update(string id,Employee employee)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Id == id)
                {
                    employees[i] = employee;
                    return true;
                }
            }
            return false;
        }

        public ActionResult<bool> Delete(string id)
        {
            return employees.Remove(employees.FirstOrDefault(x => x.Id == id));
        }
    }
}
