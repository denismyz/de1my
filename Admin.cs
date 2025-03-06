using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public sealed class Admin // (7) sealed - забороняє наслідування
    {
        private const string AdminPassword = "1234";

        // (3) 
        public string Name { get; set; }

        // (4) Конструктори
        public Admin() { }
        public Admin(string name)
        {
            Name = name;
        }

        // (5) Використання new для приховування методу
        public new void DisplayInfo()
        {
            Console.WriteLine($"Admin: {Name}");
        }

        // (6) Метод з base (якщо Admin наслідує User)
        public void AccessBaseMethod()
        {
            Console.WriteLine("Accessing base class method...");
        }
    }
}
