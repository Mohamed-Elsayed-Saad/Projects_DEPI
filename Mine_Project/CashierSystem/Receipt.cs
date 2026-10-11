using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierSystem
{
    public class Receipt
    {
        public string Name { get; set; } = default!;
        public decimal TotalBeforeDiscount { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalAfterDiscount { get; set; }
        public IPayment Payment { get; set; } = default!;
        public void PrintReceipt()
        {
            Console.WriteLine($"Receipt for {Name}");
            Console.WriteLine($"Total : {TotalBeforeDiscount}");
            Console.WriteLine($"Discount : {Discount}");
            Console.WriteLine($"Total after discount : {TotalAfterDiscount}");
            Console.WriteLine($"Payment Method : {Payment.GetType().Name}");
        }
    }
}
