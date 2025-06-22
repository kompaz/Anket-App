using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketApp.Model
{
    public class SoruCevap
    {
        public long Id { get; set; }
        public long AnketId { get; set; }
        public long KatilimciId { get; set; }
        public long SoruId { get; set; }
        public string Cevap { get; set; }
    }
}
