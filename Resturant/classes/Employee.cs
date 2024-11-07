using System.Net;

namespace Resturant.classes
{
    public enum Positions { ADMIN,WAITER,CLEANER}
    public class Employee
    {
        static int id = 1;
        public int Id { get;private set; }
        public string Tz { get;set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhonNumber { get; set; }
        public string Address { get; set; }
        public int MonthOfExperience { get; set; }
        public string WorkingDays { get; set; }
        public int QtyWeeklyWorkingHours { get; set; }
        public bool IsStudent { get; set; }
        public double Salary { get; set; }
        public Positions EmployeesPosition { get; set; }
        public Employee()
        {
            
        }
        public Employee(int id, Employee other)
        {
            Id = id;
            Tz = other.Tz;
            Name = other.Name;
            Email = other.Email;
            PhonNumber = other.PhonNumber;
            Address = other.Address;
            MonthOfExperience = other.MonthOfExperience;
            WorkingDays = other.WorkingDays;
            QtyWeeklyWorkingHours = other.QtyWeeklyWorkingHours;
            IsStudent = other.IsStudent;
            EmployeesPosition = other.EmployeesPosition;
            Salary = other.Salary;
        }

        public Employee(Employee other)
        {
            Id = id;
            id++;
            Tz = other.Tz;
            Name = other.Name;
            Email = other.Email;
            PhonNumber = other.PhonNumber;
            Address = other.Address;
            MonthOfExperience = other.MonthOfExperience;
            WorkingDays = other.WorkingDays;
            QtyWeeklyWorkingHours = other.QtyWeeklyWorkingHours;
            IsStudent = other.IsStudent;
            EmployeesPosition = other.EmployeesPosition;
            Salary = other.Salary;
        }

        public double CalcSalary()
        {
            double salary = 0;
            switch (EmployeesPosition)
            {
                case Positions.ADMIN:
                    salary = QtyWeeklyWorkingHours * 40;
                    break;
                case Positions.WAITER: 
                    salary = QtyWeeklyWorkingHours * 32;
                    break;
                case Positions.CLEANER:
                    salary = QtyWeeklyWorkingHours * 28;
                    break;
            }           
            if (IsStudent)
                salary += 500;
            if (MonthOfExperience > 12)
                salary += (MonthOfExperience - 12) * 5;
            return salary;

        }
    }
}
