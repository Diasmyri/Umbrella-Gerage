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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            txtAmount = new TextBox();
            datePayment = new DateTimePicker();
            comboMethod = new ComboBox();
            dataGridViewPayment = new DataGridView();
            comboClientId = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            cmbPlatNumber = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPayment).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Soccer League", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(406, 26);
            label1.Name = "label1";
            label1.Size = new Size(173, 28);
            label1.TabIndex = 2;
            label1.Text = "PAYMENT";
            label1.UseMnemonic = false;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Coral;
            label3.Location = new Point(72, 130);
            label3.Name = "label3";
            label3.Size = new Size(136, 27);
            label3.TabIndex = 6;
            label3.Text = "AMOUNT";
            label3.UseMnemonic = false;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Coral;
            label4.Location = new Point(72, 232);
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
            label5.Location = new Point(72, 165);
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
            label6.Location = new Point(72, 96);
            label6.Name = "label6";
            label6.Size = new Size(197, 27);
            label6.TabIndex = 12;
            label6.Text = "CLIENT ID";
            label6.UseMnemonic = false;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(350, 130);
            txtAmount.Margin = new Padding(3, 4, 3, 4);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(300, 27);
            txtAmount.TabIndex = 5;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // datePayment
            // 
            datePayment.Location = new Point(352, 232);
            datePayment.Name = "datePayment";
            datePayment.Size = new Size(300, 27);
            datePayment.TabIndex = 8;
            datePayment.ValueChanged += datePayment_ValueChanged;
            // 
            // comboMethod
            // 
            comboMethod.FormattingEnabled = true;
            comboMethod.Items.AddRange(new object[] { "Dana", "Gopay" });
            comboMethod.Location = new Point(350, 164);
            comboMethod.Name = "comboMethod";
            comboMethod.Size = new Size(300, 28);
            comboMethod.TabIndex = 10;
            comboMethod.SelectedIndexChanged += comboMethod_SelectedIndexChanged;
            // 
            // dataGridViewPayment
            // 
            dataGridViewPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPayment.Location = new Point(350, 329);
            dataGridViewPayment.Name = "dataGridViewPayment";
            dataGridViewPayment.RowHeadersWidth = 51;
            dataGridViewPayment.Size = new Size(487, 205);
            dataGridViewPayment.TabIndex = 13;
            dataGridViewPayment.CellContentClick += dataGridViewPayment_CellContentClick;
            // 
            // comboClientId
            // 
            comboClientId.FormattingEnabled = true;
            comboClientId.Location = new Point(350, 95);
            comboClientId.Name = "comboClientId";
            comboClientId.Size = new Size(300, 28);
            comboClientId.TabIndex = 14;
            comboClientId.SelectedIndexChanged += comboClientId_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(352, 291);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 31);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(458, 291);
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
            btnDelete.Location = new Point(566, 291);
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
            cmbPlatNumber.Items.AddRange(new object[] { "Servis Kecil", "Servis Sedang", "Servis Besar" });
            cmbPlatNumber.Location = new Point(352, 198);
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
            label2.Location = new Point(72, 199);
            label2.Name = "label2";
            label2.Size = new Size(179, 27);
            label2.TabIndex = 18;
            label2.Text = "PLAT NUMBER";
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1031, 580);
            Controls.Add(cmbPlatNumber);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(comboClientId);
            Controls.Add(dataGridViewPayment);
            Controls.Add(label6);
            Controls.Add(comboMethod);
            Controls.Add(label5);
            Controls.Add(datePayment);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtAmount);
            Controls.Add(label1);
            Name = "PaymentForm";
            Text = "Payment";
            Load += PaymentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPayment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPAY;
        private TextBox txtAmount;
        private DateTimePicker datePayment;
        private ComboBox comboMethod;
        private DataGridView dataGridViewPayment;
        private ComboBox comboClientId;
        private TextBox txtClientId;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private ComboBox cmbPlatNumber;
        private Label label2;
    }
}