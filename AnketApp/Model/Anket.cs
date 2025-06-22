using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketApp.Model
{
    public class Anket
    {
        public long Id { get; set; }
        public DateTime KayitTarih { get; set; }
        public string Duzenleyen { get; set; }
        public string AnketAd { get; set; }
        public DateTime Baslama { get; set; }
        public DateTime Bitis { get; set; }
        public string Konu { get; set; }
    }
}
