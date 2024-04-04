using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Homework_Product
{
    public class CounterService
    {
        public ICounter Counter { get; }
        
        public CounterService(ICounter counter)
        {
            Counter = counter;
        }
    }
}
