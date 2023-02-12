using Shop.Models;

namespace Shop.Services.Interfaces
{
    public interface IProductServices
    {
        int Save(Product product);
        List<Product> GetAll();
        Product Get(int id);
        int Delete(int id);
    }
}
