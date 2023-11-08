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
    internal class HangHoaController
    {
        List<HangHoa> hanghoaList;
        public HangHoaController()
        {
            hanghoaList = new List<HangHoa>();
        }
        public List<HangHoa> load()
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from HANGHOA", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String ID = reader["ID"].ToString();
                    String NAME = reader["NAME"].ToString();
                    String UNIT = reader["UNIT"].ToString();

                    HangHoa hanghoa = new HangHoa(ID, NAME, UNIT);
                    hanghoaList.Add(hanghoa);

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return hanghoaList;
        }
        public HangHoa get(string ID)
        {
            return null;
        }
        public bool insert(string newID, string newNAME, string newUNIT)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO HANGHOA (ID, NAME, UNIT) VALUES (@ID, @NAME, @UNIT)", conn);
                cmd.Parameters.AddWithValue("@ID", newID);
                cmd.Parameters.AddWithValue("@NAME", newNAME);
                cmd.Parameters.AddWithValue("@ADDRESS", newUNIT);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Failed to insert the new record: " + ex.Message);
                return false;
            }
        }


        public bool update(Kho kho) { return false; }
        public bool delete(String id) { return false; }
        public bool delete(Kho kho) { return false; }
    }
}

