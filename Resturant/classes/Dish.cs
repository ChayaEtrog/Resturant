namespace Resturant.classes
{
    public enum DishType{FIRSTCOURSE,MAINCOURSE,DESSERT,LIGHTDISH };

    public class Dish
    {
        static int id = 1;
        public int Id { get;private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DishType Type { get; set; }
        public string Ingredients { get; set; }
        public int Calories { get; set; }
        public bool IsGlutenFree { get; set; }
        public bool IsVegetarian { get; set; }

        public Dish(int id,Dish other)
        {
            Id = id;
            Name = other.Name;
            Description = other.Description;
            Price = other.Price;
            Type = other.Type;
            Ingredients = other.Ingredients;
            Calories = other.Calories;
            IsGlutenFree = other.IsGlutenFree;
            IsVegetarian = other.IsVegetarian;
        }

        public Dish(Dish other)
        {
            Id = id;
            id++;
            Name = other.Name;
            Description = other.Description;
            Price = other.Price;
            Type = other.Type;
            Ingredients = other.Ingredients;
            Calories = other.Calories;
            IsGlutenFree = other.IsGlutenFree;
            IsVegetarian = other.IsVegetarian;
        }
        public Dish()
        {

        }
    }
}
