namespace AnketApp
{
    partial class AnketSorgu
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
            this.dgAnket = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKayitTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDuzenleyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAnketAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBaslama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBitis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKonu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSorgu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDuzenleyen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnket = new System.Windows.Forms.TextBox();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grSorgu = new System.Windows.Forms.GroupBox();
            this.txtBitis2 = new System.Windows.Forms.TextBox();
            this.txtBitis1 = new System.Windows.Forms.TextBox();
            this.txtBaslama2 = new System.Windows.Forms.TextBox();
            this.txtBaslama1 = new System.Windows.Forms.TextBox();
            this.txtKayitTarih2 = new System.Windows.Forms.TextBox();
            this.txtKayitTarih1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnket)).BeginInit();
            this.grSorgu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgAnket
            // 
            this.dgAnket.AllowUserToAddRows = false;
            this.dgAnket.AllowUserToDeleteRows = false;
            this.dgAnket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAnket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColKayitTarih,
            this.ColDuzenleyen,
            this.ColAnketAd,
            this.ColBaslama,
            this.ColBitis,
            this.ColKonu});
            this.dgAnket.Location = new System.Drawing.Point(21, 178);
            this.dgAnket.MultiSelect = false;
            this.dgAnket.Name = "dgAnket";
            this.dgAnket.ReadOnly = true;
            this.dgAnket.RowHeadersVisible = false;
            this.dgAnket.RowTemplate.Height = 25;
            this.dgAnket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAnket.Size = new System.Drawing.Size(1240, 403);
            this.dgAnket.TabIndex = 1;
            this.dgAnket.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAnket_CellDoubleClick);
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "Id";
            this.ColId.HeaderText = "Kayıt No";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Width = 70;
            // 
            // ColKayitTarih
            // 
            this.ColKayitTarih.DataPropertyName = "KayitTarih";
            this.ColKayitTarih.HeaderText = "Kayıt Tarihi";
            this.ColKayitTarih.Name = "ColKayitTarih";
            this.ColKayitTarih.ReadOnly = true;
            this.ColKayitTarih.Width = 130;
            // 
            // ColDuzenleyen
            // 
            this.ColDuzenleyen.DataPropertyName = "Duzenleyen";
            this.ColDuzenleyen.HeaderText = "Anketi Düzenleyen";
            this.ColDuzenleyen.Name = "ColDuzenleyen";
            this.ColDuzenleyen.ReadOnly = true;
            this.ColDuzenleyen.Width = 200;
            // 
            // ColAnketAd
            // 
            this.ColAnketAd.DataPropertyName = "AnketAd";
            this.ColAnketAd.HeaderText = "Anketin Adı";
            this.ColAnketAd.Name = "ColAnketAd";
            this.ColAnketAd.ReadOnly = true;
            this.ColAnketAd.Width = 360;
            // 
            // ColBaslama
            // 
            this.ColBaslama.DataPropertyName = "Baslama";
            this.ColBaslama.HeaderText = "Başlama Tarihi";
            this.ColBaslama.Name = "ColBaslama";
            this.ColBaslama.ReadOnly = true;
            this.ColBaslama.Width = 95;
            // 
            // ColBitis
            // 
            this.ColBitis.DataPropertyName = "Bitis";
            this.ColBitis.HeaderText = "Bitiş Tarihi";
            this.ColBitis.Name = "ColBitis";
            this.ColBitis.ReadOnly = true;
            this.ColBitis.Width = 95;
            // 
            // ColKonu
            // 
            this.ColKonu.DataPropertyName = "Konu";
            this.ColKonu.HeaderText = "Anketin Konusu";
            this.ColKonu.Name = "ColKonu";
            this.ColKonu.ReadOnly = true;
            this.ColKonu.Width = 160;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(937, 126);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 38);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSorgu
            // 
            this.btnSorgu.Location = new System.Drawing.Point(1050, 126);
            this.btnSorgu.Name = "btnSorgu";
            this.btnSorgu.Size = new System.Drawing.Size(80, 38);
            this.btnSorgu.TabIndex = 3;
            this.btnSorgu.Text = "Sorgula";
            this.btnSorgu.UseVisualStyleBackColor = true;
            this.btnSorgu.Click += new System.EventHandler(this.btnSorgu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(38, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "ANKET LİSTESİ";
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDel.Location = new System.Drawing.Point(210, 121);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(28, 37);
            this.btnDel.TabIndex = 16;
            this.btnDel.Text = "-";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.Location = new System.Drawing.Point(254, 121);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(28, 37);
            this.btnEkle.TabIndex = 17;
            this.btnEkle.Text = "+";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kayıt Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Düzenleyen";
            // 
            // txtDuzenleyen
            // 
            this.txtDuzenleyen.Location = new System.Drawing.Point(114, 64);
            this.txtDuzenleyen.Name = "txtDuzenleyen";
            this.txtDuzenleyen.Size = new System.Drawing.Size(230, 27);
            this.txtDuzenleyen.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Anket Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Konu";
            // 
            // txtAnket
            // 
            this.txtAnket.Location = new System.Drawing.Point(507, 25);
            this.txtAnket.Name = "txtAnket";
            this.txtAnket.Size = new System.Drawing.Size(230, 27);
            this.txtAnket.TabIndex = 7;
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(507, 65);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(230, 27);
            this.txtKonu.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(777, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Başlama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(777, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bitiş";
            // 
            // grSorgu
            // 
            this.grSorgu.Controls.Add(this.txtBitis2);
            this.grSorgu.Controls.Add(this.txtBitis1);
            this.grSorgu.Controls.Add(this.txtBaslama2);
            this.grSorgu.Controls.Add(this.txtBaslama1);
            this.grSorgu.Controls.Add(this.txtKayitTarih2);
            this.grSorgu.Controls.Add(this.txtKayitTarih1);
            this.grSorgu.Controls.Add(this.label6);
            this.grSorgu.Controls.Add(this.label5);
            this.grSorgu.Controls.Add(this.txtKonu);
            this.grSorgu.Controls.Add(this.txtAnket);
            this.grSorgu.Controls.Add(this.label4);
            this.grSorgu.Controls.Add(this.label3);
            this.grSorgu.Controls.Add(this.txtDuzenleyen);
            this.grSorgu.Controls.Add(this.label2);
            this.grSorgu.Controls.Add(this.label1);
            this.grSorgu.Location = new System.Drawing.Point(11, 8);
            this.grSorgu.Name = "grSorgu";
            this.grSorgu.Size = new System.Drawing.Size(1250, 102);
            this.grSorgu.TabIndex = 0;
            this.grSorgu.TabStop = false;
            this.grSorgu.Text = "Sorgulama Kriterleri";
            // 
            // txtBitis2
            // 
            this.txtBitis2.Location = new System.Drawing.Point(983, 61);
            this.txtBitis2.Name = "txtBitis2";
            this.txtBitis2.Size = new System.Drawing.Size(113, 27);
            this.txtBitis2.TabIndex = 16;
            // 
            // txtBitis1
            // 
            this.txtBitis1.Location = new System.Drawing.Point(864, 61);
            this.txtBitis1.Name = "txtBitis1";
            this.txtBitis1.Size = new System.Drawing.Size(113, 27);
            this.txtBitis1.TabIndex = 15;
            // 
            // txtBaslama2
            // 
            this.txtBaslama2.Location = new System.Drawing.Point(983, 25);
            this.txtBaslama2.Name = "txtBaslama2";
            this.txtBaslama2.Size = new System.Drawing.Size(113, 27);
            this.txtBaslama2.TabIndex = 14;
            // 
            // txtBaslama1
            // 
            this.txtBaslama1.Location = new System.Drawing.Point(864, 25);
            this.txtBaslama1.Name = "txtBaslama1";
            this.txtBaslama1.Size = new System.Drawing.Size(113, 27);
            this.txtBaslama1.TabIndex = 13;
            // 
            // txtKayitTarih2
            // 
            this.txtKayitTarih2.Location = new System.Drawing.Point(233, 25);
            this.txtKayitTarih2.Name = "txtKayitTarih2";
            this.txtKayitTarih2.Size = new System.Drawing.Size(113, 27);
            this.txtKayitTarih2.TabIndex = 12;
            // 
            // txtKayitTarih1
            // 
            this.txtKayitTarih1.Location = new System.Drawing.Point(114, 25);
            this.txtKayitTarih1.Name = "txtKayitTarih1";
            this.txtKayitTarih1.Size = new System.Drawing.Size(113, 27);
            this.txtKayitTarih1.TabIndex = 11;
            // 
            // AnketSorgu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1273, 593);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSorgu);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgAnket);
            this.Controls.Add(this.grSorgu);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "AnketSorgu";
            this.Text = "ANKET SORGULAMA";
            this.Load += new System.EventHandler(this.AnketSorgu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAnket)).EndInit();
            this.grSorgu.ResumeLayout(false);
            this.grSorgu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dgAnket;
        private Button btnClear;
        private Button btnSorgu;
        private Label label7;
        private Button btnDel;
        private Button btnEkle;
        private Label label1;
        private Label label2;
        private TextBox txtDuzenleyen;
        private Label label3;
        private Label label4;
        private TextBox txtAnket;
        private TextBox txtKonu;
        private Label label5;
        private Label label6;
        private GroupBox grSorgu;
        private TextBox txtBitis2;
        private TextBox txtBitis1;
        private TextBox txtBaslama2;
        private TextBox txtBaslama1;
        private TextBox txtKayitTarih2;
        private TextBox txtKayitTarih1;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColKayitTarih;
        private DataGridViewTextBoxColumn ColDuzenleyen;
        private DataGridViewTextBoxColumn ColAnketAd;
        private DataGridViewTextBoxColumn ColBaslama;
        private DataGridViewTextBoxColumn ColBitis;
        private DataGridViewTextBoxColumn ColKonu;
    }
}