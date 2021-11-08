using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsForm_OE_102_AnaProje.Fonksiyonlar
{
    class Mesajlar
    {
        public void YeniKayit(string mesaj)
        {
            MessageBox.Show(mesaj,"Yeni Kayıt Giriş" ,MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
        public DialogResult Guncelle()
        {
            return MessageBox.Show("Seçili olan kayıt güncellenecektir. \n İşlemi onaylıyor musunuz ?", "Guncelleme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void Guncelle(bool guncelleme)
        {
            MessageBox.Show("Kayıt Güncellenmiştir.","Kayıt Güncelleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public void Guncelle(Exception e)
        {
            MessageBox.Show(""+e,"Kayıt Güncelleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public void Sil(Exception e)
        {
            MessageBox.Show("" + e, "Kayıt Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Sil(bool Silme)
        {
            MessageBox.Show("Kayıt Silinmiştir.", "Kayıt Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public DialogResult Sil()
        {
            return MessageBox.Show("Seçili olan kayıt Silinecektir. \n İşlemi onaylıyor musunuz ?", "Silme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public void TamSil(Exception e)
        {
            MessageBox.Show("" + e, " Tam Kayıt Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void TamSil(bool Silme)
        {
            MessageBox.Show("Tam Kayıt Silinmiştir.", "Tam Kayıt Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public DialogResult TamSil()
        {
            return MessageBox.Show("Seçili olan Tüm kayıt Silinecektir. \n İşlemi onaylıyor musunuz ?", "Tam Silme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public void Hata(Exception hata)
        {
            MessageBox.Show(hata.Message,"işler yolunda gitmiyor",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
