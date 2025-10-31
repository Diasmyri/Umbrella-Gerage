using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umbrella_gerage.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; } = DateTime.Now;

        public string Method { get; set; } // misalnya: Cash, Transfer, QRIS, dll.

        // Foreign Key ke Client
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }

}
