
namespace OKULUYGULAMA
{
    partial class OGRENCILISTESI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOgrenciId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cologrenci_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cologrenci_tc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cologrenci_ad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cologrenci_soyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cologrenci_seviye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsilindi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ogrenciListesiDataSet11 = new OKULUYGULAMA.ogrenciListesiDataSet11();
            this.ogrencilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrencilerTableAdapter = new OKULUYGULAMA.ogrenciListesiDataSet11TableAdapters.OgrencilerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciListesiDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.ogrenciListesiDataSet11;
            this.gridControl1.Location = new System.Drawing.Point(13, 21);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1111, 552);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Lavender;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOgrenciId,
            this.cologrenci_no,
            this.cologrenci_tc,
            this.cologrenci_ad,
            this.cologrenci_soyad,
            this.cologrenci_seviye,
            this.colsilindi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colOgrenciId
            // 
            this.colOgrenciId.FieldName = "OgrenciId";
            this.colOgrenciId.MinWidth = 25;
            this.colOgrenciId.Name = "colOgrenciId";
            this.colOgrenciId.Visible = true;
            this.colOgrenciId.VisibleIndex = 0;
            this.colOgrenciId.Width = 94;
            // 
            // cologrenci_no
            // 
            this.cologrenci_no.FieldName = "ogrenci_no";
            this.cologrenci_no.MinWidth = 25;
            this.cologrenci_no.Name = "cologrenci_no";
            this.cologrenci_no.Visible = true;
            this.cologrenci_no.VisibleIndex = 1;
            this.cologrenci_no.Width = 94;
            // 
            // cologrenci_tc
            // 
            this.cologrenci_tc.FieldName = "ogrenci_tc";
            this.cologrenci_tc.MinWidth = 25;
            this.cologrenci_tc.Name = "cologrenci_tc";
            this.cologrenci_tc.Visible = true;
            this.cologrenci_tc.VisibleIndex = 2;
            this.cologrenci_tc.Width = 94;
            // 
            // cologrenci_ad
            // 
            this.cologrenci_ad.FieldName = "ogrenci_ad";
            this.cologrenci_ad.MinWidth = 25;
            this.cologrenci_ad.Name = "cologrenci_ad";
            this.cologrenci_ad.Visible = true;
            this.cologrenci_ad.VisibleIndex = 3;
            this.cologrenci_ad.Width = 94;
            // 
            // cologrenci_soyad
            // 
            this.cologrenci_soyad.FieldName = "ogrenci_soyad";
            this.cologrenci_soyad.MinWidth = 25;
            this.cologrenci_soyad.Name = "cologrenci_soyad";
            this.cologrenci_soyad.Visible = true;
            this.cologrenci_soyad.VisibleIndex = 4;
            this.cologrenci_soyad.Width = 94;
            // 
            // cologrenci_seviye
            // 
            this.cologrenci_seviye.FieldName = "ogrenci_seviye";
            this.cologrenci_seviye.MinWidth = 25;
            this.cologrenci_seviye.Name = "cologrenci_seviye";
            this.cologrenci_seviye.Visible = true;
            this.cologrenci_seviye.VisibleIndex = 5;
            this.cologrenci_seviye.Width = 94;
            // 
            // colsilindi
            // 
            this.colsilindi.FieldName = "silindi";
            this.colsilindi.MinWidth = 25;
            this.colsilindi.Name = "colsilindi";
            this.colsilindi.Visible = true;
            this.colsilindi.VisibleIndex = 6;
            this.colsilindi.Width = 94;
            // 
            // ogrenciListesiDataSet11
            // 
            this.ogrenciListesiDataSet11.DataSetName = "ogrenciListesiDataSet11";
            this.ogrenciListesiDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrencilerBindingSource
            // 
            this.ogrencilerBindingSource.DataMember = "Ogrenciler";
            this.ogrencilerBindingSource.DataSource = this.ogrenciListesiDataSet11;
            // 
            // ogrencilerTableAdapter
            // 
            this.ogrencilerTableAdapter.ClearBeforeFill = true;
            // 
            // OGRENCILISTESI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 595);
            this.Controls.Add(this.gridControl1);
            this.Name = "OGRENCILISTESI";
            this.Text = "OGRENCILISTESI";
            this.Load += new System.EventHandler(this.OGRENCILISTESI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciListesiDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrenciId;
        private DevExpress.XtraGrid.Columns.GridColumn cologrenci_no;
        private DevExpress.XtraGrid.Columns.GridColumn cologrenci_tc;
        private DevExpress.XtraGrid.Columns.GridColumn cologrenci_ad;
        private DevExpress.XtraGrid.Columns.GridColumn cologrenci_soyad;
        private DevExpress.XtraGrid.Columns.GridColumn cologrenci_seviye;
        private DevExpress.XtraGrid.Columns.GridColumn colsilindi;
        private ogrenciListesiDataSet11 ogrenciListesiDataSet11;
        private System.Windows.Forms.BindingSource ogrencilerBindingSource;
        private ogrenciListesiDataSet11TableAdapters.OgrencilerTableAdapter ogrencilerTableAdapter;
    }
}