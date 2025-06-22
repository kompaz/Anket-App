namespace AnketApp
{
    partial class AnketSoruKayit
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoruMetni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSoruTipi = new System.Windows.Forms.ComboBox();
            this.txtSoruNo = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panSecenek = new System.Windows.Forms.Panel();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lbSecenek = new System.Windows.Forms.ListBox();
            this.txtSecenek = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panSecenek.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soru Metni";
            // 
            // txtSoruMetni
            // 
            this.txtSoruMetni.Location = new System.Drawing.Point(141, 90);
            this.txtSoruMetni.Multiline = true;
            this.txtSoruMetni.Name = "txtSoruMetni";
            this.txtSoruMetni.Size = new System.Drawing.Size(960, 55);
            this.txtSoruMetni.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soru Tipi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(332, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Soru No";
            // 
            // cbSoruTipi
            // 
            this.cbSoruTipi.FormattingEnabled = true;
            this.cbSoruTipi.Location = new System.Drawing.Point(141, 22);
            this.cbSoruTipi.Name = "cbSoruTipi";
            this.cbSoruTipi.Size = new System.Drawing.Size(150, 25);
            this.cbSoruTipi.TabIndex = 7;
            this.cbSoruTipi.SelectedIndexChanged += new System.EventHandler(this.cbSoruTipi_SelectedIndexChanged);
            // 
            // txtSoruNo
            // 
            this.txtSoruNo.Location = new System.Drawing.Point(406, 22);
            this.txtSoruNo.Name = "txtSoruNo";
            this.txtSoruNo.ReadOnly = true;
            this.txtSoruNo.Size = new System.Drawing.Size(52, 25);
            this.txtSoruNo.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(976, 588);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 36);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panSecenek
            // 
            this.panSecenek.Controls.Add(this.btnGuncelle);
            this.panSecenek.Controls.Add(this.lbSecenek);
            this.panSecenek.Controls.Add(this.txtSecenek);
            this.panSecenek.Controls.Add(this.btnAdd);
            this.panSecenek.Controls.Add(this.btnDel);
            this.panSecenek.Controls.Add(this.btnUp);
            this.panSecenek.Controls.Add(this.btnDown);
            this.panSecenek.Controls.Add(this.label7);
            this.panSecenek.Location = new System.Drawing.Point(27, 169);
            this.panSecenek.Name = "panSecenek";
            this.panSecenek.Size = new System.Drawing.Size(1074, 402);
            this.panSecenek.TabIndex = 30;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuncelle.Location = new System.Drawing.Point(840, 9);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(35, 35);
            this.btnGuncelle.TabIndex = 36;
            this.btnGuncelle.Text = "G";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // lbSecenek
            // 
            this.lbSecenek.DisplayMember = "Secenek";
            this.lbSecenek.FormattingEnabled = true;
            this.lbSecenek.ItemHeight = 17;
            this.lbSecenek.Location = new System.Drawing.Point(14, 54);
            this.lbSecenek.Name = "lbSecenek";
            this.lbSecenek.Size = new System.Drawing.Size(1043, 327);
            this.lbSecenek.TabIndex = 35;
            this.lbSecenek.ValueMember = "Id";
            this.lbSecenek.SelectedIndexChanged += new System.EventHandler(this.lbSecenek_SelectedIndexChanged);
            // 
            // txtSecenek
            // 
            this.txtSecenek.Location = new System.Drawing.Point(238, 14);
            this.txtSecenek.Name = "txtSecenek";
            this.txtSecenek.Size = new System.Drawing.Size(583, 25);
            this.txtSecenek.TabIndex = 34;
            this.txtSecenek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecenek_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(886, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(35, 35);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDel.Location = new System.Drawing.Point(931, 7);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(35, 35);
            this.btnDel.TabIndex = 32;
            this.btnDel.Text = "-";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUp.Location = new System.Drawing.Point(1021, 7);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(35, 35);
            this.btnUp.TabIndex = 31;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDown.Location = new System.Drawing.Point(976, 7);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(35, 35);
            this.btnDown.TabIndex = 30;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(9, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 30);
            this.label7.TabIndex = 29;
            this.label7.Text = "SORU SEÇENEKLERİ";
            // 
            // AnketSoruKayit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1117, 646);
            this.Controls.Add(this.panSecenek);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSoruNo);
            this.Controls.Add(this.cbSoruTipi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoruMetni);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "AnketSoruKayit";
            this.Text = "Anket Soru Kayıt";
            this.Load += new System.EventHandler(this.AnketSoruKayit_Load);
            this.panSecenek.ResumeLayout(false);
            this.panSecenek.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private TextBox txtSoruMetni;
        private Label label3;
        private Label label4;
        private ComboBox cbSoruTipi;
        private TextBox txtSoruNo;
        private Button btnSave;
        private Panel panSecenek;
        private TextBox txtSecenek;
        private Button btnAdd;
        private Button btnDel;
        private Button btnUp;
        private Button btnDown;
        private Label label7;
        private ListBox lbSecenek;
        private Button btnGuncelle;
    }
}