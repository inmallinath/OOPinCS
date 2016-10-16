using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BL
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public int ProductId { get; private set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        /// <summary>
        /// Nullable type of Decimal - Allows a value or Null 
        /// Eg: 0 
        /// </summary>
        public Decimal? CurrentPrice { get; set; }

        public Product Retrieve(int productId)
        {
            return new Product();
        }

        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (String.IsNullOrWhiteSpace(ProductName) || (CurrentPrice == null))
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
