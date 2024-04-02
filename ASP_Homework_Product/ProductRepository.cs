using System;
using System.Collections.Generic;
using ASP_Homework_Product.Models;

namespace ASP_Homework_Product
{
    public class ProductRepository
    {
        public static List<Product> products = new List<Product>()
        {
            new Product("Last of us", 1000,"Sony's exclusive","/images/lastofusimg.jpg"),
            new Product("Red Dead Redemption 2", 2000, "Rockstar games", "/images/rdr2image.jpg"),
            new Product("Detroit",500,"Quantic Dream", "/images/detroitimg.jpg"),
            new Product("Horizon FW",5000,"Sony", "/images/horizonfbimage.jpg") 
        };

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public Product TryGetById(int id)
        {
            foreach (var prod in products)
            {
                if (prod.Id == id)
                {
                    return prod;
                }
            }
            return null;
        }

        public ProductRepository()
        {
        }
    }
}

