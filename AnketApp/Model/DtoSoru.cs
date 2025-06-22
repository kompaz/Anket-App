using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketApp.Model
{
    public class DtoSoru
    {
        public long Id { get; set; }
        public int SoruNo { get; set; }
        public string SoruTipText { get; set; }
        public string SoruMetin { get; set; }
        public string Secenekler { get; set; }
    }
}
