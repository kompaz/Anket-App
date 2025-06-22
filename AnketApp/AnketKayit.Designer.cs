namespace AnketApp
{
    partial class AnketKayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnketAdi = new System.Windows.Forms.TextBox();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.txtDuzenleyen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtKayit = new System.Windows.Forms.DateTimePicker();
            this.dtBaslama = new System.Windows.Forms.DateTimePicker();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.clbKatilimciProfil = new System.Windows.Forms.CheckedListBox();
            this.dgAnketSorulari = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collSoru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collSoruTipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collSoruMetni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collSecenekler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.pbGorsel = new System.Windows.Forms.PictureBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCevapSorgu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnketSorulari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGorsel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anket Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Konu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Düzenleyen";
            // 
            // txtAnketAdi
            // 
            this.txtAnketAdi.Location = new System.Drawing.Point(125, 30);
            this.txtAnketAdi.Name = "txtAnketAdi";
            this.txtAnketAdi.Size = new System.Drawing.Size(681, 23);
            this.txtAnketAdi.TabIndex = 3;
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(125, 70);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(348, 23);
            this.txtKonu.TabIndex = 4;
            // 
            // txtDuzenleyen
            // 
            this.txtDuzenleyen.Location = new System.Drawing.Point(125, 110);
            this.txtDuzenleyen.Name = "txtDuzenleyen";
            this.txtDuzenleyen.Size = new System.Drawing.Size(348, 23);
            this.txtDuzenleyen.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(530, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kayıt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(530, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Başlama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(530, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Bitiş";
            // 
            // dtKayit
            // 
            this.dtKayit.CustomFormat = " ";
            this.dtKayit.Enabled = false;
            this.dtKayit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtKayit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtKayit.Location = new System.Drawing.Point(640, 70);
            this.dtKayit.Name = "dtKayit";
            this.dtKayit.Size = new System.Drawing.Size(166, 27);
            this.dtKayit.TabIndex = 9;
            // 
            // dtBaslama
            // 
            this.dtBaslama.CustomFormat = " ";
            this.dtBaslama.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtBaslama.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBaslama.Location = new System.Drawing.Point(640, 120);
            this.dtBaslama.Name = "dtBaslama";
            this.dtBaslama.Size = new System.Drawing.Size(166, 27);
            this.dtBaslama.TabIndex = 10;
            // 
            // dtBitis
            // 
            this.dtBitis.CustomFormat = " ";
            this.dtBitis.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBitis.Location = new System.Drawing.Point(640, 170);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(166, 27);
            this.dtBitis.TabIndex = 11;
            // 
            // clbKatilimciProfil
            // 
            this.clbKatilimciProfil.CheckOnClick = true;
            this.clbKatilimciProfil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clbKatilimciProfil.FormattingEnabled = true;
            this.clbKatilimciProfil.Location = new System.Drawing.Point(825, 30);
            this.clbKatilimciProfil.Name = "clbKatilimciProfil";
            this.clbKatilimciProfil.Size = new System.Drawing.Size(160, 124);
            this.clbKatilimciProfil.TabIndex = 12;
            // 
            // dgAnketSorulari
            // 
            this.dgAnketSorulari.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.dgAnketSorulari.AllowUserToAddRows = false;
            this.dgAnketSorulari.AllowUserToDeleteRows = false;
            this.dgAnketSorulari.AllowUserToResizeColumns = false;
            this.dgAnketSorulari.AllowUserToResizeRows = false;
            this.dgAnketSorulari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAnketSorulari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.collSoru,
            this.collSoruTipi,
            this.collSoruMetni,
            this.collSecenekler});
            this.dgAnketSorulari.Location = new System.Drawing.Point(24, 245);
            this.dgAnketSorulari.MultiSelect = false;
            this.dgAnketSorulari.Name = "dgAnketSorulari";
            this.dgAnketSorulari.ReadOnly = true;
            this.dgAnketSorulari.RowHeadersVisible = false;
            this.dgAnketSorulari.RowTemplate.Height = 25;
            this.dgAnketSorulari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAnketSorulari.Size = new System.Drawing.Size(1175, 323);
            this.dgAnketSorulari.TabIndex = 13;
            this.dgAnketSorulari.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAnketSorulari_CellDoubleClick);
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "Id";
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
            // 
            // collSoru
            // 
            this.collSoru.DataPropertyName = "SoruNo";
            this.collSoru.FillWeight = 162.4366F;
            this.collSoru.HeaderText = "Soru";
            this.collSoru.Name = "collSoru";
            this.collSoru.ReadOnly = true;
            // 
            // collSoruTipi
            // 
            this.collSoruTipi.DataPropertyName = "SoruTipText";
            this.collSoruTipi.FillWeight = 79.18781F;
            this.collSoruTipi.HeaderText = "Anket Soru Tipi";
            this.collSoruTipi.Name = "collSoruTipi";
            this.collSoruTipi.ReadOnly = true;
            this.collSoruTipi.Width = 160;
            // 
            // collSoruMetni
            // 
            this.collSoruMetni.DataPropertyName = "SoruMetin";
            this.collSoruMetni.FillWeight = 79.18781F;
            this.collSoruMetni.HeaderText = "Anket Soru Metni";
            this.collSoruMetni.Name = "collSoruMetni";
            this.collSoruMetni.ReadOnly = true;
            this.collSoruMetni.Width = 400;
            // 
            // collSecenekler
            // 
            this.collSecenekler.DataPropertyName = "Secenekler";
            this.collSecenekler.FillWeight = 79.18781F;
            this.collSecenekler.HeaderText = "Anket Soru Seçenekleri";
            this.collSecenekler.Name = "collSecenekler";
            this.collSecenekler.ReadOnly = true;
            this.collSecenekler.Width = 360;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(24, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 30);
            this.label7.TabIndex = 14;
            this.label7.Text = "ANKET SORULARI";
            // 
            // pbGorsel
            // 
            this.pbGorsel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbGorsel.Location = new System.Drawing.Point(1005, 30);
            this.pbGorsel.Name = "pbGorsel";
            this.pbGorsel.Size = new System.Drawing.Size(201, 184);
            this.pbGorsel.TabIndex = 15;
            this.pbGorsel.TabStop = false;
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDown.Location = new System.Drawing.Point(234, 174);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(35, 35);
            this.btnDown.TabIndex = 16;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUp.Location = new System.Drawing.Point(284, 174);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(35, 35);
            this.btnUp.TabIndex = 17;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDel.Location = new System.Drawing.Point(334, 174);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(35, 35);
            this.btnDel.TabIndex = 18;
            this.btnDel.Text = "-";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(384, 174);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(35, 35);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(1005, 574);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 40);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCevapSorgu
            // 
            this.btnCevapSorgu.Location = new System.Drawing.Point(825, 169);
            this.btnCevapSorgu.Name = "btnCevapSorgu";
            this.btnCevapSorgu.Size = new System.Drawing.Size(160, 45);
            this.btnCevapSorgu.TabIndex = 21;
            this.btnCevapSorgu.Text = "CEVAP SORGULA";
            this.btnCevapSorgu.UseVisualStyleBackColor = true;
            this.btnCevapSorgu.Click += new System.EventHandler(this.btnCevapSorgu_Click);
            // 
            // AnketKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 626);
            this.Controls.Add(this.btnCevapSorgu);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.pbGorsel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgAnketSorulari);
            this.Controls.Add(this.clbKatilimciProfil);
            this.Controls.Add(this.dtBitis);
            this.Controls.Add(this.dtBaslama);
            this.Controls.Add(this.dtKayit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDuzenleyen);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.txtAnketAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AnketKayit";
            this.Text = "Anket Kayit";
            this.Load += new System.EventHandler(this.AnketKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAnketSorulari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGorsel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAnketAdi;
        private TextBox txtKonu;
        private TextBox txtDuzenleyen;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dtKayit;
        private DateTimePicker dtBaslama;
        private DateTimePicker dtBitis;
        private CheckedListBox clbKatilimciProfil;
        private DataGridView dgAnketSorulari;
        private Label label7;
        private PictureBox pbGorsel;
        private Button btnDown;
        private Button btnUp;
        private Button btnDel;
        private Button btnAdd;
        private Button btnSave;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn collSoru;
        private DataGridViewTextBoxColumn collSoruTipi;
        private DataGridViewTextBoxColumn collSoruMetni;
        private DataGridViewTextBoxColumn collSecenekler;
        private Button btnCevapSorgu;
    }
}