namespace project1
{
    public class Address
    {
        // Fields of the Address class.
        private string addressName;
        private string street;
        private string number;
        private string postalCode;
        private string city;
        private string country;
        private string addressNote;

        // Properties of the Address class.
        public string AddressName { get => addressName; set => addressName = value; }
        public string Street { get => street; set => street = value; }
        public string Number { get => number; set => number = value; }
        public string PostalCode { get => postalCode; set => postalCode = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }
        public string AddressNote { get => addressNote; set => addressNote = value; }

        // Constructors of the Address class.
        public Address() { }
    }
}