using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class BankAccount 
    {
        // (3) Властивості
        public string CardNumber { get; set; }
        public decimal Balance { get; set; }

        // (4) Конструктори
        public BankAccount() { }
        public BankAccount(string cardNumber, decimal balance)
        {
            CardNumber = cardNumber;
            Balance = balance;
        }

        // (9) Віртуальний метод
        public virtual void ShowBalance()
        {
            Console.WriteLine($"Balance: {Balance}");
        }
    }
}
