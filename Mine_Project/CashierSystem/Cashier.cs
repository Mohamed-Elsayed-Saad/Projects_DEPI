using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierSystem
{
    public class Cashier
    {
        public Cart Cart { get;  set; } = new Cart();
        public void AddProductToCart(Product product)
        {
            Cart.AddProduct(product);
        }
        public decimal CalculateTotal()
        {
            return Cart.CalculateTotal();
        }
        
        public decimal CalculateFinalTotal(IDiscount discount)
        {
            var total = Cart.CalculateTotal();
            return discount.ApplyDiscount(total);
        }
        public decimal Pay(decimal total, IPayment payment)
        {
            return payment.Pay(total);
        }
    }
}
