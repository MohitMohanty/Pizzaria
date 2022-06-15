namespace Pizzeria.Models
{
    public class PizzasModel
    {
        public string ImageTitle { get; set; }
        public string PizzaName { get; set; }
        public float BasePrice { get; set; } = 100;
        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Peporoni { get; set; }
        public bool Mushroom { get; set; }
        public bool Tuna { get; set; }
        public bool Pineapple { get; set; }
        public bool Chicken { get; set; }
        public bool Paneer { get; set; }
        public float FinalPrice { get; set; }
    }
}
