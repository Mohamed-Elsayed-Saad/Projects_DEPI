using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierSystem
{
    public interface IPayment
    {
        public decimal Pay(decimal total);
        
    }
    public class CashPayment : IPayment
    {
        public decimal Pay(decimal total)
        {
            return total;
        }
    }
    // Class that implements Visa card payment
    public class VisaPayment : IPayment
    {
        public decimal Pay(decimal total)
        {
            return total;
        }
    }
     // Class that implements digital wallet payment
    public class WalletPayment : IPayment
    {
        public decimal Pay(decimal total)
        {
            return total;
        }
    }
      // Class that implements MasterCard payment
    public class MasterCardPayment : IPayment
    {
        public decimal Pay(decimal total)
        {
            return total;
        }
    }
}
