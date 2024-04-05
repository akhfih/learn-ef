using LearnEF.Entities;

namespace LearnEF.Services;

public interface IPurchaseService
{
    Purchase CreateNewTransaction(Purchase purchase);
    
}