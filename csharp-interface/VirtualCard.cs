using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_interface
{
    class VirtualCard : IPay
    {
        private List<Bank> _lstBank;

        public List<Bank> LstBank
        {
            get { return _lstBank; }
            set { _lstBank = value; }
        }


        private string _number;

        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }


        /// <summary>
        /// Interface Method : Payment
        /// </summary>
        public void Payment()
        {
            Console.WriteLine("VirtualCard Payment Operation / {0}", this.Number);
        }

        /// <summary>
        /// Interface Method : CancelPayment
        /// </summary>
        public void CancelPayment()
        {
            Console.WriteLine("VirtualCard Cancellation of Payment Operation / {0}", this.Number);
        }
        
    }
}
