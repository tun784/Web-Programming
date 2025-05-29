using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BanHoa.Models;

namespace BanHoa.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }

        [Required]
        public string SupplierName { get; set; }

        public string AddressSupplier { get; set; }

        public string Phone { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public Supplier()
        {
            Products = new HashSet<Product>();
        }
        public Supplier(string supplierName, string addressSupplier, string phoneNumber)
        {
            SupplierName = supplierName;
            AddressSupplier = addressSupplier;
            Phone = phoneNumber;
        }
        public Supplier(int supplierID, string supplierName, string addressSupplier, string phoneNumber)
        {
            SupplierID = supplierID;
            SupplierName = supplierName;
            AddressSupplier = addressSupplier;
            Phone = phoneNumber;
        }
        public Supplier(int supplierID, string supplierName, string addressSupplier, string phoneNumber, ICollection<Product> products)
        {
            SupplierID = supplierID;
            SupplierName = supplierName;
            AddressSupplier = addressSupplier;
            Phone = phoneNumber;
            Products = products;
        }
        public Supplier(string supplierName, string addressSupplier, string phoneNumber, ICollection<Product> products)
        {
            SupplierName = supplierName;
            AddressSupplier = addressSupplier;
            Phone = phoneNumber;
            Products = products;
        }
    }
}
