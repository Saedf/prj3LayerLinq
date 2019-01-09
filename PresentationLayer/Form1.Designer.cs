namespace PresentationLayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.rbtn_NewOzv = new DevComponents.DotNetBar.ButtonItem();
            this.rbtn_editAza = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.rbn_aza = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem2 = new DevComponents.DotNetBar.RibbonTabItem();
            this.applicationButton1 = new DevComponents.DotNetBar.ApplicationButton();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.btn_NewOzv = new DevComponents.DotNetBar.ButtonItem();
            this.btn_editAza = new DevComponents.DotNetBar.ButtonItem();
            this.btn_newUser = new DevComponents.DotNetBar.ButtonItem();
            this.btn_editPermission = new DevComponents.DotNetBar.ButtonItem();
            this.btn_infoBook = new DevComponents.DotNetBar.ButtonItem();
            this.btn_editBook = new DevComponents.DotNetBar.ButtonItem();
            this.btn_amanat = new DevComponents.DotNetBar.ButtonItem();
            this.btn_editAmant = new DevComponents.DotNetBar.ButtonItem();
            this.btn_LogOff = new DevComponents.DotNetBar.ButtonItem();
            this.galleryContainer1 = new DevComponents.DotNetBar.GalleryContainer();
            this.Btn_RptGbook = new DevComponents.DotNetBar.ButtonItem();
            this.Btn_RptMember = new DevComponents.DotNetBar.ButtonItem();
            this.Btn_RptAmanat = new DevComponents.DotNetBar.ButtonItem();
            this.Btn_rptKartMember = new DevComponents.DotNetBar.ButtonItem();
            this.Btnexit = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer4 = new DevComponents.DotNetBar.ItemContainer();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.sideBar1 = new DevComponents.DotNetBar.SideBar();
            this.sideBarPanelItem1 = new DevComponents.DotNetBar.SideBarPanelItem();
            this.buttonItem14 = new DevComponents.DotNetBar.ButtonItem();
            this.sideBarPanelItem2 = new DevComponents.DotNetBar.SideBarPanelItem();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.rbn_aza,
            this.ribbonTabItem2});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ribbonControl1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.applicationButton1,
            this.qatCustomizeItem1});
            this.ribbonControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ribbonControl1.Size = new System.Drawing.Size(789, 154);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 1;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ribbonPanel1.Size = new System.Drawing.Size(789, 95);
            // 
            // 
            // 
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 1;
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.DragDropSupport = true;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.rbtn_NewOzv,
            this.rbtn_editAza});
            this.ribbonBar1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(132, 92);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 0;
            this.ribbonBar1.Text = "اعضاء";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // rbtn_NewOzv
            // 
            this.rbtn_NewOzv.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.rbtn_NewOzv.DisabledImage = global::PresentationLayer.Properties.Resources.gpg;
            this.rbtn_NewOzv.Image = global::PresentationLayer.Properties.Resources.Login_Manager;
            this.rbtn_NewOzv.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.rbtn_NewOzv.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center;
            this.rbtn_NewOzv.Name = "rbtn_NewOzv";
            this.rbtn_NewOzv.SubItemsExpandWidth = 14;
            this.rbtn_NewOzv.Text = "عضو جدید";
            this.rbtn_NewOzv.Tooltip = "عضوجدید";
            this.rbtn_NewOzv.Click += new System.EventHandler(this.rbtn_NewOzv_Click);
            // 
            // rbtn_editAza
            // 
            this.rbtn_editAza.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.rbtn_editAza.DisabledImage = global::PresentationLayer.Properties.Resources.gpg;
            this.rbtn_editAza.Image = global::PresentationLayer.Properties.Resources.kuser;
            this.rbtn_editAza.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.rbtn_editAza.Name = "rbtn_editAza";
            this.rbtn_editAza.SubItemsExpandWidth = 14;
            this.rbtn_editAza.Text = "ویرایش اطلاعات اعضاء";
            this.rbtn_editAza.Tooltip = "ویرایش اطلاعات اعضاء";
            this.rbtn_editAza.Click += new System.EventHandler(this.rbtn_editAza_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(789, 95);
            // 
            // 
            // 
            this.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel2.TabIndex = 2;
            this.ribbonPanel2.Visible = false;
            // 
            // rbn_aza
            // 
            this.rbn_aza.Checked = true;
            this.rbn_aza.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.rbn_aza.Name = "rbn_aza";
            this.rbn_aza.Panel = this.ribbonPanel1;
            this.rbn_aza.Text = "اعضاء";
            // 
            // ribbonTabItem2
            // 
            this.ribbonTabItem2.Name = "ribbonTabItem2";
            this.ribbonTabItem2.Panel = this.ribbonPanel2;
            this.ribbonTabItem2.Text = "کتاب ها";
            // 
            // applicationButton1
            // 
            this.applicationButton1.AutoExpandOnClick = true;
            this.applicationButton1.CanCustomize = false;
            this.applicationButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.applicationButton1.Image = global::PresentationLayer.Properties.Resources.samba;
            this.applicationButton1.ImagePaddingHorizontal = 2;
            this.applicationButton1.ImagePaddingVertical = 2;
            this.applicationButton1.Name = "applicationButton1";
            this.applicationButton1.NotificationMarkPosition = DevComponents.DotNetBar.eNotificationMarkPosition.TopLeft;
            this.applicationButton1.ShowSubItems = false;
            this.applicationButton1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer2,
            this.Btnexit,
            this.itemContainer4});
            this.applicationButton1.Text = "&File";
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
            this.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.ItemSpacing = 0;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer3,
            this.galleryContainer1});
            // 
            // 
            // 
            this.itemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer3
            // 
            // 
            // 
            // 
            this.itemContainer3.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.itemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer3.MinimumSize = new System.Drawing.Size(120, 0);
            this.itemContainer3.Name = "itemContainer3";
            this.itemContainer3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_NewOzv,
            this.btn_editAza,
            this.btn_newUser,
            this.btn_editPermission,
            this.btn_infoBook,
            this.btn_editBook,
            this.btn_amanat,
            this.btn_editAmant,
            this.btn_LogOff});
            // 
            // 
            // 
            this.itemContainer3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btn_NewOzv
            // 
            this.btn_NewOzv.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_NewOzv.DisabledImage = global::PresentationLayer.Properties.Resources.gpg;
            this.btn_NewOzv.Image = global::PresentationLayer.Properties.Resources.Community_Help;
            this.btn_NewOzv.Name = "btn_NewOzv";
            this.btn_NewOzv.SubItemsExpandWidth = 24;
            this.btn_NewOzv.Text = "عضو جدید";
            this.btn_NewOzv.Tooltip = "عضو جدید";
            // 
            // btn_editAza
            // 
            this.btn_editAza.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_editAza.DisabledImage = global::PresentationLayer.Properties.Resources.gpg;
            this.btn_editAza.Image = global::PresentationLayer.Properties.Resources.kuser;
            this.btn_editAza.Name = "btn_editAza";
            this.btn_editAza.SubItemsExpandWidth = 24;
            this.btn_editAza.Text = "ویرایش اطلاعات اعضا";
            this.btn_editAza.Click += new System.EventHandler(this.btn_editAza_Click);
            // 
            // btn_newUser
            // 
            this.btn_newUser.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_newUser.DisabledImage = global::PresentationLayer.Properties.Resources.gpg;
            this.btn_newUser.Image = global::PresentationLayer.Properties.Resources.User_3_Add;
            this.btn_newUser.Name = "btn_newUser";
            this.btn_newUser.SubItemsExpandWidth = 24;
            this.btn_newUser.Text = "کاربر جدید";
            this.btn_newUser.Tooltip = "کاربر جدید";
            // 
            // btn_editPermission
            // 
            this.btn_editPermission.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_editPermission.DisabledImage = global::PresentationLayer.Properties.Resources.gpg;
            this.btn_editPermission.Image = global::PresentationLayer.Properties.Resources.User_4_Edit_2;
            this.btn_editPermission.Name = "btn_editPermission";
            this.btn_editPermission.Text = "ویرایش سطح دسترسی کاربر";
            this.btn_editPermission.Tooltip = "ویرایش سطح دسترسی کاربر";
            // 
            // btn_infoBook
            // 
            this.btn_infoBook.BeginGroup = true;
            this.btn_infoBook.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_infoBook.DisabledImage = global::PresentationLayer.Properties.Resources.gpg;
            this.btn_infoBook.Image = global::PresentationLayer.Properties.Resources.File_Documents;
            this.btn_infoBook.Name = "btn_infoBook";
            this.btn_infoBook.SubItemsExpandWidth = 24;
            this.btn_infoBook.Text = "ثبت کتاب جدید";
            this.btn_infoBook.Tooltip = "ثبت کتاب جدید";
            // 
            // btn_editBook
            // 
            this.btn_editBook.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_editBook.DisabledImage = global::PresentationLayer.Properties.Resources.gpg;
            this.btn_editBook.Image = global::PresentationLayer.Properties.Resources.File_Documents_Edit;
            this.btn_editBook.Name = "btn_editBook";
            this.btn_editBook.SubItemsExpandWidth = 24;
            this.btn_editBook.Text = "ویرایش کتاب";
            this.btn_editBook.Tooltip = "ویرایش کتاب";
            // 
            // btn_amanat
            // 
            this.btn_amanat.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_amanat.DisabledImage = global::PresentationLayer.Properties.Resources.gpg;
            this.btn_amanat.Image = global::PresentationLayer.Properties.Resources.File_Documents_New;
            this.btn_amanat.Name = "btn_amanat";
            this.btn_amanat.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btn_amanat.SubItemsExpandWidth = 24;
            this.btn_amanat.Text = "امانت کتاب";
            this.btn_amanat.Tooltip = "امانت کتاب";
            // 
            // btn_editAmant
            // 
            this.btn_editAmant.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_editAmant.DisabledImage = global::PresentationLayer.Properties.Resources.gpg;
            this.btn_editAmant.Image = global::PresentationLayer.Properties.Resources.File_Documents_Edit;
            this.btn_editAmant.Name = "btn_editAmant";
            this.btn_editAmant.Text = "ویرایش اطلاعات امانات";
            this.btn_editAmant.Tooltip = "ویرایش اطلاعات امانات";
            // 
            // btn_LogOff
            // 
            this.btn_LogOff.BeginGroup = true;
            this.btn_LogOff.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_LogOff.Image = global::PresentationLayer.Properties.Resources.coffe;
            this.btn_LogOff.Name = "btn_LogOff";
            this.btn_LogOff.SubItemsExpandWidth = 24;
            this.btn_LogOff.Text = "خروج موقت";
            this.btn_LogOff.Tooltip = "خروج موقت";
            // 
            // galleryContainer1
            // 
            // 
            // 
            // 
            this.galleryContainer1.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer";
            this.galleryContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.galleryContainer1.EnableGalleryPopup = false;
            this.galleryContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.galleryContainer1.MinimumSize = new System.Drawing.Size(180, 240);
            this.galleryContainer1.MultiLine = false;
            this.galleryContainer1.Name = "galleryContainer1";
            this.galleryContainer1.PopupUsesStandardScrollbars = false;
            this.galleryContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.Btn_RptGbook,
            this.Btn_RptMember,
            this.Btn_RptAmanat,
            this.Btn_rptKartMember});
            // 
            // 
            // 
            this.galleryContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // Btn_RptGbook
            // 
            this.Btn_RptGbook.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.Btn_RptGbook.DisabledImage = ((System.Drawing.Image)(resources.GetObject("Btn_RptGbook.DisabledImage")));
            this.Btn_RptGbook.Image = ((System.Drawing.Image)(resources.GetObject("Btn_RptGbook.Image")));
            this.Btn_RptGbook.Name = "Btn_RptGbook";
            this.Btn_RptGbook.Text = "لیست کتاب های هر گروه";
            this.Btn_RptGbook.Tooltip = "لیست کتاب های هر گروه";
            // 
            // Btn_RptMember
            // 
            this.Btn_RptMember.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.Btn_RptMember.DisabledImage = ((System.Drawing.Image)(resources.GetObject("Btn_RptMember.DisabledImage")));
            this.Btn_RptMember.Image = ((System.Drawing.Image)(resources.GetObject("Btn_RptMember.Image")));
            this.Btn_RptMember.Name = "Btn_RptMember";
            this.Btn_RptMember.Text = "لیست اعضا";
            this.Btn_RptMember.Tooltip = "لیست اعضا";
            // 
            // Btn_RptAmanat
            // 
            this.Btn_RptAmanat.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.Btn_RptAmanat.DisabledImage = ((System.Drawing.Image)(resources.GetObject("Btn_RptAmanat.DisabledImage")));
            this.Btn_RptAmanat.Image = ((System.Drawing.Image)(resources.GetObject("Btn_RptAmanat.Image")));
            this.Btn_RptAmanat.Name = "Btn_RptAmanat";
            this.Btn_RptAmanat.Text = "لیست امانات هر عضو";
            this.Btn_RptAmanat.Tooltip = "لیست امانات هر عضو";
            // 
            // Btn_rptKartMember
            // 
            this.Btn_rptKartMember.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.Btn_rptKartMember.DisabledImage = ((System.Drawing.Image)(resources.GetObject("Btn_rptKartMember.DisabledImage")));
            this.Btn_rptKartMember.Image = ((System.Drawing.Image)(resources.GetObject("Btn_rptKartMember.Image")));
            this.Btn_rptKartMember.Name = "Btn_rptKartMember";
            this.Btn_rptKartMember.Text = "کارت عضویت";
            this.Btn_rptKartMember.Tooltip = "کارت عضویت";
            // 
            // Btnexit
            // 
            this.Btnexit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.Btnexit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btnexit.HotFontBold = true;
            this.Btnexit.Image = global::PresentationLayer.Properties.Resources.exit;
            this.Btnexit.Name = "Btnexit";
            this.Btnexit.SubItemsExpandWidth = 24;
            this.Btnexit.Text = "خروج از سیستم";
            this.Btnexit.Tooltip = "خروج از سیستم";
            // 
            // itemContainer4
            // 
            // 
            // 
            // 
            this.itemContainer4.BackgroundStyle.Class = "RibbonFileMenuBottomContainer";
            this.itemContainer4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer4.Name = "itemContainer4";
            // 
            // 
            // 
            this.itemContainer4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Black;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // sideBar1
            // 
            this.sideBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.Document;
            this.sideBar1.BorderStyle = DevComponents.DotNetBar.eBorderType.None;
            this.sideBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar1.ExpandedPanel = this.sideBarPanelItem1;
            this.sideBar1.Location = new System.Drawing.Point(0, 154);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Panels.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.sideBarPanelItem1,
            this.sideBarPanelItem2});
            this.sideBar1.Size = new System.Drawing.Size(231, 619);
            this.sideBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.sideBar1.TabIndex = 3;
            this.sideBar1.Text = "sideBar1";
            // 
            // sideBarPanelItem1
            // 
            this.sideBarPanelItem1.FontBold = true;
            this.sideBarPanelItem1.Name = "sideBarPanelItem1";
            this.sideBarPanelItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem14});
            this.sideBarPanelItem1.Text = "کاربر";
            // 
            // buttonItem14
            // 
            this.buttonItem14.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem14.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem14.Name = "buttonItem14";
            this.buttonItem14.Text = "New Button";
            // 
            // sideBarPanelItem2
            // 
            this.sideBarPanelItem2.FontBold = true;
            this.sideBarPanelItem2.Name = "sideBarPanelItem2";
            this.sideBarPanelItem2.Text = "ساعت";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 773);
            this.ControlBox = false;
            this.Controls.Add(this.sideBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.ItemContainer itemContainer3;
        private DevComponents.DotNetBar.ButtonItem btn_NewOzv;
        private DevComponents.DotNetBar.ButtonItem btn_editAza;
        private DevComponents.DotNetBar.ButtonItem btn_newUser;
        private DevComponents.DotNetBar.ButtonItem btn_infoBook;
        private DevComponents.DotNetBar.ButtonItem btn_editBook;
        private DevComponents.DotNetBar.ButtonItem btn_LogOff;
        private DevComponents.DotNetBar.GalleryContainer galleryContainer1;
        private DevComponents.DotNetBar.ItemContainer itemContainer4;
        private DevComponents.DotNetBar.RibbonTabItem rbn_aza;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem2;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        public DevComponents.DotNetBar.SideBar sideBar1;
        private DevComponents.DotNetBar.SideBarPanelItem sideBarPanelItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem14;
        private DevComponents.DotNetBar.SideBarPanelItem sideBarPanelItem2;
        public DevComponents.DotNetBar.ApplicationButton applicationButton1;
        private DevComponents.DotNetBar.ButtonItem rbtn_NewOzv;
        private DevComponents.DotNetBar.ButtonItem rbtn_editAza;
        private DevComponents.DotNetBar.ButtonItem btn_editPermission;
        private DevComponents.DotNetBar.ButtonItem btn_amanat;
        private DevComponents.DotNetBar.ButtonItem btn_editAmant;
        internal DevComponents.DotNetBar.ButtonItem Btnexit;
        internal DevComponents.DotNetBar.ButtonItem Btn_RptGbook;
        internal DevComponents.DotNetBar.ButtonItem Btn_RptMember;
        internal DevComponents.DotNetBar.ButtonItem Btn_RptAmanat;
        internal DevComponents.DotNetBar.ButtonItem Btn_rptKartMember;
    }
}

