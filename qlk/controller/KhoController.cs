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
    internal class khocontroller
    {
        List<Kho> khoList;
        public khocontroller()
        {
            khoList = new List<Kho>();
        }
        public List<Kho> load()
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            khoList.Clear();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from DM_KHO", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String ID = reader["ID"].ToString();
                    String NAME = reader["NAME"].ToString();
                    String ADDRESS = reader["ADDRESS"].ToString();

                    Kho kho = new Kho(ID, NAME, ADDRESS);
                    khoList.Add(kho);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return khoList;
        }

        public Kho get(string ID) { return null; }
        public bool insert(string newID, string newNAME, string newADDRESS)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO DM_KHO (ID, NAME, ADDRESS) VALUES (@ID, @NAME, @ADDRESS)", conn);
                cmd.Parameters.AddWithValue("@ID", newID);
                cmd.Parameters.AddWithValue("@NAME", newNAME);
                cmd.Parameters.AddWithValue("@ADDRESS", newADDRESS);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Failed to insert the new record: " + ex.Message);
                return false;
            }
        }
        public bool Update(string newID, string newNAME, string newADDRESS)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE DM_KHO SET NAME = @NAME, ADDRESS = @ADDRESS WHERE ID = @ID", conn);
                cmd.Parameters.AddWithValue("@ID", newID);
                cmd.Parameters.AddWithValue("@NAME", newNAME);
                cmd.Parameters.AddWithValue("@ADDRESS", newADDRESS);



                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gặp lỗi khi sửa: " + ex.Message);
                return false;
            }
        }


        public bool delete(String ID)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM DM_KHO WHERE ID = @ID", conn);
                cmd.Parameters.AddWithValue("@ID", ID);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Failed to delete the record: " + ex.Message);
                return false;
            }
        }
        public bool delete(Kho kho) { return false; }

    }
}
