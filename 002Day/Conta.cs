using System;
using System.Globalization;

namespace _002Day
{
    class Conta
    {
        private string _nome;
        public double Saldo { get; private set; }
        public int NumConta { get; private set; }

        public Conta(){
        }
        public Conta(string nome, double saldo, int numConta)
        {
            this._nome = nome;
            this.Saldo = saldo;
            this.NumConta = numConta;
        }

        public string Nome
        {
            get { return _nome; }
            set { 
                if(value != null && value.Length > 2)
                    _nome = value; 
            }
        }
        // public double Saldo
        // {
        //     get { return _saldo; }
        //     set { _saldo = value; }
        // }

        public double Depositar(double a)
        {
            return Saldo += a;
        }

        public override string ToString()
        {
            return "Conta " + NumConta + ", Titular: " + Nome + ", Saldo: R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}