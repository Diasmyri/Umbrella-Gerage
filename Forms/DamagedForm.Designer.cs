namespace Umbrella_gerage.Forms
{
    partial class DamagedForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DamagedForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtPlatNomor = new TextBox();
            txtDeskripsi = new TextBox();
            cmbTipeMobil = new ComboBox();
            cmbTipeServis = new ComboBox();
            dateReport = new DateTimePicker();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label7 = new Label();
            dgvDamaged = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDamaged).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Soccer League", 24F);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(324, 32);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(168, 32);
            label1.TabIndex = 0;
            label1.Text = "DAMAGED";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(52, 87);
            label2.Name = "label2";
            label2.Size = new Size(152, 24);
            label2.TabIndex = 1;
            label2.Text = "PLAT NUMBER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Coral;
            label3.Location = new Point(53, 130);
            label3.Name = "label3";
            label3.Size = new Size(109, 24);
            label3.TabIndex = 2;
            label3.Text = "CAR TYPE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Coral;
            label4.Location = new Point(52, 175);
            label4.Name = "label4";
            label4.Size = new Size(153, 24);
            label4.TabIndex = 3;
            label4.Text = "SERVICE TYPE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Coral;
            label5.Location = new Point(53, 217);
            label5.Name = "label5";
            label5.Size = new Size(144, 24);
            label5.TabIndex = 4;
            label5.Text = "DESCRIPTION";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Coral;
            label6.Location = new Point(52, 259);
            label6.Name = "label6";
            label6.Size = new Size(153, 24);
            label6.TabIndex = 5;
            label6.Text = "SERVICE DATE";
            // 
            // txtPlatNomor
            // 
            txtPlatNomor.Location = new Point(217, 81);
            txtPlatNomor.Name = "txtPlatNomor";
            txtPlatNomor.Size = new Size(284, 32);
            txtPlatNomor.TabIndex = 6;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(217, 211);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(284, 32);
            txtDeskripsi.TabIndex = 7;
            // 
            // cmbTipeMobil
            // 
            cmbTipeMobil.FormattingEnabled = true;
            cmbTipeMobil.Items.AddRange(new object[] { "Avanza", "Terios", "Xpander" });
            cmbTipeMobil.Location = new Point(217, 124);
            cmbTipeMobil.Name = "cmbTipeMobil";
            cmbTipeMobil.Size = new Size(284, 34);
            cmbTipeMobil.TabIndex = 8;
            // 
            // cmbTipeServis
            // 
            cmbTipeServis.FormattingEnabled = true;
            cmbTipeServis.Items.AddRange(new object[] { "Servis Kecil", "Servis Sedang", "Servis Besar" });
            cmbTipeServis.Location = new Point(217, 169);
            cmbTipeServis.Name = "cmbTipeServis";
            cmbTipeServis.Size = new Size(284, 34);
            cmbTipeServis.TabIndex = 9;
            // 
            // dateReport
            // 
            dateReport.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateReport.Location = new Point(217, 252);
            dateReport.Name = "dateReport";
            dateReport.Size = new Size(284, 31);
            dateReport.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(217, 314);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 11;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(344, 314);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 30);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(473, 314);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Soccer League", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(311, 357);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(138, 16);
            label7.TabIndex = 14;
            label7.Text = "Data Damaged";
            // 
            // dgvDamaged
            // 
            dgvDamaged.AllowUserToAddRows = false;
            dgvDamaged.AllowUserToDeleteRows = false;
            dgvDamaged.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDamaged.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDamaged.Location = new Point(27, 386);
            dgvDamaged.MultiSelect = false;
            dgvDamaged.Name = "dgvDamaged";
            dgvDamaged.ReadOnly = true;
            dgvDamaged.RowHeadersWidth = 51;
            dgvDamaged.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDamaged.Size = new Size(711, 185);
            dgvDamaged.TabIndex = 15;
            dgvDamaged.CellClick += dgvDamaged_CellClick;
            // 
            // DamagedForm
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(762, 595);
            Controls.Add(dgvDamaged);
            Controls.Add(label7);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(dateReport);
            Controls.Add(cmbTipeServis);
            Controls.Add(cmbTipeMobil);
            Controls.Add(txtDeskripsi);
            Controls.Add(txtPlatNomor);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "DamagedForm";
            Text = "Damaged";
            Load += DamagedForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDamaged).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtPlatNomor;
        private TextBox txtDeskripsi;
        private ComboBox cmbTipeMobil;
        private ComboBox cmbTipeServis;
        private DateTimePicker dateReport;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label7;
        private DataGridView dgvDamaged;
    }
}
