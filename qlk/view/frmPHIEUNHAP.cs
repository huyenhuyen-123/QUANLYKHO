using QLK.controller;
using QLK.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLK.view
{
    public partial class frmPHIEUNHAP : Form
    {
        khocontroller khoController;//khoController
        HangHoaController hanghoaController;// HangHoaController
        List<Kho> ds_kho;//danh sach kho
        List<HangHoa> ds_HangHoa;//danh sach hang hoa

        PhieuNhapController phieuNhapController;
        CTPhieuNhapController ctNhapController = new CTPhieuNhapController();
        public frmPHIEUNHAP()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmPHIEUNHAP_Load(object sender, EventArgs e)
        {
            ds_kho = new List<Kho>(); //chứa danh sách kho
            khoController = new khocontroller();//Kho controller
            ds_HangHoa = new List<HangHoa>();
            hanghoaController = new HangHoaController();
            ds_kho = khoController.load();
            ds_HangHoa = hanghoaController.load();


            foreach (Kho k in ds_kho)
            {
                //comboboxColumn.Items.Add(k.getID());
            }
            //setup cho datagridview => chi tiết phiếu nhập
            dataGridView1.Columns.Clear();
            DataGridViewComboBoxColumn comboboxColumn;
            comboboxColumn = new DataGridViewComboBoxColumn();
            comboboxColumn.DataPropertyName = "ID";
            comboboxColumn.HeaderText = "Mã hàng";
            comboboxColumn.DropDownWidth = 160;
            comboboxColumn.Width = 90;
            comboboxColumn.MaxDropDownItems = 30;
            comboboxColumn.FlatStyle = FlatStyle.Flat;
            foreach (HangHoa k in ds_HangHoa)
            {
                comboboxColumn.Items.Add(k.getID());
            }
            //thêm cột hàng vào trong datagridview
            dataGridView1.Columns.Add(comboboxColumn);
            //tên hàng
            DataGridViewTextBoxColumn colTenHang = new DataGridViewTextBoxColumn();
            colTenHang.DataPropertyName = "TenHang";
            colTenHang.HeaderText = "Tên hàng";
            dataGridView1.Columns.Add(colTenHang);
            // Đơn vị tính
            DataGridViewTextBoxColumn colDVT = new DataGridViewTextBoxColumn();
            colDVT.DataPropertyName = "DVT";
            colDVT.HeaderText = "Đơn vị tính";
            dataGridView1.Columns.Add(colDVT);
            // Số lượng
            DataGridViewTextBoxColumn colSoLuong = new DataGridViewTextBoxColumn();
            colSoLuong.DataPropertyName = "SoLuong";
            colSoLuong.HeaderText = "Số lượng";
            dataGridView1.Columns.Add(colSoLuong);
            // Đơn giá
            DataGridViewTextBoxColumn colDongia = new DataGridViewTextBoxColumn();
            colDongia.DataPropertyName = "Dongia";
            colDongia.HeaderText = "Đơn giá";
            dataGridView1.Columns.Add(colDongia);
            //Thành tiền
            DataGridViewTextBoxColumn colThanhTien = new DataGridViewTextBoxColumn();
            colThanhTien.DataPropertyName = "ThanhTien";
            colThanhTien.HeaderText = "Thành tiền";
            dataGridView1.Columns.Add(colThanhTien);
        }

        private void txtSoPhieu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMaKho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNgay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgayHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //column index 0 là mặt hàng
            if (e.ColumnIndex == 0)
            {
                String id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                dataGridView1.Rows[e.RowIndex].Cells[1].Value = hanghoaController.get(id).getNAME();

            }
            //column index 4 là đơn giá
            if (e.ColumnIndex == 4)
            {
                int sl = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString().Trim());
                int dg = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString().Trim());
                dataGridView1.Rows[e.RowIndex].Cells[5].Value = sl * dg;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //1. lưu Phieu nhap
            PhieuNhap pn = new PhieuNhap();
            string soPN = txtSoPhieu.Text;
            //....
            ///PhieuNhapController.insert(pn);
            //2. Lưu chi tiết phiếu nhập
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                CTPhieuNhap ct = new CTPhieuNhap();
                ///ct.SetID(dataGridView1.Rows[i].Cells[0].Value.ToString());
                ctNhapController.insert(ct);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

