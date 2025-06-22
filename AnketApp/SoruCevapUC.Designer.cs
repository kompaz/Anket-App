namespace AnketApp
{
    partial class SoruCevapUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labSoruNo = new System.Windows.Forms.Label();
            this.txtSoruMetin = new System.Windows.Forms.TextBox();
            this.panCevap = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labSoruNo
            // 
            this.labSoruNo.AutoSize = true;
            this.labSoruNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labSoruNo.ForeColor = System.Drawing.Color.Blue;
            this.labSoruNo.Location = new System.Drawing.Point(14, 15);
            this.labSoruNo.Name = "labSoruNo";
            this.labSoruNo.Size = new System.Drawing.Size(28, 21);
            this.labSoruNo.TabIndex = 0;
            this.labSoruNo.Text = "01";
            // 
            // txtSoruMetin
            // 
            this.txtSoruMetin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSoruMetin.Enabled = false;
            this.txtSoruMetin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSoruMetin.ForeColor = System.Drawing.Color.Blue;
            this.txtSoruMetin.Location = new System.Drawing.Point(47, 18);
            this.txtSoruMetin.Multiline = true;
            this.txtSoruMetin.Name = "txtSoruMetin";
            this.txtSoruMetin.Size = new System.Drawing.Size(612, 55);
            this.txtSoruMetin.TabIndex = 1;
            this.txtSoruMetin.Text = "Hangi Cumhurbaşkanı adayına oy verdiğniz?";
            // 
            // panCevap
            // 
            this.panCevap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panCevap.Location = new System.Drawing.Point(45, 83);
            this.panCevap.Name = "panCevap";
            this.panCevap.Size = new System.Drawing.Size(614, 130);
            this.panCevap.TabIndex = 2;
            // 
            // SoruCevapUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.panCevap);
            this.Controls.Add(this.txtSoruMetin);
            this.Controls.Add(this.labSoruNo);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SoruCevapUC";
            this.Size = new System.Drawing.Size(671, 230);
            this.Load += new System.EventHandler(this.SoruCevapUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labSoruNo;
        private TextBox txtSoruMetin;
        private Panel panCevap;
    }
}
