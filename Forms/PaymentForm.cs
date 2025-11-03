using System;
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

        // ✅ Load semua data payment
        private void LoadPaymentData()
        {
            using (var db = new AppDbContext())
            {
                dgvPayment.DataSource = db.Payments
                    .Select(p => new
                    {
                        p.PaymentId,
                        ClientName = p.Client.Name,
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

        // ✅ Isi combo box (client, plat, method)
        private void LoadComboBoxes()
        {
            using (var db = new AppDbContext())
            {
                cmbClientId.DataSource = db.Clients
                    .Select(c => new { c.ClientId, c.Name })
                    .ToList();
                cmbClientId.DisplayMember = "Name";
                cmbClientId.ValueMember = "ClientId";
                cmbClientId.SelectedIndex = -1;

                cmbPlatNumber.DataSource = db.Damageds
                    .Select(d => d.PlateNumber)
                    .Distinct()
                    .ToList();
                cmbPlatNumber.SelectedIndex = -1;
            }

            cmbMethod.Items.Clear();
            cmbMethod.Items.AddRange(new string[]
            {
                "Cash", "Transfer", "Credit Card", "E-Wallet"
            });
            cmbMethod.SelectedIndex = -1;
        }

        // ✅ Kosongkan form input
        private void ClearForm()
        {
            cmbClientId.SelectedIndex = -1;
            txtPrice.Clear();
            cmbMethod.SelectedIndex = -1;
            cmbPlatNumber.SelectedIndex = -1;
            datePayment.Value = DateTime.Now;
            selectedPaymentId = null;
        }

        // ✅ Klik baris → isi form otomatis
        private void dgvPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedPaymentId = Convert.ToInt32(dgvPayment.Rows[e.RowIndex].Cells["PaymentId"].Value);
                cmbClientId.Text = dgvPayment.Rows[e.RowIndex].Cells["ClientName"].Value?.ToString();
                txtPrice.Text = dgvPayment.Rows[e.RowIndex].Cells["Price"].Value?.ToString();
                cmbMethod.Text = dgvPayment.Rows[e.RowIndex].Cells["Method"].Value?.ToString();
                cmbPlatNumber.Text = dgvPayment.Rows[e.RowIndex].Cells["PlatNumber"].Value?.ToString();
                datePayment.Value = Convert.ToDateTime(dgvPayment.Rows[e.RowIndex].Cells["PaymentDate"].Value);
            }
        }

        // ✅ Validasi input seperti DamagedForm
        private bool ValidateInput()
        {
            if (cmbClientId.SelectedIndex == -1)
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
            if (string.IsNullOrWhiteSpace(cmbMethod.Text))
            {
                MessageBox.Show("Metode pembayaran wajib dipilih.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(cmbPlatNumber.Text))
            {
                MessageBox.Show("Plat nomor wajib dipilih.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // ✅ Tombol SIMPAN
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            using (var db = new AppDbContext())
            {
                var newPayment = new Payment
                {
                    ClientId = (int)cmbClientId.SelectedValue,
                    Price = decimal.Parse(txtPrice.Text.Trim()),
                    Method = cmbMethod.Text.Trim(),
                    PlatNumber = cmbPlatNumber.Text.Trim(),
                    PaymentDate = DateTime.SpecifyKind(datePayment.Value, DateTimeKind.Unspecified)
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
                MessageBox.Show("Pilih data yang ingin diperbarui.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput()) return;

            using (var db = new AppDbContext())
            {
                var payment = db.Payments.FirstOrDefault(p => p.PaymentId == selectedPaymentId);
                if (payment != null)
                {
                    payment.ClientId = (int)cmbClientId.SelectedValue;
                    payment.Price = decimal.Parse(txtPrice.Text.Trim());
                    payment.Method = cmbMethod.Text.Trim();
                    payment.PlatNumber = cmbPlatNumber.Text.Trim();
                    payment.PaymentDate = DateTime.SpecifyKind(datePayment.Value, DateTimeKind.Unspecified);

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

        // ✅ Saat form load ulang data
        private void PaymentForm_Load(object sender, EventArgs e)
        {
            LoadPaymentData();
            LoadComboBoxes();
        }
    }
}
