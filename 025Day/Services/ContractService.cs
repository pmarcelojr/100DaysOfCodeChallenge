using System;
using _025Day.Entities;

namespace _025Day.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double taxQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = taxQuota + _onlinePaymentService.PaymentFee(taxQuota);
                contract.AddInstallments(new Installment(date, fullQuota));
            }
        }
    }
}