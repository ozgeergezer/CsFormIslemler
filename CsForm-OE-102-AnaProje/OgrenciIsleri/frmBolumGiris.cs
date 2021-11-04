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

namespace CsForm_OE_102_AnaProje.OgrenciIsleri
{
    public partial class frmBolumGiris : Form
    {
        readonly StudentsEntities sdb = new StudentsEntities();
        public frmBolumGiris()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }

        private void frmBolumGiris_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            int i = 0;
            var lst = (from s in sdb.TblDepartments select s).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value=k.Id;
                Liste.Rows[i].Cells[1].Value=k.BolumAdi;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }

    }
}
