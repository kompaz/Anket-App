using AnketApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketApp.Dal
{
    public class KatilimciDal
    {
        public Katilimci Get(long id)
        {
            string sql = "Select * From dbo.katilimci Where id=@id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@id", id);
            Katilimci obj = null;
            SqlDataReader rd = null;
            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    obj = new Katilimci()
                    {
                        Id = rd.GetInt64(0),
                        AnketId = rd.GetInt64(1),
                        KatilimciNo = rd.GetInt32(2),
                        Tarih = rd.GetDateTime(3),
                        Yer = rd.GetString(4)
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

        public Katilimci Get(long anket_id, long katilimci_no)
        {
            string sql = "Select * From dbo.katilimci Where anket_id=@anket_id and katilimci_no=@katilimci_no";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@anket_id", anket_id);
            cmd.Parameters.AddWithValue("@katilimci_no", katilimci_no);
            Katilimci obj = null;
            SqlDataReader rd = null;
            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    obj = new Katilimci()
                    {
                        Id = rd.GetInt64(0),
                        AnketId = rd.GetInt64(1),
                        KatilimciNo = rd.GetInt32(2),
                        Tarih = rd.GetDateTime(3),
                        Yer = rd.GetString(4)
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


        public List<Katilimci> GetAll()
        {
            string sql = "Select * From dbo.katilimci Order By id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);

            SqlDataReader rd = null;
            List<Katilimci> res = new List<Katilimci>();

            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Katilimci obj = new Katilimci()
                    {
                        Id = rd.GetInt64(0),
                        AnketId = rd.GetInt64(1),
                        KatilimciNo = rd.GetInt32(2),
                        Tarih = rd.GetDateTime(3),
                        Yer = rd.GetString(4)
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

        public long Insert(Katilimci obj)
        {
            string sql = "Insert Into dbo.katilimci Values (@anket_id, @katilimci_no, @tarih, @yer); Select SCOPE_IDENTITY()";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@anket_id", obj.AnketId);
            cmd.Parameters.AddWithValue("@katilimci_no", obj.KatilimciNo);
            cmd.Parameters.AddWithValue("@tarih", obj.Tarih);
            cmd.Parameters.AddWithValue("@yer", obj.Yer);
           


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


        public bool Update(Katilimci obj)
        {
            string sql = "Update dbo.katilimci Set anket_id=@anket_id, katilimci_no=@katilimci_no, tarih=@tarih, yer=@yer Where id=@id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@id", obj.Id);
            cmd.Parameters.AddWithValue("@anket_id", obj.AnketId);
            cmd.Parameters.AddWithValue("@katilimci_no", obj.KatilimciNo);
            cmd.Parameters.AddWithValue("@tarih", obj.Tarih);
            cmd.Parameters.AddWithValue("@yer", obj.Yer);

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
            string sql = "Delete From dbo.katilimci Where id=@id";
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

        public void KatilimciIdDegis(long id1, long id2)
        {
            var obj1 = Get(id1);
            var obj2 = Get(id2);

            int kn = obj1.KatilimciNo;
            obj1.KatilimciNo = obj2.KatilimciNo;
            obj2.KatilimciNo = kn;

            Update(obj1);
            Update(obj2);
        }

        public int GetNewKatilimciNo(long anketid)
        {
            string sql = "Select Max(katilimci_no) From dbo.katilimci Where anket_id=@anket_id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@anket_id", anketid);
            object obj;
            int katno;
            try
            {
                GenelDal.Conn1.Open();
                obj = cmd.ExecuteScalar();
                if (obj != null)
                {
                    katno = Convert.ToInt32(obj) + 1;
                }
                else
                {
                    katno = 1;
                }
                

            }
            catch (Exception)
            {
                katno = 1;
            }
            finally
            {
                GenelDal.Conn1.Close();
            }

            return katno;
        }



    }
}
