using System.Data;
using LIBRARY_1.DAL;

namespace LIBRARY_1.BLL
{
    public class KitapBLL
    {
        private KitapDAL _kitapDal = new KitapDAL();

        public DataTable KitaplariListele()
        {
            // İleride buraya "Stokta olmayanları gösterme" gibi filtreler eklenebilir.
            return _kitapDal.VerileriGetir();
        }
    }
}