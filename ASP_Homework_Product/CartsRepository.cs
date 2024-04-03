using ASP_Homework_Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASP_Homework_Product
{
    public class CartsRepository
    {
        private static List<Cart> carts = new List<Cart>();

        public static object TryGetByUserId(string userId)
        {
            return carts.FirstOrDefault(x => x.userId == userId);
        }
    }
}
