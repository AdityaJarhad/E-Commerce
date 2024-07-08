using ProductOnline.Models;
using ProductOnline.Repositories;

namespace ProductOnline.Services
{
    public interface IProductService
    {
        public List<Product> GetAllProducts();
        public Product GetProductById(int id);
        public bool InsertProduct(Product product);
        public bool DeleteProductById(int id);
        public bool UpdateProduct(Product product);
    }
}
