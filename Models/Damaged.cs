using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umbrella_gerage.Models
{

    public class Damaged
    {
        [Key]
        public int DamagedId { get; set; }

        [Required]
        public string ItemName { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime ReportDate { get; set; } = DateTime.Now;

        // Foreign Key ke Client
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }

}
