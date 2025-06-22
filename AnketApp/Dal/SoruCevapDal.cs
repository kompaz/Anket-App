using AnketApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace AnketApp.Dal
{
    public class SoruCevapDal
    {
        SoruSecenekDal scDal = new SoruSecenekDal();
        public SoruCevap Get(int id)
        {
            string sql = "Select * From dbo.soru_cevap Where id=@id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@id", id);
            SoruCevap obj = null;
            SqlDataReader rd = null;
            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    obj = new SoruCevap()
                    {
                        Id = rd.GetInt64(0),
                        AnketId = rd.GetInt64(1),
                        KatilimciId = rd.GetInt64(2),
                        SoruId = rd.GetInt32(3),
                        Cevap = rd.GetString(4)
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
        /// <param name="anket_id"></param>
        /// <param name="katilimci_no"></param>
        /// <returns></returns>

        public SoruCevap Get(long anket_id, long katilimci_id)
        {
            string sql = "Select * From dbo.soru_cevap Where anket_id=@anket_id and katilimci_id=@katilimci_id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@anket_id", anket_id);
            cmd.Parameters.AddWithValue("@katilimci_id", katilimci_id);
            SoruCevap obj = null;
            SqlDataReader rd = null;
            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    obj = new SoruCevap()
                    {
                        Id = rd.GetInt64(0),
                        AnketId = rd.GetInt64(1),
                        KatilimciId = rd.GetInt64(2),
                        SoruId = rd.GetInt32(3),
                        Cevap = rd.GetString(4)
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


        public List<SoruCevap> GetAll()
        {
            string sql = "Select * From dbo.soru_cevap Order By id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);

            SqlDataReader rd = null;
            List<SoruCevap> res = new List<SoruCevap>();

            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    SoruCevap obj = new SoruCevap()
                    {
                        Id = rd.GetInt64(0),
                        AnketId = rd.GetInt64(1),
                        KatilimciId = rd.GetInt64(2),
                        SoruId = rd.GetInt32(3),
                        Cevap = rd.GetString(4)
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

        public List<DtoSoruCevap> GetKatilimciCevapList(long anketid, long katilimciid)
        {
            SqlCommand cmd = new SqlCommand();
            string sql = string.Empty;
           
            if (katilimciid > 0)
            {
                sql += "Select S.anket_id, K.id as katilimci_id, S.id, S.soru_no, S.soru_tip_id, S.soru_metin, SC.id as cevap_id, SC.cevap from dbo.soru S ";
                sql += "Cross Join dbo.katilimci K ";
                sql += "Left Join dbo.soru_cevap SC on SC.soru_id = S.id and SC.katilimci_id = K.id ";
                sql += "Where S.anket_id = K.anket_id and K.id=@katilimci_id ";
                sql += "Order By S.anket_id, K.id, S.soru_no; ";
                cmd.Parameters.AddWithValue("@katilimci_id", katilimciid);
            }
            else
            {
                sql += "Select S.anket_id, cast(0 as bigint) as katilimci_id, S.id, S.soru_no, S.soru_tip_id, S.soru_metin, cast(0 as bigint) as cevap_id, '' as cevap from dbo.soru S ";
                sql += "Where S.anket_id=@anket_id ";
                sql += "Order By S.anket_id,  S.soru_no; ";
                cmd.Parameters.AddWithValue("@anket_id", anketid);
            }
            
            cmd.CommandText = sql;
            cmd.Connection = GenelDal.Conn1;

            SqlDataReader rd = null;
            List<DtoSoruCevap> res = new List<DtoSoruCevap>();

            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    DtoSoruCevap obj = new DtoSoruCevap()
                    {

                        AnketId = rd.GetInt64(0),
                        KatilimciId = rd.GetInt64(1),
                        SoruId = rd.GetInt64(2),
                        SoruNo = rd.GetInt32(3),
                        SoruTipId = rd.GetInt32(4),
                        SoruMetin = rd.GetString(5),
                        SoruSeceneks = scDal.GetSoruSecenekObjListFromSoruId(rd.GetInt64(2)),
                        Id = rd.IsDBNull(6) ? 0 : rd.GetInt64(6),
                        Cevap = rd.IsDBNull(7) ? string.Empty : rd.GetString(7)
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

        public long Insert(SoruCevap obj)
        {
            string sql = "Insert Into dbo.soru_cevap Values (@anket_id, @katilimci_id, @soru_id, @cevap); Select SCOPE_IDENTITY()";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@anket_id", obj.AnketId);
            cmd.Parameters.AddWithValue("@katilimci_id", obj.KatilimciId);
            cmd.Parameters.AddWithValue("@soru_id", obj.SoruId);
            cmd.Parameters.AddWithValue("@cevap", obj.Cevap);



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


        public bool Update(SoruCevap obj)
        {
            string sql = "Update dbo.soru_cevap Set anket_id=@anket_id, katilimci_id=@katilimci_id, soru_id=@soru_id, cevap=@cevap Where id=@id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@id", obj.Id);
            cmd.Parameters.AddWithValue("@anket_id", obj.AnketId);
            cmd.Parameters.AddWithValue("@katilimci_id", obj.KatilimciId);
            cmd.Parameters.AddWithValue("@soru_id", obj.SoruId);
            cmd.Parameters.AddWithValue("@cevap", obj.Cevap);

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
            string sql = "Delete From dbo.soru_cevap Where id=@id";
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
