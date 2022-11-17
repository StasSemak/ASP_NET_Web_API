using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class PaymentInfo
    {
        public string Id { get; set; }
        public string CardNumber { get; set; }
        public DateTime DateOfExpire { get; set; }
        public int CVV { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
