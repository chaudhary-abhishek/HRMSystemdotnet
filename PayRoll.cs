using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class PayRoll
    {
        public int ID { get; set; }
        public Decimal BasicPay { get; set; }
        public Decimal Allowance { get; set; }
        public Decimal Deductions { get; set; }
        public Decimal GrossPay { get; set; }
        public Decimal NetPay { get; set; }
    }
}
