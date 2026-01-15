using System;
using LIBRARY_1.DAL;

namespace LIBRARY_1.BLL
{
    public class KullaniciBLL
    {
        private KullaniciDAL _kullaniciDal = new KullaniciDAL();

        public string KullaniciDogrula(string ad, string sifre)
        {
            // İş Kuralı: Boş kullanıcı adı veya şifre ile sorgu yapılmaz
            if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(sifre))
            {
                throw new Exception("Kullanıcı adı veya şifre boş bırakılamaz.");
            }

            // DAL katmanına git ve sonucu getir
            return _kullaniciDal.GirisKontrol(ad, sifre);
        }
    }
}