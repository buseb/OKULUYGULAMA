
namespace OKULUYGULAMA
{
    partial class Okulbilgileri
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
            this.okulBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciListesiDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciListesiDataSet5 = new OKULUYGULAMA.ogrenciListesiDataSet5();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colokul_adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.okulTableAdapter = new OKULUYGULAMA.ogrenciListesiDataSet5TableAdapters.OkulTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciListesiDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciListesiDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(OKULUYGULAMA.Okul);
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1152, 550);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // okulBindingSource
            // 
            this.okulBindingSource.DataMember = "Okul";
            this.okulBindingSource.DataSource = this.ogrenciListesiDataSet5BindingSource;
            // 
            // ogrenciListesiDataSet5BindingSource
            // 
            this.ogrenciListesiDataSet5BindingSource.DataSource = this.ogrenciListesiDataSet5;
            this.ogrenciListesiDataSet5BindingSource.Position = 0;
            // 
            // ogrenciListesiDataSet5
            // 
            this.ogrenciListesiDataSet5.DataSetName = "ogrenciListesiDataSet5";
            this.ogrenciListesiDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Lavender;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colokul_adi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colokul_adi
            // 
            this.colokul_adi.FieldName = "okul_adi";
            this.colokul_adi.MinWidth = 25;
            this.colokul_adi.Name = "colokul_adi";
            this.colokul_adi.Visible = true;
            this.colokul_adi.VisibleIndex = 0;
            this.colokul_adi.Width = 94;
            // 
            // okulTableAdapter
            // 
            this.okulTableAdapter.ClearBeforeFill = true;
            // 
            // Okulbilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 662);
            this.Controls.Add(this.gridControl1);
            this.Name = "Okulbilgileri";
            this.Text = "Okulbilgileri";
            this.Load += new System.EventHandler(this.Okulbilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciListesiDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciListesiDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource ogrenciListesiDataSet5BindingSource;
        private ogrenciListesiDataSet5 ogrenciListesiDataSet5;
        private System.Windows.Forms.BindingSource okulBindingSource;
        private ogrenciListesiDataSet5TableAdapters.OkulTableAdapter okulTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colokul_adi;
    }
}