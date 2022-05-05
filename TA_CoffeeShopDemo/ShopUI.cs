using System;

public class ShopUI
{
    static ICustomerRepository _customerRepository;
    public ShopUI(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public Customer CurrentCustomer { get; set; }

    public void Start()
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
        PrintNavigation();

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

    private static void PrintNavigation()
    {
        Console.WriteLine(String.Format("{0,5} {1,5} {2,5}", "[1] Login", "[2] Create an account", "[3] Exit"));
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

        Customer newCustomer = new Customer(newUsername, newFirstname, newPassword);
        _customerRepository.CreateCustomer(newCustomer);
    }

    public void LoginPage()
    {
        Console.Clear();
        Console.WriteLine("LOGIN PAGE\n");

        Console.WriteLine("Enter your username: ");
        string username = Console.ReadLine();

        Console.WriteLine("Enter your password: ");
        string password = Console.ReadLine();

        Customer userMatch = _customerRepository.GetCustomerByUsername(username);

        if (userMatch != null && password == userMatch.Password)
        {
            CurrentCustomer = userMatch;
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

    public void PrintReceipt()
    {
        Console.WriteLine("YOUR BILL: ");
        foreach (CartItem item in CurrentCustomer.Cart.Products)
        {
            Console.WriteLine($"{item.Product.Name}: {item.Product.Price} X {item.Quantity}: {item.Product.Price * item.Quantity}");
            CurrentCustomer.Cart.SubTotal += item.Product.Price;
        }

        Console.WriteLine($"\n\nTOTAL: {CurrentCustomer.Cart.SubTotal}");
    }
}
