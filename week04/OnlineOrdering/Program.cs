using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("250 West 200 South", "Springville", "UT", "USA");
        Customer customer1 = new Customer("Maggie McCausland", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("portable charger", "010-0000", 55.99, 2));
        order1.AddProduct(new Product("MacBook Laptop", "010-0001", 899.99, 1));
        order1.AddProduct(new Product("HP Printer", "010-0002", 549.99, 1));

        Console.WriteLine("------- ORDER 1 -------");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\n{order1.GetPackingLabel()}");
        Console.WriteLine($"Order Total: ${order1.GetTotalCost()}");



        Address address2 = new Address("100 Main Street", "Mataro", "Barcelona", "Spain");
        Customer customer2 = new Customer("Lucas Fernandez", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Notebook", "020-0220", 15.99, 1));
        order2.AddProduct(new Product("Crock-Pot", "010-0035", 59.99, 1));
        order2.AddProduct(new Product("No Show Socks", "030-0016", 12.99, 2));

        Console.WriteLine("\n------- ORDER 2 -------");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\n{order2.GetPackingLabel()}");
        Console.WriteLine($"ORDER TOTAL: ${order2.GetTotalCost()}");
    }
}