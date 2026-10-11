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
    public class VisaPayment : IPayment
    {
        public decimal Pay(decimal total)
        {
            return total;
        }
    }
    public class WalletPayment : IPayment
    {
        public decimal Pay(decimal total)
        {
            return total;
        }
    }
    public class MasterCardPayment : IPayment
    {
        public decimal Pay(decimal total)
        {
            return total;
        }
    }
}
