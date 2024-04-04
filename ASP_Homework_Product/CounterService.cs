using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Homework_Product
{
    public class CounterService
    {
        public RandomCounter Counter { get; }
        
        public CounterService(RandomCounter counter)
        {
            Counter = counter;
        }
    }
}
