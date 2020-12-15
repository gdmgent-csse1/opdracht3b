namespace project1
{
    public class Supplier
    {
        // Fields of the Supplier class.
        private string name;
        private Company company;
        private User adminUser;

        // Properties of the Supplier class.
        public string Name { get => name; set => name = value; }
        public Company Company { get => company; set => company = value; }
        public User AdminUser { get => adminUser; set => adminUser = value; }

        // Constructors of the Supplier class.
        public Supplier() { }
    }
}