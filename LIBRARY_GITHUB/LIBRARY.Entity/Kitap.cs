using System;

namespace LIBRARY_1.Entity
{
    public class Kitap
    {
        public int KitapID { get; set; }
        public string KitapIsmi { get; set; }
        public string Yazari { get; set; }
        public string Yayinevi { get; set; }
        public int BasimYili { get; set; }
        public int StokAdedi { get; set; }
    }
}