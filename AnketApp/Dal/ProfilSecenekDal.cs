using AnketApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketApp.Dal
{
    public class ProfilSecenekDal
    {
        public ProfilSecenek Get(int id)
        {
            string sql = "Select * From dbo.profil_secenek Where id=@id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@id", id);
            ProfilSecenek obj = null;
            SqlDataReader rd = null;
            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    obj = new ProfilSecenek()
                    {
                        Id = rd.GetInt32(0),
                        ProfilId = rd.GetInt32(1),
                        SecenekNo = rd.GetInt32(2),
                        Secenek = rd.GetString(3)
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

        public ProfilSecenek Get(int profil_id, int secenek_no)
        {
            string sql = "Select * From dbo.profil_secenek Where profil_id=@profil_id and secenek_no=@secenek_no";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@profil_id", profil_id);
            cmd.Parameters.AddWithValue("@secenek_no", secenek_no);
            ProfilSecenek obj = null;
            SqlDataReader rd = null;
            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    obj = new ProfilSecenek()
                    {
                        Id = rd.GetInt32(0),
                        ProfilId = rd.GetInt32(1),
                        SecenekNo = rd.GetInt32(2),
                        Secenek = rd.GetString(3)
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

        public List<ProfilSecenek> GetAll()
        {
            string sql = "Select * From dbo.profil_secenek Order By id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);

            SqlDataReader rd = null;
            List<ProfilSecenek> res = new List<ProfilSecenek>();

            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ProfilSecenek obj = new ProfilSecenek()
                    {
                        Id = rd.GetInt32(0),
                        ProfilId = rd.GetInt32(1),
                        SecenekNo = rd.GetInt32(2),
                        Secenek = rd.GetString(3)
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

        public List<ProfilSecenek> GetProfilSecenekList(int profil_id)
        {
            string sql = "Select * From dbo.profil_secenek Where profil_id=@profil_id Order By id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@profil_id", profil_id);
            SqlDataReader rd = null;
            List<ProfilSecenek> res = new List<ProfilSecenek>();

            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ProfilSecenek obj = new ProfilSecenek()
                    {
                        Id = rd.GetInt32(0),
                        ProfilId = rd.GetInt32(1),
                        SecenekNo = rd.GetInt32(2),
                        Secenek = rd.GetString(3)
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
