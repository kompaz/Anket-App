using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketApp.Model
{
    public class SoruSecenek
    {
        public long Id { get; set; }
        public long SoruId { get; set; }
        public int SecenekNo { get; set; }
        public string Secenek { get; set; }
    }
}
