using System;
using LIBRARY_1.DAL;
using LIBRARY_1.Entity;

namespace LIBRARY_1.BLL
{
    public class DonemBLL
    {
        private DonemDAL _donemDal = new DonemDAL();

        public Donem RastgeleDonemGetir()
        {
            // İhtiyaç duyulursa burada ek kontroller yapılabilir.
            return _donemDal.RastgeleDonemGetir();
        }
    }
}