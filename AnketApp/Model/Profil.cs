using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketApp.Model
{
    public class Profil
    {
        public int Id { get; set; }
        public int ProfilNo { get; set; }
        public string ProfilAd { get; set; }
        public int SoruTipId { get; set; }
    }
}
