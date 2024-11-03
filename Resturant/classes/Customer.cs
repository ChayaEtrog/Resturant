namespace Resturant.classes
{
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhonNumber { get; set; }
        public string address { get; set; }
        public bool IsMemberShip { get; set; }
        public bool IsGlutenFree { get; set; }
        public bool IsVegetarian { get; set; }
        public DateTime DateJoinigClub { get; set; }
    }
}
