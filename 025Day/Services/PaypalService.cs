namespace _025Day.Services
{
    class PaypalService : IOnlinePaymentService
    {
        private const double TaxPaymentFee = 0.02;
        private const double TaxInterest = 0.01;
        public double Interest(double amount, int months)
        {
            return amount * TaxInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * TaxPaymentFee;
        }
    }
}