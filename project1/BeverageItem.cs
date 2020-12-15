namespace project1
{
    public class BeverageItem
    {
        // Fields of the BeverageItem class.
        private string name;
        private string content;
        private double price;

        // Properties of the BeverageItem class.
        public string Name { get => name; set => name = value; }
        public string Content { get => content; set => content = value; }
        public double Price { get => price; set => price = value; }

        // Constructors of the BeverageItem class.
        public BeverageItem() { }
    }
}