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
using Sitecore.FakeDb;

namespace OKULUYGULAMA
{
    public partial class OGRENCİ : Form
    {
        public OGRENCİ()
        {
            InitializeComponent();
        }


        //   SqlConnection baglan = new SqlConnection("Data Source = DESKTOP - BR37C26; Initial Catalog = ogrenciListesi; Integrated Security = True");

        void Sinif()
        {
            /* SqlDataAdapter da = new SqlDataAdapter("SELECT dbo.Sınıf.SinifId,ogrenci_seviye FROM dbo.Sınıf INNER JOIN dbo.Okul ON dbo.Sınıf.ogrenci_seviye = dbo.Okul.OkulId" ,baglan);
             DataTable dt = new DataTable();
             da.Fill(dt);
             lookUpEdit1.Properties.ValueMember = "ID";
             lookUpEdit1.Properties.DisplayMember = "ogrenci_tc";
             lookUpEdit1.Properties.DisplayMember = "ogrenci_ad";
             lookUpEdit1.Properties.DisplayMember = "ogrenci_soyad";
             lookUpEdit1.Properties.DisplayMember = "ogrenci_seviye";
             lookUpEdit1.Properties.DataSource = dt;  */
        }

      

        public int ogrenci_tc { get; private set; }
        public object ogrenci_ad { get; private set; }
        public object ogrenci_soyad { get; private set; }

        private static void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            
        }

        protected void OGRENCİ_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ogrenciListesiDataSet6.Ogrenciler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrencilerTableAdapter1.Fill(this.ogrenciListesiDataSet6.Ogrenciler);
            // TODO: Bu kod satırı 'ogrenciListesiDataSet5.Okul' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.okulTableAdapter1.Fill(this.ogrenciListesiDataSet5.Okul);
            // TODO: Bu kod satırı 'ogrenciListesiDataSet4.Sınıf' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sınıfTableAdapter1.Fill(this.ogrenciListesiDataSet4.Sınıf);
            // TODO: Bu kod satırı 'ogrenciListesiDataSet3.Okul' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.okulTableAdapter.Fill(this.ogrenciListesiDataSet3.Okul);
            // TODO: Bu kod satırı 'ogrenciListesiDataSet2.Sınıf' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sınıfTableAdapter.Fill(this.ogrenciListesiDataSet2.Sınıf);
            // TODO: Bu kod satırı 'ogrenciListesiDataSet.Ogrenciler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrencilerTableAdapter.Fill(this.ogrenciListesiDataSet.Ogrenciler);

           
        }


    }

    
        
       
    
    
}
