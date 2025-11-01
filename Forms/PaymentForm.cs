using System;
using System.Linq;
using System.Windows.Forms;
using Umbrella_gerage.Data;
using Umbrella_gerage.Models;

namespace Umbrella_gerage.Forms
{
    public partial class PaymentForm : Form
    {
        private readonly AppDbContext _context;

        public PaymentForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        // ===================== FORM LOAD =====================
        private void PaymentForm_Load(object sender, EventArgs e)
        {
            LoadClients();
            LoadPayments();
            comboMethod.Items.Clear();
            comboMethod.Items.Add("Dana");
            comboMethod.Items.Add("Gopay");
        }

        // ===================== LOAD DATA =====================
        private void LoadClients()
        {
            try
            {
                comboClientId.DataSource = _context.Clients.ToList();
                comboClientId.DisplayMember = "ClientId";   // tampilkan ID
                comboClientId.ValueMember = "ClientId";
                comboClientId.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading clients: " + ex.Message);
            }
        }

        private void LoadPayments()
        {
            try
            {
                var payments = _context.Payments
                    .Select(p => new
                    {
                        p.PaymentId,
                        p.ClientId,
                        p.Amount,
                        p.PaymentDate,
                        p.Method
                    })
                    .ToList();

                dataGridViewPayment.DataSource = payments;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payments: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            comboClientId.SelectedIndex = -1;
            txtAmount.Clear();
            comboMethod.SelectedIndex = -1;
            datePayment.Value = DateTime.Now;
        }

        // ===================== EVENT HANDLERS =====================
        private void comboClientId_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kosongkan (tidak wajib diisi)
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtAmount.Text, out _) && txtAmount.Text != "")
            {
                MessageBox.Show("Please enter a valid amount.", "Invalid Input");
                txtAmount.Clear();
            }
        }

        private void datePayment_ValueChanged(object sender, EventArgs e)
        {
            // Tidak perlu isi apa-apa
        }

        private void comboMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Tidak perlu isi apa-apa
        }

        private void dataGridViewPayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridViewPayment.Rows[e.RowIndex];
                    comboClientId.SelectedValue = row.Cells["ClientId"].Value;
                    txtAmount.Text = row.Cells["Amount"].Value.ToString();
                    datePayment.Value = Convert.ToDateTime(row.Cells["PaymentDate"].Value);
                    comboMethod.Text = row.Cells["Method"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting row: " + ex.Message);
            }
        }

        // ===================== BUTTON ACTIONS =====================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboClientId.SelectedValue == null ||
                    string.IsNullOrEmpty(txtAmount.Text) ||
                    comboMethod.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill all fields.");
                    return;
                }

                var payment = new Payment
                {
                    ClientId = (int)comboClientId.SelectedValue,
                    Amount = decimal.Parse(txtAmount.Text),
                    PaymentDate = datePayment.Value,
                    Method = comboMethod.Text
                };

                _context.Payments.Add(payment);
                _context.SaveChanges();

                MessageBox.Show("Payment added successfully!");
                LoadPayments();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding payment: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPayment.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a payment to update.");
                    return;
                }

                int id = Convert.ToInt32(dataGridViewPayment.SelectedRows[0].Cells["PaymentId"].Value);
                var payment = _context.Payments.FirstOrDefault(p => p.PaymentId == id);

                if (payment != null)
                {
                    payment.ClientId = (int)comboClientId.SelectedValue;
                    payment.Amount = decimal.Parse(txtAmount.Text);
                    payment.PaymentDate = datePayment.Value;
                    payment.Method = comboMethod.Text;

                    _context.SaveChanges();

                    MessageBox.Show("Payment updated successfully!");
                    LoadPayments();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating payment: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPayment.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a payment to delete.");
                    return;
                }

                int id = Convert.ToInt32(dataGridViewPayment.SelectedRows[0].Cells["PaymentId"].Value);
                var payment = _context.Payments.FirstOrDefault(p => p.PaymentId == id);

                if (payment != null)
                {
                    _context.Payments.Remove(payment);
                    _context.SaveChanges();

                    MessageBox.Show("Payment deleted successfully!");
                    LoadPayments();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting payment: " + ex.Message);
            }
        }
    }
}
