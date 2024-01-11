// Product.cs

using System;

public class Product
{
    private int productId;
    private string productName;
    private decimal price;

    public Product(int productId, string productName, decimal price)
    {
        this.productId = productId;
        this.productName = productName;
        this.price = price;
    }

    public void Display()
    {
        Console.WriteLine($"Product ID: {productId}, Name: {productName}, Price: {price:C}");
    }
}
