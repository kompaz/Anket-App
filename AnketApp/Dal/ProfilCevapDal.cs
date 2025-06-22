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
    public class ProfilCevapDal
    {
        public ProfilCevap Get(int id)
        {
            string sql = "Select * From dbo.profil_cevap Where id=@id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@id", id);
            ProfilCevap obj = null;
            SqlDataReader rd = null;
            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    obj = new ProfilCevap()
                    {
                        Id = rd.GetInt64(0),
                        AnketId = rd.GetInt64(1),
                        KatilimciId = rd.GetInt64(2),
                        ProfilId = rd.GetInt32(3),
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

        /// <param name="katilimci_no"></param>
        /// /// <param name="anket_id"></param>
        /// <returns></returns>

        public ProfilCevap Get(long katilimci_id, int profil_id)
        {
            string sql = "Select * From dbo.profil_cevap Where katilimci_id=@katilimci_id and profil_id=@profil_id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);

            cmd.Parameters.AddWithValue("@katilimci_id", katilimci_id);
            cmd.Parameters.AddWithValue("@profil_id", profil_id);
            ProfilCevap obj = null;
            SqlDataReader rd = null;
            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    obj = new ProfilCevap()
                    {
                        Id = rd.GetInt64(0),
                        AnketId = rd.GetInt64(1),
                        KatilimciId = rd.GetInt64(2),
                        ProfilId = rd.GetInt32(3),
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


        public DtoKatilimciProfil GetKatilimciProfil(long katilimciid)
        {
            string sql = "Select K.id, k.katilimci_no, K.tarih, K.yer, PC.profil_id, P.profil_ad, PS.secenek_no, PS.secenek, PC.cevap From dbo.profil_cevap PC ";
            sql += "inner join dbo.katilimci K on K.id = PC.katilimci_id ";
            sql += "inner join dbo.profil P on P.id = PC.profil_id ";
            sql += "left outer join dbo.profil_secenek PS on PS.profil_id = PC.profil_id and PS.secenek_no = PC.cevap ";
            sql += "Where PC.katilimci_id=@katilimci_id ";
            sql += "Order By K.id, PS.profil_id;";

            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@katilimci_id", katilimciid);

            SqlDataReader rd = null;
            int kno = 0;
            DtoKatilimciProfil obj = null;
            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    if (kno == 0)
                    {
                        obj = new DtoKatilimciProfil();
                        obj.Id = rd.GetInt64(0);
                        obj.KatilimciNo = rd.GetInt32(1);
                        obj.Tarih = rd.GetDateTime(2);
                        obj.Yer = rd.GetString(3);
                        kno = rd.GetInt32(1);
                    }
                    int profilid = rd.GetInt32(4);

                    switch (profilid)
                    {
                        case 1:
                            obj.AdSoyad = rd.GetString(8);
                            break;
                        case 2:
                            obj.CinsNo = rd.GetInt32(6);
                            obj.CinsText = rd.GetString(7);
                            break;
                        case 3:
                            obj.Yas = Tool.StrToInt(rd.GetString(8));
                            break;
                        case 4:
                            obj.OgrenimDurumNo = rd.GetInt32(6);
                            obj.OgrenimDurumText = rd.GetString(7);
                            break;
                        case 5:
                            obj.CalismaDurumNo = rd.GetInt32(6);
                            obj.CalismaDurumText = rd.GetString(7);
                            break;
                        case 6:
                            obj.AskerlikDurumNo = rd.GetInt32(6);
                            obj.AskerlikDurumText = rd.GetString(7);
                            break;
                        case 7:
                            obj.MedeniHalNo = rd.GetInt32(6);
                            obj.MedeniHalText = rd.GetString(7);
                            break;
                        case 8:
                            obj.YasadigiYer = rd.GetString(8);
                            break;
                        case 9:
                            obj.AylikNetGelir = Tool.StrToDouble(rd.GetString(8));
                            break;
                        case 10:
                            obj.EtnikKokenNo = rd.GetInt32(6);
                            obj.EtnikKokenText = rd.GetString(7);
                            break;
                        case 11:
                            obj.DiniInancNo = rd.GetInt32(6);
                            obj.DiniInancText = rd.GetString(7);
                            break;
                        case 12:
                            obj.MezhepNo = rd.GetInt32(6);
                            obj.MezhepText = rd.GetString(7);
                            break;
                    }


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

            return obj;
        }



        public List<ProfilCevap> GetAll()
        {
            string sql = "Select * From dbo.profil_cevap Order By id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);

            SqlDataReader rd = null;
            List<ProfilCevap> res = new List<ProfilCevap>();

            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ProfilCevap obj = new ProfilCevap()
                    {
                        Id = rd.GetInt64(0),
                        AnketId = rd.GetInt64(1),
                        KatilimciId = rd.GetInt64(2),
                        ProfilId = rd.GetInt32(3),
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

        public List<DtoKatilimciProfil> GetKatilimciProfilList(long anketid)
        {
            string sql = "Select K.id, k.katilimci_no, K.tarih, K.yer, PC.profil_id, P.profil_ad, PS.secenek_no, PS.secenek, PC.cevap From dbo.profil_cevap PC ";
            sql += "inner join dbo.katilimci K on K.id = PC.katilimci_id ";
            sql += "inner join dbo.profil P on P.id = PC.profil_id ";
            sql += "left outer join dbo.profil_secenek PS on PS.profil_id = PC.profil_id and PS.secenek_no = PC.cevap ";
            sql += "Where PC.anket_id=@anket_id ";
            sql += "Order By K.id, PS.profil_id;";

            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@anket_id", anketid);
            SqlDataReader rd = null;
            List<DtoKatilimciProfil> res = new List<DtoKatilimciProfil>();

            int kno = 0;
            DtoKatilimciProfil obj = null;
            try
            {
                GenelDal.Conn1.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    if (rd.GetInt32(1) != kno)
                    {
                        // Önceki Katılımcı
                        if (obj != null)
                        {
                            res.Add(obj);
                        }

                        // Yeni katılımcı
                        obj = new DtoKatilimciProfil();
                        obj.Id = rd.GetInt64(0);
                        obj.KatilimciNo = rd.GetInt32(1);
                        obj.Tarih = rd.GetDateTime(2);
                        obj.Yer = rd.GetString(3);
                        kno = rd.GetInt32(1);
                    }
                    int profilid = rd.GetInt32(4);

                    switch(profilid)
                    {
                        case 1: 
                            obj.AdSoyad = rd.IsDBNull(8) ? String.Empty : rd.GetString(8);
                            break;
                        case 2: 
                            obj.CinsNo = rd.GetInt32(6);
                            obj.CinsText = rd.GetString(7);
                            break;
                        case 3:
                            obj.Yas = Tool.StrToInt(rd.GetString(8));
                            break;
                        case 4:
                            obj.OgrenimDurumNo = rd.GetInt32(6);
                            obj.OgrenimDurumText = rd.GetString(7);
                            break;
                        case 5:
                            obj.CalismaDurumNo = rd.GetInt32(6);
                            obj.CalismaDurumText = rd.GetString(7);
                            break;
                        case 6:
                            obj.AskerlikDurumNo = rd.GetInt32(6);
                            obj.AskerlikDurumText = rd.GetString(7);
                            break;
                        case 7:
                            obj.MedeniHalNo = rd.GetInt32(6);
                            obj.MedeniHalText = rd.GetString(7);
                            break;
                        case 8:
                            obj.YasadigiYer = rd.GetString(8);
                            break;
                        case 9:
                            obj.AylikNetGelir = Tool.StrToDouble(rd.GetString(8));
                            break;
                        case 10:
                            obj.EtnikKokenNo = rd.GetInt32(6);
                            obj.EtnikKokenText = rd.GetString(7);
                            break;
                        case 11:
                            obj.DiniInancNo = rd.GetInt32(6);
                            obj.DiniInancText = rd.GetString(7);
                            break;
                        case 12:
                            obj.MezhepNo = rd.GetInt32(6);
                            obj.MezhepText = rd.GetString(7);
                            break;
                    }


                }

                // Son Obje
                if (obj != null)
                {
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

        public long Insert(ProfilCevap obj)
        {
            string sql = "Insert Into dbo.profil_cevap Values (@anket_id, @katilimci_id, @profil_id, @cevap); Select SCOPE_IDENTITY()";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@anket_id", obj.AnketId);
            cmd.Parameters.AddWithValue("@katilimci_id", obj.KatilimciId);
            cmd.Parameters.AddWithValue("@profil_id", obj.ProfilId);
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


        public bool Update(ProfilCevap obj)
        {
            string sql = "Update dbo.profil_cevap Set anket_id=@anket_id, katilimci_id=@katilimci_id, profil_id=@profil_id, cevap=@cevap Where id=@id";
            SqlCommand cmd = new SqlCommand(sql, GenelDal.Conn1);
            cmd.Parameters.AddWithValue("@id", obj.Id);
            cmd.Parameters.AddWithValue("@anket_id", obj.AnketId);
            cmd.Parameters.AddWithValue("@katilimci_id", obj.KatilimciId);
            cmd.Parameters.AddWithValue("@profil_id", obj.ProfilId);
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
            string sql = "Delete From dbo.profil_cevap Where id=@id";
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
