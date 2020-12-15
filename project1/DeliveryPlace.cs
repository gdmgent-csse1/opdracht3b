namespace project1
{
    public class DeliveryPlace
    {
        // Fields of the DeliveryPlace class.
        private string name;
        private Address place;

        // Properties of the DeliveryPlace class.
        public string Name { get => name; set => name = value; }
        public Address Place { get => place; set => place = value; }

        // Constructors of the DeliveryPlace class.
        public DeliveryPlace() { }
    }
}