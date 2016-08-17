using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_interface
{
    class CreditCard : IPay, IComparable, IEquatable<string>
    {
        private string _number;

        /// <summary>
        /// 16 digits CreditCard Number
        /// </summary> 
        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }

        private Bank _bank;

        public Bank bank
        {
            get { return _bank; }
            set { _bank = value; }
        }

        /// <summary>
        /// Interface Method : Payment
        /// </summary>
        public void Payment()
        {
            Console.WriteLine("Payment Operation / {0},{1}", this.Number, this._bank.Name);
        }

        /// <summary>
        /// Interface Method : CancelPayment
        /// </summary>
        public void CancelPayment()
        {
            Console.WriteLine("Cancellation of Payment Operation / {0},{1}", this.Number, this._bank.Name);
        }

        public int CompareTo(object obj)
        {
            if (this.Number == obj.ToString())
                return 0;
            return -1;
        }

        public bool Equals(string other)
        {
            return this.Number.Equals(other);
        }
    }
}
