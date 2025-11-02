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
        [MaxLength(20)]
        public string PlateNumber { get; set; } // primary key input manual

        [Required]
        [MaxLength(50)]
        public string CarType { get; set; } // jenis mobil

        [Required]
        [MaxLength(100)]
        public string ServiceType { get; set; } // servis yang dipilih dari combo box

        [MaxLength(200)]
        public string Description { get; set; } // optional catatan tambahan

        [Column(TypeName = "timestamp without time zone")]
        public DateTime ReportDate { get; set; } = DateTime.UtcNow;

    }
}