using ProductOnline.Models;

namespace ProductOnline.Repositories
{
    public interface IDBManager
    {
        public List<Product> GetAllProducts();
        public Product GetProductById(int id);
        public bool InsertProduct(Product product);
        public bool DeleteProductById(int id);
        public bool UpdateProduct(Product product);

    }
}
