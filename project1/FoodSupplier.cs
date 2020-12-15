using System.Collections.Generic;

namespace project1
{
    public class FoodSupplier : Supplier
    {
        // Fields of the FoodSupplier class.
        private List<FoodItem> pricelist;

        // Properties of the FoodSupplier class.
        public List<FoodItem> Pricelist { get => pricelist; set => pricelist = value; }

        // Constructors of the FoodSupplier.
        public FoodSupplier() { }
    }
}