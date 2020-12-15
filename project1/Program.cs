using System;
using System.Collections.Generic;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestGenerateWord();
            CreateAddress();
            CreateCompany();
            CreateContactPerson();
            CreateDeliveryPlace();
            CreateCustomer();
            CreateDeliveryNote();
            CreateTransporter();
        }

        public static void TestGenerateWord()
        {
            // Test for Hashing...
            char c1 = 'C';
            int c1HashCode = c1.GetHashCode();
            Console.WriteLine("C1: " + c1HashCode);
            if('C'.GetHashCode().Equals(c1HashCode))
            {
                Console.WriteLine("OK!");
            } else {
                Console.WriteLine("NOK!");
            }
                       
            Console.WriteLine(Functions.GenerateWord(4,65,122));
        }

        public static Address CreateAddress()
        {
            Address a = new Address();
            a.AddressName = "MAR";
            a.AddressNote = "A-blok daar moet je zijn.";
            a.City = "Mariakerke";
            a.Country = "België";
            a.Number = "232";
            a.PostalCode = "9030";
            a.Street = "Industrieweg";
            return a;
        }

        public static ContactPerson CreateContactPerson()
        {
            ContactPerson cp = new ContactPerson();
            cp.FirstName = "Tim";
            cp.LastName = "Romi";
            cp.EmailAddress = "tim.talia@pizzaromi.shop";
            return cp;
        }

        public static Company CreateCompany()
        {
            Company c = new Company();
            c.Name = "Pizza Romi";
            c.Vat = "BE0123456789";
            c.EmailAddress = "gent@pizzaromi.shop";
            // ContactPerson
            ContactPerson cp = new ContactPerson();
            cp.FirstName = "Tim";
            cp.LastName = "Romi";
            cp.EmailAddress = "tim.talia@pizzaromi.shop";
            // Company Address.
            Address ca = new Address();
            ca = CreateAddress();
            // Mailing Address.
            Address ma = new Address();
            ma = CreateAddress();
            return c;
        }

        public static DeliveryPlace CreateDeliveryPlace()
        {
            // Create a delivery place.
            DeliveryPlace dp = new DeliveryPlace();
            dp.Name = "I232";
            // Create a address.
            Address address = new Address();
            address.AddressName = "MAR";
            address.AddressNote = "A-blok daar moet je zijn.";
            address.City = "Mariakerke";
            address.Country = "België";
            address.Number = "232";
            address.PostalCode = "9030";
            address.Street = "Industrieweg";
            dp.Place = address;
            return dp;
        }

        public static Customer CreateCustomer()
        {
            Customer c = new Customer();
            // Create a user.
            User u = new User();
            u.Name = "Krisra";
            u.EmailAddress = "krisra@arteveldehs.be";
            u.Password = "test123".GetHashCode();
            u.CreateTimestamp = DateTime.Now;
            c.User = u;
            c.Name = "Kristof Raes";
            // Create a delivery place.
            DeliveryPlace dp = new DeliveryPlace();
            dp.Name = "I232";
            // Create a address.
            Address address = new Address();
            address.AddressName = "MAR";
            address.AddressNote = "A-blok daar moet je zijn.";
            address.City = "Mariakerke";
            address.Country = "België";
            address.Number = "232";
            address.PostalCode = "9030";
            address.Street = "Industrieweg";
            dp.Place = address;
            List<DeliveryPlace> deliveryPlaces = new List<DeliveryPlace>();
            deliveryPlaces.Add(dp);
            c.DeliveryPlaces = deliveryPlaces;
            return c;
        }

        public static DeliveryNote CreateDeliveryNote()
        {
            // Create a delivery place.
            DeliveryNote dn = new DeliveryNote();
            dn.Note = "Liefst zo snel mogelijk leveren!";
            dn.Timestamp = DateTime.Now;
            // Create a user.
            User u = new User();
            u.Name = "Krisra";
            u.EmailAddress = "krisra@arteveldehs.be";
            u.Password = "test123".GetHashCode();
            u.CreateTimestamp = DateTime.Now;
            dn.User = u;
            return dn;
        }

        public static Transporter CreateTransporter()
        {
            // Create a transporter.
            Transporter t = new Transporter();
            return t;
        }
    }
}
