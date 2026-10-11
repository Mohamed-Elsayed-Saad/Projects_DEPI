namespace CashierSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Apple", Price = 150 },
                new Product { Id = 2, Name = "Banana", Price = 100 },
                new Product { Id = 3, Name = "Orange", Price = 50 },
                new Product { Id = 4, Name = "Mango", Price = 200 },
                new Product { Id = 5, Name = "Grapes", Price = 250 },
                new Product { Id = 6, Name = "Pineapple", Price = 300 },
                new Product { Id = 7, Name = "Strawberry", Price = 400 },
                new Product { Id = 8, Name = "Watermelon", Price = 500 },
                new Product { Id = 9, Name = "Papaya", Price = 600 },
                new Product { Id = 10, Name = "Kiwi", Price = 700 }
            };
            //--------------------------------
            Cashier cashier = new Cashier();
            cashier.AddProductToCart(products[0]);
            cashier.AddProductToCart(products[1]);
            cashier.AddProductToCart(products[2]);
            IDiscount discount = new DiscountVip();
            IPayment payment = new VisaPayment();
            ReceiptService receiptService = new ReceiptService();
            var receipt = receiptService.GenerateReceipt("Ahmed", discount, payment, cashier.Cart);
             receipt.PrintReceipt();
            //-------------------------------------
            Console.WriteLine("============================================");
            Console.WriteLine("cashier02");
            Cashier cashier02 = new Cashier();
            cashier02.AddProductToCart(products[5]);
            cashier02.AddProductToCart(products[3]);
            cashier02.AddProductToCart(products[9]);
            IDiscount discountPre = new DiscountPremium();
            IPayment paymentMaster = new MasterCardPayment();
            ReceiptService receiptService02 = new ReceiptService();
            var receipt02 = receiptService.GenerateReceipt("Ali", discountPre, paymentMaster, cashier02.Cart);
            receipt02.PrintReceipt();

        }
    }
}
