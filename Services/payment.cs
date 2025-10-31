using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Umbrella_gerage.Data;     // ✅ penting! biar AppDbContext dikenali
using Umbrella_gerage.Models;

namespace Umbrella_gerage.Services
{
    public class PaymentService
    {
        private readonly AppDbContext _context;

        public PaymentService(AppDbContext context)
        {
            _context = context;
        }

        // Ambil semua pembayaran (termasuk relasi Client)
        public List<Payment> GetAllPayments()
        {
            return _context.Payments
                .Include(p => p.Client)
                .OrderByDescending(p => p.PaymentDate)
                .ToList();
        }

        // Ambil pembayaran berdasarkan ID
        public Payment GetPaymentById(int id)
        {
            return _context.Payments
                .Include(p => p.Client)
                .FirstOrDefault(p => p.PaymentId == id);
        }

        // Tambah data pembayaran baru
        public void AddPayment(Payment payment)
        {
            _context.Payments.Add(payment);
            _context.SaveChanges();
        }

        // Update data pembayaran
        public void UpdatePayment(Payment payment)
        {
            var existing = _context.Payments.FirstOrDefault(p => p.PaymentId == payment.PaymentId);
            if (existing != null)
            {
                existing.Amount = payment.Amount;
                existing.PaymentDate = payment.PaymentDate;
                existing.Method = payment.Method;
                existing.ClientId = payment.ClientId;

                _context.SaveChanges();
            }
        }

        // Hapus data pembayaran
        public void DeletePayment(int id)
        {
            var payment = _context.Payments.FirstOrDefault(p => p.PaymentId == id);
            if (payment != null)
            {
                _context.Payments.Remove(payment);
                _context.SaveChanges();
            }
        }
    }
}
