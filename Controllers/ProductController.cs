using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using Shop.Services.Interfaces;

namespace Shop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductServices _productService;
        public ProductController(IProductServices productServices)
        {
            _productService = productServices;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            var productList = _productService.GetAll();
            return View(productList);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Product body)
        {
            if (!ModelState.IsValid)
            {
                return View(body);
            }
            var id= _productService.Save(body);
            TempData["Prodectid"] = id;
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var product = _productService.Get(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _productService.Delete(id);
            return RedirectToAction("List");
        }
    }
}
