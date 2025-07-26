using System;

class Program
{
    static void Main(string[] args)
    {
        // First Order - USA customer
        Address address1 = new Address("123 Apple St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LPT123", 799.99, 1));
        order1.AddProduct(new Product("Mouse", "MSE456", 25.50, 2));

        // Second Order - International customer
        Address address2 = new Address("456 Mango Rd", "Accra", "Greater Accra", "Ghana");
        Customer customer2 = new Customer("Kwame Mensah", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Smartphone", "SPH789", 599.99, 1));
        order2.AddProduct(new Product("Earbuds", "EAR101", 49.99, 2));

        // Display for Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}\n");

        // Display for Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}");
    }
}
