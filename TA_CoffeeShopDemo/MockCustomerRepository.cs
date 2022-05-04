using System.Collections.Generic;
using System.Linq;

public class MockCustomerRepository : ICustomerRepository
{
    public MockCustomerRepository()
    {
        AllCustomers = new List<Customer>
        {
            new Customer("bigdog123", "Anya", "12345"),
            new Customer("admin", "admin","password")
        };
    }

    public List<Customer> AllCustomers { get; set; }

    public Customer GetCustomerByUsername(string username)
    {
        return AllCustomers.FirstOrDefault(user => user.Username == username);
    }

    public void CreateCustomer(Customer customer)
    {
        AllCustomers.Add(customer);
    }

}