using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umbrella_gerage.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        public ICollection<Payment> Payments { get; set; }
        public ICollection<Damaged> DamagedItems { get; set; }
    }

}
