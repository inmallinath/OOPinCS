using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BL
{
    public class Product : EntityBase
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

        //public string ProductName { get; set; }

        private string _productName;

        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }


        public string ProductDescription { get; set; }

        /// <summary>
        /// Nullable type of Decimal - Allows a value or Null 
        /// Eg: 0 
        /// </summary>
        public decimal? CurrentPrice { get; set; }

        /// <summary>
        /// Validate the Product for valid values
        /// CurrentPrice cannot be null and Product Name should be present
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (String.IsNullOrWhiteSpace(ProductName) || (CurrentPrice == null))
            {
                isValid = false;
            }
            return isValid;
        }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
