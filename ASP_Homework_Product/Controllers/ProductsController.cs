using Microsoft.AspNetCore.Mvc;

namespace ASP_Homework_Product.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductRepository productRepository;

        public ProductsController() 
        {
            productRepository = new ProductRepository();
        }

        public IActionResult Index(int id)
        {
            var product = productRepository.TryGetById(id);

            return View(product);


        }
    }
}
