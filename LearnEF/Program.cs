
using LearnEF.Entities;
using LearnEF.Repositories;

public class Program
{
    public static void Main(string[] args)
    {
        AppDbContext context = new();
        IRepository<Customer> repository = new Repository<Customer>(context);

        Customer fikron = new()
        {
            CustomerName = "Fikron",
            Address = "Brebes",
            MobilePhone = "085729332881",
            Email = "fikron@email.com"
        };

        // repository.Save(fikron);
        // var customer = repository.FindById(Guid.Parse("FAAD0A90-F392-4DAD-40B7-08DC53AEA93F"));
        var customer = repository.FindBy(c => c.CustomerName.Equals("Fikron"));
        Console.WriteLine(customer.CustomerName);
    }
}

        /*using AppDbContext context = new();

        // get by id
        /*var customer = context.Customers.FirstOrDefault(customer => customer.Id.Equals(1));
        Console.WriteLine($"Customer: Id{customer.Id}, Name: {customer.CustomerName}, " + "" +
                          $"Mobile Phone: {customer.MobilePhone}, Email: {customer.MobilePhone}");
        
        Console.WriteLine(context.Entry(customer).State);#1#
        
        // get by name
        var customerByName = context.Customers.FirstOrDefault(customer => customer.CustomerName.ToLower().Equals("andik".ToLower()));
        Console.WriteLine($"Customer: Id{customerByName.Id}, Name: {customerByName.CustomerName}, " + "" +
                          $"Mobile Phone: {customerByName.MobilePhone}, Email: {customerByName.MobilePhone}");
        
        Console.WriteLine(context.Entry(customerByName).State);

        // get all
        var customers = context.Customers.ToList();
        
        foreach (var c in customers)
        {
            Console.WriteLine($"Customer: Id{c.Id}, Name: {c.CustomerName}, " + "" +
                              $"Mobile Phone: {c.MobilePhone}, Email: {c.MobilePhone}");
        }
        
        //remove
        context.Customers.Remove(customerByName);
        context.SaveChanges();

        // update
        /*Customer akhmad = new()
        {
            Id = 2,
            CustomerName = "Huda2",
            Address = "JL. H. Dahlan",
            MobilePhone = "12345678",
            Email = "huda@gmail.com",
        };#1#
        //untuk update find by dulu
        /*customerByName.CustomerName = "andik";
        context.Customers.Update(customerByName);
        context.SaveChanges();#1#

        // create
        /*Customer newCustomer = new()
        {
            CustomerName = "Fikron",
            Address = "Jl. Melati",
            MobilePhone = "0857425531193",
            Email = "fikron@gmail.com"

        };

        context.Customers.Add(newCustomer);
        context.SaveChanges();#1#*/