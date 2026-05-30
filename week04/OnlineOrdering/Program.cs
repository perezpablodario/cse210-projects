using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("400N, 500E", "Orem", "Utah", "USA");
        Customer customer1 = new Customer("Jaasiel Perez", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Nike air Monarch", "S001", 85.00, 1);
        Product product2 = new Product("Sonoma Goods for Life", "S009", 27.99, 2);
        Product product3 = new Product("Shorts dry tek", "C001", 27.99, 1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Address address2 = new Address("Canova 65", "Salta", "Salta", "Argentina");
        Customer customer2 = new Customer("Pablo Perez", address2);
        Order order2 = new Order(customer2);

        Product product4 = new Product("Men's Nike 6-pack", "C010", 26.00, 1);
        Product product5 = new Product("JanSport Backpack", "B005", 67.00, 2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine("--- LIST OF ORDERS ---");
        Console.WriteLine("");

        Console.WriteLine("Order number 1");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total: {order1.CalculateTotalCost()}");

        Console.WriteLine("********************************************************************");

        Console.WriteLine("--- Order number 2 ---");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total: {order2.CalculateTotalCost()}");
    }
}