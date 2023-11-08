using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using QLK.controller;
using QLK.model;
using QLK.utils;

namespace QLK.view
{
    public partial class frmKHOHANG : Form
    {
        khocontroller controller;
        List<Kho> dsKho;
        Kho currentKho;

        public frmKHOHANG()
        {
            InitializeComponent();
            controller = new khocontroller();
            dsKho = new List<Kho>();
            currentKho = new Kho();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmKHOHANG_Load(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtADDRESS_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnINSERT_Click(object sender, EventArgs e)
        {
            string newID = txtID.Text;
            string newNAME = txtNAME.Text;
            string newADDRESS = txtADDRESS.Text;

            if (string.IsNullOrWhiteSpace(newID) || string.IsNullOrWhiteSpace(newNAME) || string.IsNullOrWhiteSpace(newADDRESS))
            {
                MessageBox.Show("Vui lòng thêm dữ liệu!");
            }
            else
            {
                if (IsKhoIdExists(newID))
                {
                    MessageBox.Show("Mã kho đã tồn tại!");
                }
                else
                {
                    if (controller.insert(newID, newNAME, newADDRESS))
                    {
                        MessageBox.Show("Thêm thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!");
                    }
                }
            }

        }

        private bool IsKhoIdExists(string KHOID)
        {
            using (SqlConnection con = DatabaseHelper.getConnection())
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM DM_KHO WHERE ID = @KHOID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@KHOID", KHOID);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            string NAME = txtNAME.Text;
            string ADDRESS = txtADDRESS.Text;

            if (string.IsNullOrWhiteSpace(ID) || string.IsNullOrWhiteSpace(NAME) || string.IsNullOrWhiteSpace(ADDRESS))
            {
                MessageBox.Show("Điền đầy đủ trước khi sửa!");
            }
            else
            {
                if (controller.Update(ID, NAME, ADDRESS))
                {
                    MessageBox.Show("Sửa thành công!");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }

        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            if (controller.delete(ID))
            {
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }
        

        private void btnLOAD_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "NAME";
            dataGridView1.Columns[2].Name = "ADDRESS";

            dataGridView1.Rows.Clear();
            dsKho = controller.load();
            foreach (Kho kho in dsKho)
            {
                string[] row = { kho.getID(), kho.getNAME(), kho.getADDRESS() };
                dataGridView1.Rows.Add(row);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo chỉ xử lý khi click vào dòng hợp lệ
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Lấy dữ liệu từ dòng đã chọn và hiển thị nó trên TextBox
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtNAME.Text = row.Cells["NAME"].Value.ToString();
                txtADDRESS.Text = row.Cells["ADDRESS"].Value.ToString();
            }
        }
    }
}
