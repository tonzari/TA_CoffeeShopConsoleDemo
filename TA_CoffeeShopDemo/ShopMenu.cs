using System.Collections.Generic;

public class ShopMenu
{
    public static List<Product> Products = new List<Product>()
    {
        new Product("Espresso","beverage",1.99M),
        new Product("Latte","beverage",3.99M),
        new Product("Americano","beverage",1.99M),
        new Product("Macchiato","beverage",2.99M),
        new Product("Cappuccino","beverage",3.99M),
        new Product("Cortado","beverage",2.99M),
        new Product("Croissant","food",1.99M),
        new Product("Yogurt Parfait","food",3.99M),
        new Product("Water","beverage",0.99M),
        new Product("Gift Card","gift",15.00M)
    };
}