using OnlineMarket_HT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket_HT.Interfaces
{
    public interface IOnlineMarket
    {
        public void BuyProduct(string name, int number, int card);
        public void AddProduct(Product product);

    }
}
