using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Address a1 = new Address("500 N Courtview", "Provo","Utah", "USA" );
        // Address a2 = new Address("500e 1234n", "Lehi", "UT", "USA");
        // Address a3 = new Address("500 N Sinjeong", "Yangchun","Seoul", "Korea" );
        // Address a4 = new Address("500 N Courtview", "Provo","Utah", "USA" );
        Customer c1 = new Customer("Suzan Molly", a1 );


        Product p1 = new Product("RootBeer", "aslkqo", 1.25, 4);
        Product p2 = new Product("Ham", "Assi", 3.55, 1);
        Product p3 = new Product("Gojujang", "Medow", 4.99, 2);
        Product p4 = new Product("chess", "sume", 4.99, 2);


        Order o1 = new Order(c1);

        o1.AddProduct(p1);
        o1.AddProduct(p2);
        o1.AddProduct(p3);
        o1.AddProduct(p4);

        
       System.Console.WriteLine(o1.GetPackingLabel());

       System.Console.WriteLine(o1.GetShippingLabel());

       System.Console.WriteLine(o1.TotalCost());

    }
}