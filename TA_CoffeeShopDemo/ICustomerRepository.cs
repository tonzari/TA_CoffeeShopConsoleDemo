using System.Collections.Generic;

public interface ICustomerRepository
{
    List<Customer> AllCustomers { get; set; }

    public Customer GetCustomerByUsername(string username);

    public void CreateCustomer(Customer customer);
}
