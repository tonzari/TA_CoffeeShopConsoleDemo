public class Product
{
    public Product(string name, string category, decimal price)
    {
        Name = name;
        Category = category;
        Price = price;
    }

    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
}
