using MySql.Data.MySqlClient;
using System.Data;

namespace LIBRARY_1.DAL
{
    public class RaporDAL
    {
        private string baglantiString = "Server=172.21.54.253;Database=26_132430050;User ID=26_132430050;Pwd=İnif123.;";

        private DataTable SorguCalistir(string sorgu)
        {
            using (MySqlConnection conn = new MySqlConnection(baglantiString))
            {
                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetAktifUyeler()
        {
            return SorguCalistir("SELECT uyeID AS `Üye No`, uyeAdi AS `Üye Adı Soyadı`, uyeDurumu AS `Üyelik Durumu`, aldigiKitapID AS `Kitap ID`, aldigiKitapAdi AS `Ödünç Aldığı Kitap` FROM aktifUyeForm");
        }

        public DataTable GetEnCokKitaplar()
        {
            return SorguCalistir("SELECT kitapID AS `Kitap No`, kitapIsmi AS `Kitap Adı`, tercihEdilmeSayisi AS `Ödünç Sayısı` FROM enCokKitapForm ORDER BY tercihEdilmeSayisi DESC");
        }

        public DataTable GetGecikenKitaplar()
        {
            return SorguCalistir("SELECT kitapID AS `Kitap No`, kitapIsmi AS `Kitap Adı`, uyeAdi AS `Üye Adı Soyadı`, DATE_FORMAT(teslimTarihi, '%d.%m.%Y') AS `Teslim Tarihi`, gecikmeGunu AS `Gecikme Gün Sayısı` FROM gecikenKitapForm ORDER BY gecikmeGunu DESC");
        }

        public DataTable GetKategoriRaporu()
        {
            return SorguCalistir("SELECT kitapID AS `Kitap No`, kitapIsmi AS `Kitap Adı`, yazari AS `Yazar`, turu AS `Kitap Türü` FROM kategoriForm");
        }
    }
}