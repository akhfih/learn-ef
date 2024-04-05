
using LearnEF.Entities;
using LearnEF.Repositories;
using LearnEF.Services;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {
        AppDbContext context = new();

        IRepository<Purchase> repository = new Repository<Purchase>(context);
        IRepository<Product> repositoryProduct = new Repository<Product>(context);
        IPersistence persistence = new DbPersistence(context);
        IProductService productService = new ProductService(repositoryProduct, persistence);
        IPurchaseService purchaseService = new PurchaseService(repository, persistence, productService);

        var purchase = new Purchase
        {
            TransDate = DateTime.Now,
            CustomerId = Guid.Parse("d038b78b-22c3-4566-0b9b-08dc543caec4"),
            PurchaseDetails = new List<PurchaseDetail>()
            {
                new() {ProductId = Guid.Parse("2e100fc2-a888-42dd-7ac2-08dc5441dcde"), Qty = 2,},
                new() {ProductId = Guid.Parse("22b0165a-b3b9-4728-7ac3-08dc5441dcde"), Qty = 1,},
            }
        };  

        purchaseService.CreateNewTransaction(purchase);










        /*IRepository<Customer> repository = new Repository<Customer>(context);
        IRepository<Product> proRepository = new Repository<Product>(context);

        var purchase = context.Purchases
                // .Include(purchase => purchase.Customer)
                .Include("Customer")
                // .Include(p=>p.PurchaseDetails)
                // .ThenInclude(pd=>pd.Product)
                .Include("PurchaseDetails.Product")
                .FirstOrDefault(p=>p.Id.Equals(Guid.Parse("9a48280e-57ed-47a3-de54-08dc547ad166")));
        Console.WriteLine(purchase);*/

        /*
         * "SELECT * FROM t_purchase tp
         * JOIN m_customer mc ON mc.id = tp.customer_id
         * JOIN t_purchase_detail tpd ON tpd.purchase_id = tp.id
         * JOIN m_product mp ON mp.id = tpd.purchase_id"
         */

        //Transaction Insert
        /*var transaction = context.Database.BeginTransaction();

        try
        {
            var purchase = new Purchase
            {
                TransDate = DateTime.Now,
                CustomerId = Guid.Parse("d038b78b-22c3-4566-0b9b-08dc543caec4"),
                PurchaseDetails = new List<PurchaseDetail>
                {
                    new() {ProductId = Guid.Parse("2e100fc2-a888-42dd-7ac2-08dc5441dcde"), Qty = 2,},
                    new() {ProductId = Guid.Parse("22b0165a-b3b9-4728-7ac3-08dc5441dcde"), Qty = 1,},
                }
            };
            context.Purchases.Add(purchase);
            context.SaveChanges();

            foreach (var purchaseDetail in purchase.PurchaseDetails)
            {
                var product = context.Products.FirstOrDefault(product => product.Id.Equals(purchaseDetail.ProductId));
                if (product != null) product.Stock -= purchaseDetail.Qty;
            }

            context.SaveChanges();
            transaction.Commit();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            transaction.Rollback();
            throw;
        }*/
    }
}

        /*Product nabati = new Product
        {
            ProductName = "Rich Rich Nabati",
            ProductPrice = 3000,
            Stock = 15
        };
                
        Product tongo = new Product
        {
            ProductName = "Tongo Coklat",
            ProductPrice = 5000,
            Stock = 10
        };
                
        Product nextmonth = new Product
        {
            ProductName = "Nextmont",
            ProductPrice = 4000,
            Stock = 5
        };

        proRepository.Save(nabati);
        proRepository.Save(tongo);
        proRepository.Save(nextmonth);*/

        // Customer fikron = new()
        // {
        //     CustomerName = "Fikron",
        //     Address = "Brebes",
        //     MobilePhone = "085729332881",
        //     Email = "fikron@email.com"
        // };
        //
        //  repository.Save(fikron);
        // var customer = repository.FindById(Guid.Parse("FAAD0A90-F392-4DAD-40B7-08DC53AEA93F"));
        /*var customer = repository.FindBy(c => c.CustomerName.Equals("Fikron"));
        Console.WriteLine(customer.CustomerName);*/





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