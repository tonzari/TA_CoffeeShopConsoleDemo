namespace TA_CoffeeShopDemo
{
    class Program
    {
        static ICustomerRepository _customerDB; // A single instance of the customer "database" to use across the program. Passed into UI.

        static void Main(string[] args)
        {
            _customerDB = new MockCustomerRepository();

            ShopUI ui = new ShopUI(_customerDB);
            ui.Start();
        }
    }
}


// TODO
/*
 * Consider moving to a State Machine. 
 * I think that each UI page could be a finite state.
 * Upon entering each state, do some housekeeping with the console design.
 * Consider a cursor to navigate the 'page'. The cursor behaviour can change depending on page state. 
 * 
 */
