namespace Resturant.classes
{
    public class Customer
    {
        static int id = 1;
        public int Id { get;private set; }
        public string Tz { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhonNumber { get; set; }
        public string Address { get; set; }
        public bool IsMemberShip { get; set; }
        public bool IsGlutenFree { get; set; }
        public bool IsVegetarian { get; set; }
        public DateTime DateJoinigClub { get; set; }

        public Customer(int id, Customer other)
        {
            Id = id;
            Tz = other.Tz;
            Name = other.Name;
            Email = other.Email;
            PhonNumber = other.PhonNumber;
            Address = other.Address;
            IsMemberShip = other.IsMemberShip;
            IsGlutenFree = other.IsGlutenFree;
            IsVegetarian = other.IsVegetarian;
            DateJoinigClub = other.DateJoinigClub;
        }

        public Customer(Customer other)
        {
            Id = id;
            id++;
            Tz = other.Tz;
            Name = other.Name;
            Email = other.Email;
            PhonNumber = other.PhonNumber;
            Address = other.Address;
            IsMemberShip = other.IsMemberShip;
            IsGlutenFree = other.IsGlutenFree;
            IsVegetarian = other.IsVegetarian;
            DateJoinigClub = other.DateJoinigClub;
        }

        public Customer()
        {

        }

        public Customer( string tz, string name, string email, string phonNumber, string address, bool isMemberShip, bool isGlutenFree, bool isVegetarian, DateTime dateJoinigClub)
        {
            Id = id;
            id++;
            Tz = tz;
            Name = name;
            Email = email;
            PhonNumber = phonNumber;
            Address = address;
            IsMemberShip = isMemberShip;
            IsGlutenFree = isGlutenFree;
            IsVegetarian = isVegetarian;
            DateJoinigClub = dateJoinigClub;
        }
    }
}
