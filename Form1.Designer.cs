namespace Umbrella_gerage
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem clientToolStripMenuItem;
        private ToolStripMenuItem damagedToolStripMenuItem;
        private ToolStripMenuItem paymentToolStripMenuItem;


        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            clientToolStripMenuItem = new ToolStripMenuItem();
            damagedToolStripMenuItem = new ToolStripMenuItem();
            paymentToolStripMenuItem = new ToolStripMenuItem();
            panelContent = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Controls.Add(this.panelContent);

            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { clientToolStripMenuItem, damagedToolStripMenuItem, paymentToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(820, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // clientToolStripMenuItem
            // 
            clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            clientToolStripMenuItem.Size = new Size(50, 20);
            clientToolStripMenuItem.Text = "Client";
            clientToolStripMenuItem.Click += clientToolStripMenuItem_Click;
            // 
            // damagedToolStripMenuItem
            // 
            damagedToolStripMenuItem.Name = "damagedToolStripMenuItem";
            damagedToolStripMenuItem.Size = new Size(70, 20);
            damagedToolStripMenuItem.Text = "Damaged";
            damagedToolStripMenuItem.Click += damagedToolStripMenuItem_Click;
            // 
            // paymentToolStripMenuItem
            // 
            paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            paymentToolStripMenuItem.Size = new Size(66, 20);
            paymentToolStripMenuItem.Text = "Payment";
            paymentToolStripMenuItem.Click += paymentToolStripMenuItem_Click;
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 24);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(820, 375);
            panelContent.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(820, 399);
            Controls.Add(panelContent);
            Controls.Add(menuStrip1);
            ForeColor = Color.Coral;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Umbrella Garage System";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        private Panel panelContent;
    }
}
