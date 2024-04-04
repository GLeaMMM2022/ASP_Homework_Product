using Microsoft.AspNetCore.Mvc;

namespace ASP_Homework_Product.Controllers
{
    public class RandomController : Controller
    {
        private readonly ICounter randomCounter;
        private readonly CounterService counterService;

        public RandomController(ICounter randomCounter,CounterService counterService)
        {
            this.randomCounter = randomCounter;
            this.counterService = counterService;
        }

        public string Index()
        {
            return $"randomCounter = {randomCounter.Value}, countreService = {counterService.Counter.Value}";
            //return View();
        }
    }
}
