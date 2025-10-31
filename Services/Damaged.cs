using System.Collections.Generic;
using System.Linq;
using Umbrella_gerage.Data;
using Umbrella_gerage.Models;

namespace Umbrella_gerage.Services
{
    public class DamagedService
    {
        private readonly AppDbContext _context;

        public DamagedService(AppDbContext context)
        {
            _context = context;
        }

        // Ambil semua data kerusakan (termasuk relasi Client)
        public List<Damaged> GetAllDamages()
        {
            return _context.Damaged
                .OrderByDescending(d => d.ReportDate)
                .ToList();
        }

        // Ambil data berdasarkan ID
        public Damaged GetDamageById(int id)
        {
            return _context.Damaged.FirstOrDefault(d => d.DamagedId == id);
        }

        // Tambah data baru
        public void AddDamage(Damaged damage)
        {
            _context.Damaged.Add(damage);
            _context.SaveChanges();
        }

        // Update data
        public void UpdateDamage(Damaged damage)
        {
            var existing = _context.Damaged.FirstOrDefault(d => d.DamagedId == damage.DamagedId);
            if (existing != null)
            {
                existing.ItemName = damage.ItemName;
                existing.Description = damage.Description;
                existing.ReportDate = damage.ReportDate;
                existing.ClientId = damage.ClientId;

                _context.SaveChanges();
            }
        }

        // Hapus data
        public void DeleteDamage(int id)
        {
            var damage = _context.Damaged.FirstOrDefault(d => d.DamagedId == id);
            if (damage != null)
            {
                _context.Damaged.Remove(damage);
                _context.SaveChanges();
            }
        }
    }
}
