using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Customer customer1 = new Customer(0);
        Product prod1a = new Product(0);
        prod1a.SetQuantity(1);
        Product prod1b = new Product(1);
        prod1b.SetQuantity(2);

        Order order1 = new Order(customer1);
        order1.AddProduct(prod1a);
        order1.AddProduct(prod1b);

        Customer customer2 = new Customer(1);
        Product prod2a = new Product(3);
        prod2a.SetQuantity(1);
        Product prod2b = new Product(4);
        prod2b.SetQuantity(1);

        Order order2 = new Order(customer2);
        order2.AddProduct(prod2a);
        order2.AddProduct(prod2b);

        Console.WriteLine("******** ORDER 1 ********");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("-------------------------------");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");
        Console.WriteLine("-------------------------------");


        Console.WriteLine("******** ORDER 2 ********");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("-------------------------------");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
        Console.WriteLine("-------------------------------");

    }
}