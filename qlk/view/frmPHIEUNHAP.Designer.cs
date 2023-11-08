namespace QLK.view
{
    partial class frmPHIEUNHAP
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
            txtSoPhieu = new TextBox();
            txtSoHD = new TextBox();
            comboBoxMaKho = new ComboBox();
            lbNgay = new Label();
            label5 = new Label();
            txtNgay = new TextBox();
            txtNgayHD = new TextBox();
            label6 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewComboBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            btnSave = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(428, 9);
            label1.Name = "label1";
            label1.Size = new Size(202, 31);
            label1.TabIndex = 0;
            label1.Text = "PHIẾU NHẬP KHO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 71);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Số phiếu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 124);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Số HĐ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 186);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 3;
            label4.Text = "Mã Kho";
            // 
            // txtSoPhieu
            // 
            txtSoPhieu.Location = new Point(138, 68);
            txtSoPhieu.Name = "txtSoPhieu";
            txtSoPhieu.Size = new Size(157, 27);
            txtSoPhieu.TabIndex = 4;
            txtSoPhieu.TextChanged += txtSoPhieu_TextChanged;
            // 
            // txtSoHD
            // 
            txtSoHD.Location = new Point(138, 124);
            txtSoHD.Name = "txtSoHD";
            txtSoHD.Size = new Size(157, 27);
            txtSoHD.TabIndex = 5;
            txtSoHD.TextChanged += txtSoHD_TextChanged;
            // 
            // comboBoxMaKho
            // 
            comboBoxMaKho.FormattingEnabled = true;
            comboBoxMaKho.Items.AddRange(new object[] { "1", "2", "3" });
            comboBoxMaKho.Location = new Point(138, 183);
            comboBoxMaKho.Name = "comboBoxMaKho";
            comboBoxMaKho.Size = new Size(157, 28);
            comboBoxMaKho.TabIndex = 6;
            comboBoxMaKho.SelectedIndexChanged += comboBoxMaKho_SelectedIndexChanged;
            // 
            // lbNgay
            // 
            lbNgay.AutoSize = true;
            lbNgay.Location = new Point(395, 75);
            lbNgay.Name = "lbNgay";
            lbNgay.Size = new Size(44, 20);
            lbNgay.TabIndex = 7;
            lbNgay.Text = "Ngày";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(395, 124);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 8;
            label5.Text = "Ngày HĐ";
            label5.Click += label5_Click;
            // 
            // txtNgay
            // 
            txtNgay.Location = new Point(477, 68);
            txtNgay.Name = "txtNgay";
            txtNgay.Size = new Size(162, 27);
            txtNgay.TabIndex = 9;
            txtNgay.TextChanged += txtNgay_TextChanged;
            // 
            // txtNgayHD
            // 
            txtNgayHD.Location = new Point(477, 124);
            txtNgayHD.Name = "txtNgayHD";
            txtNgayHD.Size = new Size(162, 27);
            txtNgayHD.TabIndex = 10;
            txtNgayHD.TextChanged += txtNgayHD_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(738, 127);
            label6.Name = "label6";
            label6.Size = new Size(125, 20);
            label6.TabIndex = 11;
            label6.Text = "ĐV phát hành HĐ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(869, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 27);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 230);
            label7.Name = "label7";
            label7.Size = new Size(146, 20);
            label7.TabIndex = 13;
            label7.Text = "Danh Sách mặt hàng";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(65, 263);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(810, 188);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã Hàng";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Resizable = DataGridViewTriState.True;
            Column1.SortMode = DataGridViewColumnSortMode.Automatic;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên hàng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "ĐVT";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Số lượng";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Đơn giá";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Thành tiền";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(940, 355);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(940, 422);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 16;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmPHIEUNHAP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 525);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(txtNgayHD);
            Controls.Add(txtNgay);
            Controls.Add(label5);
            Controls.Add(lbNgay);
            Controls.Add(comboBoxMaKho);
            Controls.Add(txtSoHD);
            Controls.Add(txtSoPhieu);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPHIEUNHAP";
            Text = "frmPHIEUNHAP";
            Load += frmPHIEUNHAP_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSoPhieu;
        private TextBox txtSoHD;
        private ComboBox comboBoxMaKho;
        private Label lbNgay;
        private Label label5;
        private TextBox txtNgay;
        private TextBox txtNgayHD;
        private Label label6;
        private TextBox textBox1;
        private Label label7;
        private DataGridView dataGridView1;
        private DataGridViewComboBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button btnSave;
        private Button btnClose;
    }
}