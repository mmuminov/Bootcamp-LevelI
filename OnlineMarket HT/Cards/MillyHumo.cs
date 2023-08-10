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
    public class MillyHumo : IDebitCard
    {
        public int CardNumber { get; set; }
        public string BankName { get; init; }
        public int Balance { get; set; }

        public MillyHumo(int cardNumber, string bankName, int balance)
        {
            CardNumber = cardNumber;
            BankName = bankName;
            Balance = balance;
        }
    }


}



