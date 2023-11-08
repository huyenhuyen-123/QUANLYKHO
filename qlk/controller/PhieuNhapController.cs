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
    internal class PhieuNhapController
    {
        List<PhieuNhap> phieunhapList;

        public PhieuNhapController()
        {
            phieunhapList = new List<PhieuNhap>();
        }

        public List<PhieuNhap> load()
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from PN_KHO", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String SO_PN = reader["SO_PN"].ToString();
                    String NGAY_NHAP = reader["NGAY_NHAP"].ToString();
                    String SO_HD = reader["SO_HD"].ToString();
                    String NGAY_HD = reader["NGAY_HD"].ToString();
                    String NOI_PH_DH = reader["NOI_PH_DH"].ToString();
                    String MA_KHO = reader["MA_KHO"].ToString();

                    PhieuNhap phieunhap = new PhieuNhap(SO_PN, NGAY_NHAP, SO_HD, NGAY_HD, NOI_PH_DH, MA_KHO);
                    phieunhapList.Add(phieunhap);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return phieunhapList;
        }

        public Kho get(string id)
        {
            return null;
        }


        public bool insert(string newSO_PN, string newNGAY_NHAP, string newSO_HD, string newNGAY_HD, string newNOI_PH_DH, string newMA_KHO)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                string query = "INSERT INTO PN_KHO (SO_PN, NGAY_NHAP, SO_HD, NGAY_HD, NOI_PH_DH, MA_KHO) " +
                               "VALUES (@SO_PN, @NGAY_NHAP, @SO_HD, @NGAY_HD, @NOI_PH_DH, @MA_KHO)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SO_PN", newSO_PN);
                cmd.Parameters.AddWithValue("@NGAY_NHAP", newNGAY_NHAP);
                cmd.Parameters.AddWithValue("@SO_HD", newSO_HD);
                cmd.Parameters.AddWithValue("@NGAY_HD", newNGAY_HD);
                cmd.Parameters.AddWithValue("@NOI_PH_DH", newNOI_PH_DH);
                cmd.Parameters.AddWithValue("@MA_KHO", newMA_KHO);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể thêm bản ghi mới: " + ex.Message);
                return false;
            }
        }
    }
}

