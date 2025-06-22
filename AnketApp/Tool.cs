using AnketApp.Dal;
using AnketApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketApp
{
    public class Tool
    {
        public static ProfilSecenekDal prSecDal = new ProfilSecenekDal();

        public static DateTime? StrToDate(string str)
        {
            DateTime d;
            if (DateTime.TryParse(str, out d))
            {
                return d;
            }
            else
            {
                return null;
            }

        }

        public static int? StrToInt(string str)
        {
            int i;
            if (int.TryParse(str, out i))
            {
                return i;
            }
            else
            {
                return null;
            }

        }

        public static double? StrToDouble(string str)
        {
            double d;
            if (double.TryParse(str, out d))
            {
                return d;
            }
            else
            {
                return null;
            }

        }

        public static void SecenekDoldur(ComboBox cb, int profilid, bool sorguicin = true)
        {
            var secList = prSecDal.GetProfilSecenekList(profilid);
            if (sorguicin)
            {
                ProfilSecenek tumu = new ProfilSecenek()
                {
                    Id = 0,
                    ProfilId = profilid,
                    SecenekNo = 0,
                    Secenek = "(Tümü)"
                };
                cb.Items.Add(tumu);
            }

            cb.DisplayMember = "Secenek";
            cb.ValueMember = "SecenekNo";

            for (int i = 0; i < secList.Count; i++)
            {
                var sec = secList[i];
                cb.Items.Add(sec);
            }
            cb.SelectedIndex = 0;

        }

        
        public static List<int> GetIntList(string str)
        {
            List<int> res = new List<int>();

            var strList = str.Split(',');
            for (int i = 0; i < strList.Length; i++)
            {
                int? val = StrToInt(strList[i]);
                if (val.HasValue)
                {
                    res.Add(val.Value);
                }
            }
            return res;
        }

        //21.08
        public static string AddIntList(string str, int val)
        {
            List<int> mev = GetIntList(str);
            if (mev.Contains(val) == false)
            {
                mev.Add(val);
                string res = string.Empty;
                var yeni = mev.OrderBy(x => x).ToList();
                for (int i = 0; i < yeni.Count; i++)
                {
                    if (res!=string.Empty)
                    {
                        res += ",";
                    }
                    res += yeni[i].ToString();

                }
                return res;
            }

            return str;
        }

        //21.08
        public static string RemoveIntList(string str, int val)
        {
            List<int> mev = GetIntList(str);
            if (mev.Contains(val))
            {
                mev.Remove(val);
                string res = string.Empty;
                for (int i = 0; i < mev.Count; i++)
                {
                    if (res != string.Empty)
                    {
                        res += ",";
                    }
                    res += mev[i].ToString();

                }
                return res;
            }

            return str;
        }

    }
}
