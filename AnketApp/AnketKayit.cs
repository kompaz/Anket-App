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
    public partial class AnketKayit : Form
    {
        long Id;
        Anket Obj;
        AnketDal dal = new AnketDal();
        AnketProfilDal apDal = new AnketProfilDal();
        ProfilDal pDal = new ProfilDal();
        SoruDal soruDal = new SoruDal();

        public AnketKayit(long id)
        {
            InitializeComponent();
            Id = id;
        }


        public void SoruListeGuncelle()
        {
            List<DtoSoru> soruList = soruDal.GetDtoSoruFromAnket(Obj.Id);
            BindingSource bs = new BindingSource();
            bs.DataSource = soruList;
            dgAnketSorulari.DataSource = bs;

        }

        public void FormDoldur()
        {
            dtKayit.Value = Obj.KayitTarih;
            txtDuzenleyen.Text = Obj.Duzenleyen;
            txtAnketAdi.Text = Obj.AnketAd;
            dtBaslama.Value = Obj.Baslama;
            dtBitis.Value = Obj.Bitis;
            txtKonu.Text = Obj.Konu;
            SoruListeGuncelle();
        }

        public void ObjDoldur()
        {
            Obj.KayitTarih= dtKayit.Value;
            Obj.Duzenleyen = txtDuzenleyen.Text.Trim();
            Obj.AnketAd = txtAnketAdi.Text.Trim();
            Obj.Baslama = dtBaslama.Value;
            Obj.Bitis = dtBitis.Value;
            Obj.Konu = txtKonu.Text.Trim();
        }


        public void FormTemizle()
        {
            dtKayit.Value = DateTime.Now;
            txtDuzenleyen.Text = String.Empty;
            txtAnketAdi.Text = String.Empty;
            dtBaslama.Value = DateTime.Today;
            dtBitis.Value = DateTime.Today;
            txtKonu.Text = String.Empty;

        }

        public int GetSelectedRowIndex()
        {
            for (int i = 0; i < dgAnketSorulari.Rows.Count; i++)
            {
                if (dgAnketSorulari.Rows[i].Selected)
                {
                    return i;
                }
            }
            return -1;
        }

        public string Kontrol()
        {
            string hata = string.Empty;

            if (string.IsNullOrEmpty(txtDuzenleyen.Text))
            {
                hata += "Düzenleyen girilmemiş\n";
            }
            if (string.IsNullOrEmpty(txtAnketAdi.Text))
            {
                hata += "Anket Adı girilmemiş\n";
            }
            if (string.IsNullOrEmpty(txtKonu.Text))
            {
                hata += "Konu girilmemiş\n";
            }

            if (dtBitis.Value < dtBitis.Value)
            {
                hata += "Bitiş tarihi, Başlama tarihindem önce olamaz.\n";
            }
            return hata;

        }

        public void ProfilYukle()
        {
            List<Profil> pList = pDal.GetAll();
            List<int> apIdlist = apDal.GetProfilIdFromAnket(Obj.Id);

            for (int i = 0; i < pList.Count; i++)
            {
                Profil p = pList[i];
                clbKatilimciProfil.Items.Add(p.ProfilAd);
                clbKatilimciProfil.SetItemChecked(i, apIdlist.Contains(p.ProfilNo));
            }
        }

        public void AnketProfilKayit()
        {
            // Mevcut Profil Listesini elde
            List<int> mevList = apDal.GetProfilIdFromAnket(Obj.Id);

            for (int i = 0; i < clbKatilimciProfil.Items.Count; i++)
            {
                if (clbKatilimciProfil.GetItemChecked(i))
                {
                    if (mevList.Contains(i + 1) ==  false)
                    {
                        // Checked olup ancak mevcut içinde bulunmayanları ekliyoruz.
                        var obj = new AnketProfil()
                        {
                            Id = 0,
                            AnketId = Obj.Id,
                            ProfilId = i + 1
                        };
                        apDal.Insert(obj);
                    }

                }
                else
                {
                    if (mevList.Contains(i + 1))
                    {
                        // Checked olmayıp ancak mevcut içinde bulunanları siliyoruz.
                        apDal.Delete(Obj.Id, i + 1);
                    }
                        
                }
            }


        }

        private void AnketKayit_Load(object sender, EventArgs e)
        {
            if (Id == 0)
            {
                // Yeni Anket
                Obj = new Anket();
                Obj.Id = 0;
                FormTemizle();

            }
            else
            {
                // Mevcut Anket
                Obj = dal.Get(Id);
                FormDoldur();
            }
            ProfilYukle();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AnketSoruKayit frmSoruKayit = new AnketSoruKayit(Obj.Id, 0);
            frmSoruKayit.ShowDialog();
            SoruListeGuncelle();
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgAnketSorulari.SelectedRows.Count > 0)
            {
                long id = Convert.ToInt64(dgAnketSorulari.SelectedRows[0].Cells["ColId"].Value);
                if (id > 0)
                {
                    if (MessageBox.Show(id.ToString() + " no.lu Soru silinecek. Devam etmek istediğinizden emin misiniz?", "SİLME ONAYI", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (soruDal.Delete(id))
                        {
                            SoruListeGuncelle();
                        }
                        else
                        {
                            MessageBox.Show(id.ToString() + " no.lu Soru silinemedi.");
                        }
                    }
                }
            }

            SoruListeGuncelle();
        }

        private void dgAnketSorulari_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            long id = Convert.ToInt64(dgAnketSorulari.SelectedRows[0].Cells["ColId"].Value);
            if (id > 0)
            {
                AnketSoruKayit frmKayit = new AnketSoruKayit(Obj.Id, id);
                frmKayit.ShowDialog();
                SoruListeGuncelle();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string hata = Kontrol();
            bool basari;
            if (hata!=string.Empty)
            {
                MessageBox.Show(hata, "BAZI HATA ve EKSİKLİKLER BULUNDU");
                basari = false;
                return;
            }

            ObjDoldur();

            if (Obj.Id == 0)
            {
                // Yeni Kayıt
                long id = dal.Insert(Obj);
                Obj.Id = id;
                basari = true;
            }
            else
            {
                // Güncelleme
                if (dal.Update(Obj))
                {
                    basari = true;
                }
                else
                {
                    basari = false;
                    MessageBox.Show("Güncellemedi.");
                }
            }

            if (basari)
            {
                // Anket Profil Kayıt
                AnketProfilKayit();
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int i = GetSelectedRowIndex();

            if (i > 0)
            {
                long id1 = Convert.ToInt64(dgAnketSorulari.Rows[i].Cells["ColId"].Value);
                long id2 = Convert.ToInt64(dgAnketSorulari.Rows[i - 1].Cells["ColId"].Value);
                soruDal.SonuNoDegis(id1, id2);
                SoruListeGuncelle();
                dgAnketSorulari.Rows[i - 1].Selected = true;

            }

        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int i = GetSelectedRowIndex();
            
            if (i >= 0 && i < dgAnketSorulari.Rows.Count-1)
            {
                long id1 = Convert.ToInt64(dgAnketSorulari.Rows[i].Cells["ColId"].Value);
                long id2 = Convert.ToInt64(dgAnketSorulari.Rows[i+1].Cells["ColId"].Value);
                soruDal.SonuNoDegis(id1, id2);
                SoruListeGuncelle();
                dgAnketSorulari.Rows[i + 1].Selected = true;

            }
        }

        private void btnCevapSorgu_Click(object sender, EventArgs e)
        {
            AnketCevapSorgulama frm = new AnketCevapSorgulama(Obj.Id);
            frm.ShowDialog();
        }
    }
}
