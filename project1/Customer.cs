using System.Collections.Generic;

namespace project1
{
    public class Customer
    {
        // Fields of the Customer class.
        private string name;
        private User user;
        private List<DeliveryPlace> deliveryPlaces;

        // Properties of the Customer class.
        public string Name { get => name; set => name = value; }
        public User User { get => user; set => user = value; }
        public List<DeliveryPlace> DeliveryPlaces { get => deliveryPlaces; set => deliveryPlaces = value; }

        // Constructors of the Customer class.
        public Customer() { }
    }
}