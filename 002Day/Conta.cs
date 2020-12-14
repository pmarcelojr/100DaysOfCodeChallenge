using System;
using System.Globalization;

namespace _002Day
{
    class Conta
    {
        private string _nome;
        private double _saldo;
        public int _numConta { get; private set; }

        public Conta(){
        }
        public Conta(string nome, double saldo, int numConta)
        {
            this._nome = nome;
            this._saldo = saldo;
            this._numConta = numConta;
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public override string ToString()
        {
            return "Conta " + _numConta + ", Titular: " + _nome + ", Saldo: R$ "
                + _saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}