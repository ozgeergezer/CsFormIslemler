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
            if (rbHepsi.Checked==true)
            {
                Liste.Rows.Clear();
                int i = 0;
                var lst = (from s in sdb.TblDepartments select s).ToList(); //where koşulu yok gerekli tüm kayıtları getirecek
                foreach (var k in lst)
                {
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = k.Id;
                    Liste.Rows[i].Cells[1].Value = k.BolumAdi;
                    Liste.Rows[i].Cells[2].Value = k.isActive;
                    i++;
                }

                Liste.AllowUserToAddRows = false; 
            }
            else if (rbaktif.Checked==true)
            {
                Liste.Rows.Clear();
                int i = 0;
                var lst = (from s in sdb.TblDepartments where s.isActive == true select s).ToList(); //where var aktifliği true olanları getirecek
                foreach (var k in lst)
                {
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = k.Id;
                    Liste.Rows[i].Cells[1].Value = k.BolumAdi;
                    i++;
                }

                Liste.AllowUserToAddRows = false;

            }
            else if (rbpasif.Checked==true)
            {
                Liste.Rows.Clear();
                int i = 0;
                var lst = (from s in sdb.TblDepartments where s.isActive == false select s).ToList();
                foreach (var k in lst)
                {
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = k.Id;
                    Liste.Rows[i].Cells[1].Value = k.BolumAdi;
                    i++;
                }

                Liste.AllowUserToAddRows = false; 
            }
        }
        private void YeniKayit()
        {
            try
            {
                if (txtBolumadi.Text!="")
                {
                    TblDepartments blm = new TblDepartments();
                    blm.BolumAdi = txtBolumadi.Text;
                    blm.isActive = true;
                    sdb.TblDepartments.Add(blm);
                    sdb.SaveChanges();
                    m.YeniKayit("Yeni Kayıt Oluşturuldu.");
                    //MessageBox.Show("Yeni Kayıt Oluşturuldu."); 
                }
                else
                {
                    MessageBox.Show("Hatalı işlem. Lütfen giriş yapınız");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Kayıt oluiturulamadı."+ e);
            }
        }

        private void Guncelle()
        {
            try
            {
                TblDepartments blm = sdb.TblDepartments.First(x => x.Id == secimId); //db tek kayıt getirir
                //TblDepartments blm1 = sdb.TblDepartments.Find(secimId); -- sadece !! id araması yapar.
                blm.BolumAdi =txtBolumadi.Text;
                //blm.Id = 2222;
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

        private void Sil()
        {
            try
            {
                if (secimId>0)
                {
                    TblDepartments blm = sdb.TblDepartments.Find(secimId);
                    blm.isActive = false;
                    //blm.Id = 444;
                    sdb.SaveChanges();
                    MessageBox.Show("Kayıt Silinmiştir.");
                    m.Sil(true); 
                }
                else
                {
                    MessageBox.Show("Lütfen silinecek kayıdı ilk önce seçiniz.");
                }
            }
            catch (Exception e)
            {
                m.Sil(e);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
            Temizle();
            Listele();
        }

        private void TamSil()
        {
            try
            {
                if (secimId > 0)
                {
                    TblDepartments blm = sdb.TblDepartments.Remove(sdb.TblDepartments.Find(secimId)); //remove işlemini yapacak
                    sdb.SaveChanges();
                    //blm.isActive = true;
                    //blm.Id = 444;
                    MessageBox.Show("Kayıt Silinmiştir.");
                    m.Sil(true);
                }
                else
                {
                    MessageBox.Show("Lütfen silinecek kayıdı ilk önce seçiniz.");
                }
            }
            catch (Exception e)
            {
                m.Sil(e);
            }
        }

        private void btnTamsil_Click(object sender, EventArgs e)
        {
            TamSil();
            Temizle();
            Listele();
        }

        private void chkPasif_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPasif.Checked == true)
            {
                Liste.Rows.Clear();

                int i = 0;
                var lst = (from s in sdb.TblDepartments where s.isActive == false select s).ToList();
                foreach (var k in lst)
                {
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = k.Id;
                    Liste.Rows[i].Cells[1].Value = k.BolumAdi;
                    i++;
                }
                Liste.AllowUserToAddRows = false;
            }
            else
            {
                Listele();
            }
        }

        private void rbHepsi_CheckedChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void rbaktif_CheckedChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void rbpasif_CheckedChanged(object sender, EventArgs e)
        {
            Listele();
        }
    }
}