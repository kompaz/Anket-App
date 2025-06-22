using AnketApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketApp.Dal
{
    public class ProfilDal
    {
        public Profil Get(int id)
        {
            string sql = "Select * From dbo.profil Where id=@id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@id", id);
            Profil obj = null;
            SqlDataReader rd = null;
            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    obj = new Profil()
                    {
                        Id = rd.GetInt32(0),
                        ProfilNo = rd.GetInt32(1),
                        ProfilAd =rd.GetString(2),
                        SoruTipId = rd.GetInt32(3)
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

        public List<Profil> GetAll()
        {
            string sql = "Select * From dbo.profil Order By id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);

            SqlDataReader rd = null;
            List<Profil> res = new List<Profil>();

            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Profil obj = new Profil()
                    {
                        Id = rd.GetInt32(0),
                        ProfilNo = rd.GetInt32(1),
                        ProfilAd = rd.GetString(2),
                        SoruTipId = rd.GetInt32(3)
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
