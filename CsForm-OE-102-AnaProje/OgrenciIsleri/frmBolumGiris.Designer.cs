
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
            this.Liste = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BolumAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
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
            this.ScBolumler.Panel1.Controls.Add(this.btnKaydet);
            this.ScBolumler.Panel1.Controls.Add(this.textBox1);
            this.ScBolumler.Panel1.Controls.Add(this.label1);
            // 
            // ScBolumler.Panel2
            // 
            this.ScBolumler.Panel2.Controls.Add(this.Liste);
            this.ScBolumler.Size = new System.Drawing.Size(427, 358);
            this.ScBolumler.SplitterDistance = 138;
            this.ScBolumler.TabIndex = 0;
            // 
            // Liste
            // 
            this.Liste.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.BolumAdi});
            this.Liste.Location = new System.Drawing.Point(3, 3);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(418, 206);
            this.Liste.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id.HeaderText = "SiraNo";
            this.id.Name = "id";
            this.id.Width = 64;
            // 
            // BolumAdi
            // 
            this.BolumAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BolumAdi.HeaderText = "Bolum";
            this.BolumAdi.Name = "BolumAdi";
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
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(423, 20);
            this.textBox1.TabIndex = 1;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BolumAdi;
    }
}