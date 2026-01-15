using System;
using System.Data;
using LIBRARY_1.DAL;    // DAL katmanını tanıması için
using LIBRARY_1.Entity; // Entity katmanını tanıması için

namespace LIBRARY_1.BLL
{
    public class OduncBLL
    {
        private OduncDAL _oduncDAL = new OduncDAL();

        public DataTable OduncListesi()
        {
            return _oduncDAL.VerileriGetir();
        }

        public bool KitapIadeAl(int oduncID)
        {
            if (oduncID <= 0) return false;
            return _oduncDAL.TeslimAlGuncelle(oduncID) > 0;
        }

        public bool YeniOduncVer(string ad, string kitap)
        {
            if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(kitap))
                return false;

            Odunc model = new Odunc
            {
                UyeAdSoyad = ad.Trim(),
                KitapAdi = kitap.Trim(),
                OduncAlmaTarihi = DateTime.Now,
                IadeTarihi = DateTime.Now.AddDays(14)
            };

            return _oduncDAL.OduncVer(model) > 0;
        }
    }
}