
namespace CsForm_OE_102_AnaProje.Formİslemleri
{
    partial class UrunFiyatKDVHesabı
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
            this.txtKDVfiyati = new System.Windows.Forms.TextBox();
            this.txtKDVadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSonFiyat = new System.Windows.Forms.TextBox();
            this.txtSonKDV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKDVfiyati
            // 
            this.txtKDVfiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKDVfiyati.Location = new System.Drawing.Point(121, 48);
            this.txtKDVfiyati.Name = "txtKDVfiyati";
            this.txtKDVfiyati.Size = new System.Drawing.Size(100, 24);
            this.txtKDVfiyati.TabIndex = 5;
            // 
            // txtKDVadi
            // 
            this.txtKDVadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKDVadi.Location = new System.Drawing.Point(121, 8);
            this.txtKDVadi.Name = "txtKDVadi";
            this.txtKDVadi.Size = new System.Drawing.Size(100, 24);
            this.txtKDVadi.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(4, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Urun Fiyat :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Urun Ad :";
            // 
            // txtSonFiyat
            // 
            this.txtSonFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSonFiyat.Location = new System.Drawing.Point(121, 129);
            this.txtSonFiyat.Name = "txtSonFiyat";
            this.txtSonFiyat.Size = new System.Drawing.Size(100, 24);
            this.txtSonFiyat.TabIndex = 9;
            // 
            // txtSonKDV
            // 
            this.txtSonKDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSonKDV.Location = new System.Drawing.Point(121, 87);
            this.txtSonKDV.Name = "txtSonKDV";
            this.txtSonKDV.Size = new System.Drawing.Size(100, 24);
            this.txtSonKDV.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(4, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "KDV\'li Fiyat :";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(4, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "KDV Oranı :";
            // 
            // UrunFiyatKDVHesabı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 180);
            this.Controls.Add(this.txtSonFiyat);
            this.Controls.Add(this.txtSonKDV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKDVfiyati);
            this.Controls.Add(this.txtKDVadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UrunFiyatKDVHesabı";
            this.Text = "UrunFiyatKDVHesabı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtKDVfiyati;
        public System.Windows.Forms.TextBox txtKDVadi;
        public System.Windows.Forms.TextBox txtSonFiyat;
        public System.Windows.Forms.TextBox txtSonKDV;
    }
}