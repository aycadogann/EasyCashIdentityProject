using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    public class ElectricBill
    {
        [Key]
        public int ElectricBillID { get; set; }
        public string ContractNumber { get; set; }
        public string CustomerName { get; set; }
        public string BillingPeriod { get; set; }
        public DateTime PaymentDueDate { get; set; }
        public decimal Amount { get; set; }
        public bool PaidStatus { get; set; }
    }
}
