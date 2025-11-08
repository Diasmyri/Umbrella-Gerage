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

            // Tampilkan semua data Client ke DataGridView
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

            // Kosongkan form input
            private void ClearForm()
            {
                txtName.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
                txtAddress.Clear();
                selectedClientId = -1;
            }

            private void dgvClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            
            }

            //  Isi form saat klik data di DataGridView
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

            //  Validasi input sebelum simpan/update
            private bool ValidateInput()
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Nama wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Email wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                {
                    MessageBox.Show("Email tidak valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    MessageBox.Show("Nomor telepon wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (!txtPhone.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Nomor telepon hanya boleh berisi angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    MessageBox.Show("Alamat wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                return true;
            }

            //  Tombol SIMPAN
            private void btnSave_Click(object sender, EventArgs e)
            {
                if (!ValidateInput())
                    return;

                using (var db = new AppDbContext())
                {
                    // 🔍 Cek apakah email atau phone sudah terdaftar
                    var existing = db.Clients.FirstOrDefault(c =>
                        c.Email == txtEmail.Text.Trim() || c.Phone == txtPhone.Text.Trim());

                    if (existing != null)
                    {
                        MessageBox.Show("Email atau nomor telepon sudah terdaftar. Gunakan Email atau Nomor Telepon yang lain.",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var newClient = new Client
                    {
                        Name = txtName.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Phone = txtPhone.Text.Trim(),
                        Address = txtAddress.Text.Trim()
                    };

                    db.Clients.Add(newClient);
                    db.SaveChanges();
                }

                LoadClientData();
                MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //  Tombol UPDATE
            private void btnUpdate_Click(object sender, EventArgs e)
            {
                if (selectedClientId == -1)
                {
                    MessageBox.Show("Silakan pilih data klien yang ingin diperbarui.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidateInput())
                    return;

                using (var db = new AppDbContext())
                {
                    var existingEmail = db.Clients.FirstOrDefault(c =>
                        c.Email == txtEmail.Text.Trim() && c.ClientId != selectedClientId);
                    var existingPhone = db.Clients.FirstOrDefault(c =>
                        c.Phone == txtPhone.Text.Trim() && c.ClientId != selectedClientId);

                    if (existingEmail != null || existingPhone != null)
                    {
                        MessageBox.Show("Email atau nomor telepon sudah digunakan.",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var client = db.Clients.FirstOrDefault(c => c.ClientId == selectedClientId);
                    if (client != null)
                    {
                        client.Name = txtName.Text.Trim();
                        client.Email = txtEmail.Text.Trim();
                        client.Phone = txtPhone.Text.Trim();
                        client.Address = txtAddress.Text.Trim();

                        db.SaveChanges();

                        MessageBox.Show("Data klien berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                LoadClientData();
            }

            //  Tombol DELETE
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

            //  Tombol CLEAR
            private void btnClear_Click(object sender, EventArgs e)
            {
                ClearForm();
            }

            private void Client_Load(object sender, EventArgs e)
            {
            
            }

            private void dgvClient_CellClick_1(object sender, DataGridViewCellEventArgs e)
            {
                dgvClient_CellClick(sender, e);
            }


        }
    }
