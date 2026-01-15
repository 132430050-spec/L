using System;
using System.Data;
using LIBRARY_1.DAL;
using LIBRARY_1.Entity;

namespace LIBRARY_1.BLL
{
    public class UyeBLL
    {
        private UyeDAL _uyeDal = new UyeDAL();

        public DataTable UyeListesi()
        {
            return _uyeDal.VerileriGetir();
        }

        public bool YeniUyeEkle(string ad, string tel)
        {
            if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(tel))
                return false;

            Uye yeniUye = new Uye
            {
                UyeAdi = ad.Trim(),
                UyeTel = tel.Trim(),
                UyeRolu = "uye",
                UyeSifre = "12345"
            };

            return _uyeDal.UyeEkle(yeniUye) > 0;
        }

        public bool UyeSil(int id)
        {
            if (id <= 0) return false;
            return _uyeDal.UyeSil(id) > 0;
        }
    }
}