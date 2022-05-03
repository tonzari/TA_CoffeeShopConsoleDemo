using System.Collections.Generic;

class ShoppingCart
{
    public List<CartItem> Products = new List<CartItem>();
    public decimal SubTotal { get; set; }
    public decimal Tax { get; set; }
    public decimal Total { get; set; }
}
