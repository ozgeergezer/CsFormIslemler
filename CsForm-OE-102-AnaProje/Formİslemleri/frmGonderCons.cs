using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsForm_OE_102_AnaProje.Entity;

namespace CsForm_OE_102_AnaProje.Formİslemleri
{
    public partial class frmGonderCons : Form
    {
        public frmGonderCons()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            NORTHWNDEntities1 db = new NORTHWNDEntities1();
            List<ModelKisi> elist = db.Employees.Select(x => new ModelKisi
            {
                Ad = x.FirstName,
                Soyad = x.LastName

            }).ToList(); // list olduğunu declare etmek lazım

            frmAlCons frm = new frmAlCons(elist);
            frm.Show();
        }

        private void frmGonderCons_Load(object sender, EventArgs e)
        {

        }
    }
}
