
namespace CsForm_OE_102_AnaProje.OgrenciIsleri
{
    partial class frmOgrenciGiris
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.scOgr = new System.Windows.Forms.SplitContainer();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.mTxtOgrNo = new System.Windows.Forms.MaskedTextBox();
            this.mTxtTcNo = new System.Windows.Forms.MaskedTextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.txtBolumler = new System.Windows.Forms.ComboBox();
            this.txtSehirler = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOgrNo = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TcNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bolum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scOgr)).BeginInit();
            this.scOgr.Panel1.SuspendLayout();
            this.scOgr.Panel2.SuspendLayout();
            this.scOgr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 99);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Bilgi Giriş";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(98, 23);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(146, 20);
            this.txtAd.TabIndex = 1;
            // 
            // scOgr
            // 
            this.scOgr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scOgr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scOgr.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scOgr.Location = new System.Drawing.Point(0, 99);
            this.scOgr.Name = "scOgr";
            this.scOgr.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scOgr.Panel1
            // 
            this.scOgr.Panel1.Controls.Add(this.btnKaydet);
            this.scOgr.Panel1.Controls.Add(this.mTxtOgrNo);
            this.scOgr.Panel1.Controls.Add(this.mTxtTcNo);
            this.scOgr.Panel1.Controls.Add(this.btnTemizle);
            this.scOgr.Panel1.Controls.Add(this.txtBolumler);
            this.scOgr.Panel1.Controls.Add(this.txtSehirler);
            this.scOgr.Panel1.Controls.Add(this.label5);
            this.scOgr.Panel1.Controls.Add(this.label4);
            this.scOgr.Panel1.Controls.Add(this.label3);
            this.scOgr.Panel1.Controls.Add(this.label7);
            this.scOgr.Panel1.Controls.Add(this.label6);
            this.scOgr.Panel1.Controls.Add(this.label2);
            this.scOgr.Panel1.Controls.Add(this.txtOgrNo);
            this.scOgr.Panel1.Controls.Add(this.txtTc);
            this.scOgr.Panel1.Controls.Add(this.txtSoyad);
            this.scOgr.Panel1.Controls.Add(this.txtAd);
            // 
            // scOgr.Panel2
            // 
            this.scOgr.Panel2.Controls.Add(this.Liste);
            this.scOgr.Size = new System.Drawing.Size(800, 351);
            this.scOgr.SplitterDistance = 195;
            this.scOgr.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(681, 95);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(105, 42);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // mTxtOgrNo
            // 
            this.mTxtOgrNo.Location = new System.Drawing.Point(250, 130);
            this.mTxtOgrNo.Mask = "0000999999";
            this.mTxtOgrNo.Name = "mTxtOgrNo";
            this.mTxtOgrNo.Size = new System.Drawing.Size(103, 20);
            this.mTxtOgrNo.TabIndex = 5;
            // 
            // mTxtTcNo
            // 
            this.mTxtTcNo.Location = new System.Drawing.Point(250, 95);
            this.mTxtTcNo.Mask = "00000000000";
            this.mTxtTcNo.Name = "mTxtTcNo";
            this.mTxtTcNo.Size = new System.Drawing.Size(103, 20);
            this.mTxtTcNo.TabIndex = 5;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(681, 143);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(105, 45);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtBolumler
            // 
            this.txtBolumler.FormattingEnabled = true;
            this.txtBolumler.Location = new System.Drawing.Point(372, 57);
            this.txtBolumler.Name = "txtBolumler";
            this.txtBolumler.Size = new System.Drawing.Size(163, 21);
            this.txtBolumler.TabIndex = 3;
            // 
            // txtSehirler
            // 
            this.txtSehirler.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSehirler.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSehirler.FormattingEnabled = true;
            this.txtSehirler.Location = new System.Drawing.Point(372, 20);
            this.txtSehirler.Name = "txtSehirler";
            this.txtSehirler.Size = new System.Drawing.Size(163, 21);
            this.txtSehirler.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ogr No :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(10, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tc No :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(279, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Bölümler : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(279, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Şehirler :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOgrNo
            // 
            this.txtOgrNo.Location = new System.Drawing.Point(98, 130);
            this.txtOgrNo.Name = "txtOgrNo";
            this.txtOgrNo.Size = new System.Drawing.Size(146, 20);
            this.txtOgrNo.TabIndex = 1;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(98, 95);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(146, 20);
            this.txtTc.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(98, 60);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(146, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ad,
            this.Surname,
            this.TcNo,
            this.OgrNo,
            this.Sehir,
            this.Bolum});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(796, 148);
            this.Liste.TabIndex = 0;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 41;
            // 
            // Ad
            // 
            this.Ad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
            // 
            // Surname
            // 
            this.Surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Surname.HeaderText = "Soyad";
            this.Surname.Name = "Surname";
            // 
            // TcNo
            // 
            this.TcNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TcNo.HeaderText = "TcNo";
            this.TcNo.Name = "TcNo";
            this.TcNo.Width = 59;
            // 
            // OgrNo
            // 
            this.OgrNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.OgrNo.HeaderText = "Öğrenci No";
            this.OgrNo.Name = "OgrNo";
            this.OgrNo.Width = 86;
            // 
            // Sehir
            // 
            this.Sehir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sehir.HeaderText = "Sehir";
            this.Sehir.Name = "Sehir";
            // 
            // Bolum
            // 
            this.Bolum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Bolum.HeaderText = "Bolum";
            this.Bolum.Name = "Bolum";
            // 
            // frmOgrenciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scOgr);
            this.Controls.Add(this.label1);
            this.Name = "frmOgrenciGiris";
            this.Text = "frmOgrenciGiris";
            this.Load += new System.EventHandler(this.frmOgrenciGiris_Load);
            this.scOgr.Panel1.ResumeLayout(false);
            this.scOgr.Panel1.PerformLayout();
            this.scOgr.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scOgr)).EndInit();
            this.scOgr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.SplitContainer scOgr;
        private System.Windows.Forms.ComboBox txtBolumler;
        private System.Windows.Forms.ComboBox txtSehirler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOgrNo;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.MaskedTextBox mTxtTcNo;
        private System.Windows.Forms.MaskedTextBox mTxtOgrNo;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn TcNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sehir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bolum;
    }
}