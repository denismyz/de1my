using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class CreditCard : BankAccount // (2) Наслідування BankAccount
    {
        // (3) Властивості
        public bool IsBlocked { get; set; }

        // (4) Конструктори
        public CreditCard() { }
        public CreditCard(string cardNumber, decimal balance, bool isBlocked)
            : base(cardNumber, balance) // (6) Використання base
        {
            IsBlocked = isBlocked;
        }

        // (8) Перевизначений метод
        public override void ShowBalance()
        {
            if (IsBlocked)
                Console.WriteLine("Card is blocked.");
            else
                base.ShowBalance();
        }
    }
}
