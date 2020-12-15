using System;

namespace project1
{
    public class DeliveryNote
    {
        // Fields of the DeliveryNote class.
        private string note;
        private DateTime timestamp;
        private User user;

        // Properties of the DeliveryNote class.
        public string Note { get => note; set => note = value; }
        public DateTime Timestamp { get => timestamp; set => timestamp = value; }
        public User User { get => user; set => user = value; }


        // Constructors of the DeliveryNote class.
        public DeliveryNote() { }
    }
}