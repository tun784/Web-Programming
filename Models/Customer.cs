using BanHoa.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace BanHoa.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên khách hàng không được để trống")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        public string Phone { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public Customer()
        {
            Orders = new HashSet<Order>();
        }
        public Customer(string name, string address, string phone)
        {
            Name = name;
            Address = address;
            Phone = phone;
        }
        public Customer(int id, string name, string address, string phone)
        {
            Id = id;
            Name = name;
            Address = address;
            Phone = phone;
        }
        public Customer(int id, string name, string address, string phone, ICollection<Order> orders)
        {
            Id = id;
            Name = name;
            Address = address;
            Phone = phone;
            Orders = orders;
        }
    }
}
