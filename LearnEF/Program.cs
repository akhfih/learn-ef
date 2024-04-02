
using LearnEF.Entities;
using LearnEF.Repositories;

public class Program
{
    public static void Main(string[] args)
    {
        using AppDbContext context = new();
        Customer customer = new()
        {
            CustomerName = "Akhmad",
            Address = "Jl. H. Dahlan",
            MobilePhone = "085742553119",
            Email = "akhmad@gmail.com"
            
        };

        context.Customers.Add(customer);
        context.SaveChanges();
    }
}