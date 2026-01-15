using System.Data;
using LIBRARY_1.DAL;

namespace LIBRARY_1.BLL
{
    public class RaporBLL
    {
        private RaporDAL _dal = new RaporDAL();

        public DataTable AktifUyeleriGetir() => _dal.GetAktifUyeler();
        public DataTable EnCokTercihEdilenleriGetir() => _dal.GetEnCokKitaplar();
        public DataTable GecikenleriGetir() => _dal.GetGecikenKitaplar();
        public DataTable KategoriRaporuGetir() => _dal.GetKategoriRaporu();
    }
}