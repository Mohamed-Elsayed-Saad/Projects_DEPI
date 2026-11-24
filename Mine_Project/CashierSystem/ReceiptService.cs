using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierSystem
{
    
    public class ReceiptService
    {
        public Receipt GenerateReceipt(string name, IDiscount discount, IPayment payment ,Cart cart)
        {
            var total = cart.CalculateTotal();
            var discountedTotal = discount.ApplyDiscount(total);
            return new Receipt
            {
                Name = name,
                TotalBeforeDiscount = total,
                Discount = total - discountedTotal,
                TotalAfterDiscount = discountedTotal,
                Payment = payment
            };
        }
    }
}
