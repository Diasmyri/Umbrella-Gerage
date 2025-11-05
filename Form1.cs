using Umbrella_gerage.Forms;

namespace Umbrella_gerage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            MessageBox.Show("Selamat datang di Umbrella Garage!");
        }

        // ?? Fungsi untuk load form ke panel
        private void OpenChildForm(Form childForm)
        {
            // Bersihkan panel dulu
            panelContent.Controls.Clear();

            // Set form agar tampil di dalam panel
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Tambahkan ke panel
            panelContent.Controls.Add(childForm);
            childForm.Show();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ClientForm());
        }

        private void damagedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DamagedForm());
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PaymentForm());
        }
    }
}
