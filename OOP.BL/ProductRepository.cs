using OOP.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Tests
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieves a single Product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            var product = new Product(productId);
            if (productId == 1)
            {
                product.ProductName = "Terminal SP-630";
                product.ProductDescription = "Windows 10 Terminal";
                product.CurrentPrice = 299.89M;
            }
            return product;
        }

        /// <summary>
        /// Retrieves a list of Products
        /// </summary>
        /// <returns></returns>
        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        /// <summary>
        /// Save a new Product to the DB
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }

    }
}
