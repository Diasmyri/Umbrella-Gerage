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

        // Ambil semua data service kendaraan
        public List<Damaged> GetAll()
        {
            return _context.Damaged
                .OrderByDescending(d => d.ReportDate)
                .ToList();
        }

        // Ambil data berdasarkan nomor plat
        public Damaged GetByPlate(string plateNumber)
        {
            return _context.Damaged
                .FirstOrDefault(d => d.PlateNumber == plateNumber);
        }

        // Tambah data service baru
        public void Add(Damaged damaged)
        {
            _context.Damaged.Add(damaged);
            _context.SaveChanges();
        }

        // Update data service berdasarkan nomor plat
        public void Update(Damaged damaged)
        {
            var existing = _context.Damaged
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

        // Hapus data service berdasarkan nomor plat
        public void Delete(string plateNumber)
        {
            var damaged = _context.Damaged
                .FirstOrDefault(d => d.PlateNumber == plateNumber);

            if (damaged != null)
            {
                _context.Damaged.Remove(damaged);
                _context.SaveChanges();
            }
        }
    }
}
