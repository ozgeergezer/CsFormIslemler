using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsForm_OE_102_AnaProje.OgrenciIsleri.OgrEntity;
using CsForm_OE_102_AnaProje.Fonksiyonlar;

namespace CsForm_OE_102_AnaProje.OgrenciIsleri
{
    public partial class frmBolumGiris : Form
    {
        readonly StudentsEntities sdb = new StudentsEntities();
        private Mesajlar m = new Mesajlar();
        private int secimId = -1;
        private bool Edit = false;

        public frmBolumGiris()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (secimId > 0 && Edit == true && m.Guncelle()==DialogResult.Yes) // güncelleme yapabilmek için id > 0 olmalı , editin true olması lazım ki güncelleyebilelim , en son da hepsi tamam eğer yes dersen işlem başlayacak
            {
                Guncelle();
            }
            else if (Edit==false) // hayıra basarsak da buraya girip yeni kayıt oluşturuyor.
            {
                YeniKayit();
            }
            //else
            //{
            //    Temizle();
            //}
            Listele();
            Temizle();
        }

        private void frmBolumGiris_Load(object sender, EventArgs e)
        {
            Listele(); // açılırken direkt listeler
        }
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var lst = (from s in sdb.TblDepartments select s).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value=k.Id;
                Liste.Rows[i].Cells[1].Value=k.BolumAdi;
                i++;
            }
            Liste.AllowUserToAddRows = false; //ekrana yazılan datagrid son satırı boş verir bu kodla onu vermez
            Liste.AllowUserToDeleteRows = false; //silme 
            Liste.AllowUserToOrderColumns = false;
        }
        private void YeniKayit()
        {
            try
            {
                TblDepartments blm = new TblDepartments();
                blm.BolumAdi = txtBolumadi.Text;
                sdb.TblDepartments.Add(blm);
                sdb.SaveChanges();
                m.YeniKayit("Yeni Kayıt Oluşturuldu.");
                //MessageBox.Show("Yeni Kayıt Oluşturuldu.");
            }
            catch (Exception e)
            {
                MessageBox.Show(""+ e);
            }
        }

        private void Guncelle()
        {
            try
            {
                TblDepartments blm = sdb.TblDepartments.First(x => x.Id == secimId); //db tek kayıt getirir
                //TblDepartments blm1 = sdb.TblDepartments.Find(secimId); -- sadece !! id araması yapar.
                //blm.BolumAdi =txtBolumadi.Text;
                blm.Id = 2222;
                sdb.SaveChanges();
                m.Guncelle(true);
                //MessageBox.Show("Yeni Kayıt Oluşturuldu.");
            }
            catch (Exception e)
            {
                m.Guncelle(false);
                m.Guncelle(e);
                MessageBox.Show("" + e);
                Close();
            }
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int)Liste.CurrentRow.Cells[0].Value; // çift tıkladığımdaki değeri ver (convert değil casting işlemi parse ile yapamazsın)
            txtBolumadi.Text = Liste.CurrentRow.Cells[1].Value.ToString();
            MessageBox.Show(secimId.ToString());
            if (secimId>0)
            {
                Edit = true;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            secimId = -1;
            Edit = false;
            txtBolumadi.Clear();
        }

        private void txtBolumadi_TextChanged(object sender, EventArgs e)
        {
            //if (txtBolumadi.Text=="")
            //{
            //    Edit = false;
            //}
        }
    }
}