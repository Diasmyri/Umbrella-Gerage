using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Umbrella_gerage.Data;
using Umbrella_gerage.Models;

namespace Umbrella_gerage.Forms
{
    public partial class PaymentForm : Form
    {
        private int? selectedPaymentId = null;

        public PaymentForm()
        {
            InitializeComponent();
            LoadPaymentData();
            LoadComboBoxes();
        }

        // ✅ Load semua data saat form dibuka
        private void PaymentForm_Load(object sender, EventArgs e)
        {
            LoadPaymentData();
            LoadComboBoxes();
        }

        // ✅ Load data ke DataGridView
        private void LoadPaymentData()
        {
            using (var db = new AppDbContext())
            {
                dgvPayment.DataSource = db.Payments
                    .Select(p => new
                    {
                        p.PaymentId,
                        Client = p.Client.Name,
                        p.Price,
                        p.Method,
                        p.PlatNumber,
                        p.PaymentDate
                    })
                    .OrderByDescending(p => p.PaymentDate)
                    .ToList();
            }

            dgvPayment.ClearSelection();
            ClearForm();
        }

        // ✅ Load ComboBox
        private void LoadComboBoxes()
        {
            using (var db = new AppDbContext())
            {
                // Client
                var clients = db.Clients
                    .Select(c => new { c.ClientId, c.Name })
                    .ToList();
                cmbClientId.DataSource = clients;
                cmbClientId.DisplayMember = "Name";
                cmbClientId.ValueMember = "ClientId";
                cmbClientId.SelectedIndex = -1;

                // Plat Number
                var plats = db.Damageds
                    .Select(d => d.PlateNumber)
                    .Distinct()
                    .ToList();
                cmbPlatNumber.DataSource = plats;
                cmbPlatNumber.SelectedIndex = -1;
            }

            // Payment Methods
            cmbMethod.Items.Clear();
            cmbMethod.Items.AddRange(new object[]
            {
                "Cash", "Transfer", "Credit Card", "E-Wallet"
            });
            cmbMethod.SelectedIndex = -1;
        }

        // ✅ Validasi Input seperti di DamagedForm
        private bool ValidateInput()
        {
            if (cmbClientId.SelectedValue == null)
            {
                MessageBox.Show("Client wajib dipilih.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Harga wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!decimal.TryParse(txtPrice.Text, out _))
            {
                MessageBox.Show("Harga harus berupa angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Metode pembayaran wajib dipilih.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbPlatNumber.SelectedIndex == -1)
            {
                MessageBox.Show("Plat nomor wajib dipilih.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // ✅ Tombol SIMPAN
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            using (var db = new AppDbContext())
            {
                var newPayment = new Payment
                {
                    ClientId = (int)cmbClientId.SelectedValue,
                    Price = decimal.Parse(txtPrice.Text.Trim()),
                    Method = cmbMethod.Text.Trim(),
                    PlatNumber = cmbPlatNumber.Text.Trim(),
                    PaymentDate = datePayment.Value.ToUniversalTime() // ✅ fix timezone untuk PostgreSQL
                };

                db.Payments.Add(newPayment);
                db.SaveChanges();
            }

            LoadPaymentData();
            MessageBox.Show("Data pembayaran berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ✅ Tombol UPDATE
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedPaymentId == null)
            {
                MessageBox.Show("Silakan pilih data yang ingin diperbarui.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput())
                return;

            using (var db = new AppDbContext())
            {
                var payment = db.Payments.FirstOrDefault(p => p.PaymentId == selectedPaymentId);
                if (payment != null)
                {
                    payment.ClientId = (int)cmbClientId.SelectedValue;
                    payment.Price = decimal.Parse(txtPrice.Text.Trim());
                    payment.Method = cmbMethod.Text.Trim();
                    payment.PlatNumber = cmbPlatNumber.Text.Trim();
                    payment.PaymentDate = datePayment.Value.ToUniversalTime(); // ✅ tetap UTC

                    db.SaveChanges();
                }
            }

            LoadPaymentData();
            MessageBox.Show("Data pembayaran berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ✅ Tombol DELETE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedPaymentId == null)
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
                    var payment = db.Payments.FirstOrDefault(p => p.PaymentId == selectedPaymentId);
                    if (payment != null)
                    {
                        db.Payments.Remove(payment);
                        db.SaveChanges();
                    }
                }

                LoadPaymentData();
                MessageBox.Show("Data pembayaran berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ✅ Klik data grid → isi form
        private void dgvPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvPayment.Rows[e.RowIndex];
                selectedPaymentId = Convert.ToInt32(row.Cells["PaymentId"].Value);

                cmbClientId.Text = row.Cells["Client"].Value?.ToString();
                txtPrice.Text = row.Cells["Price"].Value?.ToString();
                cmbMethod.Text = row.Cells["Method"].Value?.ToString();
                cmbPlatNumber.Text = row.Cells["PlatNumber"].Value?.ToString();

                if (row.Cells["PaymentDate"].Value != null)
                {
                    datePayment.Value = Convert.ToDateTime(row.Cells["PaymentDate"].Value).ToLocalTime();
                }
            }
        }

        // ✅ Kosongkan input form
        private void ClearForm()
        {
            cmbClientId.SelectedIndex = -1;
            txtPrice.Clear();
            cmbMethod.SelectedIndex = -1;
            cmbPlatNumber.SelectedIndex = -1;
            datePayment.Value = DateTime.Now;
            selectedPaymentId = null;
        }

        // ✅ Utility untuk tampilkan error lengkap
        private void ShowDetailedError(Exception ex)
        {
            string error = ex.Message;
            if (ex.InnerException != null)
            {
                error += "\n\nInner Exception:\n" + ex.InnerException.Message;
                if (ex.InnerException.InnerException != null)
                    error += "\n\nRoot Cause:\n" + ex.InnerException.InnerException.Message;
            }

            MessageBox.Show(error, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
