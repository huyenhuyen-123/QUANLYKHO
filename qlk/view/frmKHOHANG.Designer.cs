namespace QLK.view
{
    partial class frmKHOHANG
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
            txtID = new TextBox();
            txtNAME = new TextBox();
            txtADDRESS = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btnINSERT = new Button();
            btnUPDATE = new Button();
            btnDELETE = new Button();
            btnLOAD = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(341, 25);
            label1.Name = "label1";
            label1.Size = new Size(114, 28);
            label1.TabIndex = 0;
            label1.Text = "KHOHANG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 121);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 162);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 2;
            label3.Text = "NAME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 205);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 3;
            label4.Text = "ADDRESS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(437, 82);
            label5.Name = "label5";
            label5.Size = new Size(142, 20);
            label5.TabIndex = 4;
            label5.Text = "Danh sách kho hàng";
            label5.Click += label5_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(143, 114);
            txtID.Name = "txtID";
            txtID.Size = new Size(246, 27);
            txtID.TabIndex = 5;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // txtNAME
            // 
            txtNAME.Location = new Point(143, 159);
            txtNAME.Name = "txtNAME";
            txtNAME.Size = new Size(246, 27);
            txtNAME.TabIndex = 6;
            txtNAME.TextChanged += txtNAME_TextChanged;
            // 
            // txtADDRESS
            // 
            txtADDRESS.Location = new Point(143, 198);
            txtADDRESS.Name = "txtADDRESS";
            txtADDRESS.Size = new Size(246, 27);
            txtADDRESS.TabIndex = 7;
            txtADDRESS.TextChanged += txtADDRESS_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(437, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(501, 188);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "NAME";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "ADDRESS";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // btnINSERT
            // 
            btnINSERT.Location = new Point(65, 251);
            btnINSERT.Name = "btnINSERT";
            btnINSERT.Size = new Size(94, 29);
            btnINSERT.TabIndex = 9;
            btnINSERT.Text = "INSERT";
            btnINSERT.UseVisualStyleBackColor = true;
            btnINSERT.Click += btnINSERT_Click;
            // 
            // btnUPDATE
            // 
            btnUPDATE.Location = new Point(177, 251);
            btnUPDATE.Name = "btnUPDATE";
            btnUPDATE.Size = new Size(94, 29);
            btnUPDATE.TabIndex = 10;
            btnUPDATE.Text = "UPDATE";
            btnUPDATE.UseVisualStyleBackColor = true;
            btnUPDATE.Click += btnUPDATE_Click;
            // 
            // btnDELETE
            // 
            btnDELETE.Location = new Point(295, 251);
            btnDELETE.Name = "btnDELETE";
            btnDELETE.Size = new Size(94, 29);
            btnDELETE.TabIndex = 11;
            btnDELETE.Text = "DELETE";
            btnDELETE.UseVisualStyleBackColor = true;
            btnDELETE.Click += btnDELETE_Click;
            // 
            // btnLOAD
            // 
            btnLOAD.Location = new Point(437, 308);
            btnLOAD.Name = "btnLOAD";
            btnLOAD.Size = new Size(94, 29);
            btnLOAD.TabIndex = 12;
            btnLOAD.Text = "LOAD";
            btnLOAD.UseVisualStyleBackColor = true;
            btnLOAD.Click += btnLOAD_Click;
            // 
            // frmKHOHANG
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 450);
            Controls.Add(btnLOAD);
            Controls.Add(btnDELETE);
            Controls.Add(btnUPDATE);
            Controls.Add(btnINSERT);
            Controls.Add(dataGridView1);
            Controls.Add(txtADDRESS);
            Controls.Add(txtNAME);
            Controls.Add(txtID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmKHOHANG";
            Text = "frmKHOHANG";
            Load += frmKHOHANG_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtID;
        private TextBox txtNAME;
        private TextBox txtADDRESS;
        private DataGridView dataGridView1;
        private Button btnINSERT;
        private Button btnUPDATE;
        private Button btnDELETE;
        private Button btnLOAD;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}