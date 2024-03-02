using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Bai123_Form.Models
{
    public class Information2
    {
        [Required(ErrorMessage="Yeu cau nhap lai ho ten")]
        [StringLength(50)]
        public string FullName;

        [Required(ErrorMessage="Yeu cau nhap lai ID")]
        [StringLength(10, ErrorMessage="Nhap chieu dai khong qua 10 ky so")]
        public string IdStudent;

        [Required(ErrorMessage = "Bat buoc nhap Email")]
        [EmailAddress(ErrorMessage = "Dia chi email khong hop le")]
        public string Email;

        public string FileImage, Note, ChooseWorkTime;
        public bool Check1, Check2, Check3;
        [Required(ErrorMessage="Yeu cau chon khoa hoc")]
        public string SelectCourse;
    }
}