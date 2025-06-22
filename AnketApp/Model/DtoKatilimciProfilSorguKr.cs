using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketApp.Model
{
    public class DtoKatilimciProfilSorguKr
    {
        public DateTime? Tarih1 { get; set; }
        public DateTime? Tarih2 { get; set; }
        public string Yer { get; set; }
        public string AdSoyad { get; set; }
        public int CinsNo { get; set; }
        public int? Yas1 { get; set; }
        public int? Yas2 { get; set; }
        public int OgrenimDurumNo { get; set; }
        public int CalismaDurumNo { get; set; }
        public int AskerlikDurumNo { get; set; }
        public int MedeniHalNo { get; set; }
        public string YasadigiYer { get; set; }
        public double? AylikNetGelir1 { get; set; }
        public double? AylikNetGelir2 { get; set; }
        public int EtnikKokenNo { get; set; }
        public int DiniInancNo { get; set; }
        public int MezhepNo { get; set; }
    }
}
