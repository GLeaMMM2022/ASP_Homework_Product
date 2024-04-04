using Microsoft.AspNetCore.Mvc;

namespace ASP_Homework_Product.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsRepository productRepository;

        public ProductsController(IProductsRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult Index(int id)
        {
            var product = productRepository.TryGetById(id);

            return View(product);

            //забыл создать ветку для задания 4_2 и просто перекопировал с прошлой ветки последнего коммита (Т.Е. ЗАДАНИЕ 4_1 НУЖНО СМОТРЕТЬ С ПРЕДПОСЛЕДНЕГО КОММИТА 
        }
    }
}
