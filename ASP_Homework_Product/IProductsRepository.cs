using ASP_Homework_Product.Models;
using System.Collections.Generic;

namespace ASP_Homework_Product
{
    public interface IProductsRepository
    {
        List<Product> GetAllProducts();
        Product TryGetById(int id);
    }
}