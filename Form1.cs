using Umbrella_gerage.Forms;

namespace Umbrella_gerage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializePanelContainer();
        }
        private Panel panelContainer;

        private void InitializePanelContainer()
        {
            panelContainer = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.WhiteSmoke, // biar lebih netral dan terang
                Visible = true // langsung tampil, karena ini area utama
            };

            this.Controls.Add(panelContainer);
            panelContainer.BringToFront();
        }

        // ? Fungsi untuk menampilkan form di dalam panel
        private void LoadFormToPanel(Form form)
        {
            if (panelContainer == null)
            {
                InitializePanelContainer();
            }

            panelContainer.Controls.Clear(); // hapus form sebelumnya
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(form);
            form.Show();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFormToPanel(new ClientForm());
        }
    }
}
    