using MySql.Data.MySqlClient;
using System;
using System.Data;
using LIBRARY_1.Entity;

namespace LIBRARY_1.DAL
{
    public class UyeDAL
    {
        private string baglantiString = "Server=172.21.54.253;Database=26_132430050;User ID=26_132430050;Pwd=İnif123.;";

        public DataTable VerileriGetir()
        {
            using (MySqlConnection conn = new MySqlConnection(baglantiString))
            {
                string sorgu = "SELECT UyeID AS `Üye ID`, UyeAdi AS `Üye Adı`, UyeTel AS `Telefon Numarası` FROM uyeBilgisiForm";
                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public int UyeEkle(Uye uye)
        {
            using (MySqlConnection conn = new MySqlConnection(baglantiString))
            {
                string sorgu = "INSERT INTO uyeBilgisiForm (UyeAdi, UyeTel, uyeRolu, uyeSifre) VALUES (@ad, @tel, @rol, @sifre)";
                MySqlCommand cmd = new MySqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@ad", uye.UyeAdi);
                cmd.Parameters.AddWithValue("@tel", uye.UyeTel);
                cmd.Parameters.AddWithValue("@rol", uye.UyeRolu);
                cmd.Parameters.AddWithValue("@sifre", uye.UyeSifre);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public int UyeSil(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(baglantiString))
            {
                string sorgu = "DELETE FROM uyeBilgisiForm WHERE UyeID = @id";
                MySqlCommand cmd = new MySqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}