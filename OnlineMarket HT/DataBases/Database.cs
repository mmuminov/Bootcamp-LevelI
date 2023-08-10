using OnlineMarket_HT.Cards;
using OnlineMarket_HT.Entities;

namespace OnlineMarket_HT.DataBases
{
    public  class Database
    {

        public  List<KapitalUzcard> Uzcards = new List<KapitalUzcard>()
        {
             new KapitalUzcard(1234,"Halq Bank", 34000000),
        };

        public  List<MillyHumo> HumoCards = new List<MillyHumo>()
        {
            new MillyHumo(2345,"Milliy Bank", 50000) 
        };

        public  List<Product> products = new List<Product>()
        {
             new Product(1,"Iphone 14",1200.0,5)
        };



    }
}
