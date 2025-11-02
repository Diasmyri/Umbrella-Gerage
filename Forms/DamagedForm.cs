using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Umbrella_gerage.Data;
using Umbrella_gerage.Models;

namespace Umbrella_gerage.Forms
{
    public partial class DamagedForm : Form
    {
        private string selectedPlateNumber = null;

        public DamagedForm()
        {
            InitializeComponent();
            LoadDamagedData();
            LoadComboBoxes();
        }

        // ✅ Menampilkan data kerusakan
        private void LoadDamagedData()
        {
            using (var db = new AppDbContext())
            {
                dgvDamaged.DataSource = db.Damageds
                    .Select(d => new
                    {
                        d.PlateNumber,
                        d.CarType,
                        d.ServiceType,
                        d.Description,
                        d.ReportDate
                    })
                    .ToList();
            }

            dgvDamaged.ClearSelection();
            ClearForm();
        }

        // ✅ Isi pilihan ComboBox
        private void LoadComboBoxes()
        {
            cmbTipeMobil.Items.Clear();
            cmbTipeMobil.Items.AddRange(new string[]
            {
                "Avanza", "Terios", "Xpander"
            });

            cmbTipeServis.Items.Clear();
            cmbTipeServis.Items.AddRange(new string[]
            {
                "Servis Kecil", "Servis Sedang", "Servis Besar"
            });
        }

        // ✅ Kosongkan input form
        private void ClearForm()
        {
            txtPlatNomor.Clear();
            cmbTipeMobil.SelectedIndex = -1;
            cmbTipeServis.SelectedIndex = -1;
            txtDeskripsi.Clear();
            dateReport.Value = DateTime.Now;
            selectedPlateNumber = null;
            txtPlatNomor.Enabled = true;
        }

        // ✅ Klik data grid untuk isi form
        private void dgvDamaged_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedPlateNumber = dgvDamaged.Rows[e.RowIndex].Cells["PlateNumber"].Value.ToString();
                txtPlatNomor.Text = selectedPlateNumber;
                cmbTipeMobil.Text = dgvDamaged.Rows[e.RowIndex].Cells["CarType"].Value?.ToString();
                cmbTipeServis.Text = dgvDamaged.Rows[e.RowIndex].Cells["ServiceType"].Value?.ToString();
                txtDeskripsi.Text = dgvDamaged.Rows[e.RowIndex].Cells["Description"].Value?.ToString();
                dateReport.Value = Convert.ToDateTime(dgvDamaged.Rows[e.RowIndex].Cells["ReportDate"].Value);

                txtPlatNomor.Enabled = false;
            }
        }

        // ✅ Validasi input sebelum simpan/update
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtPlatNomor.Text))
            {
                MessageBox.Show("Plat Nomor wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(cmbTipeMobil.Text))
            {
                MessageBox.Show("Tipe Mobil wajib dipilih.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(cmbTipeServis.Text))
            {
                MessageBox.Show("Tipe Servis wajib dipilih.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDeskripsi.Text))
            {
                MessageBox.Show("Deskripsi wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void DamagedForm_Load(object sender, EventArgs e)
        {
            LoadDamagedData();
            LoadComboBoxes();
        }



        // ✅ Tombol SIMPAN
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            using (var db = new AppDbContext())
            {
                var existing = db.Damageds.FirstOrDefault(d => d.PlateNumber == txtPlatNomor.Text.Trim());

                if (existing != null)
                {
                    MessageBox.Show("Plat nomor sudah terdaftar. Gunakan UPDATE untuk mengubah data.",
                        "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newData = new Damaged
                {
                    PlateNumber = txtPlatNomor.Text.Trim(),
                    CarType = cmbTipeMobil.Text.Trim(),
                    ServiceType = cmbTipeServis.Text.Trim(),
                    Description = txtDeskripsi.Text.Trim(),
                    ReportDate = DateTime.SpecifyKind(dateReport.Value, DateTimeKind.Utc)
                };

                db.Damageds.Add(newData);
                db.SaveChanges();
            }

            LoadDamagedData();
            MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ✅ Tombol UPDATE
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedPlateNumber))
            {
                MessageBox.Show("Silakan pilih data yang ingin diperbarui.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput())
                return;

            using (var db = new AppDbContext())
            {
                var damaged = db.Damageds.FirstOrDefault(d => d.PlateNumber == selectedPlateNumber);
                if (damaged != null)
                {
                    damaged.CarType = cmbTipeMobil.Text.Trim();
                    damaged.ServiceType = cmbTipeServis.Text.Trim();
                    damaged.Description = txtDeskripsi.Text.Trim();
                    damaged.ReportDate = DateTime.SpecifyKind(dateReport.Value, DateTimeKind.Utc);

                    db.SaveChanges();
                }
            }

            LoadDamagedData();
            MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ✅ Tombol DELETE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedPlateNumber))
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
                    var damaged = db.Damageds.FirstOrDefault(d => d.PlateNumber == selectedPlateNumber);
                    if (damaged != null)
                    {
                        db.Damageds.Remove(damaged);
                        db.SaveChanges();
                    }
                }

                LoadDamagedData();
                MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
