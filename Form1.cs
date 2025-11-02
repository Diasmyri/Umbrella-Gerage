using Umbrella_gerage.Forms;

namespace Umbrella_gerage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void OpenChildForm(Form childForm)
        {
            // Tutup semua form anak sebelumnya
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            // Tampilkan form baru dalam container
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
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
