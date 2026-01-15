using MySql.Data.MySqlClient;
using System;
using System.Data;
using LIBRARY_1.Entity; // Entity katmanını dahil ettik

namespace LIBRARY_1.DAL
{
    public class OduncDAL
    {
        private string baglantiString = "Server=172.21.54.253;Database=26_132430050;User ID=26_132430050;Pwd=İnif123.;";

        public DataTable VerileriGetir()
        {
            using (MySqlConnection conn = new MySqlConnection(baglantiString))
            {
                string sorgu = @"SELECT oduncID AS `İşlem No`, uyeID AS `Üye No`, uyeAdSoyad AS `Üye Ad Soyad`, 
                                 kitapAdi AS `Kitap Adı`, DATE_FORMAT(oduncAlmaTarihi, '%d.%m.%Y') AS `Veriliş Tarihi`, 
                                 DATE_FORMAT(iadeTarihi, '%d.%m.%Y') AS `İade Tarihi` 
                                 FROM oduncAlmaEkraniForm";
                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public int TeslimAlGuncelle(int oduncID)
        {
            using (MySqlConnection conn = new MySqlConnection(baglantiString))
            {
                string sorgu = "UPDATE oduncAlmaEkraniForm SET iadeTarihi = @bugun WHERE oduncID = @id";
                MySqlCommand cmd = new MySqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@bugun", DateTime.Now);
                cmd.Parameters.AddWithValue("@id", oduncID);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public int OduncVer(Odunc model)
        {
            using (MySqlConnection conn = new MySqlConnection(baglantiString))
            {
                string sorgu = @"INSERT INTO oduncAlmaEkraniForm (uyeAdSoyad, kitapAdi, oduncAlmaTarihi, iadeTarihi) 
                                 VALUES (@ad, @kitap, @baslangic, @bitis)";
                MySqlCommand cmd = new MySqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@ad", model.UyeAdSoyad);
                cmd.Parameters.AddWithValue("@kitap", model.KitapAdi);
                cmd.Parameters.AddWithValue("@baslangic", model.OduncAlmaTarihi);
                cmd.Parameters.AddWithValue("@bitis", model.IadeTarihi);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}