using AnketApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketApp.Dal
{
    public class SoruTipDal
    {
        public SoruTip Get(int id)
        {
            string sql = "Select * From dbo.soru_tip Where id=@id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@id", id);
            SoruTip obj = null;
            SqlDataReader rd = null;
            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    obj = new SoruTip()
                    {
                        Id = rd.GetInt32(0),
                        TipAd = rd.GetString(1)
                    };
                }
               
            }
            catch (Exception)
            {
                obj = null;
            }
            finally
            {
                rd.Close();
                GenelDal.Conn1.Close();
            }

            return obj;
        }

        public List<SoruTip> GetAll()
        {
            string sql = "Select * From dbo.soru_tip Order By id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);

            SqlDataReader rd = null;
            List<SoruTip> res = new List<SoruTip> ();

            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    SoruTip obj = new SoruTip()
                    {
                        Id = rd.GetInt32(0),
                        TipAd = rd.GetString(1)
                    };
                    res.Add(obj);
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                rd.Close();
                GenelDal.Conn1.Close();
            }

            return res;
        }
    }
}
