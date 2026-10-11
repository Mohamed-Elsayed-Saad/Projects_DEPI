using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierSystem
{
    public interface IDiscount
    {
        public decimal ApplyDiscount(decimal total);
    }
    public class DiscountUser : IDiscount
    {
        public decimal ApplyDiscount(decimal total)
        {
            var t= total - (total *( 20m / 100m));
            return t;
        }
    }
    public class DiscountVip : IDiscount
    {
        public decimal ApplyDiscount(decimal total)
        {
            var t= total - (total *( 35m / 100m));
            return t;
        }
    }
    public class DiscountPremium : IDiscount
    {
        public decimal ApplyDiscount(decimal total)
        {
            var t= total - (total *( 50m / 100m));
            return t;
        }
    }
}
