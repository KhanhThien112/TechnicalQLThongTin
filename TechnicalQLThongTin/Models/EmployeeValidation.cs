using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechnicalQLThongTin.Models
{
    public class EmployeeValidation
    {
        public int id { get; set; }

        public string maNV { get; set; }

        public string hoTen { get; set; }

        public DateTime namSinh { get; set; }

        public string email { get; set; }

        public string dienThoai { get; set; }

        public string diaChi { get; set; }
    }
}