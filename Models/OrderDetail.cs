using BanHoa.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BanHoa.Models;

namespace BanHoa.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailsID { get; set; }

        [ForeignKey("Order")]
        public int OrderID { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }

        public int Quantity { get; set; }

        public double UnitPrice { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
        public OrderDetail()
        {
        }
        public OrderDetail(int orderID, int productID, int quantity, double unitPrice)
        {
            OrderID = orderID;
            ProductID = productID;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
        public OrderDetail(int orderDetailsID, int orderID, int productID, int quantity, double unitPrice)
        {
            OrderDetailsID = orderDetailsID;
            OrderID = orderID;
            ProductID = productID;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
        public OrderDetail(int orderDetailsID, int orderID, int productID, int quantity, double unitPrice, Order order, Product product)
        {
            OrderDetailsID = orderDetailsID;
            OrderID = orderID;
            ProductID = productID;
            Quantity = quantity;
            UnitPrice = unitPrice;
            Order = order;
            Product = product;
        }
        public OrderDetail(int orderID, int productID, int quantity, double unitPrice, Order order, Product product)
        {
            OrderID = orderID;
            ProductID = productID;
            Quantity = quantity;
            UnitPrice = unitPrice;
            Order = order;
            Product = product;
        }
    }
}
