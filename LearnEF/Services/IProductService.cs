using LearnEF.Entities;

namespace LearnEF.Services;

public interface IProductService
{
    Product CreateNewProduct(Product product);
    Product GetById(string id);
}