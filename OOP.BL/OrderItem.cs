using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BL
{
    public class OrderItem
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public OrderItem()
        {

        }

        /// <summary>
        /// Constructor that allows to set a orderitemid
        /// </summary>
        /// <param name="orderItemId"></param>
        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }

        /// <summary>
        /// Autom Implemented Properties
        /// </summary>
        public int OrderItemId { get; private set; }

        public decimal? PurchasePrice { get; set; }

        public int ProductId { get; set; }

        public int OrderQuantity { get; set; }

        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;
            if (OrderQuantity <= 0 || ProductId <= 0 || PurchasePrice == null)
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
