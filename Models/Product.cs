using BanHoa.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BanHoa.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        public string ProductName { get; set; }

        public double Price { get; set; }

        public int StockQuantity { get; set; }

        public string ImageURL { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierID { get; set; }

        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
        public Product(string productName, long price, int stockQuantity, string imageURL, int supplierID)
        {
            ProductName = productName;
            Price = price;
            StockQuantity = stockQuantity;
            ImageURL = imageURL;
            SupplierID = supplierID;
        }
        public Product(int productID, string productName, long price, int stockQuantity, string imageURL, int supplierID)
        {
            ProductID = productID;
            ProductName = productName;
            Price = price;
            StockQuantity = stockQuantity;
            ImageURL = imageURL;
            SupplierID = supplierID;
        }
        public Product(int productID, string productName, long price, int stockQuantity, string imageURL, int supplierID, ICollection<OrderDetail> orderDetails)
        {
            ProductID = productID;
            ProductName = productName;
            Price = price;
            StockQuantity = stockQuantity;
            ImageURL = imageURL;
            SupplierID = supplierID;
            OrderDetails = orderDetails;
        }
        public Product(string productName, long price, int stockQuantity, string imageURL, int supplierID, ICollection<OrderDetail> orderDetails)
        {
            ProductName = productName;
            Price = price;
            StockQuantity = stockQuantity;
            ImageURL = imageURL;
            SupplierID = supplierID;
            OrderDetails = orderDetails;
        }
        public Product(string productName, long price, int stockQuantity, string imageURL)
        {
            ProductName = productName;
            Price = price;
            StockQuantity = stockQuantity;
            ImageURL = imageURL;
        }
    }
}
