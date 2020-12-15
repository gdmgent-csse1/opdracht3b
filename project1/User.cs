using System;

namespace project1
{
    public class User
    {
        // Fields of the User class.
        private string name;
        private DateTime createTimestamp;
        private string emailAddress;
        //private string password;
        private int password;

        // Properties of the User class.
        public string Name { get => name; set => name = value; }
        public DateTime CreateTimestamp { get => createTimestamp; set => createTimestamp = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public int Password { get => password; set => password = value; }

        // Constructors of the User class.
        public User() { }

        public string GenerateNewPassword()
        {
            return "";
        }
    }
}