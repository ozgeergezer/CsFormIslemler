using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsForm_OE_102_AnaProje.Fonksiyonlar;
using CsForm_OE_102_AnaProje.OgrenciIsleri.OgrEntity;

namespace CsForm_OE_102_AnaProje.OgrenciIsleri
{
    public partial class frmOgrenciGiris : Form
    {
        readonly StudentsEntities sdb = new StudentsEntities();
        private Mesajlar m = new Mesajlar();
        public int sehirId = -1; 
        public int bolId = -1;
        public int secimID = -1;
        public bool edit = false;

        public frmOgrenciGiris()
        {
            InitializeComponent();
        }

        private void frmOgrenciGiris_Load(object sender, EventArgs e)
        {
            txtSehirler.Text.ToUpper();
            Combolar();
            Temizle();
            Listele();

        }

        private void YeniKayit()
        {
            try
            {
                TblOgrBilgiler ogr = new TblOgrBilgiler();
                ogr.Ad = txtAd.Text;
                ogr.Soyad = txtSoyad.Text;
                ogr.TcNo = mTxtTcNo.Text; // txtTc.Text;
                ogr.OgNo = mTxtOgrNo.Text;
                ogr.SehirId = sdb.TblSehirler.First(x => x.sehir == txtSehirler.Text).id;
                //ogr.SehirId = sehirId; // en başa gidip public sehirid tanımladık.
                //ogr.BolumId = bolId;
                ogr.BolumId = sdb.TblDepartments.First(x => x.BolumAdi == txtBolumler.Text).Id;
                ogr.isActive = true;

                sdb.TblOgrBilgiler.Add(ogr);
                sdb.SaveChanges();
                m.YeniKayit("Öğrenci bilgileri kaydedildi.");
                Listele();
            }
            catch (Exception e)
            {
                m.Hata(e);
            }
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            int sayi = 1;
            var lst = from s in sdb.TblOgrBilgiler
                      where s.isActive==true
                      select new
                      {
                          id = s.Id,
                          ad = s.Ad,
                          soyad = s.Soyad,
                          tc = s.TcNo,
                          ogrno = s.OgNo,
                          sehir = s.TblSehirler.sehir,
                          bolum = s.TblDepartments.BolumAdi,
                          durum = s.isActive
                      };
            foreach (var k in lst)
            {
                //string sayi1 = sayi.ToString().PadLeft(7, '0');
                string sayi1 = DateTime.Now.Year+"_"+sayi.ToString().PadLeft(7,'0');
                Liste.Rows.Add();
                Liste.Rows[i].Cells["id"].Value = k.id;
                Liste.Rows[i].Cells[1].Value = sayi1 ;
                Liste.Rows[i].Cells[2].Value = k.ad;
                Liste.Rows[i].Cells[3].Value = k.soyad;
                Liste.Rows[i].Cells[4].Value = k.tc;
                Liste.Rows[i].Cells[5].Value = k.ogrno;
                Liste.Rows[i].Cells[6].Value = k.sehir;
                Liste.Rows[i].Cells[7].Value = k.bolum;
                Liste.Rows[i].Cells[8].Value = k.durum;
                i++;
                sayi++;
            }
            Liste.AllowUserToAddRows = false;  //readonly true yaparsam kullanıcı listeye müdehale edezmez.
        }

        private void Temizle()
        {
            //txtSehirler.Items.Clear();  bu işlem cb içindeki tüm verileri sıfırlar
            //txtSehirler.Text = "";
            //txtBolumler.Text = "";
            //txtAd.Clear();
            //txtSoyad.Clear();
            //txtOgrNo.Clear();
            //txtTc.Clear();

            foreach (Control ct in scOgr.Panel1.Controls) //panelde bulunan her şeyin içini temizlemek içinn
            {
                if (ct is TextBox || ct is ComboBox|| ct is MaskedTextBox)
                {
                    ct.Text = "";
                }
            }
            bolId = -1;
            secimID = -1;
            edit = false;
            sehirId = -1;

    }

        private void Combolar()
        {
            txtSehirler.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection veri = new AutoCompleteStringCollection();
            var lst = sdb.TblSehirler.Select(x => x.sehir).Distinct();

            foreach (string s in lst)
            {
                veri.Add(s);
                txtSehirler.Items.Add(s);
            }
            txtSehirler.AutoCompleteCustomSource = veri;
            
            txtBolumler.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection veri1 = new AutoCompleteStringCollection();
            var lst1 = sdb.TblDepartments.Where(x=>x.isActive==true).Select(x => x.BolumAdi).Distinct();

            foreach (string s in lst1)
            {
                veri1.Add(s);
                txtBolumler.Items.Add(s);
            }
            txtBolumler.AutoCompleteCustomSource = veri1;
            txtSehirler.Text.ToUpper();
    }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (secimID>0 && edit==true && m.Guncelle()==DialogResult.Yes)
            {
                Guncelle();
            }
            else if (edit==false)
            {
                YeniKayit();
            }
            Listele();
        }

        private void Guncelle()
        {
            try
            {
                TblOgrBilgiler ogr = sdb.TblOgrBilgiler.Find(secimID);
                ogr.Ad = txtAd.Text;
                ogr.Soyad = txtSoyad.Text;
                ogr.SehirId = sdb.TblSehirler.First(x => x.sehir == txtSehirler.Text).id;
                ogr.BolumId = sdb.TblDepartments.First(x => x.BolumAdi == txtBolumler.Text).Id;
                ogr.TcNo = mTxtTcNo.Text;
                ogr.OgNo = mTxtOgrNo.Text;
                //buraya isActive çalıştırmaya gerek yok çünkü kullanıcı aktif pasif yapmamalı
                sdb.SaveChanges();
                m.Guncelle(true);
                Temizle();

            }
            catch (Exception e)
            {
                m.Hata(e);
            }
        }

        private void Ac() // aşağıdaki kayda çift tık yaptığımız zaman txtler olan bilgilerle dolar güncelleme işi kolaylaşır
        {
            try
            {
                TblOgrBilgiler ogr = sdb.TblOgrBilgiler.Find(secimID);
                txtSehirler.Text = ogr.TblSehirler.sehir;
                txtBolumler.Text = ogr.TblDepartments.BolumAdi;
                txtAd.Text = ogr.Ad;
                txtSoyad.Text = ogr.Soyad;
                mTxtOgrNo.Text = ogr.OgNo;
                mTxtTcNo.Text = ogr.TcNo;
            }
            catch (Exception e)
            {

                m.Hata(e);
            }
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                edit = true;
                secimID = (int)Liste.CurrentRow.Cells[0].Value;
                Ac();
            }
            catch (Exception)
            {
                edit = false;
                secimID=-1;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            TblOgrBilgiler ogr = sdb.TblOgrBilgiler.Find(secimID);
            ogr.isActive = false;
            sdb.SaveChanges();
            MessageBox.Show("Kayıt Başarıyla Silindi");
            Temizle();
            Listele();
        }
    }
}
