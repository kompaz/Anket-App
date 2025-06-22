using AnketApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace AnketApp.Dal
{
    public class SoruDal
    {
        SoruSecenekDal secDal = new SoruSecenekDal();
        public Soru Get(long id)
        {
            string sql = "Select * From dbo.soru Where id=@id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@id", id);
            Soru obj = null;
            SqlDataReader rd = null;
            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    obj = new Soru()
                    {
                        Id = rd.GetInt64(0),
                        AnketId = rd.GetInt64(1),
                        SoruNo = rd.GetInt32(2),
                        SoruTipId = rd.GetInt32(3),
                        SoruMetin =  rd.GetString(4)
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


        public int GetLastSoruNo(long anketid)
        {
            string sql = "Select Max(Soru_no) From dbo.soru Where anket_id=@anket_id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn2);
            cmd.Parameters.AddWithValue("@anket_id", anketid);
            int soru_no;
            try
            {
                GenelDal.Conn2.Open();
                object res = cmd.ExecuteScalar();
                
                if (res != null)
                {
                    soru_no = Convert.ToInt32(res);
                }
                else
                {
                    soru_no = 0;
                }

            }
            catch (Exception)
            {
                soru_no = 0;
            }
            finally
            {
                GenelDal.Conn2.Close();
            }
            return soru_no;
        }


        public List<Soru> GetAll()
        {
            string sql = "Select * From dbo.soru Order By soru_no";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);

            SqlDataReader rd = null;
            List<Soru> res = new List<Soru>();

            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Soru obj = new Soru()
                    {
                        Id = rd.GetInt64(0),
                        AnketId = rd.GetInt64(1),
                        SoruNo = rd.GetInt32(2),
                        SoruTipId = rd.GetInt32(3),
                        SoruMetin = rd.GetString(4)
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

        public List<DtoSoru> GetDtoSoruFromAnket(long anketid)
        {
            
            string sql = "Select S.id, S.soru_no, T.tip_ad, S.soru_metin From dbo.soru S ";
            sql += "inner join dbo.soru_tip T on T.id = S.soru_tip_id ";
            sql += "Where S.anket_id=@anket_id ";
            sql += "Order By S.soru_no";


            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@anket_id", anketid);
            SqlDataReader rd = null;
            List<DtoSoru> res = new List<DtoSoru>();

            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    
                    DtoSoru obj = new DtoSoru()
                    {
                        Id = rd.GetInt64(0),
                        SoruNo = rd.GetInt32(1),
                        SoruTipText = rd.GetString(2),
                        SoruMetin = rd.GetString(3),
                        Secenekler = ""
                    };

                    obj.Secenekler = secDal.GetSecekStrFromSoru(obj.Id);
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

        public long Insert(Soru obj)
        {
            string sql = "Insert Into dbo.soru (anket_id, soru_no, soru_tip_id, soru_metin) Values (@anket_id, @soru_no, @soru_tip_id, @soru_metin); Select SCOPE_IDENTITY()";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@anket_id", obj.AnketId);
            cmd.Parameters.AddWithValue("@soru_no", obj.SoruNo);
            cmd.Parameters.AddWithValue("@soru_tip_id", obj.SoruTipId);
            cmd.Parameters.AddWithValue("@soru_metin", obj.SoruMetin);
           

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


        public bool Update(Soru obj)
        {
            string sql = "Update dbo.soru Set anket_id=@anket_id, soru_no=@soru_no, soru_tip_id=@soru_tip_id, soru_metin=@soru_metin Where id=@id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@id", obj.Id);
            cmd.Parameters.AddWithValue("@anket_id", obj.AnketId);
            cmd.Parameters.AddWithValue("@soru_no", obj.SoruNo);
            cmd.Parameters.AddWithValue("@soru_tip_id", obj.SoruTipId);
            cmd.Parameters.AddWithValue("@soru_metin", obj.SoruMetin);

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
            string sql = "Delete From dbo.soru Where id=@id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@id", id);

            bool res;
            try
            {
                secDal.DeleteSeceksFromSoru(id);
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

        public void SonuNoDegis(long id1, long id2)
        {
            var obj1 = Get(id1);
            var obj2 = Get(id2);

            int sn = obj1.SoruNo;
            obj1.SoruNo = obj2.SoruNo;
            obj2.SoruNo=sn;

            Update(obj1);
            Update(obj2); 
        }
    }
}
