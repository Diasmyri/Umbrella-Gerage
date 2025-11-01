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
            label1.Font = new Font("Blacklisted", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(288, 30);
            label1.Name = "label1";
            label1.Size = new Size(188, 55);
            label1.TabIndex = 2;
            label1.Text = "PAYMENT";
            label1.UseMnemonic = false;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("CollegiateInsideFLF", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Coral;
            label3.Location = new Point(73, 171);
            label3.Name = "label3";
            label3.Size = new Size(136, 27);
            label3.TabIndex = 6;
            label3.Text = "AMOUNT";
            label3.UseMnemonic = false;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(350, 171);
            txtAmount.Margin = new Padding(3, 4, 3, 4);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(300, 27);
            txtAmount.TabIndex = 5;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("CollegiateInsideFLF", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Coral;
            label4.Location = new Point(73, 216);
            label4.Name = "label4";
            label4.Size = new Size(252, 27);
            label4.TabIndex = 7;
            label4.Text = "PAYMENT DATE";
            label4.UseMnemonic = false;
            // 
            // datePayment
            // 
            datePayment.Location = new Point(350, 213);
            datePayment.Name = "datePayment";
            datePayment.Size = new Size(300, 27);
            datePayment.TabIndex = 8;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("CollegiateInsideFLF", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Coral;
            label5.Location = new Point(73, 254);
            label5.Name = "label5";
            label5.Size = new Size(127, 27);
            label5.TabIndex = 9;
            label5.Text = "METHOD";
            label5.UseMnemonic = false;
            // 
            // comboMethod
            // 
            comboMethod.FormattingEnabled = true;
            comboMethod.Items.AddRange(new object[] { "Dana", "Gopay" });
            comboMethod.Location = new Point(350, 253);
            comboMethod.Name = "comboMethod";
            comboMethod.Size = new Size(300, 28);
            comboMethod.TabIndex = 10;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("CollegiateInsideFLF", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Coral;
            label6.Location = new Point(73, 131);
            label6.Name = "label6";
            label6.Size = new Size(196, 26);
            label6.TabIndex = 12;
            label6.Text = "CLIENT ID";
            label6.UseMnemonic = false;
            // 
            // dataGridViewPayment
            // 
            dataGridViewPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPayment.Location = new Point(350, 287);
            dataGridViewPayment.Name = "dataGridViewPayment";
            dataGridViewPayment.RowHeadersWidth = 51;
            dataGridViewPayment.Size = new Size(300, 163);
            dataGridViewPayment.TabIndex = 13;
            // 
            // comboClientId
            // 
            comboClientId.FormattingEnabled = true;
            comboClientId.Location = new Point(350, 129);
            comboClientId.Name = "comboClientId";
            comboClientId.Size = new Size(300, 28);
            comboClientId.TabIndex = 14;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(747, 462);
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
    }
}