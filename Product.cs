// Product.cs

using System;

public class Product
{
    public int ProductID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(int id, string productName, double productPrice)
    {
        ProductID = id;
        Name = productName;
        Price = productPrice;
    }

    public void Display()
    {
        Console.WriteLine($"Product ID: {ProductID}, Name: {Name}, Price: ${Price}");
    }
}
