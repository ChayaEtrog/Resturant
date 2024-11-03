namespace Resturant.classes
{
    public enum DishType{FIRSTCOURSE,MAINCOURSE,DESSERT,LIGHTDISH };

    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DishType Type { get; set; }
        public string Ingredients { get; set; }
        public int Calories { get; set; }
        public bool IsGlutenFree { get; set; }
        public bool IsVegetarian { get; set; }
    }
}
