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
using Umbrella_gerage.Services;

namespace Umbrella_gerage.Forms
{
    public partial class DamagedForm : Form
    {
        private readonly DamagedService _damagedService;
        public DamagedForm()
        {
            InitializeComponent();
            _damagedService = new DamagedService(new AppDbContext());
        }
        private void DamagedForm_Load(object sender, EventArgs e)
        {
            LoadServiceType();
            LoadDamagedData();
            dateReport.Value = DateTime.Now;
        }
        private void LoadServiceType()
        {
            // Daftar jenis servis
            comboServiceType.Items.Clear();
            comboServiceType.Items.AddRange(new string[]
            {
                "Ganti Oli",
                "Servis Mesin",
                "Ganti Ban",
                "Cat Body",
                "Perbaikan AC",
                "Tune Up",
                "Cuci Mobil"
            });
        }
        private void LoadDamagedData()
        {
            try
            {
                var list = _damagedService.GetAll()
                    .Select(d => new
                    {
                        d.PlateNumber,
                        d.CarType,
                        d.ServiceType,
                        d.Description,
                        d.ReportDate
                    })
                    .ToList();

                dataGridViewDamaged.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        private void ClearForm()
        {
            txtPlateNumber.Clear();
            comboCarType.SelectedIndex=-1;
            comboServiceType.SelectedIndex = -1;
            txtDescription.Clear();
            dateReport.Value = DateTime.Now;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboCarType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateReport_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPlateNumber.Text) ||
                    string.IsNullOrWhiteSpace(comboCarType.Text) ||
                    comboServiceType.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                var damaged = new Damaged
                {
                    PlateNumber = txtPlateNumber.Text.Trim(),
                    CarType = comboCarType.Text.Trim(),
                    ServiceType = comboServiceType.Text,
                    Description = txtDescription.Text.Trim(),
                    ReportDate = dateReport.Value
                };

                _damagedService.Add(damaged);
                MessageBox.Show("Data added successfully!");

                LoadDamagedData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding data: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPlateNumber.Text))
                {
                    MessageBox.Show("Please select a record to update.");
                    return;
                }

                var damaged = new Damaged
                {
                    PlateNumber = txtPlateNumber.Text.Trim(),
                    CarType = comboCarType.Text.Trim(),
                    ServiceType = comboServiceType.Text,
                    Description = txtDescription.Text.Trim(),
                    ReportDate = dateReport.Value
                };

                _damagedService.Update(damaged);
                MessageBox.Show("Data updated successfully!");

                LoadDamagedData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPlateNumber.Text))
                {
                    MessageBox.Show("Please select a record to delete.");
                    return;
                }

                var confirm = MessageBox.Show("Are you sure to delete this record?",
                                              "Confirm Delete",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    _damagedService.Delete(txtPlateNumber.Text.Trim());
                    MessageBox.Show("Data deleted successfully!");

                    LoadDamagedData();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting data: " + ex.Message);
            }
        }

        private void dataGridViewDamaged_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridViewDamaged.Rows[e.RowIndex];
                    txtPlateNumber.Text = row.Cells["PlateNumber"].Value.ToString();
                    comboCarType.Text = row.Cells["CarType"].Value.ToString();
                    comboServiceType.Text = row.Cells["ServiceType"].Value.ToString();
                    txtDescription.Text = row.Cells["Description"].Value?.ToString();
                    dateReport.Value = Convert.ToDateTime(row.Cells["ReportDate"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting row: " + ex.Message);
            }
        }
    }
    }

