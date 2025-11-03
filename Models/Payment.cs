using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Umbrella_gerage.Models
{
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaymentId { get; set; }

        // Relasi ke Client
        [ForeignKey("Client")]
        [Required]
        public int ClientId { get; set; }
        public Client Client { get; set; }

        // Relasi ke Damaged berdasarkan PlatNumber
        [ForeignKey("Damaged")]
        [Required]
        [StringLength(20)]
        public string PlatNumber { get; set; }
        public Damaged Damaged { get; set; }

        // Jumlah pembayaran
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        // Metode pembayaran
        [Required]
        [StringLength(50)]
        public string Method { get; set; }

        // Tanggal pembayaran
        [Required]
        public DateTime PaymentDate { get; set; } = DateTime.Now;
    }
}
