namespace Umbrella_gerage.Forms
{
    partial class PaymentForm
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
            Label label3;
            Label label4;
            Label label5;
            Label label6;
            txtPrice = new TextBox();
            datePayment = new DateTimePicker();
            cmbMethod = new ComboBox();
            dgvPayment = new DataGridView();
            cmbClientId = new ComboBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            cmbPlatNumber = new ComboBox();
            label2 = new Label();
            btnClear = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPayment).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Soccer League", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(445, 37);
            label1.Name = "label1";
            label1.Size = new Size(172, 38);
            label1.TabIndex = 2;
            label1.Text = "PAYMENT";
            label1.UseMnemonic = false;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Coral;
            label3.Location = new Point(82, 173);
            label3.Name = "label3";
            label3.Size = new Size(136, 27);
            label3.TabIndex = 6;
            label3.Text = "PRICE";
            label3.UseMnemonic = false;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Coral;
            label4.Location = new Point(82, 309);
            label4.Name = "label4";
            label4.Size = new Size(251, 27);
            label4.TabIndex = 7;
            label4.Text = "PAYMENT DATE";
            label4.UseMnemonic = false;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Coral;
            label5.Location = new Point(82, 220);
            label5.Name = "label5";
            label5.Size = new Size(127, 27);
            label5.TabIndex = 9;
            label5.Text = "METHOD";
            label5.UseMnemonic = false;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Coral;
            label6.Location = new Point(82, 128);
            label6.Name = "label6";
            label6.Size = new Size(197, 27);
            label6.TabIndex = 12;
            label6.Text = "CLIENT ID";
            label6.UseMnemonic = false;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(400, 173);
            txtPrice.Margin = new Padding(3, 5, 3, 5);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(300, 27);
            txtPrice.TabIndex = 5;
            // 
            // datePayment
            // 
            datePayment.Location = new Point(402, 309);
            datePayment.Margin = new Padding(3, 4, 3, 4);
            datePayment.Name = "datePayment";
            datePayment.Size = new Size(300, 27);
            datePayment.TabIndex = 8;
            // 
            // cmbMethod
            // 
            cmbMethod.FormattingEnabled = true;
            cmbMethod.Items.AddRange(new object[] { "Cash", "Transfer", "Credit Card", "E-Wallet" });
            cmbMethod.Location = new Point(400, 219);
            cmbMethod.Margin = new Padding(3, 4, 3, 4);
            cmbMethod.Name = "cmbMethod";
            cmbMethod.Size = new Size(300, 28);
            cmbMethod.TabIndex = 10;
            // 
            // dgvPayment
            // 
            dgvPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayment.Location = new Point(400, 404);
            dgvPayment.Name = "dgvPayment";
            dgvPayment.RowHeadersWidth = 51;
            dgvPayment.Size = new Size(487, 205);
            dgvPayment.TabIndex = 13;
            dgvPayment.CellDoubleClick += dgvPayment_CellClick;
            // 
            // cmbClientId
            // 
            cmbClientId.FormattingEnabled = true;
            cmbClientId.Location = new Point(400, 127);
            cmbClientId.Margin = new Padding(3, 4, 3, 4);
            cmbClientId.Name = "cmbClientId";
            cmbClientId.Size = new Size(300, 28);
            cmbClientId.TabIndex = 14;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(402, 365);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 15;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(494, 365);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 31);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(586, 365);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cmbPlatNumber
            // 
            cmbPlatNumber.FormattingEnabled = true;
            cmbPlatNumber.Location = new Point(400, 264);
            cmbPlatNumber.Margin = new Padding(3, 4, 3, 4);
            cmbPlatNumber.Name = "cmbPlatNumber";
            cmbPlatNumber.Size = new Size(300, 28);
            cmbPlatNumber.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(82, 265);
            label2.Name = "label2";
            label2.Size = new Size(179, 27);
            label2.TabIndex = 18;
            label2.Text = "PLAT NUMBER";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(679, 365);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 31);
            btnClear.TabIndex = 20;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1178, 773);
            Controls.Add(btnClear);
            Controls.Add(cmbPlatNumber);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(cmbClientId);
            Controls.Add(dgvPayment);
            Controls.Add(label6);
            Controls.Add(cmbMethod);
            Controls.Add(label5);
            Controls.Add(datePayment);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPrice);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PaymentForm";
            Text = "Payment";
            Load += PaymentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPayment).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DateTimePicker datePayment;
        private System.Windows.Forms.ComboBox cmbMethod;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.ComboBox cmbClientId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbPlatNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Button btnClear;
    }
}
