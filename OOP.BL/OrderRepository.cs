using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// Save the order to the DB
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Retrieve an Order by providing the Order ID
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            var order = new Order(orderId);
            if (orderId == 1)
            {
                order.OrderDate = new DateTimeOffset(2016, 10, 15, 08, 30, 00, new TimeSpan(-6, 0, 0));
            }
            return order;
        }

        /// <summary>
        /// Retrieve a list of Orders
        /// </summary>
        /// <returns></returns>
        public List<Order> Retrieve()
        {
            return new List<Order>();
        }
    }
}
