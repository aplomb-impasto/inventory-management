// Program.cs

class Program
{
    static void Main()
    {
        // Create products
        Product product1 = new Product(1, "Laptop", 1200.0m);
        Product product2 = new Product(2, "Smartphone", 800.0m);

        // Create an order
        Order order = new Order(101);

        // Add products to the order
        order.AddProduct(product1);
        order.AddProduct(product2);

        // Display order details
        order.Display();
    }
}
