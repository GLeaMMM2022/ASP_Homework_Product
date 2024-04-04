using Microsoft.AspNetCore.Mvc;

namespace ASP_Homework_Product.Controllers
{
    public class RandomController : Controller
    {
        private readonly RandomCounter randomCounter;
        private readonly CounterService counterService;

        public RandomController(RandomCounter randomCounter,CounterService counterService)
        {
            this.randomCounter = randomCounter;
            this.counterService = counterService;
        }

        public string Index()
        {
            return randomCounter.Value.ToString();
            //return View();
        }
    }
}
