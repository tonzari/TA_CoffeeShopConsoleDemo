using System.Collections.Generic;

public class Customer
{
    public Customer(string username, string firstName, string password)
    {
        Username = username;
        FirstName = firstName;
        Password = password;
        Cart = new ShoppingCart();
    }

    public string Username { get; set; }
    public string FirstName { get; set; }
    public string Password { get; set; }
    public ShoppingCart Cart { get; set; }
}