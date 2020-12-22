using System;

namespace _009Day.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }

        public Client()
        {
        }
        public Client(string name, string email, DateTime date)
        {
            Name = name;
            Email = email;
            Date = date;
        }
    }
}