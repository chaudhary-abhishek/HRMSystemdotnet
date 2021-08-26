using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMSystem.Models
{
    public class PayRollClass
    {
        public int ID { get; set; }
        public decimal BasicPay { get; set; }
        public decimal Allowance { get; set; }
        public decimal Deductions { get; set; }
        public decimal GrossPay { get; set; }
        public decimal NetPay { get; set; }
    }
}