using AnketApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketApp.Dal
{
    public class AnketDal
    {
        public Anket Get(long id)
        {
            string sql = "Select * From dbo.anket Where id=@id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@id", id);
            Anket obj = null;
            SqlDataReader rd = null;
            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    obj = new Anket()
                    {
                        Id = rd.GetInt64(0),
                        KayitTarih = rd.GetDateTime(1),
                        Duzenleyen = rd.GetString(2),
                        AnketAd = rd.GetString(3),
                        Baslama = rd.GetDateTime(4),
                        Bitis = rd.GetDateTime(5),
                        Konu = rd.GetString(6)
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

        public List<Anket> GetAll()
        {
            string sql = "Select * From dbo.anket Order By id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);

            SqlDataReader rd = null;
            List<Anket> res = new List<Anket>();

            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Anket obj = new Anket()
                    {
                        Id = rd.GetInt64(0),
                        KayitTarih = rd.GetDateTime(1),
                        Duzenleyen = rd.GetString(2),
                        AnketAd = rd.GetString(3),
                        Baslama = rd.GetDateTime(4),
                        Bitis = rd.GetDateTime(5),
                        Konu = rd.GetString(6)
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

        public List<Anket> GetFromCriteria(DtoAnketSorguKr kriter)
        {
            string sql = "Select * From dbo.anket Where id>0";
            SqlCommand cmd = new SqlCommand();
            
            if (kriter.KayitTarih1.HasValue)
            {
                if (kriter.KayitTarih2.HasValue)
                {
                    // Tarihler Arası
                    sql += " and kayit_tarih >= @kayit_tarih1 and kayit_tarih <= @kayit_tarih2";
                    cmd.Parameters.AddWithValue("@kayit_tarih1", kriter.KayitTarih1);
                    cmd.Parameters.AddWithValue("@kayit_tarih2", kriter.KayitTarih2);
                }
                else
                {
                    // Minimumu ve üzeri
                    sql += " and kayit_tarih >= @kayit_tarih1";
                    cmd.Parameters.AddWithValue("@kayit_tarih1", kriter.KayitTarih1);
                }
            }
            else
            {
                if (kriter.KayitTarih2.HasValue)
                {
                    // Maksimum ve aşağısı
                    sql += " and kayit_tarih <= @kayit_tarih2";
                    cmd.Parameters.AddWithValue("@kayit_tarih2", kriter.KayitTarih2);
                }
            }
        
            if (string.IsNullOrWhiteSpace(kriter.Duzenleyen) == false)
            {
                sql += " and duzenleyen like @duzenleyen";
                cmd.Parameters.AddWithValue("@duzenleyen", "%" + kriter.Duzenleyen + "%");
            }

            if (string.IsNullOrWhiteSpace(kriter.AnketAd) == false)
            {
                sql += " and anket_ad like @anket_ad";
                cmd.Parameters.AddWithValue("@anket_ad", "%" + kriter.AnketAd + "%");
            }


            if (kriter.Baslama1.HasValue)
            {
                if (kriter.Baslama2.HasValue)
                {
                    // Tarihler Arası
                    sql += " and baslama >= @baslama1 and baslama <= @baslama2";
                    cmd.Parameters.AddWithValue("@baslama1", kriter.Baslama1);
                    cmd.Parameters.AddWithValue("@baslama2", kriter.Baslama2);
                }
                else
                {
                    // Minimumu ve üzeri
                    sql += " and baslama >= @baslama1";
                    cmd.Parameters.AddWithValue("@baslama1", kriter.Baslama1);
                }
            }
            else
            {
                if (kriter.Baslama2.HasValue)
                {
                    // Maksimum ve aşağısı
                    sql += " and baslama <= @baslama2";
                    cmd.Parameters.AddWithValue("@baslama2", kriter.Baslama2);
                }
            }

            if (kriter.Bitis1.HasValue)
            {
                if (kriter.Bitis2.HasValue)
                {
                    // Tarihler Arası
                    sql += " and bitis >= @bitis1 and bitis <= @bitis2";
                    cmd.Parameters.AddWithValue("@bitis1", kriter.Bitis1);
                    cmd.Parameters.AddWithValue("@bitis2", kriter.Bitis2);
                }
                else
                {
                    // Minimumu ve üzeri
                    sql += " and bitis >= @bitis1";
                    cmd.Parameters.AddWithValue("@bitis1", kriter.Bitis1);
                }
            }
            else
            {
                if (kriter.Bitis2.HasValue)
                {
                    // Maksimum ve aşağısı
                    sql += " and bitis <= @bitis2";
                    cmd.Parameters.AddWithValue("@bitis2", kriter.Bitis2);
                }
            }

            if (string.IsNullOrWhiteSpace(kriter.Konu) == false)
            {
                sql += " and konu like @konu";
                cmd.Parameters.AddWithValue("@konu", "%" + kriter.Konu + "%");
            }

            sql += " Order By id";

            cmd.CommandText = sql;
            cmd.Connection = GenelDal.Conn1;

            SqlDataReader rd = null;
            List<Anket> res = new List<Anket>();

            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Anket obj = new Anket()
                    {
                        Id = rd.GetInt64(0),
                        KayitTarih = rd.GetDateTime(1),
                        Duzenleyen = rd.GetString(2),
                        AnketAd = rd.GetString(3),
                        Baslama = rd.GetDateTime(4),
                        Bitis = rd.GetDateTime(5),
                        Konu = rd.GetString(6)
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

        public long Insert(Anket obj)
        {
            string sql = "Insert Into dbo.anket Values (@kayit_tarih, @duzenleyen, @anket_ad, @baslama, @bitis, @konu); Select SCOPE_IDENTITY()";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@kayit_tarih", obj.KayitTarih);
            cmd.Parameters.AddWithValue("@duzenleyen", obj.Duzenleyen);
            cmd.Parameters.AddWithValue("@anket_ad", obj.AnketAd);
            cmd.Parameters.AddWithValue("@baslama", obj.Baslama);
            cmd.Parameters.AddWithValue("@bitis", obj.Bitis);
            cmd.Parameters.AddWithValue("@konu", obj.Konu);

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


        public bool Update(Anket obj)
        {
            string sql = "Update dbo.anket Set kayit_tarih=@kayit_tarih, duzenleyen=@duzenleyen, anket_ad=@anket_ad, baslama=@baslama, bitis=@bitis, konu=@konu Where id=@id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@kayit_tarih", obj.KayitTarih);
            cmd.Parameters.AddWithValue("@duzenleyen", obj.Duzenleyen);
            cmd.Parameters.AddWithValue("@anket_ad", obj.AnketAd);
            cmd.Parameters.AddWithValue("@baslama", obj.Baslama);
            cmd.Parameters.AddWithValue("@bitis", obj.Bitis);
            cmd.Parameters.AddWithValue("@konu", obj.Konu);
            cmd.Parameters.AddWithValue("@id", obj.Id);

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

        public bool Delete(long id )
        {
            string sql = "Delete From dbo.anket Where id=@id";
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

    }
}
