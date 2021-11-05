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


    }
}
