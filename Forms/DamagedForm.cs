using System;
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

        private void DamagedForm_Load(object sender, EventArgs e)
        {
            LoadDamagedData();
            LoadComboBoxes();
        }

        // ✅ Menampilkan data ke DataGridView
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
                    .OrderByDescending(d => d.ReportDate)
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

        // ✅ Validasi input sebelum simpan/update
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtPlatNomor.Text))
            {
                MessageBox.Show("Plat Nomor wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbTipeMobil.SelectedIndex == -1)
            {
                MessageBox.Show("Tipe Mobil wajib dipilih.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbTipeServis.SelectedIndex == -1)
            {
                MessageBox.Show("Tipe Servis wajib dipilih.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDeskripsi.Text))
            {
                MessageBox.Show("Deskripsi wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // ✅ Validasi tanggal — hanya boleh hari ini atau besok
            DateTime selectedDate = dateReport.Value.Date;
            DateTime today = DateTime.Now.Date;
            DateTime tomorrow = today.AddDays(1);

            if (selectedDate < today)
            {
                MessageBox.Show("Tanggal laporan tidak boleh sebelum hari ini.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (selectedDate > tomorrow)
            {
                MessageBox.Show("Tanggal laporan hanya boleh hari ini atau besok.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // ✅ Klik DataGridView → isi form
        private void dgvDamaged_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvDamaged.Rows[e.RowIndex];
                selectedPlateNumber = row.Cells["PlateNumber"].Value?.ToString();

                txtPlatNomor.Text = selectedPlateNumber;
                cmbTipeMobil.Text = row.Cells["CarType"].Value?.ToString();
                cmbTipeServis.Text = row.Cells["ServiceType"].Value?.ToString();
                txtDeskripsi.Text = row.Cells["Description"].Value?.ToString();

                if (row.Cells["ReportDate"].Value != null)
                    dateReport.Value = Convert.ToDateTime(row.Cells["ReportDate"].Value);

                txtPlatNomor.Enabled = false;
            }
        }

        // ✅ Tombol SIMPAN
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            using (var db = new AppDbContext())
            {
                string plate = txtPlatNomor.Text.Trim();
                var existing = db.Damageds.FirstOrDefault(d => d.PlateNumber == plate);

                if (existing != null)
                {
                    MessageBox.Show("Plat nomor sudah terdaftar. Gunakan UPDATE untuk mengubah data.",
                        "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newData = new Damaged
                {
                    PlateNumber = plate,
                    CarType = cmbTipeMobil.Text.Trim(),
                    ServiceType = cmbTipeServis.Text.Trim(),
                    Description = txtDeskripsi.Text.Trim(),
                    ReportDate = DateTime.SpecifyKind(dateReport.Value, DateTimeKind.Unspecified)
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
            if (selectedPlateNumber == null)
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
                    damaged.ReportDate = DateTime.SpecifyKind(dateReport.Value, DateTimeKind.Unspecified);

                    db.SaveChanges();
                }
            }

            LoadDamagedData();
            MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ✅ Tombol DELETE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedPlateNumber == null)
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
