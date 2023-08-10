using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMarket_HT.DataBases;
using OnlineMarket_HT.Entities;
using OnlineMarket_HT.Interfaces;

// OnlineMarket servisidan foydalaning
//unda quyidagi konstruktor bo'lsin
//- OnlineMarket ( IPaymentProvider provider ) -bunda provider private readonly fieldga saqlansin

//unda quyidagi methodlar bo'lsin
//- Add ( product ) -productlar qatoriga berilgan productni qo'shsin ) 
//- Buy ( name, number, card ) -product lar ichidan berilgan nomdagi produktni berilgan sonda hisoblab, kartadan pul yechishni payment provider orqali amalga oshirsin

//- dasturda o'zingiz xohlagan payment provider ( KapitalUzcard, MillyHumo ) dan instance ( object ) yarating
//- OnlineMarket dan o'sha provider bilan instance yarating
//- Product dam bir nechta instance yarating va OnlineMarket ga qo'shing
//- o'zingiz xohlagan kartadan ( KapitalUzcard yoki MillyHumo ) instance yarating 
//- bir nechta produktlarni sotib olish operatsiyasini OnlineMarket orqali bajaring
//- kartada qolgan summani ekranga chiqaring


namespace OnlineMarket_HT.Services
{
    public class OnlineMarket : IOnlineMarket
    {
       
        public void AddProduct(Product product)
        {
            var dataBases = new Database();


            var checker = dataBases.products.FirstOrDefault(pr => pr.Name == product.Name);
            if (checker is not null)
            {
                throw new Exception("Product already exsits");
            }
            dataBases.products.Add(product);
        }

        public void BuyProduct(string name, int number, int cardNumber)
        {
            var dataBases = new Database();

            var product = dataBases.products.FirstOrDefault(p => p.Name == name);
            var card = dataBases.Uzcards.FirstOrDefault(cn => cn.CardNumber == cardNumber);

           
        }
    }
}
