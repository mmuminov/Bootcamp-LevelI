//IDebitCard interfeysidan foydalaning

//unda quyidagi propertylar bo'lsin
//- CardNumber - karta raqami
//- BankName - bank nomi ( init only )
//-Balance - hozirgi kartadagi balans

//quyidagi modellar IDebitCard ni implement qilgan bo'lsin

//- KapitalUzcard
//- MillyHumo

using OnlineMarket_HT.Interfaces;

namespace OnlineMarket_HT.Cards
{
    public class KapitalUzcard : IDebitCard
    {
        public int CardNumber { get; set; }
        public string BankName { get; init; }
        public double Balance { get; set; }

        public KapitalUzcard(int cardNumber, string bankName, double balance)
        {
            CardNumber = cardNumber;
            BankName = bankName;
            Balance = balance;
        }
    }


}



