using System.Collections.Generic;

namespace project1
{
    public class Platform
    {
        // Fields of the Platform class.
        private string platformName;
        private string website;
        private Company platformCompany;
        private List<BeverageSupplier> beverageSuppliers;
        private List<FoodSupplier> foodSuppliers;
        private List<Order> orders;

        // Properties of the Platform class.
        public string PlatformName { get => platformName; set => platformName = value; }
        public string Website { get => website; set => website = value; }
        public Company PlatformCompany { get => platformCompany; set => platformCompany = value; }
        public List<FoodSupplier> FoodSuppliers { get => foodSuppliers; set => foodSuppliers = value; }
        public List<BeverageSupplier> BeverageSuppliers { get => beverageSuppliers; set => beverageSuppliers = value; }
        public List<Order> Orders { get => orders; set => orders = value; }

        // Constructor of the Platform class.
        public Platform() {}
    }
}