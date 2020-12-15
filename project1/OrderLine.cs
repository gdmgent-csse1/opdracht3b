namespace project1
{
    public class OrderLine
    {
        // Fields of the OrderLine class.
        private int numberOfProducts;
        private FoodItem foodProduct;
        private BeverageItem beverageProduct;
        private double lineAmount;

        // Properties of the OrderLine class.
        public int NumberOfProducts { get => numberOfProducts; set => numberOfProducts = value; }
        public FoodItem FoodProduct { get => foodProduct; set => foodProduct = value; }
        public BeverageItem BeverageProduct { get => beverageProduct; set => beverageProduct = value; }
        public double TotalAmount { get => lineAmount; set => lineAmount = value; }
        
        // Constructors of the OrderLine.
        public OrderLine() { }
    }
}