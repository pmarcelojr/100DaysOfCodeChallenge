using System;

namespace _003Day
{
    class Rent
    {
        private string _nome; 
        public string Email { get; set; }

        public Rent(string nome, string email)
        {
            _nome = nome;
            Email = email;
        }

        public string Nome 
        {
            get { return _nome; }
            set {
                if(value != null && value.Length > 2)
                    _nome = value;
            }
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}