using Microsoft.AspNetCore.Mvc;

namespace ASP_Homework_Product.Controllers
{
    public class CartController : Controller
    {
        private readonly ProductRepository productRepository;

        public CartController() 
        {
            productRepository = new ProductRepository();
        }

        public IActionResult Index() 
        {
            var cart = CartsRepository.TryGetByUserId(Constants.UserId);
            return View(cart); 
        }

        public IActionResult Add(int productId)
        {
            var product = productRepository.TryGetById(productId);
            return View(product);
        }
    }
}
