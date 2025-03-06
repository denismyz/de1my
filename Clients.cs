using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Client // (1) Визначаємо клас Client
    {
        // (3) Властивості з get та set
        public string Name { get; set; }
        public BankAccount Account { get; set; }

        // (4) Конструктори
        public Client() { }  // Без параметрів
        public Client(string name, BankAccount account) // З параметрами
        {
            Name = name;
            Account = account;
        }

        // (9) Віртуальний метод (для перевизначення в майбутньому)
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Client: {Name}, Card Number: {Account.CardNumber}, Balance: {Account.Balance}");
        }
    }
}
