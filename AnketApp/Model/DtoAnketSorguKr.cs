using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketApp.Model
{
    public class DtoAnketSorguKr
    {
        public DateTime? KayitTarih1 { get; set; }
        public DateTime? KayitTarih2 { get; set; }

        public string Duzenleyen { get; set; }
        public string AnketAd { get; set; }

        public DateTime? Baslama1 { get; set; }
        public DateTime? Baslama2 { get; set; }

        public DateTime? Bitis1 { get; set; }    
        public DateTime? Bitis2 { get; set; }   
        public string Konu { get; set; }
    }
}
