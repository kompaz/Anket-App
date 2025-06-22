using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketApp.Model
{
    public class ProfilCevap
    {
        public long Id { get; set; }
        public long AnketId { get; set; }
        public long KatilimciId { get; set; }
        public int ProfilId { get; set; }
        public string Cevap { get; set; }
    }
}
