using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Shop.Models;
using Shop.Services.Interfaces;

namespace Shop.Services
{
    public class ProductServices : IProductServices
    {
        private readonly DbShopContext _context;
        public ProductServices(DbShopContext context)
        {
            _context = context;
        }

        public List<Product> GetAll()
        {
            var products = _context.Products.ToList();
            return products;
        }

        public Product Get(int id)
        {
            var product = _context.Products.Find(id);
            return product;
        }

        public int Save(Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
            return 1;        }

        public int Delete(int id)
        {
            var product = _context.Products.Find(id);
            _context.Products.Remove(product);
            _context.SaveChanges();
            return id;

        }
    }
}
