using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Umbrella_gerage.Data;
using Umbrella_gerage.Models;
using Microsoft.EntityFrameworkCore;

namespace Umbrella_gerage.Forms
{
    public partial class ClientForm : Form
    {
        private int selectedClientId = -1;

        public ClientForm()
        {
            InitializeComponent();
            LoadClientData();
        }

        // ✅ Fungsi untuk menampilkan semua data Client ke DataGridView
        private void LoadClientData()
        {
            using (var db = new AppDbContext())
            {
                dgvClient.DataSource = db.Clients
                    .Select(c => new
                    {
                        c.ClientId,
                        c.Name,
                        c.Email,
                        c.Phone,
                        c.Address
                    })
                    .ToList();
            }

            dgvClient.ClearSelection();
            ClearForm();
        }

        // ✅ Fungsi untuk mengosongkan semua input form
        private void ClearForm()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            selectedClientId = -1;
        }

        // ✅ Event kosong untuk menghindari error di Designer
        private void dgvClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kosong, hanya untuk menghindari error binding di Designer
        }

        // ✅ Saat user klik salah satu baris di DataGridView
        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedClientId = Convert.ToInt32(dgvClient.Rows[e.RowIndex].Cells["ClientId"].Value);
                txtName.Text = dgvClient.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtEmail.Text = dgvClient.Rows[e.RowIndex].Cells["Email"].Value?.ToString();
                txtPhone.Text = dgvClient.Rows[e.RowIndex].Cells["Phone"].Value?.ToString();
                txtAddress.Text = dgvClient.Rows[e.RowIndex].Cells["Address"].Value?.ToString();
            }
        }

        // ✅ Tombol SIMPAN (Tambah atau Update Otomatis)
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Nama wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new AppDbContext())
            {
                if (selectedClientId == -1)
                {
                    // Tambah data baru
                    var newClient = new Client
                    {
                        Name = txtName.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Phone = txtPhone.Text.Trim(),
                        Address = txtAddress.Text.Trim()
                    };
                    db.Clients.Add(newClient);
                }
                else
                {
                    // Update data yang sudah ada
                    var existing = db.Clients.FirstOrDefault(c => c.ClientId == selectedClientId);
                    if (existing != null)
                    {
                        existing.Name = txtName.Text.Trim();
                        existing.Email = txtEmail.Text.Trim();
                        existing.Phone = txtPhone.Text.Trim();
                        existing.Address = txtAddress.Text.Trim();
                    }
                }

                db.SaveChanges();
            }

            LoadClientData();
            MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ✅ Tombol UPDATE (khusus untuk memperbarui data yang dipilih)
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedClientId == -1)
            {
                MessageBox.Show("Silakan pilih data klien yang ingin diperbarui terlebih dahulu.",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Nama wajib diisi.",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new AppDbContext())
            {
                var client = db.Clients.FirstOrDefault(c => c.ClientId == selectedClientId);
                if (client != null)
                {
                    client.Name = txtName.Text.Trim();
                    client.Email = txtEmail.Text.Trim();
                    client.Phone = txtPhone.Text.Trim();
                    client.Address = txtAddress.Text.Trim();

                    db.SaveChanges();

                    MessageBox.Show("Data klien berhasil diperbarui!",
                        "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadClientData();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Data klien tidak ditemukan di database.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ✅ Tombol HAPUS
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedClientId == -1)
            {
                MessageBox.Show("Pilih data yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?",
                "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                using (var db = new AppDbContext())
                {
                    var client = db.Clients.FirstOrDefault(c => c.ClientId == selectedClientId);
                    if (client != null)
                    {
                        db.Clients.Remove(client);
                        db.SaveChanges();
                    }
                }

                LoadClientData();
                MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ✅ Tombol CLEAR untuk mengosongkan form
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // ✅ Event bawaan (tidak digunakan, tapi biar designer tidak error)
        private void Client_Load(object sender, EventArgs e)
        {
            // Bisa dihapus event-nya dari Properties nanti jika tidak digunakan.
        }

        private void dgvClient_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Teruskan ke handler utama supaya tidak duplikasi kode
            dgvClient_CellClick(sender, e);
        }

    }
}
