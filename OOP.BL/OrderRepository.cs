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
        public bool Save(Order order)
        {
            var success = true;
            if (order.HasChanges && order.IsValid)
            {
                if (order.IsNew)
                {
                    //CREATE the new Order
                }
                else
                {
                    //UPDATE the edited order
                }
            }
            return success;
        }

        /// <summary>
        /// Retrieve an Order by providing the Order ID
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            var order = new Order(orderId);
            if (orderId == 5)
            {
                order.OrderDate = new DateTimeOffset(2016, 10, 15, 08, 30, 00, new TimeSpan(-6, 0, 0));
            }
            return order;
        }

        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay();

            if (orderId == 5)
            {
                orderDisplay.FirstName = "CSharp";
                orderDisplay.LastName = "Test";
                orderDisplay.OrderDate = new DateTimeOffset(2016, 10, 15, 08, 30, 00, new TimeSpan(-6, 0, 0));
                orderDisplay.ShippingAddress = new Address()
                {
                    AddressType = 3,
                    StreetLine1 = "8134",
                    StreetLine2 = "152 St",
                    City = "Surrey",
                    State = "BC",
                    PostalCode = "V2W1T1",
                    Country = "Canada"
                };
            }

            orderDisplay.OrderDisplayItemList = new List<OrderDisplayItem>();

            if (orderId == 5)
            {
                var orderDsiplayItem = new OrderDisplayItem()
                {
                    ProductName = "XBox one",
                    OrderQuantity = 1,
                    PurchasePrice = 565.50M
                };
                orderDisplay.OrderDisplayItemList.Add(orderDsiplayItem);

                orderDsiplayItem = new OrderDisplayItem()
                {
                    ProductName = "Sony Playstation",
                    OrderQuantity = 3,
                    PurchasePrice = 426.35M
                };
                orderDisplay.OrderDisplayItemList.Add(orderDsiplayItem);
            }

            return orderDisplay;
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
