using System;

namespace LIBRARY_1.Entity
{
    public class Rapor
    {
        // Aktif Üye ve Genel Bilgiler
        public int UyeID { get; set; }
        public string UyeAdi { get; set; }
        public string UyelikDurumu { get; set; }
        public string OduncKitap { get; set; }

        // Kitap ve Kategori Bilgileri
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public string Yazar { get; set; }
        public string KitapTuru { get; set; }

        // İstatistik Bilgileri
        public int TercihSayisi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public int GecikmeGunu { get; set; }
    }
}