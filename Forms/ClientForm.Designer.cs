namespace Umbrella_gerage.Forms
{
    partial class ClientForm
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
            Label label1;
            Label label2;
            Label label3;
            Label label4;
            Label label5;
            Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            btnSave = new Button();
            dgvClient = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClient).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(28, 34);
            label1.Name = "label1";
            label1.Size = new Size(288, 40);
            label1.TabIndex = 1;
            label1.Text = "INPUT YOUR DATA";
            label1.UseMnemonic = false;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(28, 105);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 2;
            label2.Text = "NAME";
            label2.UseMnemonic = false;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Coral;
            label3.Location = new Point(28, 146);
            label3.Name = "label3";
            label3.Size = new Size(105, 27);
            label3.TabIndex = 6;
            label3.Text = "EMAIL";
            label3.UseMnemonic = false;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Coral;
            label4.Location = new Point(28, 189);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 6;
            label4.Text = "PHONE";
            label4.UseMnemonic = false;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Coral;
            label5.Location = new Point(28, 235);
            label5.Name = "label5";
            label5.Size = new Size(130, 22);
            label5.TabIndex = 8;
            label5.Text = "ADDRESS";
            label5.UseMnemonic = false;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.MenuHighlight;
            label6.Location = new Point(551, 34);
            label6.Name = "label6";
            label6.Size = new Size(195, 45);
            label6.TabIndex = 13;
            label6.Text = "LIST PANEL";
            label6.UseMnemonic = false;
            // 
            // txtName
            // 
            txtName.Location = new Point(170, 105);
            txtName.Name = "txtName";
            txtName.Size = new Size(190, 23);
            txtName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(170, 146);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(190, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(170, 189);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(190, 23);
            txtPhone.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.AcceptsReturn = true;
            txtAddress.Location = new Point(170, 235);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(190, 23);
            txtAddress.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(28, 314);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(92, 30);
            btnSave.TabIndex = 9;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvClient
            // 
            dgvClient.BackgroundColor = Color.MintCream;
            dgvClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClient.Location = new Point(392, 105);
            dgvClient.Name = "dgvClient";
            dgvClient.RowHeadersWidth = 51;
            dgvClient.Size = new Size(450, 239);
            dgvClient.TabIndex = 12;
            dgvClient.CellClick += dgvClient_CellClick_1;
            dgvClient.CellContentClick += dgvClient_CellContentClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(126, 314);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 30);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(224, 314);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 30);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(880, 391);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(label6);
            Controls.Add(dgvClient);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ClientForm";
            Text = "Client";
            Load += Client_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private Button btnSave;
        private DataGridView dgvClient;
        private Button btnUpdate;
        private Button btnDelete;
    }
}