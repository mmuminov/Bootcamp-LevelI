using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMarket_HT.Interfaces;

//PaymePaymentProvider tipini yarating, unda IPaymentProvider interfeysini implement qiling

namespace OnlineMarket_HT.Services
{
    public class PaymePaymentProvider : IPaymentProvider
    {
        public void Transfer(int LocalCardNumber, int DestinationCard, double PaymentSum)
        {
            throw new NotImplementedException();
        }
    }
}
