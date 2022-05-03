using System;

class ShopUI
{
    public Customer CurrentCustomer { get; set; }

    public void StartUI()
    {
        WelcomePage();
        do
        {
            MainMenuPage();
        } while (true);
        
    }

    public void WelcomePage()
    {
        Console.WriteLine("Welcome to Bing Bong Coffee Shop!");
    }

    public void MainMenuPage()
    {
        Console.WriteLine("[1] Login");
        Console.WriteLine("[2] Create an account");
        Console.WriteLine("[3] Exit");

        switch (Int32.Parse(Console.ReadLine()))
        {
            case 1:
                LoginPage();
                break;
            case 2:
                CreateAccountPage();
                break;
            case 3:
                ExitPage();
                break;
        };
    }

    public void CreateAccountPage()
    {
        Console.Clear();
        Console.WriteLine("CREATE ACCOUNT PAGE\n");

        Console.WriteLine("Create username: ");
        string newUsername = Console.ReadLine();

        Console.WriteLine("Enter first name: ");
        string newFirstname = Console.ReadLine();

        Console.WriteLine("Create password: ");
        string newPassword = Console.ReadLine();

        Customer NewCustomer = new Customer(newUsername, newFirstname, newPassword);
        Customer.Customers.Add(NewCustomer);
    }

    public void LoginPage()
    {
        Console.Clear();
        Console.WriteLine("LOGIN PAGE\n");

        Console.WriteLine("Enter your username: ");
        string username = Console.ReadLine();

        Console.WriteLine("Enter your password: ");
        string password = Console.ReadLine();

        Customer userMatch = Customer.Customers.Find(c => c.Username == username);

        if (userMatch != null && password == userMatch.Password)
        {
            ShopMenuPage();
        }
        else
        {
            Console.WriteLine("Sorry, invalid credintials.");
        }
    }

    public void ShopMenuPage()
    {
        Console.Clear();
        Console.WriteLine("======= OUR MENU =======");
        foreach (Product product in ShopMenu.Products)
        {
            Console.WriteLine($"{product.Name}........{product.Price}");
        }
        Console.WriteLine("\n");
        
    }

    public void ExitPage()
    {
        Console.Clear();
        Console.WriteLine("Goodbye! Exiting app...");
        Environment.Exit(0);
    }


    //Once logged in, provide menu options:
    //  1. Place an order (print menu and allow add to cart option),
    //  2. See Shopping Cart
    //  3. Exit (stretch goal: see purchase history)
}
