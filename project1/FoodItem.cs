namespace project1
{
    public class FoodItem
    {
        // Fields of the FoodItem class.
        private string name;
        private string size;
        private double price;

        // Properties of the FoodItem class.
        public string Name { get => name; set => name = value; }
        public string Size { get => size; set => size = value; }
        public double Price { get => price; set => price = value; }

        // Constructors of the FoodItem class.
        public FoodItem() { }
    }
}