// InventoryManager.cs

using System;
using System.Collections.Generic;

public class InventoryManager
{
    public List<Product> Products { get; private set; }
    public List<Order> Orders { get; private set; }

    public InventoryManager()
    {
        Products = new List<Product>();
        Orders = new List<Order>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void CreateOrder(Order order)
    {
        Orders.Add(order);
    }

    public void DisplayProducts()
    {
        Console.WriteLine("Available Products:");
        foreach (var product in Products)
        {
            product.Display();
        }
    }

    public void DisplayOrders()
    {
        Console.WriteLine("Order History:");
        foreach (var order in Orders)
        {
            order.Display();
        }
    }
}
