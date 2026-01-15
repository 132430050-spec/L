using MySql.Data.MySqlClient;
using System;

namespace LIBRARY_1.DAL
{
    public class KullaniciDAL
    {
        private string baglantiString = "Server=172.21.54.253;Database=26_132430050;User ID=26_132430050;Pwd=İnif123.;";

        public string GirisKontrol(string ad, string sifre)
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiString))
            {
                // SQL Sorgusu: Kullanıcı adı ve şifre eşleşiyor mu?
                string sql = "SELECT uyeRolu FROM uyeBilgisiForm WHERE uyeAdi = @ad AND uyeSifre = @sifre";
                MySqlCommand komut = new MySqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@ad", ad);
                komut.Parameters.AddWithValue("@sifre", sifre);

                baglanti.Open();
                object rolObj = komut.ExecuteScalar();

                // Eğer sonuç varsa rolü döner, yoksa null döner
                return rolObj?.ToString();
            }
        }
    }
}