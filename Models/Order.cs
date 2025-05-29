using BanHoa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BanHoa.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }

        public DateTime OrderDate { get; set; }

        public string DeliveryAddress { get; set; }

        public double TotalPrice { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
        public Order(int customerID, DateTime orderDate, string deliveryAddress, double totalPrice)
        {
            CustomerID = customerID;
            OrderDate = orderDate;
            DeliveryAddress = deliveryAddress;
            TotalPrice = totalPrice;
        }
        public Order(int orderID, int customerID, DateTime orderDate, string deliveryAddress, double totalPrice)
        {
            OrderID = orderID;
            CustomerID = customerID;
            OrderDate = orderDate;
            DeliveryAddress = deliveryAddress;
            TotalPrice = totalPrice;
        }
        public Order(int orderID, int customerID, DateTime orderDate, string deliveryAddress, double totalPrice, ICollection<OrderDetail> orderDetails)
        {
            OrderID = orderID;
            CustomerID = customerID;
            OrderDate = orderDate;
            DeliveryAddress = deliveryAddress;
            TotalPrice = totalPrice;
            OrderDetails = orderDetails;
        }
        public Order(int customerID, DateTime orderDate, string deliveryAddress, double totalPrice, ICollection<OrderDetail> orderDetails)
        {
            CustomerID = customerID;
            OrderDate = orderDate;
            DeliveryAddress = deliveryAddress;
            TotalPrice = totalPrice;
            OrderDetails = orderDetails;
        }
        public Order(int orderID, int customerID, DateTime orderDate, string deliveryAddress, double totalPrice, Customer customer)
        {
            OrderID = orderID;
            CustomerID = customerID;
            OrderDate = orderDate;
            DeliveryAddress = deliveryAddress;
            TotalPrice = totalPrice;
            Customer = customer;
        }
    }
}
