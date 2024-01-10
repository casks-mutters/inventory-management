// Order.cs

using System;
using System.Collections.Generic;

public class Order
{
    public int OrderID { get; set; }
    public List<Product> Products { get; set; }

    public Order(int orderId)
    {
        OrderID = orderId;
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void Display()
    {
        Console.WriteLine($"Order ID: {OrderID}");
        foreach (var product in Products)
        {
            product.Display();
        }
    }
}
