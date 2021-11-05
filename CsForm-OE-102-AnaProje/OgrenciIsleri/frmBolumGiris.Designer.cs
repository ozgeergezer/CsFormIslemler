
namespace CsForm_OE_102_AnaProje.OgrenciIsleri
{
    partial class frmBolumGiris
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
            this.ScBolumler = new System.Windows.Forms.SplitContainer();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtBolumadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTamsil = new System.Windows.Forms.Button();
            this.chkPasif = new System.Windows.Forms.CheckBox();
            this.rbaktif = new System.Windows.Forms.RadioButton();
            this.rbpasif = new System.Windows.Forms.RadioButton();
            this.rbHepsi = new System.Windows.Forms.RadioButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BolumAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ScBolumler)).BeginInit();
            this.ScBolumler.Panel1.SuspendLayout();
            this.ScBolumler.Panel2.SuspendLayout();
            this.ScBolumler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // ScBolumler
            // 
            this.ScBolumler.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ScBolumler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScBolumler.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.ScBolumler.Location = new System.Drawing.Point(0, 0);
            this.ScBolumler.Name = "ScBolumler";
            this.ScBolumler.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ScBolumler.Panel1
            // 
            this.ScBolumler.Panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.ScBolumler.Panel1.Controls.Add(this.rbHepsi);
            this.ScBolumler.Panel1.Controls.Add(this.rbpasif);
            this.ScBolumler.Panel1.Controls.Add(this.rbaktif);
            this.ScBolumler.Panel1.Controls.Add(this.chkPasif);
            this.ScBolumler.Panel1.Controls.Add(this.btnTamsil);
            this.ScBolumler.Panel1.Controls.Add(this.btnSil);
            this.ScBolumler.Panel1.Controls.Add(this.btnTemizle);
            this.ScBolumler.Panel1.Controls.Add(this.btnKaydet);
            this.ScBolumler.Panel1.Controls.Add(this.txtBolumadi);
            this.ScBolumler.Panel1.Controls.Add(this.label1);
            // 
            // ScBolumler.Panel2
            // 
            this.ScBolumler.Panel2.Controls.Add(this.Liste);
            this.ScBolumler.Size = new System.Drawing.Size(427, 358);
            this.ScBolumler.SplitterDistance = 138;
            this.ScBolumler.TabIndex = 0;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(10, 86);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(92, 34);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(328, 48);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(93, 83);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kayıt";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtBolumadi
            // 
            this.txtBolumadi.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBolumadi.Location = new System.Drawing.Point(0, 22);
            this.txtBolumadi.Name = "txtBolumadi";
            this.txtBolumadi.Size = new System.Drawing.Size(423, 20);
            this.txtBolumadi.TabIndex = 1;
            this.txtBolumadi.TextChanged += new System.EventHandler(this.txtBolumadi_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bölüm Adı :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Liste
            // 
            this.Liste.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.BolumAdi,
            this.isActive});
            this.Liste.Location = new System.Drawing.Point(3, 3);
            this.Liste.MultiSelect = false;
            this.Liste.Name = "Liste";
            this.Liste.ReadOnly = true;
            this.Liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Liste.Size = new System.Drawing.Size(418, 206);
            this.Liste.TabIndex = 0;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(10, 48);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(92, 32);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTamsil
            // 
            this.btnTamsil.Location = new System.Drawing.Point(108, 48);
            this.btnTamsil.Name = "btnTamsil";
            this.btnTamsil.Size = new System.Drawing.Size(92, 32);
            this.btnTamsil.TabIndex = 5;
            this.btnTamsil.Text = "Tam Silme";
            this.btnTamsil.UseVisualStyleBackColor = true;
            this.btnTamsil.Click += new System.EventHandler(this.btnTamsil_Click);
            // 
            // chkPasif
            // 
            this.chkPasif.Location = new System.Drawing.Point(3, -1);
            this.chkPasif.Name = "chkPasif";
            this.chkPasif.Size = new System.Drawing.Size(51, 23);
            this.chkPasif.TabIndex = 6;
            this.chkPasif.Text = "Pasif";
            this.chkPasif.UseVisualStyleBackColor = true;
            this.chkPasif.CheckedChanged += new System.EventHandler(this.chkPasif_CheckedChanged);
            // 
            // rbaktif
            // 
            this.rbaktif.Location = new System.Drawing.Point(221, 79);
            this.rbaktif.Name = "rbaktif";
            this.rbaktif.Size = new System.Drawing.Size(74, 24);
            this.rbaktif.TabIndex = 7;
            this.rbaktif.Text = "aktif";
            this.rbaktif.UseVisualStyleBackColor = true;
            this.rbaktif.CheckedChanged += new System.EventHandler(this.rbaktif_CheckedChanged);
            // 
            // rbpasif
            // 
            this.rbpasif.Location = new System.Drawing.Point(221, 109);
            this.rbpasif.Name = "rbpasif";
            this.rbpasif.Size = new System.Drawing.Size(55, 17);
            this.rbpasif.TabIndex = 7;
            this.rbpasif.Text = "pasif";
            this.rbpasif.UseVisualStyleBackColor = true;
            this.rbpasif.CheckedChanged += new System.EventHandler(this.rbpasif_CheckedChanged);
            // 
            // rbHepsi
            // 
            this.rbHepsi.Checked = true;
            this.rbHepsi.Location = new System.Drawing.Point(221, 56);
            this.rbHepsi.Name = "rbHepsi";
            this.rbHepsi.Size = new System.Drawing.Size(55, 17);
            this.rbHepsi.TabIndex = 7;
            this.rbHepsi.TabStop = true;
            this.rbHepsi.Text = "Hepsi";
            this.rbHepsi.UseVisualStyleBackColor = true;
            this.rbHepsi.CheckedChanged += new System.EventHandler(this.rbHepsi_CheckedChanged);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id.HeaderText = "SiraNo";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 64;
            // 
            // BolumAdi
            // 
            this.BolumAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BolumAdi.HeaderText = "Bolum";
            this.BolumAdi.Name = "BolumAdi";
            this.BolumAdi.ReadOnly = true;
            // 
            // isActive
            // 
            this.isActive.HeaderText = "Durum";
            this.isActive.Name = "isActive";
            this.isActive.ReadOnly = true;
            // 
            // frmBolumGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 358);
            this.Controls.Add(this.ScBolumler);
            this.Name = "frmBolumGiris";
            this.Text = "frmBolumGiris";
            this.Load += new System.EventHandler(this.frmBolumGiris_Load);
            this.ScBolumler.Panel1.ResumeLayout(false);
            this.ScBolumler.Panel1.PerformLayout();
            this.ScBolumler.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScBolumler)).EndInit();
            this.ScBolumler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer ScBolumler;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtBolumadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTamsil;
        private System.Windows.Forms.CheckBox chkPasif;
        private System.Windows.Forms.RadioButton rbHepsi;
        private System.Windows.Forms.RadioButton rbpasif;
        private System.Windows.Forms.RadioButton rbaktif;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BolumAdi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActive;
    }
}