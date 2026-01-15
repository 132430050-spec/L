using MySql.Data.MySqlClient;
using System;
using LIBRARY_1.Entity;

namespace LIBRARY_1.DAL
{
    public class DonemDAL
    {
        private string baglantiString = "Server=172.21.54.253;Database=26_132430050;User ID=26_132430050;Pwd=İnif123.;";

        public Donem RastgeleDonemGetir()
        {
            Donem donemBilgisi = null;

            using (MySqlConnection conn = new MySqlConnection(baglantiString))
            {
                string sorgu = @"SELECT DonemAdi, BaslangicTarihi, BitisTarihi, GenelBilgi, Yazarlar 
                                 FROM edebiDonemlerForm ORDER BY RAND() LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(sorgu, conn);
                conn.Open();

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        donemBilgisi = new Donem
                        {
                            DonemAdi = dr["DonemAdi"].ToString(),
                            BaslangicTarihi = dr["BaslangicTarihi"].ToString(),
                            BitisTarihi = dr["BitisTarihi"].ToString(),
                            GenelBilgi = dr["GenelBilgi"].ToString(),
                            Yazarlar = dr["Yazarlar"].ToString()
                        };
                    }
                }
            }
            return donemBilgisi;
        }
    }
}