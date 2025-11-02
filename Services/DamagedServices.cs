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

        // Ambil semua data kendaraan rusak (urut berdasarkan tanggal terbaru)
        public List<Damaged> GetAll()
        {
            return _context.Damageds
                .OrderByDescending(d => d.ReportDate)
                .ToList();
        }

        // Ambil data berdasarkan plat nomor
        public Damaged GetByPlate(string plateNumber)
        {
            return _context.Damageds
                .FirstOrDefault(d => d.PlateNumber == plateNumber);
        }

        // Tambah data baru
        public void Add(Damaged damaged)
        {
            _context.Damageds.Add(damaged);
            _context.SaveChanges();
        }

        // Update data berdasarkan plat nomor
        public void Update(Damaged damaged)
        {
            var existing = _context.Damageds
                .FirstOrDefault(d => d.PlateNumber == damaged.PlateNumber);

            if (existing != null)
            {
                existing.CarType = damaged.CarType;
                existing.ServiceType = damaged.ServiceType;
                existing.Description = damaged.Description;
                existing.ReportDate = damaged.ReportDate;

                _context.SaveChanges();
            }
        }

        // Hapus data berdasarkan plat nomor
        public void Delete(string plateNumber)
        {
            var damaged = _context.Damageds
                .FirstOrDefault(d => d.PlateNumber == plateNumber);

            if (damaged != null)
            {
                _context.Damageds.Remove(damaged);
                _context.SaveChanges();
            }
        }
    }
}
