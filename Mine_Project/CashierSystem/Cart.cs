using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierSystem
{
    public class  Cart
    {
        List<Product> products = new List<Product>();
        // Calculates the total price of all products in the cart.

        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (var product in products)
            {
                total += product.Price;
            }
            return total;
        }
    }
}
