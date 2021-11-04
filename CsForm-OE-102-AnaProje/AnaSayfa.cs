using CsForm_OE_102_AnaProje.Formİslemleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsForm_OE_102_AnaProje.OgrenciIsleri.OgrEntity;
using CsForm_OE_102_AnaProje.OgrenciIsleri;

namespace CsForm_OE_102_AnaProje
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        #region PnlUstPaneli

        void Paneller()
        {
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
            gbSol.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbSol.Text = button1.Text;
            Paneller();
            pnl1.Visible = true;
            //pnl2.Visible = false;
            //pnl3.Visible = false;
            //pnl4.Visible = false;
            //pnl5.Visible = false;
            //pnl6.Visible = false;
            //pnl7.Visible = false;

            // hepsine bu şekilde yazmaktansa Paneller() diye metod oluşturup sadece istediğimiz panelin görünürlüğünü açarak kod kalabalığından kurtuluyoruz.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbSol.Text = button2.Text;
            Paneller();
            pnl2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gbSol.Text = button3.Text;
            Paneller();
            pnl3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gbSol.Text = button4.Text;
            Paneller();
            pnl4.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gbSol.Text = button5.Text;
            Paneller();
            pnl5.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gbSol.Text = button6.Text;
            Paneller();
            pnl6.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            gbSol.Text = button7.Text;
            Paneller();
            pnl7.Visible = true;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnCollaps_Click(object sender, EventArgs e)
        {
            if (gbSol.Visible == true)
            {
                gbSol.Visible = false;
                btnCollaps.Text = "GÖSTER";
            }
            else if (gbSol.Visible == false)
            {
                gbSol.Visible = true;
                btnCollaps.Text = "GİZLE";
            }
        }
        #endregion

        #region Formİslemleri
        private void btnGonderProp_Click(object sender, EventArgs e)
        {
            frmGonderProp frm = new frmGonderProp();
            frm.MdiParent = Form.ActiveForm; // açılan ekran ana ekran üzerinde açılsın yeni bir pencere olmasın.
            frm.WindowState = FormWindowState.Maximized; //tam ekran açılması için.
            frm.Show();
        }

        private void btnGonderCons_Click(object sender, EventArgs e)
        {
            frmGonderCons frm = new frmGonderCons();
            frm.MdiParent = Form.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        #endregion

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            frmBolumGiris frm = new frmBolumGiris();
            frm.ShowDialog();
        }
    }
}
