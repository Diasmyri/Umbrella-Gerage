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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtPlateNumber = new TextBox();
            txtDescription = new TextBox();
            comboCarType = new ComboBox();
            comboServiceType = new ComboBox();
            dateReport = new DateTimePicker();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label7 = new Label();
            dataGridViewDamaged = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDamaged).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 34);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "DAMAGED";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 84);
            label2.Name = "label2";
            label2.Size = new Size(112, 19);
            label2.TabIndex = 1;
            label2.Text = "Plate Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 132);
            label3.Name = "label3";
            label3.Size = new Size(77, 19);
            label3.TabIndex = 2;
            label3.Text = "Car Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 176);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 3;
            label4.Text = "Service Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 218);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(27, 255);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 5;
            label6.Text = "Report Date";
            // 
            // txtPlateNumber
            // 
            txtPlateNumber.Location = new Point(191, 84);
            txtPlateNumber.Name = "txtPlateNumber";
            txtPlateNumber.Size = new Size(155, 27);
            txtPlateNumber.TabIndex = 6;
            txtPlateNumber.TextChanged += textBox1_TextChanged;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(191, 214);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(155, 27);
            txtDescription.TabIndex = 7;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // comboCarType
            // 
            comboCarType.FormattingEnabled = true;
            comboCarType.Location = new Point(191, 127);
            comboCarType.Name = "comboCarType";
            comboCarType.Size = new Size(155, 28);
            comboCarType.TabIndex = 8;
            comboCarType.SelectedIndexChanged += comboCarType_SelectedIndexChanged;
            // 
            // comboServiceType
            // 
            comboServiceType.FormattingEnabled = true;
            comboServiceType.Location = new Point(191, 172);
            comboServiceType.Name = "comboServiceType";
            comboServiceType.Size = new Size(155, 28);
            comboServiceType.TabIndex = 9;
            comboServiceType.SelectedIndexChanged += comboServiceType_SelectedIndexChanged;
            // 
            // dateReport
            // 
            dateReport.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateReport.Location = new Point(191, 255);
            dateReport.Name = "dateReport";
            dateReport.Size = new Size(284, 26);
            dateReport.TabIndex = 10;
            dateReport.ValueChanged += dateReport_ValueChanged;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(119, 318);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 23);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(246, 318);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 23);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "UPDATE ";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(375, 318);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 23);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(569, 34);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(213, 20);
            label7.TabIndex = 14;
            label7.Text = "dataGridViewDamaged";
            // 
            // dataGridViewDamaged
            // 
            dataGridViewDamaged.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDamaged.Location = new Point(514, 84);
            dataGridViewDamaged.Name = "dataGridViewDamaged";
            dataGridViewDamaged.Size = new Size(357, 257);
            dataGridViewDamaged.TabIndex = 15;
            dataGridViewDamaged.CellContentClick += dataGridViewDamaged_CellContentClick;
            // 
            // DamagedForm
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 376);
            Controls.Add(dataGridViewDamaged);
            Controls.Add(label7);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dateReport);
            Controls.Add(comboServiceType);
            Controls.Add(comboCarType);
            Controls.Add(txtDescription);
            Controls.Add(txtPlateNumber);
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewDamaged).EndInit();
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
        private TextBox txtPlateNumber;
        private TextBox txtDescription;
        private ComboBox comboCarType;
        private ComboBox comboServiceType;
        private DateTimePicker dateReport;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label7;
        private DataGridView dataGridViewDamaged;
    }
}