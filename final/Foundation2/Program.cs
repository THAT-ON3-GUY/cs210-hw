using System;

class Program
{
    static void Main(string[] args)
    {
        Order order = new Order(new Customer("John Doe", new Address("123 Main St", "Anytown", "CA", "United States")));
        Product product1 = new Product("Laptop", 1, 999.99, 1);
        Product product2 = new Product("Mouse", 2, 29.99, 2);
        order.AddProduct(product1);
        order.AddProduct(product2);
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():F2}");
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------");

        Order order2 = new Order(new Customer("Jane Smith", new Address("456 Elm St", "Othertown", "ON", "Canada")));
        Product product3 = new Product("Keyboard", 3, 49.99, 1);
        Product product4 = new Product("Monitor", 4, 199.99, 1);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
    }
}