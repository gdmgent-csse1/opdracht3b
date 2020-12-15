namespace project1
{
    public class Company
    {
        // Fields of the Company class.
        string name;
        string vat;
        Address companyAddress;
        Address mailingAddress;
        string emailAddress;
        ContactPerson director;

        // Properties of the Company class.
        public string Name { get => name; set => name = value; }
        public string Vat { get => vat; set => vat = value; }
        public Address CompanyAddress { get => companyAddress; set => companyAddress = value; }
        public Address MailingAddress { get => mailingAddress; set => mailingAddress = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public ContactPerson Director { get => director; set => director = value; }

        // Constructors of the Company class.
        public Company() { }
    }
}