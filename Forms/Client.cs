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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void dgvClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtName.Text = dgvClient.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtEmail.Text = dgvClient.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txtPhone.Text = dgvClient.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                txtAddress.Text = dgvClient.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            }
        }

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

        }


        private void Client_Load(object sender, EventArgs e)
        {
            LoadClientData();
        }

        private void ClearForm()
        {
            throw new NotImplementedException();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
