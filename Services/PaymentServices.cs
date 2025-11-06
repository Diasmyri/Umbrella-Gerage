using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Umbrella_gerage.Data;     // ✅ penting untuk akses AppDbContext
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

        // 🔹 Ambil semua pembayaran (termasuk relasi Client dan Damaged)
        public List<Payment> GetAllPayments()
        {
            return _context.Payments
                .Include(p => p.Client)
                .Include(p => p.Damaged)
                .OrderByDescending(p => p.PaymentDate)
                .ToList();
        }

        // 🔹 Ambil pembayaran berdasarkan ID
        public Payment GetPaymentById(int id)
        {
            return _context.Payments
                .Include(p => p.Client)
                .Include(p => p.Damaged)
                .FirstOrDefault(p => p.PaymentId == id);
        }

        // 🔹 Tambah data pembayaran baru
        public void AddPayment(Payment payment)
        {
            _context.Payments.Add(payment);
            _context.SaveChanges();
        }

        // 🔹 Update data pembayaran
        public void UpdatePayment(Payment payment)
        {
            var existing = _context.Payments.FirstOrDefault(p => p.PaymentId == payment.PaymentId);
            if (existing != null)
            {
                existing.Price = payment.Price;
                existing.Method = payment.Method;
                existing.ClientId = payment.ClientId;
                existing.PlatNumber = payment.PlatNumber;
                existing.PaymentDate = payment.PaymentDate;

                _context.SaveChanges();
            }
        }

        // 🔹 Hapus data pembayaran
        public void DeletePayment(int id)
        {
            var payment = _context.Payments.FirstOrDefault(p => p.PaymentId == id);
            if (payment != null)
            {
                _context.Payments.Remove(payment);
                _context.SaveChanges();
            }
        }

        // 🔹 Cari pembayaran berdasarkan nama client (opsional)
        public List<Payment> SearchByClientName(string name)
        {
            return _context.Payments
                .Include(p => p.Client)
                .Include(p => p.Damaged)
                .Where(p => p.Client.Name.Contains(name))
                .OrderByDescending(p => p.PaymentDate)
                .ToList();
        }

        // 🔹 Filter berdasarkan plat nomor (opsional
        public List<Payment> GetByPlatNumber(string plat)
        {
            return _context.Payments
                .Include(p => p.Client)
                .Include(p => p.Damaged)
                .Where(p => p.PlatNumber == plat)
                .OrderByDescending(p => p.PaymentDate)
                .ToList();
        }
    }
}
