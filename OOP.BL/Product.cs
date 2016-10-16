using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BL
{
    public class Product
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Product()
        {

        }

        /// <summary>
        /// Constructor to allow setting of ProductId
        /// </summary>
        /// <param name="productId"></param>
        public Product(int productId)
        {
            this.ProductId = productId;
        }

        /// <summary>
        /// Auto Implemented properties
        /// </summary>
        public int ProductId { get; private set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        /// <summary>
        /// Nullable type of Decimal - Allows a value or Null 
        /// Eg: 0 
        /// </summary>
        public Decimal? CurrentPrice { get; set; }

        /// <summary>
        /// Retrieves a single Product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            return new Product();
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

        /// <summary>
        /// Validate the Product for valid values
        /// CurrentPrice cannot be null and Product Name should be present
        /// </summary>
        /// <returns></returns>
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
