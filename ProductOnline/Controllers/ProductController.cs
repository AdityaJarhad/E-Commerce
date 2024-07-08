using Microsoft.AspNetCore.Mvc;
using ProductOnline.Models;
using ProductOnline.Services;
using ProductOnline.Repositories;

namespace ProductOnline.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAllProducts()
        {
            List<Product> products = _productService.GetAllProducts();
            if (products == null)
            {
                return RedirectToAction(nameof(Index));
            }
            ViewData["AllProducts"] = products;
            return Json(products);
        }
        public IActionResult GetProductById(int id)
        {
            var product = _productService.GetProductById(id);
            if (product == null)
            {
                return RedirectToAction(nameof(Index));
            }
            //ViewData["Product"] = product;
            return Json(product);
        }
        [HttpPost]
        public IActionResult InsertProduct(Product product)
        {
            var prod = _productService.InsertProduct(product);
            ViewData["Insert"] = prod;
            return View();
        }
        public IActionResult DeleteProductById(int id)
        {
            return View();
        }
        [HttpGet]
        public IActionResult UpdateProduct(Product product)
        {
            return View();
        }
    }
}
