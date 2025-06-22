using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketApp.Model
{
    public class DtoKatilimciProfil
    {
        public long Id { get; set; } // Gizlenecek
        public int KatilimciNo { get; set; }
        public DateTime Tarih { get; set; }
        public string Yer { get; set; }
        public string? AdSoyad { get; set; }
        public int? CinsNo { get; set; }
        public string? CinsText { get; set; }
        public int? Yas { get; set; }
        public int? OgrenimDurumNo { get; set; }
        public string? OgrenimDurumText { get; set; }
        public int? CalismaDurumNo { get; set; }
        public string? CalismaDurumText { get; set; }
        public int? AskerlikDurumNo { get; set; }
        public string? AskerlikDurumText { get; set; }
        public int? MedeniHalNo { get; set; }
        public string? MedeniHalText { get; set; }
        public string? YasadigiYer { get; set; }
        public double? AylikNetGelir { get; set; }
        public int? EtnikKokenNo { get; set; }
        public string? EtnikKokenText { get; set; }
        public int? DiniInancNo { get; set; }
        public string? DiniInancText { get; set; }
        public int? MezhepNo { get; set; }
        public string? MezhepText { get; set; }
    }
}
