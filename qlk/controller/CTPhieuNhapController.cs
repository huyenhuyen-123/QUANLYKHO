using QLK.model;
using QLK.utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLK.controller
{
    internal class CTPhieuNhapController
    {
        List<CTPhieuNhap> ctpnList;
        public CTPhieuNhapController()
        {
            ctpnList = new List<CTPhieuNhap>();
        }
        public List<CTPhieuNhap> load()
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from CT_PN_KHO", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String ID = reader["ID"].ToString();
                    String MA_PN_KHO = reader["MA_PN_KHO"].ToString();
                    String MA_HH = reader["MA_HH"].ToString();
                    int SOLUONG = int.Parse(reader["SOLUONG"].ToString());
                    double DONGIA = double.Parse(reader["DONGIA"].ToString());
                    CTPhieuNhap ct_pn = new CTPhieuNhap(ID, MA_PN_KHO, MA_HH, SOLUONG, DONGIA);
                    ctpnList.Add(ct_pn);

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ctpnList;
        }
        public CTPhieuNhap get(string ID)
        {
            return null;
        }
        public bool insert(CTPhieuNhap ctpn)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                string query = "INSERT INTO CT_PN_KHO (ID, MA_PN_KHO, MA_HH, SOLUONG, DONGIA) " +
                               "VALUES (@ID, @MA_PN_KHO, @MA_HH, @SOLUONG, @DONGIA)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", ctpn.LayID());
                cmd.Parameters.AddWithValue("@MA_PN_KHO", ctpn.LayMaPnKho());
                cmd.Parameters.AddWithValue("@MA_HH", ctpn.LayMaHH());
                cmd.Parameters.AddWithValue("@SOLUONG", ctpn.LaySoLuong());
                cmd.Parameters.AddWithValue("@DONGIA", ctpn.LayDonGia());

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể thêm bản ghi mới: " + ex.Message);
                return false;
            }
        }
        public bool update(Kho kho) { return false; }
        public bool delete(String id) { return false; }
        public bool delete(Kho kho) { return false; }
    }
}
