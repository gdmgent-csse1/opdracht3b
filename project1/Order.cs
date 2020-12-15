using System;
using System.Collections.Generic;

namespace project1
{
    public class Order
    {
        // Fields of the Order class.
        private Supplier supplier;
        private Customer customer;
        private DateTime orderDate;
        private DateTime deliveryDate;
        private double totalAmount;
        private List<OrderLine> orderLines;

        // Properties of the Order class.
        public Supplier Supplier { get => supplier; set => supplier = value; }
        public Customer Customer { get => customer; set => customer = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        public DateTime DeliveryDate { get => deliveryDate; set => deliveryDate = value; }
        public double TotalAmount { get => totalAmount; set => totalAmount = value; }
        public List<OrderLine> OrderLines { get => orderLines; set => orderLines = value; }

        // Constructors of the Order.
        public Order() { }

        
    }
}