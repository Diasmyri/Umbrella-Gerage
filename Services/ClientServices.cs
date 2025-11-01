using System.Collections.Generic;
using System.Linq;
using Umbrella_gerage.Data;
using Umbrella_gerage.Models; // pastikan ini sesuai folder model kamu

namespace Umbrella_gerage.Services
{
    public class ClientServices
    {
        private readonly AppDbContext _context;

        public ClientServices(AppDbContext context)
        {
            _context = context;
        }

        // Menampilkan semua client
        public List<Client> GetAllClients()
        {
            return _context.Clients.ToList();
        }

        // Menampilkan client berdasarkan ID
        public Client GetClientById(int id)
        {
            return _context.Clients.FirstOrDefault(c => c.ClientId == id);
        }

        // Menambah client baru
        public void AddClient(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
        }

        // Mengupdate data client
        public void UpdateClient(Client client)
        {
            var existing = _context.Clients.FirstOrDefault(c => c.ClientId == client.ClientId);
            if (existing != null)
            {
                existing.Name = client.Name;
                existing.Phone = client.Phone;
                existing.Email = client.Email;
                existing.Address = client.Address;
                _context.SaveChanges();
            }
        }

        // Menghapus client
        public void DeleteClient(int id)
        {
            var client = _context.Clients.FirstOrDefault(c => c.ClientId == id);
            if (client != null)
            {
                _context.Clients.Remove(client);
                _context.SaveChanges();
            }
        }
    }
}
