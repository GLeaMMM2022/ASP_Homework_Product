using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Homework_Product
{
    public class RandomCounter
    {
        static Random rnd = new Random();

        private int _value;

        public RandomCounter()
        {
            _value = rnd.Next(0, 100); 
        }

        public int Value
        {
            get { return _value; }
        }
    }
}
