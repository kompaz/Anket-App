using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketApp.Model
{
    public class DtoSoruCevap
    {

        public long AnketId { get; set; }
        public long KatilimciId { get; set; }
        public long SoruId { get; set; }
        public int SoruNo { get; set; }
        public int SoruTipId { get; set; }
        public string SoruMetin { get; set; }
        public List<SoruSecenek> SoruSeceneks { get; set; }
        public long Id { get; set; }
        public string Cevap { get; set; }
    }
}
