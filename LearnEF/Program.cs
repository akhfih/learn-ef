
using LearnEF.Entities;
using LearnEF.Repositories;

public class Program
{
    public static void Main(string[] args)
    {
        using AppDbContext context = new();

        // get by id
        var customer = context.Customers.FirstOrDefault(customer => customer.Id.Equals(1));
        Console.WriteLine($"Customer: Id{customer.Id}, Name: {customer.CustomerName}, " + "" +
                          $"Mobile Phone: {customer.MobilePhone}, Email: {customer.MobilePhone}");
        
        // get by name
        var customerByName = context.Customers.FirstOrDefault(customer => customer.CustomerName.ToLower().Equals("fikron".ToLower()));
        Console.WriteLine($"Customer: Id{customerByName.Id}, Name: {customerByName.CustomerName}, " + "" +
                          $"Mobile Phone: {customerByName.MobilePhone}, Email: {customerByName.MobilePhone}");
        
        Console.WriteLine(context.Entry(customer).State);

        // get all
        var customers = context.Customers.ToList();
        
        foreach (var c in customers)
        {
            Console.WriteLine($"Customer: Id{c.Id}, Name: {c.CustomerName}, " + "" +
                              $"Mobile Phone: {c.MobilePhone}, Email: {c.MobilePhone}");
        }

        // create
        /*Customer newCustomer = new()
        {
            CustomerName = "Fikron",
            Address = "Jl. Melati",
            MobilePhone = "0857425531193",
            Email = "fikron@gmail.com"

        };

        context.Customers.Add(newCustomer);
        context.SaveChanges();*/
    }
}