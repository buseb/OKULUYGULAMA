using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OKULUYGULAMA
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1() { InitializeComponent(); }
       

        OGRENCILISTESI frm1;
        Okulbilgileri frm2;
        SINIF frm3;
        OGRENCİ frm4;

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void Ogrencilistesi_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frm1 == null || frm1.IsDisposed)
            {
                frm1 = new OGRENCILISTESI();
                frm1.MdiParent = this;
                frm1.Show();
            }
        }

        private void Okulbilgileri_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
            {
                frm2 = new Okulbilgileri();
                frm2.MdiParent = this;
                frm2.Show();
            }

        }


        private void Sinifbilgileri_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frm3 == null || frm3.IsDisposed)
            {
                frm3 = new SINIF();
                frm3.MdiParent = this;
                frm3.Show();
            }
        }


        private void Ogrencibilgileribtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frm4 == null || frm4.IsDisposed)
            {
                frm4 = new OGRENCİ();
                frm4.MdiParent = this;
                frm4.Show();
            }
        }
    }
}
