using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_interface;

namespace csharp_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank() {Name = "HSBC" };

            CreditCard creditCard = new CreditCard() { bank = bank, Number = "1234567890123456" };
            CreditCard creditCard2 = new CreditCard() { bank = bank, Number = "111111111111111" };
            creditCard.Payment();
            creditCard.CancelPayment();

            VirtualCard virtualCard = new VirtualCard() { Number = "111111111111111" };
            virtualCard.Payment();
            virtualCard.CancelPayment();


            Console.WriteLine("CreditCard CompareTo: {0}", creditCard.CompareTo(creditCard2.Number));
            Console.WriteLine("CreditCard Equals: {0}", creditCard.Equals(creditCard2.Number));

            Console.ReadLine();
        }
    }
}
