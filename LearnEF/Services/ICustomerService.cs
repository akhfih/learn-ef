using LearnEF.Entities;

namespace LearnEF.Services;

public interface ICustomerService
{
    Customer createNewCustomer(Customer customer);
    Customer GetById(string id);
}