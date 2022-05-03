namespace TA_CoffeeShopDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //INIT and TESTING
            ShopMenu shopMenu = new ShopMenu();
            Customer testCustomer = new Customer("bigdog123", "Anya", "12345");
            Customer.Customers.Add(testCustomer);
            ShopUI ui = new ShopUI();
            ui.CurrentCustomer = testCustomer;

            ui.StartUI();




            /*
             * 
            testCustomer.Cart.Products.Add(new CartItem(shopMenu.Products[0], 4));
            testCustomer.Cart.Products.Add(new CartItem(shopMenu.Products[3], 1));
            testCustomer.Cart.Products.Add(new CartItem(shopMenu.Products[4], 3));
            testCustomer.Cart.Products.Add(new CartItem(shopMenu.Products[1], 1));

            Console.WriteLine("YOUR BILL: ");
            foreach (CartItem item in testCustomer.Cart.Products)
            {
                Console.WriteLine($"{item.Product.Name}: {item.Product.Price} X {item.Quantity}: {item.Product.Price * item.Quantity}");
                testCustomer.Cart.SubTotal += item.Product.Price;
            }

            Console.WriteLine($"\n\nTOTAL: {testCustomer.Cart.SubTotal}");
            
             */
        }
    }
}
