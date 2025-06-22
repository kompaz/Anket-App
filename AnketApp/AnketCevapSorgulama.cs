using AnketApp.Dal;
using AnketApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnketApp
{
    public partial class AnketCevapSorgulama : Form
    {
        long AnketId;
        Anket Obj;
        AnketDal anketDal = new AnketDal();
        AnketProfilDal apDal = new AnketProfilDal();
        ProfilSecenekDal prSecDal = new ProfilSecenekDal();
        ProfilCevapDal prCevDal = new ProfilCevapDal();
        KatilimciDal kDal = new KatilimciDal();

        List<DtoKatilimciProfil> katilimciList;
        List<int> profilIdList;
        public AnketCevapSorgulama(long anketid)
        {
            InitializeComponent();
            AnketId = anketid;  

        }


        public List<Control> GetControlFromTag(int tag)
        {
            List<Control> res = new List<Control>();

            for (int i = 0; i < gbSorguKriter.Controls.Count; i++)
            {
                Control cont = gbSorguKriter.Controls[i];

                int t = Convert.ToInt32(cont.Tag);
                if (t == tag)
                {
                    res.Add(cont);
                }
            }
            return res;
        }

        public int GetLabelIndex(List<Control> contList)
        {
            for (int i = 0; i < contList.Count; i++)
            {
                var cont = contList[i];
                var ts = cont.GetType().ToString();
                if (ts == "System.Windows.Forms.Label")
                {
                    return i;
                }
            }
            return -1;
        }

        private void AnketCevapSorgulama_Load(object sender, EventArgs e)
        {
            Obj = anketDal.Get(AnketId);
            txtAnketAdi.Text = Obj.AnketAd;
            txtDuzenleyen.Text = Obj.Duzenleyen;
            dtBaslama.Value = Obj.Baslama;
            dtBitis.Value = Obj.Bitis;

            Tool.SecenekDoldur(cbCinsiyet, 2);
            Tool.SecenekDoldur(cbOgrenimDurum, 4);
            Tool.SecenekDoldur(cbCalismaDurum, 5);
            Tool.SecenekDoldur(cbAskerlikDurumu, 6);
            Tool.SecenekDoldur(cbMedeniHali, 7);
            Tool.SecenekDoldur(cbEtnikKoken, 10);
            Tool.SecenekDoldur(cbDiniInanci, 11);
            Tool.SecenekDoldur(cbMezhebi, 12);

            SorgulamaKriterYerlestir();
            katilimciList = prCevDal.GetKatilimciProfilList(Obj.Id);

            for (int i = 0; i < dgAnketKatilimciListesi.Columns.Count; i++)
            {
                var col = dgAnketKatilimciListesi.Columns[i];
                if (i>= 4)
                {
                    int prid = i - 3;
                    col.Visible = profilIdList.Contains(prid);
                }
            }

            Sorgula();

        }

        public void Sorgula()
        {

            DtoKatilimciProfilSorguKr kriter = new DtoKatilimciProfilSorguKr();

            kriter.Tarih1 = Tool.StrToDate(txtTarih1.Text.Trim());
            kriter.Tarih2 = Tool.StrToDate(txtTarih2.Text.Trim());
            kriter.Yer = txtYer.Text.Trim();

            kriter.AdSoyad = txtAdiSoyadi.Text.Trim();

            //kriter.CinsNo = cbCinsiyet.SelectedIndex >= 0 ? Convert.ToInt32(cbCinsiyet.SelectedValue) : 0;
            kriter.CinsNo = cbCinsiyet.SelectedIndex;

            kriter.Yas1 = Tool.StrToInt(txtYas1.Text.Trim());
            kriter.Yas2 = Tool.StrToInt(txtYas2.Text.Trim());

            //kriter.OgrenimDurumNo =cbOgrenimDurum.SelectedIndex >= 0 ? Convert.ToInt32(cbCinsiyet.SelectedValue) : 0;
            kriter.OgrenimDurumNo = cbOgrenimDurum.SelectedIndex;

            //kriter.CalismaDurumNo = cbCalismaDurum.SelectedIndex >= 0 ? Convert.ToInt32(cbCinsiyet.SelectedValue) : 0;
            kriter.CalismaDurumNo = cbCalismaDurum.SelectedIndex;

            //kriter.AskerlikDurumNo = cbAskerlikDurumu.SelectedIndex >= 0 ? Convert.ToInt32(cbCinsiyet.SelectedValue) : 0;
            kriter.AskerlikDurumNo = cbAskerlikDurumu.SelectedIndex;

            //kriter.MedeniHalNo = cbMedeniHali.SelectedIndex >= 0 ? Convert.ToInt32(cbCinsiyet.SelectedValue) : 0;
            kriter.MedeniHalNo = cbMedeniHali.SelectedIndex;

            kriter.YasadigiYer = txtYasadigiYer.Text.Trim();
            kriter.AylikNetGelir1 = Tool.StrToDouble(txtNetGelir1.Text.Trim());
            kriter.AylikNetGelir2 = Tool.StrToDouble(txtNetGelir2.Text.Trim());

            //kriter.EtnikKokenNo = cbEtnikKoken.SelectedIndex >= 0 ? Convert.ToInt32(cbCinsiyet.SelectedValue) : 0;
            kriter.EtnikKokenNo = cbEtnikKoken.SelectedIndex;

            //kriter.DiniInancNo = cbDiniInanci.SelectedIndex >= 0 ? Convert.ToInt32(cbCinsiyet.SelectedValue) : 0;
            kriter.DiniInancNo = cbDiniInanci.SelectedIndex;

            //kriter.MezhepNo = cbMezhebi.SelectedIndex >= 0 ? Convert.ToInt32(cbCinsiyet.SelectedValue) : 0;
            kriter.MezhepNo = cbMezhebi.SelectedIndex;

            var sorgu = katilimciList.Where(x => x.Id > 0);

            if (kriter.Tarih1.HasValue)
            {
                if (kriter.Tarih2.HasValue)
                {
                    sorgu = sorgu.Where(x => x.Tarih >= kriter.Tarih1 && x.Tarih <= kriter.Tarih2);
                }
                else
                {
                    sorgu = sorgu.Where(x => x.Tarih >= kriter.Tarih1);
                }
            }
            else
            {
                if (kriter.Tarih2.HasValue)
                {
                    sorgu = sorgu.Where(x => x.Tarih <= kriter.Tarih2);
                }
            }

            if (string.IsNullOrWhiteSpace(kriter.Yer) == false)
            {
                sorgu = sorgu.Where(x => x.Yer.Contains(kriter.Yer));
            }


            if (string.IsNullOrWhiteSpace(kriter.AdSoyad) == false)
            {
                sorgu = sorgu.Where(x => x.AdSoyad.Contains(kriter.AdSoyad));
            }

            if (kriter.CinsNo > 0)
            {
                sorgu = sorgu.Where(x => x.CinsNo == kriter.CinsNo);
            }
           
            if (kriter.Yas1.HasValue)
            {
                if (kriter.Yas2.HasValue)
                {
                    sorgu = sorgu.Where(x => x.Yas >= kriter.Yas1 && x.Yas <= kriter.Yas2);
                }
                else
                {
                    sorgu = sorgu.Where(x => x.Yas >= kriter.Yas1);
                }
            }
            else
            {
                if (kriter.Yas2.HasValue)
                {
                    sorgu = sorgu.Where(x => x.Yas <= kriter.Yas2);
                }
            }

            if (kriter.OgrenimDurumNo > 0)
            {
                sorgu = sorgu.Where(x => x.OgrenimDurumNo == kriter.OgrenimDurumNo);
            }

            if (kriter.CalismaDurumNo > 0)
            {
                sorgu = sorgu.Where(x => x.CalismaDurumNo == kriter.CalismaDurumNo);
            }

            if (kriter.AskerlikDurumNo > 0)
            {
                sorgu = sorgu.Where(x => x.AskerlikDurumNo == kriter.AskerlikDurumNo);
            }

            if (kriter.MedeniHalNo > 0)
            {
                sorgu = sorgu.Where(x => x.MedeniHalNo == kriter.MedeniHalNo);
            }

            if (string.IsNullOrWhiteSpace(kriter.YasadigiYer) == false)
            {
                sorgu = sorgu.Where(x => x.YasadigiYer.Contains(kriter.YasadigiYer));
            }

            if (kriter.AylikNetGelir1.HasValue)
            {
                if (kriter.AylikNetGelir2.HasValue)
                {
                    sorgu = sorgu.Where(x => x.AylikNetGelir >= kriter.AylikNetGelir1 && x.AylikNetGelir <= kriter.AylikNetGelir2);
                }
                else
                {
                    sorgu = sorgu.Where(x => x.AylikNetGelir >= kriter.AylikNetGelir1);
                }
            }
            else
            {
                if (kriter.AylikNetGelir2.HasValue)
                {
                    sorgu = sorgu.Where(x => x.AylikNetGelir <= kriter.AylikNetGelir2);
                }
            }

            if (kriter.EtnikKokenNo > 0)
            {
                sorgu = sorgu.Where(x => x.EtnikKokenNo == kriter.EtnikKokenNo);
            }

            if (kriter.DiniInancNo > 0)
            {
                sorgu = sorgu.Where(x => x.DiniInancNo == kriter.DiniInancNo);
            }

            if (kriter.MezhepNo > 0)
            {
                sorgu = sorgu.Where(x => x.MezhepNo == kriter.MezhepNo);
            }


            var list = sorgu.OrderBy(x => x.KatilimciNo).ToList().Select(x => new DtoKatilimciProfilView()
            {
                Id = x.Id,
                KatilimciNo = x.KatilimciNo,
                Tarih = x.Tarih,
                Yer = x.Yer,
                AdSoyad = x.AdSoyad,
                CinsText = x.CinsText,
                Yas = x.Yas,
                OgrenimDurumText = x.OgrenimDurumText,
                CalismaDurumText = x.CalismaDurumText,
                AskerlikDurumText = x.AskerlikDurumText,
                MedeniHalText = x.MedeniHalText,
                YasadigiYer = x.YasadigiYer,
                AylikNetGelir = x.AylikNetGelir,
                EtnikKokenText = x.EtnikKokenText,
                DiniInancText = x.DiniInancText,
                MezhepText = x.MezhepText

            }).ToList();

            BindingSource bs = new BindingSource();
            bs.DataSource = list;
            dgAnketKatilimciListesi.DataSource = bs;

        }

        public void SorgulamaKriterYerlestir()
        {
            profilIdList = apDal.GetProfilIdFromAnket(AnketId);
            int sol = 12;
            int sag;
            int ust_fark = 0;

            for (int t = 1; t <= 14; t++)
            {
                var conts = GetControlFromTag(t);
                if (profilIdList.Contains(t) || t > 12)
                {
                    Control lab = null;
                    int labIndex = GetLabelIndex(conts);
                    if (labIndex >= 0)
                    {
                        lab = conts[labIndex];
                    }

                    int fark = lab.Left - sol;
                    lab.Left = sol;
                    lab.Top += ust_fark;
                    lab.Visible = true;
                    sag = lab.Left + lab.Width;

                    for (int i = 0; i < conts.Count; i++)
                    {
                        if (i != labIndex)
                        {
                            var cont = conts[i];
                            cont.Left -= fark;
                            cont.Top += ust_fark;
                            if (cont.Left + cont.Width > sag)
                            {
                                sag = cont.Left + cont.Width;
                            }
                            cont.Visible = true;
                        }
                    }
                    sol = sag + 36;

                    if (sol > gbSorguKriter.Width)
                    {
                        // Taşma var
                        ust_fark += 40;
                        fark = lab.Left - 12;
                        for (int i = 0; i < conts.Count; i++)
                        {
                            var cont = conts[i];
                            cont.Left -= fark;
                            cont.Top += 40;
                        }
                        sol -= fark;
                    }
                }
                else
                {

                    for (int i = 0; i < conts.Count; i++)
                    {
                        var cont = conts[i];
                        cont.Visible = false;
                    }
                }

            }

            //// Visible
            //for (int i = 0; i < gbSorguKriter.Controls.Count; i++)
            //{
            //    Control cont = gbSorguKriter.Controls[i];

            //    int t = Convert.ToInt32(cont.Tag);
            //    cont.Visible = profilList.Contains(t);
            //}
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAdiSoyadi.Text = String.Empty;
            cbCinsiyet.SelectedIndex = 0;
            txtYas1.Text = String.Empty;
            txtYas2.Text = String.Empty;
            cbOgrenimDurum.SelectedIndex = 0;
            cbCalismaDurum.SelectedIndex = 0;
            cbAskerlikDurumu.SelectedIndex = 0;
            cbMedeniHali.SelectedIndex = 0;
            txtYasadigiYer.Text = String.Empty;
            txtNetGelir1.Text = String.Empty;
            txtNetGelir2.Text = String.Empty;
            cbEtnikKoken.SelectedIndex = 0;
            cbDiniInanci.SelectedIndex = 0;
            cbMezhebi.SelectedIndex = 0;
            txtTarih1.Text = String.Empty;
            txtTarih2.Text = String.Empty;
            txtYer.Text= String.Empty;
            Sorgula();
        }

        private void btnSorgu_Click(object sender, EventArgs e)
        {
            Sorgula();
        }

        //21.08
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AnketCevapKayit frm = new AnketCevapKayit(Obj.Id, 0);
            frm.ShowDialog();
            katilimciList = prCevDal.GetKatilimciProfilList(Obj.Id);
            Sorgula();
        }

        //21.08
        private void dgAnketKatilimciListesi_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (dgAnketKatilimciListesi.CurrentRow != null)
            {
                long katilimciid = Convert.ToInt64(dgAnketKatilimciListesi.CurrentRow.Cells["ColId"].Value);
                AnketCevapKayit frm = new AnketCevapKayit(Obj.Id, katilimciid);
                frm.ShowDialog();
                katilimciList = prCevDal.GetKatilimciProfilList(Obj.Id);
                Sorgula();
            }

        }

        public int GetSelectedRowIndex()
        {
            for (int i = 0; i < dgAnketKatilimciListesi.Rows.Count; i++)
            {
                if (dgAnketKatilimciListesi.Rows[i].Selected)
                {
                    return i;
                }
            }
            return -1;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int i = GetSelectedRowIndex();

            if (i > 0)
            {
                long id1 = Convert.ToInt64(dgAnketKatilimciListesi.Rows[i].Cells["ColId"].Value);
                long id2 = Convert.ToInt64(dgAnketKatilimciListesi.Rows[i - 1].Cells["ColId"].Value);
                kDal.KatilimciIdDegis(id1, id2); // Veri tabanında katılımcı noların değiştirilmesi
                
                
                var obj1 = katilimciList.FirstOrDefault(x => x.Id == id1);
                var obj2 = katilimciList.FirstOrDefault(x => x.Id == id2);

                int kn = obj1.KatilimciNo;
                obj1.KatilimciNo = obj2.KatilimciNo;
                obj2.KatilimciNo = kn;

                Sorgula();
                dgAnketKatilimciListesi.Rows[i - 1].Selected = true;

            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int i = GetSelectedRowIndex();

            if (i >= 0 && i < dgAnketKatilimciListesi.Rows.Count - 1)
            {
                long id1 = Convert.ToInt64(dgAnketKatilimciListesi.Rows[i].Cells["ColId"].Value);
                long id2 = Convert.ToInt64(dgAnketKatilimciListesi.Rows[i + 1].Cells["ColId"].Value);
                kDal.KatilimciIdDegis(id1, id2);

                var obj1 = katilimciList.FirstOrDefault(x => x.Id == id1);
                var obj2 = katilimciList.FirstOrDefault(x => x.Id == id2);

                int kn = obj1.KatilimciNo;
                obj1.KatilimciNo = obj2.KatilimciNo;
                obj2.KatilimciNo = kn;

                Sorgula(); 
                dgAnketKatilimciListesi.Rows[i + 1].Selected = true;

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }
    }
}
