
namespace OKULUYGULAMA
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ogrencilistesi_btn = new DevExpress.XtraBars.BarButtonItem();
            this.okulbilgileri_btn = new DevExpress.XtraBars.BarButtonItem();
            this.sinifbilgileri_btn = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSearchControl2 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemRibbonSearchEdit1 = new DevExpress.XtraBars.Ribbon.Internal.RepositoryItemRibbonSearchEdit();
            this.ogrencibilgileribtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRibbonSearchEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(26, 30, 26, 30);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.ogrencilistesi_btn,
            this.okulbilgileri_btn,
            this.sinifbilgileri_btn,
            this.barEditItem1,
            this.barEditItem2,
            this.barEditItem3,
            this.ogrencibilgileribtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 289;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchControl1,
            this.repositoryItemSearchControl2,
            this.repositoryItemRibbonSearchEdit1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1144, 223);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Below;
            // 
            // ogrencilistesi_btn
            // 
            this.ogrencilistesi_btn.Caption = "ÖĞRENCİ LİSTESİ";
            this.ogrencilistesi_btn.Id = 1;
            this.ogrencilistesi_btn.ImageOptions.Image = global::OKULUYGULAMA.Properties.Resources.listbullets_16x16;
            this.ogrencilistesi_btn.ImageOptions.LargeImage = global::OKULUYGULAMA.Properties.Resources.listbullets_32x32;
            this.ogrencilistesi_btn.Name = "ogrencilistesi_btn";
            this.ogrencilistesi_btn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Ogrencilistesi_btn_ItemClick);
            // 
            // okulbilgileri_btn
            // 
            this.okulbilgileri_btn.Caption = "OKUL BİLGİLERİ";
            this.okulbilgileri_btn.Id = 2;
            this.okulbilgileri_btn.ImageOptions.Image = global::OKULUYGULAMA.Properties.Resources.home_16x16;
            this.okulbilgileri_btn.ImageOptions.LargeImage = global::OKULUYGULAMA.Properties.Resources.home_32x32;
            this.okulbilgileri_btn.Name = "okulbilgileri_btn";
            this.okulbilgileri_btn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Okulbilgileri_btn_ItemClick);
            // 
            // sinifbilgileri_btn
            // 
            this.sinifbilgileri_btn.Caption = "SINIF BİLGİLERİ";
            this.sinifbilgileri_btn.Id = 3;
            this.sinifbilgileri_btn.ImageOptions.Image = global::OKULUYGULAMA.Properties.Resources.contentautoarrange_16x16;
            this.sinifbilgileri_btn.ImageOptions.LargeImage = global::OKULUYGULAMA.Properties.Resources.contentautoarrange_32x32;
            this.sinifbilgileri_btn.Name = "sinifbilgileri_btn";
            this.sinifbilgileri_btn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Sinifbilgileri_btn_ItemClick);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Edit = this.repositoryItemSearchControl1;
            this.barEditItem1.Id = 4;
            this.barEditItem1.ImageOptions.Image = global::OKULUYGULAMA.Properties.Resources.find_16x16;
            this.barEditItem1.ImageOptions.LargeImage = global::OKULUYGULAMA.Properties.Resources.find_32x32;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemSearchControl1
            // 
            this.repositoryItemSearchControl1.AutoHeight = false;
            this.repositoryItemSearchControl1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
            // 
            // barEditItem2
            // 
            this.barEditItem2.Edit = this.repositoryItemSearchControl2;
            this.barEditItem2.Id = 5;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // repositoryItemSearchControl2
            // 
            this.repositoryItemSearchControl2.AutoHeight = false;
            this.repositoryItemSearchControl2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.repositoryItemSearchControl2.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.repositoryItemSearchControl2.Name = "repositoryItemSearchControl2";
            // 
            // barEditItem3
            // 
            this.barEditItem3.Edit = this.repositoryItemRibbonSearchEdit1;
            this.barEditItem3.Id = 7;
            this.barEditItem3.Name = "barEditItem3";
            this.barEditItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // repositoryItemRibbonSearchEdit1
            // 
            this.repositoryItemRibbonSearchEdit1.AutoHeight = false;
            this.repositoryItemRibbonSearchEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemRibbonSearchEdit1.Name = "repositoryItemRibbonSearchEdit1";
            // 
            // ogrencibilgileribtn
            // 
            this.ogrencibilgileribtn.Caption = "ÖĞRENCİ BİLGİLERİ";
            this.ogrencibilgileribtn.Id = 8;
            this.ogrencibilgileribtn.ImageOptions.Image = global::OKULUYGULAMA.Properties.Resources.customer_16x16;
            this.ogrencibilgileribtn.ImageOptions.LargeImage = global::OKULUYGULAMA.Properties.Resources.customer_32x321;
            this.ogrencibilgileribtn.Name = "ogrencibilgileribtn";
            this.ogrencibilgileribtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Ogrencibilgileribtn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "OKUL";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.ogrencilistesi_btn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.okulbilgileri_btn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.sinifbilgileri_btn);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.ogrencibilgileribtn);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 603);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "AYDIN LİSESİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRibbonSearchEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem ogrencilistesi_btn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem okulbilgileri_btn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem sinifbilgileri_btn;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl2;
        private DevExpress.XtraBars.BarEditItem barEditItem3;
        private DevExpress.XtraBars.Ribbon.Internal.RepositoryItemRibbonSearchEdit repositoryItemRibbonSearchEdit1;
        private DevExpress.XtraBars.BarButtonItem ogrencibilgileribtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

