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
    public partial class AnketCevapKayit : Form
    {
        long AnketId;
        long KatilimciId;

        AnketDal anketDal = new AnketDal();
        AnketProfilDal apDal = new AnketProfilDal();
        ProfilCevapDal pcDal = new ProfilCevapDal();
        SoruCevapDal scDal = new SoruCevapDal();
        KatilimciDal katDal = new KatilimciDal();
        List<int> profilIdList;

        public AnketCevapKayit(long anketid, long katilimmciid)
        {
            InitializeComponent();
            AnketId = anketid;
            KatilimciId = katilimmciid;
        }

        //21.08
        public List<Control> GetControlFromTag(int tag)
        {
            List<Control> res = new List<Control>();

            for (int i = 0; i < panKatilimciProfil.Controls.Count; i++)
            {
                Control cont = panKatilimciProfil.Controls[i];

                int t = Convert.ToInt32(cont.Tag);
                if (t == tag)
                {
                    res.Add(cont);
                }
            }
            return res;
        }

        //21.08
        public void ProfilYerlestir()
        {
            profilIdList = apDal.GetProfilIdFromAnket(AnketId);
            int ust_fark = 0;

            for (int t = 1; t <= 12; t++)
            {
                var conts = GetControlFromTag(t);
                if (profilIdList.Contains(t))
                {
                    for (int i = 0; i < conts.Count; i++)
                    {
                        var cont = conts[i];
                        cont.Top += ust_fark;

                    }
                    ust_fark += 40;
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
        }

        //21.08
        public void ProfilDoldur()
        {
            DtoKatilimciProfil obj = pcDal.GetKatilimciProfil(KatilimciId);
            dtTarih.Value = obj.Tarih;
            txtYer.Text = obj.Yer;

            for (int t = 1; t <= 12; t++)
            {
                var conts = GetControlFromTag(t);
               
                if (profilIdList.Contains(t))
                {
                    for (int i = 0; i < conts.Count; i++)
                    {
                        var cont = conts[i];
                        var ts = cont.GetType().ToString();
                        if (ts == "System.Windows.Forms.TextBox")
                        {
                            TextBox tb = (TextBox)cont;
                            switch(t) // Ad Soyad
                            {
                                case 1: 
                                    tb.Text = obj.AdSoyad;
                                    break;
                                case 3:
                                    tb.Text = obj.Yas.ToString();
                                    break;
                                case 8:
                                    tb.Text = obj.YasadigiYer;
                                    break;
                                case 9:
                                    tb.Text = obj.AylikNetGelir.ToString();
                                    break;
                            }
                        }
                        else if (ts == "System.Windows.Forms.ComboBox")
                        {
                            ComboBox cb = (ComboBox)cont;
                            switch (t) // Ad Soyad
                            {
                                case 2:
                                    cb.SelectedIndex = obj.CinsNo.HasValue ? obj.CinsNo.Value - 1 : -1;
                                    break;
                                case 4:
                                    cb.SelectedIndex = obj.OgrenimDurumNo.HasValue ? obj.OgrenimDurumNo.Value - 1 : -1;
                                    break;
                                case 5:
                                    cb.SelectedIndex = obj.CalismaDurumNo.HasValue ? obj.CalismaDurumNo.Value - 1 : -1;
                                    break;
                                case 6:
                                    cb.SelectedIndex = obj.AskerlikDurumNo.HasValue ? obj.AskerlikDurumNo.Value - 1 : -1;
                                    break;
                                case 7:
                                    cb.SelectedIndex = obj.MedeniHalNo.HasValue ? obj.MedeniHalNo.Value - 1 : -1;
                                    break;
                                case 10:
                                    cb.SelectedIndex = obj.EtnikKokenNo.HasValue ? obj.EtnikKokenNo.Value - 1 : -1;
                                    break;
                                case 11:
                                    cb.SelectedIndex = obj.DiniInancNo.HasValue ? obj.DiniInancNo.Value - 1 : -1;
                                    break;
                                case 12:
                                    cb.SelectedIndex = obj.MezhepNo.HasValue ? obj.MezhepNo.Value - 1 : -1;
                                    break;
                            }
                        }
                        else
                        {
                            // Label
                        }

                    }
                }
            }
        }

        //21.08
        public void CevapDoldur()
        {
            var cevapList = scDal.GetKatilimciCevapList(AnketId, KatilimciId);
            int ust = 15;
            foreach (var cevObj in cevapList)
            {
                var ucObj = new SoruCevapUC(cevObj);
                ucObj.Name = "Uc" + cevObj.SoruNo.ToString().PadLeft(2, '0');
                ucObj.Tag = cevObj.SoruNo;
                panAnketCevap.Controls.Add(ucObj);
                ucObj.Left = 15;
                ucObj.Top = ust;
                ust += ucObj.Height + 15;
                ucObj.Visible = true;
            }
        }

        public string ProfilKontrol()
        {
            string hata = string.Empty;

            for (int t = 1; t <= 12; t++)
            {
                var conts = GetControlFromTag(t);

                if (profilIdList.Contains(t))
                {
                    for (int i = 0; i < conts.Count; i++)
                    {
                        var cont = conts[i];
                        var ts = cont.GetType().ToString();
                        if (ts == "System.Windows.Forms.TextBox")
                        {
                            TextBox tb = (TextBox)cont;
                            switch (t) // Ad Soyad
                            {
                                case 1:
                                    if (string.IsNullOrEmpty(tb.Text))
                                    {
                                        hata += "Katılımcı adı soyadı girilmemiş\n";
                                    }
                                    break;
                                case 3:
                                    int? yas = Tool.StrToInt(tb.Text.Trim());
                                    if (yas.HasValue == false || yas.Value < 6)
                                    {
                                        hata += "Katılımcı yaşı girilmemiş veya küçük\n";
                                    }
                                    break;
                                case 8:
                                    if (string.IsNullOrEmpty(tb.Text))
                                    {
                                        hata += "Katılımcının yaşadığı yer girilmemiş\n";
                                    }
                                    break;
                                case 9:
                                    double? gelir = Tool.StrToDouble(tb.Text.Trim());
                                    if (gelir.HasValue == false || gelir.Value < 0)
                                    {
                                        hata += "Katılımcı geliri hatalı\n";
                                    }
                                    break;
                            }
                        }
                        else if (ts == "System.Windows.Forms.ComboBox")
                        {
                            ComboBox cb = (ComboBox)cont;
                            switch (t) // Ad Soyad
                            {
                                case 2:
                                    if (cb.SelectedIndex == -1)
                                    {
                                        hata += "Katılımcı cinsiyeti seçilmemiş\n";
                                    }
                                    break;
                                case 4:
                                    if (cb.SelectedIndex == -1)
                                    {
                                        hata += "Katılımcı öğrenim durumu seçilmemiş\n";
                                    }
                                    break;
                                case 5:
                                    if (cb.SelectedIndex == -1)
                                    {
                                        hata += "Katılımcı çalışma durumu seçilmemiş\n";
                                    }
                                    break;
                                case 6:
                                    if (cb.SelectedIndex == -1)
                                    {
                                        hata += "Katılımcı çalışma durumu seçilmemiş\n";
                                    }
                                    break;
                                case 7:
                                    if (cb.SelectedIndex == -1)
                                    {
                                        hata += "Katılımcı medeni hali seçilmemiş\n";
                                    }
                                    break;
                                case 10:
                                    if (cb.SelectedIndex == -1)
                                    {
                                        hata += "Katılımcı etnik kökeni seçilmemiş\n";
                                    }
                                    break;
                                case 11:
                                    if (cb.SelectedIndex == -1)
                                    {
                                        hata += "Katılımcı dini inancı seçilmemiş\n";
                                    }
                                    break;
                                case 12:
                                    if (cb.SelectedIndex == -1)
                                    {
                                        hata += "Katılımcı mezhebi seçilmemiş\n";
                                    }
                                    break;
                            }
                        }
                    }
                }
            }

            return hata;
        }

        public string Kontrol()
        {
            string hata = string.Empty;
            if (string.IsNullOrWhiteSpace(txtYer.Text))
            {
                hata += "Yer adı girilmemiş\n";
            }

            hata += ProfilKontrol();

            return hata;
        }

        public long KatilimciKaydet()
        {
            Katilimci katObj;
            if (KatilimciId == 0)
            {
                katObj = new Katilimci();
                katObj.Id = 0;
                katObj.AnketId = AnketId;
                katObj.KatilimciNo = katDal.GetNewKatilimciNo(AnketId);
                katObj.Tarih = dtTarih.Value;
                katObj.Yer = txtYer.Text.Trim();
                katObj.Id = katDal.Insert(katObj);
            }
            else
            {
                // Mevcut Katılımcı
                katObj = katDal.Get(KatilimciId);
                katObj.Tarih = dtTarih.Value;
                katObj.Yer = txtYer.Text.Trim();
                katDal.Update(katObj);
            }
            return katObj.Id;
        }

        public void ProfilKaydet(long katilimciid)
        {

            for (int t = 1; t <= 12; t++)
            {
                var conts = GetControlFromTag(t);

                if (profilIdList.Contains(t))
                {
                    ProfilCevap obj = pcDal.Get(katilimciid, t);
                    if (obj == null)
                    {
                        obj = new ProfilCevap();
                        obj.Id = 0;
                        obj.AnketId = AnketId;
                        obj.KatilimciId = katilimciid;
                        obj.ProfilId = t;
                    }
                    
                    for (int i = 0; i < conts.Count; i++)
                    {
                        var cont = conts[i];
                        var ts = cont.GetType().ToString();
                        if (ts == "System.Windows.Forms.TextBox")
                        {
                            TextBox tb = (TextBox)cont;
                            switch (t) // Ad Soyad
                            {
                                case 1:
                                    obj.Cevap = tb.Text.Trim();
                                    break;
                                case 3:
                                    int? yas = Tool.StrToInt(tb.Text.Trim());
                                    obj.Cevap = yas.Value.ToString();
                                    break;
                                case 8:
                                    obj.Cevap = tb.Text.Trim();
                                    break;
                                case 9:
                                    double? gelir = Tool.StrToDouble(tb.Text.Trim());
                                    obj.Cevap = gelir.Value.ToString();
                                    break;
                            }
                        }
                        else if (ts == "System.Windows.Forms.ComboBox")
                        {
                            ComboBox cb = (ComboBox)cont;
                            if (cb.SelectedIndex >= 0)
                            {
                                obj.Cevap = (cb.SelectedIndex +1).ToString();
                            }
                        }
                    }
                    if (obj.Id==0)
                    {
                        pcDal.Insert(obj);
                    }
                    else
                    {
                        pcDal.Update(obj);
                    }
                    
                }
            }

        }

        public void CevapKaydet(long katilimciid)
        {
            for (int i = 0; i < panAnketCevap.Controls.Count; i++)
            {
                var uc = (SoruCevapUC)panAnketCevap.Controls[i];
                var dtoObj = uc.Obj;
                SoruCevap obj = new SoruCevap()
                {
                    Id = dtoObj.Id,
                    AnketId = dtoObj.AnketId,
                    KatilimciId = katilimciid,
                    SoruId = dtoObj.SoruId,
                    Cevap = dtoObj.Cevap
                };

                if (obj.Id == 0)
                {
                    scDal.Insert(obj);
                }
                else
                {
                    scDal.Update(obj);
                }

            }
        }
        //21.08
        private void AnketCevapKayit_Load(object sender, EventArgs e)
        {
            var anketObj = anketDal.Get(AnketId);
            txtAnketAdi.Text = anketObj.AnketAd;
            Tool.SecenekDoldur(cbCinsiyet, 2, false);
            Tool.SecenekDoldur(cbOgrenimDurum, 4, false);
            Tool.SecenekDoldur(cbCalismaDurumu, 5, false);
            Tool.SecenekDoldur(cbAskerlikDurumu, 6, false);
            Tool.SecenekDoldur(cbMedeniHali, 7, false);
            Tool.SecenekDoldur(cbEtnikKoken, 10, false);
            Tool.SecenekDoldur(cbDiniInanci, 11, false);
            Tool.SecenekDoldur(cbMezhebi, 12, false);
            ProfilYerlestir();


            if (KatilimciId == 0)
            {
                // Yeni Katılımcı
            }
            else
            {
                // Mevcut Katılımcı
                ProfilDoldur();
            }
            CevapDoldur();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string hata = Kontrol();
            if (string.IsNullOrEmpty(hata)==false)
            {
                MessageBox.Show(hata, "ANKET CEVAP KONTROL");
                return;
            }

            var katid = KatilimciKaydet();
            ProfilKaydet(katid);
            CevapKaydet(katid);
        }

        private void panKatilimciProfil_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
