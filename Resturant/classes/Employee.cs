namespace Resturant.classes
{
    public enum Positions { ADMIN,WAITER,CLEANER}
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhonNumber { get; set; }
        public string address { get; set; }
        public int MonthOfExperience { get; set; }
        public string WorkingDays { get; set; }
        public int QtyWeeklyWorkingHours { get; set; }
        public bool IsStudent { get; set; }
        public double salary { get; set; }
        public Positions EmployeesPosition { get; set; }
    }
}
