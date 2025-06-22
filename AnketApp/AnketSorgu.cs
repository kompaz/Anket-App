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
    public partial class AnketSorgu : Form
    {
        AnketDal dal = new AnketDal();

        public AnketSorgu()
        {
            InitializeComponent();
        }

        public void Sorgula()
        {
            DtoAnketSorguKr kriter = new DtoAnketSorguKr();
            kriter.KayitTarih1 = Tool.StrToDate(txtKayitTarih1.Text.Trim());
            kriter.KayitTarih2 = Tool.StrToDate(txtKayitTarih2.Text.Trim());
            kriter.Duzenleyen = txtDuzenleyen.Text.Trim();
            kriter.AnketAd = txtAnket.Text.Trim();
            kriter.Baslama1 = Tool.StrToDate(txtBaslama1.Text.Trim());
            kriter.Baslama2 = Tool.StrToDate(txtBaslama2.Text.Trim());
            kriter.Bitis1 = Tool.StrToDate(txtBitis1.Text.Trim());
            kriter.Bitis2 = Tool.StrToDate(txtBitis2.Text.Trim());
            kriter.Konu = txtKonu.Text.Trim();

            List<Anket> list = dal.GetFromCriteria(kriter);

            BindingSource bs = new BindingSource();
            bs.DataSource = list;
            dgAnket.DataSource = bs;

        }


        private void btnSorgu_Click(object sender, EventArgs e)
        {
            Sorgula();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtKayitTarih1.Text = String.Empty;
            txtKayitTarih2.Text = String.Empty;
            txtDuzenleyen.Text = String.Empty;
            txtAnket.Text = String.Empty;
            txtBaslama1.Text = String.Empty;
            txtBaslama2.Text = String.Empty;
            txtBitis1.Text = String.Empty;
            txtBitis2.Text = String.Empty;
            txtKonu.Text = String.Empty;
            Sorgula();

        }

        private void AnketSorgu_Load(object sender, EventArgs e)
        {
            Sorgula();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            AnketKayit frmKayit = new AnketKayit(0);
            frmKayit.ShowDialog();
            Sorgula();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            if (dgAnket.SelectedRows.Count > 0)
            {
                long id = Convert.ToInt64(dgAnket.SelectedRows[0].Cells["ColId"].Value);
                if (id > 0)
                {
                    if (MessageBox.Show(id.ToString() + " no.lu Anket silinecek. Devam etmek istediğinizden emin misiniz?", "SİLME ONAYI", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (dal.Delete(id))
                        {
                            Sorgula();
                        }
                        else
                        {
                            MessageBox.Show(id.ToString() + " no.lu Anket silinemedi.");
                        }
                    }
                }
            }
        }

        private void dgAnket_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            long id = Convert.ToInt64(dgAnket.SelectedRows[0].Cells["ColId"].Value);
            if (id > 0)
            {
                AnketKayit frmKayit = new AnketKayit(id);
                frmKayit.ShowDialog();
                Sorgula();
            }
        }

      
    }
}
