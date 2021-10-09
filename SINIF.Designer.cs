
namespace OKULUYGULAMA
{
    partial class SINIF
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
            this.ogrenciListesiDataSet8 = new OKULUYGULAMA.ogrenciListesiDataSet8();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSinifId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colokul_adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cologrenci_seviye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sınıfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sınıfTableAdapter = new OKULUYGULAMA.ogrenciListesiDataSet8TableAdapters.SınıfTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciListesiDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sınıfBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(OKULUYGULAMA.Sınıf);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1334, 506);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // ogrenciListesiDataSet8
            // 
            this.ogrenciListesiDataSet8.DataSetName = "ogrenciListesiDataSet8";
            this.ogrenciListesiDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Lavender;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSinifId,
            this.colokul_adi,
            this.cologrenci_seviye});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colSinifId
            // 
            this.colSinifId.FieldName = "SinifId";
            this.colSinifId.MinWidth = 25;
            this.colSinifId.Name = "colSinifId";
            this.colSinifId.Visible = true;
            this.colSinifId.VisibleIndex = 0;
            this.colSinifId.Width = 94;
            // 
            // colokul_adi
            // 
            this.colokul_adi.FieldName = "okul_adi";
            this.colokul_adi.MinWidth = 25;
            this.colokul_adi.Name = "colokul_adi";
            this.colokul_adi.Visible = true;
            this.colokul_adi.VisibleIndex = 1;
            this.colokul_adi.Width = 94;
            // 
            // cologrenci_seviye
            // 
            this.cologrenci_seviye.FieldName = "ogrenci_seviye";
            this.cologrenci_seviye.MinWidth = 25;
            this.cologrenci_seviye.Name = "cologrenci_seviye";
            this.cologrenci_seviye.Visible = true;
            this.cologrenci_seviye.VisibleIndex = 2;
            this.cologrenci_seviye.Width = 94;
            // 
            // sınıfBindingSource
            // 
            this.sınıfBindingSource.DataMember = "Sınıf";
            this.sınıfBindingSource.DataSource = this.ogrenciListesiDataSet8;
            // 
            // sınıfTableAdapter
            // 
            this.sınıfTableAdapter.ClearBeforeFill = true;
            // 
            // SINIF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 506);
            this.Controls.Add(this.gridControl1);
            this.Name = "SINIF";
            this.Text = "SINIF";
            this.Load += new System.EventHandler(this.SINIF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciListesiDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sınıfBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private ogrenciListesiDataSet8 ogrenciListesiDataSet8;
        private System.Windows.Forms.BindingSource sınıfBindingSource;
        private ogrenciListesiDataSet8TableAdapters.SınıfTableAdapter sınıfTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colSinifId;
        private DevExpress.XtraGrid.Columns.GridColumn colokul_adi;
        private DevExpress.XtraGrid.Columns.GridColumn cologrenci_seviye;
    }
}