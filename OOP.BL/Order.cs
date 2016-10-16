using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BL
{
    public class Order
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Order()
        {

        }

        /// <summary>
        /// Constructor that allows setting of OrderId
        /// </summary>
        /// <param name="orderId"></param>
        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        /// <summary>
        /// Auto-Implemented Properties
        /// </summary>
        public int OrderId { get; private set; }

        /// <summary>
        /// DateTimeOffset provides the time offset for saving the date with time and offset
        /// To manage timezones
        /// </summary>
        public DateTimeOffset? OrderDate { get; set; }

        /// <summary>
        /// Validate Method to verify that the Order Date is not Null
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null)
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
