using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketApp.Model
{
    public class Katilimci
    {
        public long Id { get; set; }
        public long AnketId { get; set; }
        public int KatilimciNo { get; set; }
        public DateTime Tarih { get; set; }
        public string Yer { get; set; }
    }
}
