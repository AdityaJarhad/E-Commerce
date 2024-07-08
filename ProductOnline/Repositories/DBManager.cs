using ProductOnline.Models;
using System;

namespace ProductOnline.Repositories
{
    public class DBManager:IDBManager
    {
        public CollectionContext _Context = new CollectionContext();
        public List<Product> GetAllProducts()
        {
            return _Context.Products.ToList();
        }
        public Product GetProductById(int id)
        {
            return _Context.Products.Find(id);
        }
        public bool InsertProduct(Product product)
        {
            _Context.Add(product);
            _Context.SaveChanges();
            return true;
        }
        public bool DeleteProductById(int id)
        {
            _Context.Remove(id);
            _Context.SaveChanges ();
            return true;
        }
        public bool UpdateProduct(Product product)
        {
            _Context.Update(product);
            _Context.SaveChanges();
            return true;
        }

    }
}
