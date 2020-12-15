using System.Collections.Generic;

namespace project1
{
    public class BeverageSupplier : Supplier
    {
        // Fields of the BeverageSupplier class.
        private List<BeverageItem> pricelist;

        // Properties of the BeverageSupplier class.
        public List<BeverageItem> Pricelist { get => pricelist; set => pricelist = value; }

        // Constructors of the BeverageSupplier.
        public BeverageSupplier() { }
    }
}