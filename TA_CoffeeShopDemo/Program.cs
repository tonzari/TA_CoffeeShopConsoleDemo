namespace TA_CoffeeShopDemo
{
    class Program
    {
        static ICustomerRepository _customerRepository;
        static void Main(string[] args)
        {
            _customerRepository = new MockCustomerRepository();

            ShopMenu shopMenu = new ShopMenu();
            ShopUI ui = new ShopUI(_customerRepository);

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
