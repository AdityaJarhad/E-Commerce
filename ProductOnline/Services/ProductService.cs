using ProductOnline.Repositories;
using ProductOnline.Models;
using ProductOnline.Models;

namespace ProductOnline.Services
{
    public class ProductService:IProductService
    {
        private readonly  IDBManager _dBManager;
        public ProductService(IDBManager bManager)
        {
            _dBManager = bManager;
        }

        public List<Product> GetAllProducts() => _dBManager.GetAllProducts();
        public Product GetProductById(int id) => _dBManager.GetProductById(id);
        public bool InsertProduct(Product product) => _dBManager.InsertProduct(product);
        public bool DeleteProductById(int id) => _dBManager.DeleteProductById(id);
        public bool UpdateProduct(Product product) => _dBManager.UpdateProduct(product);
    }
}
