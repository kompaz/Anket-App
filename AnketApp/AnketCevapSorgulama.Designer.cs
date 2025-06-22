namespace AnketApp
{
    partial class AnketCevapSorgulama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbAnketBilgileri = new System.Windows.Forms.GroupBox();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.dtBaslama = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDuzenleyen = new System.Windows.Forms.TextBox();
            this.txtAnketAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSorguKriter = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtYer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTarih2 = new System.Windows.Forms.TextBox();
            this.txtTarih1 = new System.Windows.Forms.TextBox();
            this.txtNetGelir2 = new System.Windows.Forms.TextBox();
            this.cbMezhebi = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbDiniInanci = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNetGelir1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtYasadigiYer = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbAskerlikDurumu = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbCalismaDurum = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbOgrenimDurum = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAdiSoyadi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtYas2 = new System.Windows.Forms.TextBox();
            this.txtYas1 = new System.Windows.Forms.TextBox();
            this.cbEtnikKoken = new System.Windows.Forms.ComboBox();
            this.cbMedeniHali = new System.Windows.Forms.ComboBox();
            this.cbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dgAnketKatilimciListesi = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKatilimciNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColYer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCinsText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColYas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOgrenimDurumText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCalismaDurumText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAskerlikDurumText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMedeniHalText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColYasadigiYer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAylikNetGelir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEtnikKokenText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiniInancText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMezhepText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSorgu = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbAnketBilgileri.SuspendLayout();
            this.gbSorguKriter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnketKatilimciListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAnketBilgileri
            // 
            this.gbAnketBilgileri.Controls.Add(this.dtBitis);
            this.gbAnketBilgileri.Controls.Add(this.dtBaslama);
            this.gbAnketBilgileri.Controls.Add(this.label4);
            this.gbAnketBilgileri.Controls.Add(this.label3);
            this.gbAnketBilgileri.Controls.Add(this.txtDuzenleyen);
            this.gbAnketBilgileri.Controls.Add(this.txtAnketAdi);
            this.gbAnketBilgileri.Controls.Add(this.label2);
            this.gbAnketBilgileri.Controls.Add(this.label1);
            this.gbAnketBilgileri.Enabled = false;
            this.gbAnketBilgileri.Location = new System.Drawing.Point(35, 22);
            this.gbAnketBilgileri.Name = "gbAnketBilgileri";
            this.gbAnketBilgileri.Size = new System.Drawing.Size(1108, 118);
            this.gbAnketBilgileri.TabIndex = 0;
            this.gbAnketBilgileri.TabStop = false;
            this.gbAnketBilgileri.Text = "Anket Bilgileri";
            // 
            // dtBitis
            // 
            this.dtBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBitis.Location = new System.Drawing.Point(883, 69);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(95, 25);
            this.dtBitis.TabIndex = 7;
            // 
            // dtBaslama
            // 
            this.dtBaslama.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBaslama.Location = new System.Drawing.Point(634, 70);
            this.dtBaslama.Name = "dtBaslama";
            this.dtBaslama.Size = new System.Drawing.Size(101, 25);
            this.dtBaslama.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(826, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bitiş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Başlama";
            // 
            // txtDuzenleyen
            // 
            this.txtDuzenleyen.Location = new System.Drawing.Point(105, 72);
            this.txtDuzenleyen.Name = "txtDuzenleyen";
            this.txtDuzenleyen.Size = new System.Drawing.Size(405, 25);
            this.txtDuzenleyen.TabIndex = 3;
            // 
            // txtAnketAdi
            // 
            this.txtAnketAdi.Location = new System.Drawing.Point(105, 22);
            this.txtAnketAdi.Name = "txtAnketAdi";
            this.txtAnketAdi.Size = new System.Drawing.Size(980, 25);
            this.txtAnketAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Düzenleyen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anket Adı";
            // 
            // gbSorguKriter
            // 
            this.gbSorguKriter.Controls.Add(this.label19);
            this.gbSorguKriter.Controls.Add(this.txtYer);
            this.gbSorguKriter.Controls.Add(this.label5);
            this.gbSorguKriter.Controls.Add(this.txtTarih2);
            this.gbSorguKriter.Controls.Add(this.txtTarih1);
            this.gbSorguKriter.Controls.Add(this.txtNetGelir2);
            this.gbSorguKriter.Controls.Add(this.cbMezhebi);
            this.gbSorguKriter.Controls.Add(this.label18);
            this.gbSorguKriter.Controls.Add(this.cbDiniInanci);
            this.gbSorguKriter.Controls.Add(this.label17);
            this.gbSorguKriter.Controls.Add(this.txtNetGelir1);
            this.gbSorguKriter.Controls.Add(this.label16);
            this.gbSorguKriter.Controls.Add(this.txtYasadigiYer);
            this.gbSorguKriter.Controls.Add(this.label15);
            this.gbSorguKriter.Controls.Add(this.cbAskerlikDurumu);
            this.gbSorguKriter.Controls.Add(this.label14);
            this.gbSorguKriter.Controls.Add(this.cbCalismaDurum);
            this.gbSorguKriter.Controls.Add(this.label10);
            this.gbSorguKriter.Controls.Add(this.cbOgrenimDurum);
            this.gbSorguKriter.Controls.Add(this.label13);
            this.gbSorguKriter.Controls.Add(this.txtAdiSoyadi);
            this.gbSorguKriter.Controls.Add(this.label12);
            this.gbSorguKriter.Controls.Add(this.txtYas2);
            this.gbSorguKriter.Controls.Add(this.txtYas1);
            this.gbSorguKriter.Controls.Add(this.cbEtnikKoken);
            this.gbSorguKriter.Controls.Add(this.cbMedeniHali);
            this.gbSorguKriter.Controls.Add(this.cbCinsiyet);
            this.gbSorguKriter.Controls.Add(this.label9);
            this.gbSorguKriter.Controls.Add(this.label8);
            this.gbSorguKriter.Controls.Add(this.label7);
            this.gbSorguKriter.Controls.Add(this.label6);
            this.gbSorguKriter.Location = new System.Drawing.Point(35, 161);
            this.gbSorguKriter.Name = "gbSorguKriter";
            this.gbSorguKriter.Size = new System.Drawing.Size(1112, 162);
            this.gbSorguKriter.TabIndex = 1;
            this.gbSorguKriter.TabStop = false;
            this.gbSorguKriter.Text = "Sorgulama Kriterleri";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(666, 33);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 17);
            this.label19.TabIndex = 36;
            this.label19.Tag = "14";
            this.label19.Text = "Yer";
            // 
            // txtYer
            // 
            this.txtYer.Location = new System.Drawing.Point(698, 30);
            this.txtYer.Name = "txtYer";
            this.txtYer.Size = new System.Drawing.Size(98, 25);
            this.txtYer.TabIndex = 35;
            this.txtYer.Tag = "14";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 34;
            this.label5.Tag = "13";
            this.label5.Text = "Tarih";
            // 
            // txtTarih2
            // 
            this.txtTarih2.Location = new System.Drawing.Point(563, 30);
            this.txtTarih2.Name = "txtTarih2";
            this.txtTarih2.Size = new System.Drawing.Size(72, 25);
            this.txtTarih2.TabIndex = 33;
            this.txtTarih2.Tag = "13";
            // 
            // txtTarih1
            // 
            this.txtTarih1.Location = new System.Drawing.Point(485, 30);
            this.txtTarih1.Name = "txtTarih1";
            this.txtTarih1.Size = new System.Drawing.Size(72, 25);
            this.txtTarih1.TabIndex = 32;
            this.txtTarih1.Tag = "13";
            // 
            // txtNetGelir2
            // 
            this.txtNetGelir2.Location = new System.Drawing.Point(786, 29);
            this.txtNetGelir2.Name = "txtNetGelir2";
            this.txtNetGelir2.Size = new System.Drawing.Size(58, 25);
            this.txtNetGelir2.TabIndex = 31;
            this.txtNetGelir2.Tag = "9";
            // 
            // cbMezhebi
            // 
            this.cbMezhebi.DisplayMember = "Secenek";
            this.cbMezhebi.FormattingEnabled = true;
            this.cbMezhebi.Location = new System.Drawing.Point(288, 29);
            this.cbMezhebi.Name = "cbMezhebi";
            this.cbMezhebi.Size = new System.Drawing.Size(85, 25);
            this.cbMezhebi.TabIndex = 30;
            this.cbMezhebi.Tag = "12";
            this.cbMezhebi.ValueMember = "SecenekNo";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(217, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 17);
            this.label18.TabIndex = 29;
            this.label18.Tag = "12";
            this.label18.Text = "Mezhebi";
            // 
            // cbDiniInanci
            // 
            this.cbDiniInanci.DisplayMember = "Secenek";
            this.cbDiniInanci.FormattingEnabled = true;
            this.cbDiniInanci.Location = new System.Drawing.Point(85, 29);
            this.cbDiniInanci.Name = "cbDiniInanci";
            this.cbDiniInanci.Size = new System.Drawing.Size(77, 25);
            this.cbDiniInanci.TabIndex = 28;
            this.cbDiniInanci.Tag = "11";
            this.cbDiniInanci.ValueMember = "SecenekNo";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 17);
            this.label17.TabIndex = 27;
            this.label17.Tag = "11";
            this.label17.Text = "Dini İnancı";
            // 
            // txtNetGelir1
            // 
            this.txtNetGelir1.Location = new System.Drawing.Point(722, 29);
            this.txtNetGelir1.Name = "txtNetGelir1";
            this.txtNetGelir1.Size = new System.Drawing.Size(58, 25);
            this.txtNetGelir1.TabIndex = 26;
            this.txtNetGelir1.Tag = "9";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(623, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 17);
            this.label16.TabIndex = 25;
            this.label16.Tag = "9";
            this.label16.Text = "Aylık Net Geliri";
            // 
            // txtYasadigiYer
            // 
            this.txtYasadigiYer.Location = new System.Drawing.Point(505, 29);
            this.txtYasadigiYer.Name = "txtYasadigiYer";
            this.txtYasadigiYer.Size = new System.Drawing.Size(98, 25);
            this.txtYasadigiYer.TabIndex = 24;
            this.txtYasadigiYer.Tag = "8";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(421, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 17);
            this.label15.TabIndex = 23;
            this.label15.Tag = "8";
            this.label15.Text = "Yaşadığı Yer";
            // 
            // cbAskerlikDurumu
            // 
            this.cbAskerlikDurumu.DisplayMember = "Secenek";
            this.cbAskerlikDurumu.FormattingEnabled = true;
            this.cbAskerlikDurumu.Location = new System.Drawing.Point(124, 29);
            this.cbAskerlikDurumu.Name = "cbAskerlikDurumu";
            this.cbAskerlikDurumu.Size = new System.Drawing.Size(104, 25);
            this.cbAskerlikDurumu.TabIndex = 22;
            this.cbAskerlikDurumu.Tag = "6";
            this.cbAskerlikDurumu.ValueMember = "SecenekNo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 17);
            this.label14.TabIndex = 21;
            this.label14.Tag = "6";
            this.label14.Text = "Askerlik Durumu";
            // 
            // cbCalismaDurum
            // 
            this.cbCalismaDurum.DisplayMember = "Secenek";
            this.cbCalismaDurum.FormattingEnabled = true;
            this.cbCalismaDurum.Location = new System.Drawing.Point(935, 29);
            this.cbCalismaDurum.Name = "cbCalismaDurum";
            this.cbCalismaDurum.Size = new System.Drawing.Size(90, 25);
            this.cbCalismaDurum.TabIndex = 20;
            this.cbCalismaDurum.Tag = "5";
            this.cbCalismaDurum.ValueMember = "SecenekNo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(826, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 17);
            this.label10.TabIndex = 19;
            this.label10.Tag = "5";
            this.label10.Text = "Çalışma Durumu";
            // 
            // cbOgrenimDurum
            // 
            this.cbOgrenimDurum.DisplayMember = "Secenek";
            this.cbOgrenimDurum.FormattingEnabled = true;
            this.cbOgrenimDurum.Location = new System.Drawing.Point(698, 29);
            this.cbOgrenimDurum.Name = "cbOgrenimDurum";
            this.cbOgrenimDurum.Size = new System.Drawing.Size(104, 25);
            this.cbOgrenimDurum.TabIndex = 18;
            this.cbOgrenimDurum.Tag = "4";
            this.cbOgrenimDurum.ValueMember = "SecenekNo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(583, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 17);
            this.label13.TabIndex = 17;
            this.label13.Tag = "4";
            this.label13.Text = "Öğrenim Durumu";
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.Location = new System.Drawing.Point(87, 29);
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(171, 25);
            this.txtAdiSoyadi.TabIndex = 16;
            this.txtAdiSoyadi.Tag = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 17);
            this.label12.TabIndex = 15;
            this.label12.Tag = "1";
            this.label12.Text = "Adı Soyadı";
            // 
            // txtYas2
            // 
            this.txtYas2.Location = new System.Drawing.Point(512, 29);
            this.txtYas2.Name = "txtYas2";
            this.txtYas2.Size = new System.Drawing.Size(29, 25);
            this.txtYas2.TabIndex = 14;
            this.txtYas2.Tag = "3";
            // 
            // txtYas1
            // 
            this.txtYas1.Location = new System.Drawing.Point(477, 29);
            this.txtYas1.Name = "txtYas1";
            this.txtYas1.Size = new System.Drawing.Size(29, 25);
            this.txtYas1.TabIndex = 13;
            this.txtYas1.Tag = "3";
            // 
            // cbEtnikKoken
            // 
            this.cbEtnikKoken.DisplayMember = "Secenek";
            this.cbEtnikKoken.FormattingEnabled = true;
            this.cbEtnikKoken.Location = new System.Drawing.Point(894, 29);
            this.cbEtnikKoken.Name = "cbEtnikKoken";
            this.cbEtnikKoken.Size = new System.Drawing.Size(77, 25);
            this.cbEtnikKoken.TabIndex = 12;
            this.cbEtnikKoken.Tag = "10";
            this.cbEtnikKoken.ValueMember = "SecenekNo";
            // 
            // cbMedeniHali
            // 
            this.cbMedeniHali.DisplayMember = "Secenek";
            this.cbMedeniHali.FormattingEnabled = true;
            this.cbMedeniHali.Location = new System.Drawing.Point(334, 29);
            this.cbMedeniHali.Name = "cbMedeniHali";
            this.cbMedeniHali.Size = new System.Drawing.Size(61, 25);
            this.cbMedeniHali.TabIndex = 11;
            this.cbMedeniHali.Tag = "7";
            this.cbMedeniHali.ValueMember = "SecenekNo";
            // 
            // cbCinsiyet
            // 
            this.cbCinsiyet.DisplayMember = "Secenek";
            this.cbCinsiyet.FormattingEnabled = true;
            this.cbCinsiyet.Location = new System.Drawing.Point(366, 29);
            this.cbCinsiyet.Name = "cbCinsiyet";
            this.cbCinsiyet.Size = new System.Drawing.Size(60, 25);
            this.cbCinsiyet.TabIndex = 9;
            this.cbCinsiyet.Tag = "2";
            this.cbCinsiyet.ValueMember = "SecenekNo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(444, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 17);
            this.label9.TabIndex = 5;
            this.label9.Tag = "3";
            this.label9.Text = "Yaş";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(813, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 4;
            this.label8.Tag = "10";
            this.label8.Text = "Etnik Köken";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 3;
            this.label7.Tag = "2";
            this.label7.Text = "Cinsiyet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 2;
            this.label6.Tag = "7";
            this.label6.Text = "Medeni Hali";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(506, 339);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(35, 35);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDel.Location = new System.Drawing.Point(456, 339);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(35, 35);
            this.btnDel.TabIndex = 23;
            this.btnDel.Text = "-";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUp.Location = new System.Drawing.Point(406, 339);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(35, 35);
            this.btnUp.TabIndex = 22;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDown.Location = new System.Drawing.Point(356, 339);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(35, 35);
            this.btnDown.TabIndex = 21;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(39, 339);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(271, 30);
            this.label11.TabIndex = 20;
            this.label11.Text = "ANKET KATILIMCI LİSTESİ";
            // 
            // dgAnketKatilimciListesi
            // 
            this.dgAnketKatilimciListesi.AllowUserToAddRows = false;
            this.dgAnketKatilimciListesi.AllowUserToDeleteRows = false;
            this.dgAnketKatilimciListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAnketKatilimciListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColKatilimciNo,
            this.ColTarih,
            this.ColYer,
            this.ColAdSoyad,
            this.ColCinsText,
            this.ColYas,
            this.ColOgrenimDurumText,
            this.ColCalismaDurumText,
            this.ColAskerlikDurumText,
            this.ColMedeniHalText,
            this.ColYasadigiYer,
            this.ColAylikNetGelir,
            this.ColEtnikKokenText,
            this.ColDiniInancText,
            this.ColMezhepText});
            this.dgAnketKatilimciListesi.Location = new System.Drawing.Point(39, 396);
            this.dgAnketKatilimciListesi.MultiSelect = false;
            this.dgAnketKatilimciListesi.Name = "dgAnketKatilimciListesi";
            this.dgAnketKatilimciListesi.ReadOnly = true;
            this.dgAnketKatilimciListesi.RowHeadersVisible = false;
            this.dgAnketKatilimciListesi.RowTemplate.Height = 25;
            this.dgAnketKatilimciListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAnketKatilimciListesi.Size = new System.Drawing.Size(1102, 196);
            this.dgAnketKatilimciListesi.TabIndex = 25;
            this.dgAnketKatilimciListesi.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgAnketKatilimciListesi_CellMouseDoubleClick);
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "Id";
            this.ColId.HeaderText = "Kayıt";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
            this.ColId.Width = 60;
            // 
            // ColKatilimciNo
            // 
            this.ColKatilimciNo.DataPropertyName = "KatilimciNo";
            this.ColKatilimciNo.HeaderText = "Katılımcı No";
            this.ColKatilimciNo.Name = "ColKatilimciNo";
            this.ColKatilimciNo.ReadOnly = true;
            this.ColKatilimciNo.Width = 60;
            // 
            // ColTarih
            // 
            this.ColTarih.DataPropertyName = "Tarih";
            this.ColTarih.HeaderText = "Tarih";
            this.ColTarih.Name = "ColTarih";
            this.ColTarih.ReadOnly = true;
            this.ColTarih.Width = 90;
            // 
            // ColYer
            // 
            this.ColYer.DataPropertyName = "Yer";
            this.ColYer.HeaderText = "Yer";
            this.ColYer.Name = "ColYer";
            this.ColYer.ReadOnly = true;
            this.ColYer.Width = 160;
            // 
            // ColAdSoyad
            // 
            this.ColAdSoyad.DataPropertyName = "AdSoyad";
            this.ColAdSoyad.HeaderText = "Adı-Soyadı";
            this.ColAdSoyad.Name = "ColAdSoyad";
            this.ColAdSoyad.ReadOnly = true;
            this.ColAdSoyad.Width = 240;
            // 
            // ColCinsText
            // 
            this.ColCinsText.DataPropertyName = "CinsText";
            this.ColCinsText.HeaderText = "Cinsiyet";
            this.ColCinsText.Name = "ColCinsText";
            this.ColCinsText.ReadOnly = true;
            this.ColCinsText.Width = 80;
            // 
            // ColYas
            // 
            this.ColYas.DataPropertyName = "Yas";
            this.ColYas.HeaderText = "Yaş";
            this.ColYas.Name = "ColYas";
            this.ColYas.ReadOnly = true;
            this.ColYas.Width = 60;
            // 
            // ColOgrenimDurumText
            // 
            this.ColOgrenimDurumText.DataPropertyName = "OgrenimDurumText";
            this.ColOgrenimDurumText.HeaderText = "Öğrenim Durumu";
            this.ColOgrenimDurumText.Name = "ColOgrenimDurumText";
            this.ColOgrenimDurumText.ReadOnly = true;
            this.ColOgrenimDurumText.Width = 120;
            // 
            // ColCalismaDurumText
            // 
            this.ColCalismaDurumText.DataPropertyName = "CalismaDurumText";
            this.ColCalismaDurumText.HeaderText = "Çalışma Durumu";
            this.ColCalismaDurumText.Name = "ColCalismaDurumText";
            this.ColCalismaDurumText.ReadOnly = true;
            this.ColCalismaDurumText.Width = 120;
            // 
            // ColAskerlikDurumText
            // 
            this.ColAskerlikDurumText.DataPropertyName = "AskerlikDurumText";
            this.ColAskerlikDurumText.HeaderText = "Askerlik Durumu";
            this.ColAskerlikDurumText.Name = "ColAskerlikDurumText";
            this.ColAskerlikDurumText.ReadOnly = true;
            this.ColAskerlikDurumText.Width = 120;
            // 
            // ColMedeniHalText
            // 
            this.ColMedeniHalText.DataPropertyName = "MedeniHalText";
            this.ColMedeniHalText.HeaderText = "Medeni Hali";
            this.ColMedeniHalText.Name = "ColMedeniHalText";
            this.ColMedeniHalText.ReadOnly = true;
            this.ColMedeniHalText.Width = 80;
            // 
            // ColYasadigiYer
            // 
            this.ColYasadigiYer.DataPropertyName = "YasadigiYer";
            this.ColYasadigiYer.HeaderText = "Yaşadığı Yer";
            this.ColYasadigiYer.Name = "ColYasadigiYer";
            this.ColYasadigiYer.ReadOnly = true;
            this.ColYasadigiYer.Width = 120;
            // 
            // ColAylikNetGelir
            // 
            this.ColAylikNetGelir.DataPropertyName = "AylikNetGelir";
            this.ColAylikNetGelir.HeaderText = "Aylık Net Gelir";
            this.ColAylikNetGelir.Name = "ColAylikNetGelir";
            this.ColAylikNetGelir.ReadOnly = true;
            // 
            // ColEtnikKokenText
            // 
            this.ColEtnikKokenText.DataPropertyName = "EtnikKokenText";
            this.ColEtnikKokenText.HeaderText = "Etnik Köken";
            this.ColEtnikKokenText.Name = "ColEtnikKokenText";
            this.ColEtnikKokenText.ReadOnly = true;
            this.ColEtnikKokenText.Width = 110;
            // 
            // ColDiniInancText
            // 
            this.ColDiniInancText.DataPropertyName = "DiniInancText";
            this.ColDiniInancText.HeaderText = "Dini İnanç";
            this.ColDiniInancText.Name = "ColDiniInancText";
            this.ColDiniInancText.ReadOnly = true;
            this.ColDiniInancText.Width = 120;
            // 
            // ColMezhepText
            // 
            this.ColMezhepText.DataPropertyName = "MezhepText";
            this.ColMezhepText.HeaderText = "Mezhep";
            this.ColMezhepText.Name = "ColMezhepText";
            this.ColMezhepText.ReadOnly = true;
            this.ColMezhepText.Width = 120;
            // 
            // btnSorgu
            // 
            this.btnSorgu.Location = new System.Drawing.Point(1021, 339);
            this.btnSorgu.Name = "btnSorgu";
            this.btnSorgu.Size = new System.Drawing.Size(80, 38);
            this.btnSorgu.TabIndex = 27;
            this.btnSorgu.Text = "Sorgula";
            this.btnSorgu.UseVisualStyleBackColor = true;
            this.btnSorgu.Click += new System.EventHandler(this.btnSorgu_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(908, 339);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 38);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // AnketCevapSorgulama
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1181, 643);
            this.Controls.Add(this.btnSorgu);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgAnketKatilimciListesi);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gbSorguKriter);
            this.Controls.Add(this.gbAnketBilgileri);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "AnketCevapSorgulama";
            this.Text = "Anket Cevap Sorgulama";
            this.Load += new System.EventHandler(this.AnketCevapSorgulama_Load);
            this.gbAnketBilgileri.ResumeLayout(false);
            this.gbAnketBilgileri.PerformLayout();
            this.gbSorguKriter.ResumeLayout(false);
            this.gbSorguKriter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnketKatilimciListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbAnketBilgileri;
        private DateTimePicker dtBitis;
        private DateTimePicker dtBaslama;
        private Label label4;
        private Label label3;
        private TextBox txtDuzenleyen;
        private TextBox txtAnketAdi;
        private Label label2;
        private Label label1;
        private GroupBox gbSorguKriter;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtYas2;
        private TextBox txtYas1;
        private ComboBox cbEtnikKoken;
        private ComboBox cbMedeniHali;
        private ComboBox cbCinsiyet;
        private Button btnAdd;
        private Button btnDel;
        private Button btnUp;
        private Button btnDown;
        private Label label11;
        private DataGridView dgAnketKatilimciListesi;
        private Button btnSorgu;
        private Button btnClear;
        private TextBox txtAdiSoyadi;
        private Label label12;
        private ComboBox cbOgrenimDurum;
        private Label label13;
        private ComboBox cbCalismaDurum;
        private Label label10;
        private ComboBox cbAskerlikDurumu;
        private Label label14;
        private ComboBox cbMezhebi;
        private Label label18;
        private ComboBox cbDiniInanci;
        private Label label17;
        private TextBox txtNetGelir1;
        private Label label16;
        private TextBox txtYasadigiYer;
        private Label label15;
        private TextBox txtNetGelir2;
        private Label label19;
        private TextBox txtYer;
        private Label label5;
        private TextBox txtTarih2;
        private TextBox txtTarih1;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColKatilimciNo;
        private DataGridViewTextBoxColumn ColTarih;
        private DataGridViewTextBoxColumn ColYer;
        private DataGridViewTextBoxColumn ColAdSoyad;
        private DataGridViewTextBoxColumn ColCinsText;
        private DataGridViewTextBoxColumn ColYas;
        private DataGridViewTextBoxColumn ColOgrenimDurumText;
        private DataGridViewTextBoxColumn ColCalismaDurumText;
        private DataGridViewTextBoxColumn ColAskerlikDurumText;
        private DataGridViewTextBoxColumn ColMedeniHalText;
        private DataGridViewTextBoxColumn ColYasadigiYer;
        private DataGridViewTextBoxColumn ColAylikNetGelir;
        private DataGridViewTextBoxColumn ColEtnikKokenText;
        private DataGridViewTextBoxColumn ColDiniInancText;
        private DataGridViewTextBoxColumn ColMezhepText;
    }
}