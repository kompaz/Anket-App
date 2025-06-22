using AnketApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketApp.Dal
{
    public class AnketProfilDal
    {
        public AnketProfil Get(long id)
        {
            string sql = "Select * From dbo.anket_profil Where id=@id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@id", id);
            AnketProfil obj = null;
            SqlDataReader rd = null;
            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    obj = new AnketProfil()
                    {
                        Id = rd.GetInt64(0),
                        AnketId = rd.GetInt64(1),
                        ProfilId = rd.GetInt32(2)
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

        public List<AnketProfil> GetAll()
        {
            string sql = "Select * From dbo.anket_profil Order By id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);

            SqlDataReader rd = null;
            List<AnketProfil> res = new List<AnketProfil>();

            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    AnketProfil obj = new AnketProfil()
                    {
                        Id = rd.GetInt64(0),
                        AnketId = rd.GetInt64(1),
                        ProfilId = rd.GetInt32(2)
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

        /// <summary>
        /// Anket kayıt numarasından o ankete ait Anket Profil kayıtlarının listesini döndürür.
        /// </summary>
        /// <param name="anket_id">Anket Profil kayıtları döndürülecek anketin kayıt numarası</param>
        /// <returns>Anket Profil listesi veya boş liste</returns>
        public List<AnketProfil> GetProfilsFromAnket(long anket_id)
        {
            string sql = "Select * From dbo.anket_profil Where anket_id=@anket_id Order By id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@anket_id", anket_id);
            SqlDataReader rd = null;
            List<AnketProfil> res = new List<AnketProfil>();

            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    AnketProfil obj = new AnketProfil()
                    {
                        Id = rd.GetInt64(0),
                        AnketId = rd.GetInt64(1),
                        ProfilId = rd.GetInt32(2)
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

        /// <summary>
        /// Anket kayıt numarasından o ankete ait Anket Profil kayıtlarının Profil ID listesini döndürür.
        /// </summary>
        /// <param name="anket_id">Anket Profil kayıtları döndürülecek anketin kayıt numarası</param>
        /// <returns>Anket Profil ID listesi veya boş liste</returns>
        public List<int> GetProfilIdFromAnket(long anket_id)
        {
            string sql = "Select profil_id From dbo.anket_profil Where anket_id=@anket_id Order By id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@anket_id", anket_id);
            SqlDataReader rd = null;
            List<int> res = new List<int>();

            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    int profi_id = rd.GetInt32(0);
                    res.Add(profi_id);
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


        public long Insert(AnketProfil obj)
        {
            string sql = "Insert Into dbo.anket_profil Values (@AnketId, @ProfilId); Select SCOPE_IDENTITY()";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@AnketId", obj.AnketId);
            cmd.Parameters.AddWithValue("@ProfilId", obj.ProfilId);
      
            long id;
            try
            {
                GenelDal.Conn1.Open();
                id = Convert.ToInt64(cmd.ExecuteScalar());

            }
            catch (Exception)
            {
                id = 0;
            }
            finally
            {
                GenelDal.Conn1.Close();
            }

            return id;
        }

        public bool Delete(long id)
        {
            string sql = "Delete From dbo.anket_profil Where id=@id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@id", id);

            bool res;
            try
            {
                GenelDal.Conn1.Open();
                int adet = cmd.ExecuteNonQuery();
                if (adet == 0)
                    res = false;
                else
                    res = true;
            }
            catch (Exception)
            {
                res = false;
            }
            finally
            {
                GenelDal.Conn1.Close();
            }

            return res;
        }


        public bool Delete(long anketid, int profilid)
        {
            string sql = "Delete From dbo.anket_profil Where anket_id=@anket_id and profil_id=@profil_id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@anket_id", anketid);
            cmd.Parameters.AddWithValue("@profil_id", profilid);

            bool res;
            try
            {
                GenelDal.Conn1.Open();
                int adet = cmd.ExecuteNonQuery();
                if (adet == 0)
                    res = false;
                else
                    res = true;
            }
            catch (Exception)
            {
                res = false;
            }
            finally
            {
                GenelDal.Conn1.Close();
            }

            return res;
        }

    }
}
