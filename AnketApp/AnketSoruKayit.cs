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
    public partial class AnketSoruKayit : Form
    {
        long Id;
        long AnketId;
        Soru Obj = new Soru();
        SoruTipDal soruTipDal = new SoruTipDal();
        SoruDal soruDal = new SoruDal();
        SoruSecenekDal secenekDal = new SoruSecenekDal();
        public AnketSoruKayit(long anketid, long soruid)
        {
            InitializeComponent();
            Id = soruid;
            AnketId = anketid;
        }

        public void FormDoldur()
        {
            txtSoruNo.Text = Obj.SoruNo.ToString();
            cbSoruTipi.SelectedIndex = Obj.SoruTipId - 1;
            txtSoruMetni.Text = Obj.SoruMetin;
            List<SoruSecenek> secenekList = secenekDal.GetSoruSecenekObjListFromSoruId(Obj.Id);
            foreach (var item in secenekList)
            {
                lbSecenek.Items.Add(item);
            }
        }

        public void FormTemizle()
        {
            txtSoruNo.Text = String.Empty;
            cbSoruTipi.SelectedIndex =  - 1;
            txtSoruMetni.Text = String.Empty;
            

        }

        public void ObjDoldur()
        {
            Obj.SoruTipId = cbSoruTipi.SelectedIndex + 1;
            Obj.SoruNo = txtSoruNo.Text == String.Empty ? 1 : Convert.ToInt32(txtSoruNo.Text);
            Obj.SoruMetin = txtSoruMetni.Text.Trim();
            
        }


        public string Kontrol()
        {
            string hata = string.Empty;

            if (string.IsNullOrEmpty(txtSoruMetni.Text))
            {
                hata += "Soru Metni girilmemiş\n";
            }

            if (cbSoruTipi.SelectedIndex < 0)
            {
                hata += "Soru Tipi seçilmemiş\n";
            } 
            else if (cbSoruTipi.SelectedIndex <= 1)
            {
                if (lbSecenek.Items.Count < 2)
                {
                    hata += "Yeterli sayıda seçenek yok\n";
                }
            }
            return hata;

        }

        public int GetIndexFromString(string str)
        {
            for (int i = 0; i < lbSecenek.Items.Count; i++)
            {
                SoruSecenek obj = (SoruSecenek)lbSecenek.Items[i];
                if (obj.Secenek == str)
                {
                    return i;
                }
            }
            return -1;
        }

        public int GetIndexFromId(long id)
        {
            for (int i = 0; i < lbSecenek.Items.Count; i++)
            {
                SoruSecenek obj = (SoruSecenek)lbSecenek.Items[i];
                if (obj.Id == id)
                {
                    return i;
                }
            }
            return -1;
        }


     

        private void AnketSoruKayit_Load(object sender, EventArgs e)
        {
            List<SoruTip> soruTipList = soruTipDal.GetAll();
            for (int i = 0; i < soruTipList.Count; i++)
            {
                SoruTip sTip = soruTipList[i];
                cbSoruTipi.Items.Add(sTip.TipAd);
            }

            if (Id==0)
            {
                // Yeni Soru
                Obj = new Soru();
                Obj.Id = 0;
                Obj.AnketId = AnketId;
                Obj.SoruNo = soruDal.GetLastSoruNo(AnketId) + 1;
                FormTemizle();
                txtSoruNo.Text = Obj.SoruNo.ToString();

            }
            else
            {
                // Mevcut
                Obj = soruDal.Get(Id);
                FormDoldur();
            }
            
        }

    

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int i = GetIndexFromString(txtSecenek.Text.Trim());
            if (i == -1)
            {
                SoruSecenek obj = new SoruSecenek()
                {
                    Id = 0,
                    SoruId = Obj.Id,
                    SecenekNo = lbSecenek.Items.Count + 1,
                    Secenek = txtSecenek.Text.Trim()
                };

                lbSecenek.Items.Add(obj);
                txtSecenek.Text = string.Empty;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lbSecenek.SelectedIndex >=0)
            {
                lbSecenek.Items.RemoveAt(lbSecenek.SelectedIndex);
                txtSecenek.Text = string.Empty;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int i = lbSecenek.SelectedIndex;
            if (i >= 0 && i< lbSecenek.Items.Count - 1)
            {
                var item = lbSecenek.Items[i];
                lbSecenek.Items.Remove(item);
                lbSecenek.Items.Insert(i + 1, item);
                lbSecenek.SelectedIndex = i + 1;
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int i = lbSecenek.SelectedIndex;
            if (i > 0)
            {
                var item = lbSecenek.Items[i];
                lbSecenek.Items.Remove(item);
                lbSecenek.Items.Insert(i - 1, item);
                lbSecenek.SelectedIndex = i - 1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool basari;

            string hata = Kontrol();
            if (string.IsNullOrWhiteSpace(hata) == false)
            {
                MessageBox.Show(hata, "BAZI EKSİK ve HATALAR BULUNDU");
                return;
            }

            ObjDoldur();

            if (Obj.Id == 0)
            {
                // Yeni Kayıt
                long id = soruDal.Insert(Obj);
                if (id == 0)
                {
                    MessageBox.Show("Yeni soru kaydedilemedi!");
                    basari = false;
                }
                else
                {
                    Obj.Id = id;
                    basari = true;
                }
            }
            else
            {
                // Güncelleme
                bool guncelleme = soruDal.Update(Obj);
                if (guncelleme)
                {
                    basari = true;
                }
                else
                {
                    MessageBox.Show("Soru güncellenemedi!");
                    basari=false;
                }

            }

            if (basari)
            {
                // Soru kaydedildi veya güncellendi. Sıra seçeneklerde
                List<SoruSecenek> mevList = secenekDal.GetSoruSecenekObjListFromSoruId(Obj.Id);
                
                // Silme ve Güncelleme
                foreach (var mevObj in mevList)
                {
                    int i = GetIndexFromId(mevObj.Id);
                    if (i >= 0)
                    {
                        // GÜNCELLEME
                        SoruSecenek yeni = (SoruSecenek)lbSecenek.Items[i];
                        yeni.SecenekNo = i + 1;
                        secenekDal.Update(yeni);
                    }
                    else
                    {
                        // SİLME
                        secenekDal.Delete(mevObj.Id);
                    }
                }

                for (int i = 0; i < lbSecenek.Items.Count; i++)
                {
                    SoruSecenek obj = (SoruSecenek)lbSecenek.Items[i];
                    obj.SecenekNo = i + 1;

                    bool varmi = false;
                    foreach (var mevObj in mevList)
                    {
                        if (obj.Id == mevObj.Id)
                        {
                            varmi = true;
                            break;
                        }
                    }

                    if (varmi == false)
                    {
                        // YENİ EKLEME
                        obj.SoruId = Obj.Id;
                        secenekDal.Insert(obj);
                    }
                }

                lbSecenek.Items.Clear();
                Obj = soruDal.Get(Obj.Id);
                FormDoldur();

            }
        }

        private void cbSoruTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSoruTipi.SelectedIndex > 1)
            {
                panSecenek.Visible = false;
                this.Height = 266;
            }
            else
            {
                panSecenek.Visible = true;
                this.Height = 685;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lbSecenek.SelectedIndex >= 0)
            {
                int i = lbSecenek.SelectedIndex;
                SoruSecenek obj = (SoruSecenek)lbSecenek.Items[i];
                obj.Secenek = txtSecenek.Text.Trim();
                lbSecenek.Items.RemoveAt(i);
                lbSecenek.Items.Insert(i, obj);
                lbSecenek.SelectedIndex = i;
            }
        }

        private void lbSecenek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSecenek.SelectedIndex >= 0)
            {
                txtSecenek.Text = lbSecenek.Text.Trim();
            }
        }

        private void txtSecenek_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAdd_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
