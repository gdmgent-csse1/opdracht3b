namespace project1
{
    public class ContactPerson
    {
        // Fields of the ContactPerson class.
        private string firstName;
        private string lastName;
        private string emailAddress;

        // Properties of the ContactPerson class.
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }

        // Constructors of the ContactPerson class.
        public ContactPerson() { }
    }
}