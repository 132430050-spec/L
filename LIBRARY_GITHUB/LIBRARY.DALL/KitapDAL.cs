using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace LIBRARY_1.DAL
{
    public class KitapDAL
    {
        private string baglantiString = "Server=172.21.54.253;Database=26_132430050;User ID=26_132430050;Pwd=İnif123.;";

        public DataTable VerileriGetir()
        {
            using (MySqlConnection conn = new MySqlConnection(baglantiString))
            {
                string sorgu = @"SELECT kitapID AS 'ID',
                                        kitapIsmi AS 'Kitap İsmi',
                                        yazari AS 'Yazar İsmi',
                                        yayinevi AS 'Yayınevi',
                                        basimYili AS 'Basım Yılı',
                                        stokAdedi AS 'Stok Adedi'
                                 FROM kitapListesiForm";

                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}