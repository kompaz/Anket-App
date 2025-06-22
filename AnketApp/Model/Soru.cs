using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AnketApp.Model
{
    public class Soru
    {
        public long Id { get; set; }
        public long AnketId { get; set; }
        public int SoruNo { get; set; }
        public int SoruTipId { get; set; }
        public string SoruMetin { get; set; }
    }
}
