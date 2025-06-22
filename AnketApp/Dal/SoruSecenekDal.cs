using AnketApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketApp.Dal
{
    public class SoruSecenekDal
    {
        
        Soru soru = new Soru();
        public SoruSecenek Get(long id)
        {
            string sql = "Select * From dbo.soru_secenek Where id=@id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@id", id);
            SoruSecenek obj = null;
            SqlDataReader rd = null;
            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    obj = new SoruSecenek()
                    {
                        Id = rd.GetInt64(0),
                        SoruId = rd.GetInt64(1),
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

        /// <summary>
        /// soru_id ve secenek_no bilgileri girilmesi gerekiyor. girildiği takdirde soruların seçenekleri ayrı ayrı sorgulanabilir
        /// </summary>
        /// <param name="soru_id"></param>
        /// <param name="secenek_no"></param>
        /// <returns></returns>

        public SoruSecenek Get(long soru_id, int secenek_no)
        {
            string sql = "Select * From dbo.soru_secenek Where soru_id=@soru_id and secenek_no=@secenek_no";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@soru_id", soru_id);
            cmd.Parameters.AddWithValue("@secenek_no", secenek_no);
            SoruSecenek obj = null;
            SqlDataReader rd = null;
            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    obj = new SoruSecenek()
                    {
                        Id = rd.GetInt64(0),
                        SoruId = rd.GetInt64(1),
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

        public List<string> GetSoruSecenekListFromSoruId(long soruid)
        {
            SoruSecenekDal secDal = new SoruSecenekDal();
            string sql = "Select secenek From dbo.soru_secenek ";
            sql += "Where soru_id=@soru_id ";
            sql += "Order By secenek_no";


            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@soru_id", soruid);
            SqlDataReader rd = null;
            List<string> res = new List<string>();

            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    res.Add(rd.GetString(0));
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

        public List<SoruSecenek> GetSoruSecenekObjListFromSoruId(long soruid)
        {
            SoruSecenekDal secDal = new SoruSecenekDal();
            string sql = "Select * From dbo.soru_secenek ";
            sql += "Where soru_id=@soru_id ";
            sql += "Order By secenek_no";


            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn2);
            cmd.Parameters.AddWithValue("@soru_id", soruid);
            SqlDataReader rd = null;
            List<SoruSecenek> res = new List<SoruSecenek>();

            try
            {
                GenelDal.Conn2.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    SoruSecenek obj = new SoruSecenek()
                    {
                        Id = rd.GetInt64(0),
                        SoruId = rd.GetInt64(1),
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
                GenelDal.Conn2.Close();
            }

            return res;
        }

        public List<SoruSecenek> GetAll()
        {
            string sql = "Select * From dbo.soru_secenek Order By soru_id, secenek_no";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);

            SqlDataReader rd = null;
            List<SoruSecenek> res = new List<SoruSecenek>();

            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    SoruSecenek obj = new SoruSecenek()
                    {
                        Id = rd.GetInt64(0),
                        SoruId = rd.GetInt64(1),
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


        public string GetSecekStrFromSoru(long soruid)
        {
            string sql = "Select secenek From dbo.soru_secenek Where soru_id=@soru_id Order By secenek_no";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn2);
            cmd.Parameters.AddWithValue("@soru_id", soruid);
            SqlDataReader rd = null;
            string res = "";

            try
            {
                GenelDal.Conn2.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    res += rd.GetString(0) + ", ";
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                rd.Close();
                GenelDal.Conn2.Close();
            }
            if (res.Length > 57)
                return res.Substring(0, 57) + "...";
            else
                return res;
        }

        public long Insert(SoruSecenek obj)
        {
            string sql = "Insert Into dbo.soru_secenek (soru_id, secenek_no, secenek) Values (@soru_id, @secenek_no, @secenek); Select SCOPE_IDENTITY()";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@soru_id", obj.SoruId);
            cmd.Parameters.AddWithValue("@secenek_no", obj.SecenekNo);
            cmd.Parameters.AddWithValue("@secenek", obj.Secenek);


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


        public bool Update(SoruSecenek obj)
        {
            string sql = "Update dbo.soru_secenek Set soru_id=@soru_id, secenek_no=@secenek_no, secenek=@secenek Where id=@id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@id", obj.Id);
            cmd.Parameters.AddWithValue("@soru_id", obj.SoruId);
            cmd.Parameters.AddWithValue("@secenek_no", obj.SecenekNo);
            cmd.Parameters.AddWithValue("@secenek", obj.Secenek);

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

        public bool Delete(long id)
        {
            string sql = "Delete From dbo.soru_secenek Where id=@id";
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


        public bool DeleteSeceksFromSoru(long soruid)
        {
            string sql = "Delete From dbo.soru_secenek Where soru_id=@soru_id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn2);
            cmd.Parameters.AddWithValue("@soru_id", soruid);

            bool res;
            try
            {
                GenelDal.Conn2.Open();
                int adet = cmd.ExecuteNonQuery();
                if (adet == 0)
                    res = false;
                else
                    res = true;
            }
            catch (Exception e)
            {
                res = false;
            }
            finally
            {
                GenelDal.Conn2.Close();
            }

            return res;
        }

    }
}
