// Order.cs

using System;
using System.Collections.Generic;

public class Order
{
    private int orderId;
    private List<Product> products;

    public Order(int orderId)
    {
        this.orderId = orderId;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void Display()
    {
        Console.WriteLine($"Order ID: {orderId}");
        Console.WriteLine("Products in order:");
        foreach (var product in products)
        {
            product.Display();
        }
    }
}
