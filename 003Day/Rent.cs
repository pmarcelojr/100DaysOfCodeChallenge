using System;

namespace _003Day
{
    class Rent
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Rent(string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}