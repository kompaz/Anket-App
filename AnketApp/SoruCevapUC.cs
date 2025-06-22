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
    public partial class SoruCevapUC : UserControl
    {
        public DtoSoruCevap Obj;

        public SoruCevapUC(DtoSoruCevap obj)
        {
            InitializeComponent();
            Obj = obj;
        }

        public void FormDoldur()
        {
            labSoruNo.Text = Obj.SoruNo.ToString().PadLeft(2, '0');
            txtSoruMetin.Text = Obj.SoruMetin;

            if (Obj.SoruTipId > 2)
            {
                // Dar
                //panCevap.Height = 50;
                this.Height = 155;
            }
            else
            {
                // Geniş
                // panCevap.Height = 135;
                this.Height = Obj.SoruSeceneks.Count * 30 + 110;
            }

            if (Obj.SoruTipId == 1)
            {
                // Tek Seçim
                for (int i = 0; i < Obj.SoruSeceneks.Count; i++)
                {
                    var secObj = Obj.SoruSeceneks[i];
                    var radObj = new RadioButton();
                    radObj.Name = "Sec" + i.ToString().PadLeft(2, '0');
                    radObj.Tag = secObj.SecenekNo;
                    radObj.Enabled = true;
                    radObj.Text = secObj.Secenek;
                    int? cevap = Tool.StrToInt(Obj.Cevap);
                    radObj.Checked = (cevap.HasValue && cevap.Value == secObj.SecenekNo);
                    panCevap.Controls.Add(radObj);
                    radObj.AutoSize = false;
                    radObj.Left = 15;
                    radObj.Top = i * 30 + 10;
                    radObj.Width = 580;
                    radObj.Height = 25;
                    radObj.Visible = true;
                    radObj.Click += new System.EventHandler(this.radioButton_Click);
                }
            }
            else if (Obj.SoruTipId == 2)
            {
                // Çoklu Seçim
                var CevapList = Tool.GetIntList(Obj.Cevap);

                for (int i = 0; i < Obj.SoruSeceneks.Count; i++)
                {
                    var secObj = Obj.SoruSeceneks[i];
                    var chObj = new CheckBox();
                    chObj.Name = "Sec" + i.ToString().PadLeft(2, '0');
                    chObj.Tag = secObj.SecenekNo;
                    chObj.Enabled = true;
                    chObj.Text = secObj.Secenek;
                   
                    panCevap.Controls.Add(chObj);
                    chObj.AutoSize = false;
                    chObj.Left = 15;
                    chObj.Top = i * 30 + 10;
                    chObj.Width = 580;
                    chObj.Height = 25;
                    chObj.Visible = true;
                    chObj.Checked = (CevapList.Contains(secObj.SecenekNo));
                    chObj.CheckStateChanged += new System.EventHandler(this.checkBox_CheckStateChanged);
                }
            }
            else if (Obj.SoruTipId == 3)
            {
                // Sayılsal değer
                TextBox tbObj = new TextBox();
                panCevap.Controls.Add(tbObj);
                tbObj.Left = 15;
                tbObj.Top = 10;
                tbObj.Width = 100;
                tbObj.Visible = true;
                double? cevap = Tool.StrToDouble(Obj.Cevap);
                if (cevap.HasValue)
                {
                    tbObj.Text = cevap.Value.ToString();
                }
                else
                {
                    tbObj.Text = String.Empty;
                }
                tbObj.TextChanged += new System.EventHandler(this.textBoxSayi_TextChanged);
            }
            else if (Obj.SoruTipId == 4)
            {
                // Metin
                TextBox tbObj = new TextBox();
                panCevap.Controls.Add(tbObj);
                tbObj.Left = 15;
                tbObj.Top = 10;
                tbObj.Width = 570;
                tbObj.Visible = true;
                tbObj.Text = Obj.Cevap;
                tbObj.TextChanged += new System.EventHandler(this.textBoxMetin_TextChanged);

            }
            else if (Obj.SoruTipId == 5)
            {
                // Tarih
                DateTimePicker dtObj = new DateTimePicker();
                panCevap.Controls.Add(dtObj);
                dtObj.Left = 15;
                dtObj.Top = 10;
                dtObj.Width = 200;
                dtObj.Visible = true;
                dtObj.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);

                DateTime? cevap = Tool.StrToDate(Obj.Cevap);

                if (cevap.HasValue)
                {
                    dtObj.Value = cevap.Value;
                }
                else
                {
                    dtObj.Value = DateTime.Today;
                }
            }
        }

        private void RadObj_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SoruCevapUC_Load(object sender, EventArgs e)
        {
            FormDoldur();


            if (Obj.Id == 0)
            {
                // Cevaplanmamış Soru

            }
            else
            {
                // Cevaplanmış Soru
            }
        }

        private void radioButton_Click(object sender, EventArgs e)
        {
            var rbObj = (RadioButton)sender;
            int? secno = Tool.StrToInt(rbObj.Tag.ToString());
            if (secno.HasValue && rbObj.Checked)
            {
                Obj.Cevap = secno.ToString();
            }
        }

        private void checkBox_CheckStateChanged(object sender, EventArgs e)
        {
            var chObj = (CheckBox)sender;
            int? secno = Tool.StrToInt(chObj.Tag.ToString());
            if (secno.HasValue)
            { 
                if (chObj.Checked)
                {
                    Obj.Cevap = Tool.AddIntList(Obj.Cevap, secno.Value);
                }
                else
                {
                    Obj.Cevap = Tool.RemoveIntList(Obj.Cevap, secno.Value);
                }
            }
        }

        private void textBoxSayi_TextChanged(object sender, EventArgs e)
        {
            var tbObj = (TextBox)sender;
            double? val = Tool.StrToDouble(tbObj.Text.Trim());

            if (val.HasValue)
            {
                Obj.Cevap = val.ToString();
            }
            else
            {
                Obj.Cevap = null;
            }
        }


        private void textBoxMetin_TextChanged(object sender, EventArgs e)
        {
            var tbObj = (TextBox)sender;

            Obj.Cevap = tbObj.Text.Trim();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            var dtObj = (DateTimePicker)sender;

            Obj.Cevap = dtObj.Value.ToShortDateString();
        }
    }
}
