namespace PresentationLayer.Memeber
{
    partial class frmEditMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditMember));
            this.picmember = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnexit = new DevComponents.DotNetBar.ButtonX();
            this.btn_update = new DevComponents.DotNetBar.ButtonX();
            this.PanelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.txtcode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.btn_delete = new DevComponents.DotNetBar.ButtonX();
            this.Label5 = new System.Windows.Forms.Label();
            this.btn_browse = new DevComponents.DotNetBar.ButtonX();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtadress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label9 = new System.Windows.Forms.Label();
            this.txttell = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtzamentell = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtbirthday = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtozviat = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtzamen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbgride = new System.Windows.Forms.ComboBox();
            this.txtfather = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtsh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtfname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtlname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label14 = new System.Windows.Forms.Label();
            this.CmbSearch = new System.Windows.Forms.ComboBox();
            this.txtsearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Label13 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picmember)).BeginInit();
            this.PanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // picmember
            // 
            this.picmember.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picmember.Location = new System.Drawing.Point(25, 12);
            this.picmember.Name = "picmember";
            this.picmember.Size = new System.Drawing.Size(120, 99);
            this.picmember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmember.TabIndex = 172;
            this.picmember.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Label1.Location = new System.Drawing.Point(569, 41);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(24, 13);
            this.Label1.TabIndex = 142;
            this.Label1.Text = ":نام";
            // 
            // btnexit
            // 
            this.btnexit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnexit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Image = global::PresentationLayer.Properties.Resources.delete_alt;
            this.btnexit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnexit.Location = new System.Drawing.Point(15, 259);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(139, 28);
            this.btnexit.TabIndex = 18;
            this.btnexit.Text = "خروج";
            this.btnexit.Tooltip = "خروج";
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btn_update
            // 
            this.btn_update.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_update.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_update.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Image = global::PresentationLayer.Properties.Resources.accept;
            this.btn_update.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btn_update.Location = new System.Drawing.Point(356, 259);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(139, 28);
            this.btn_update.TabIndex = 15;
            this.btn_update.Text = "ثبت";
            this.btn_update.Tooltip = "ثبت";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // PanelEx1
            // 
            this.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.PanelEx1.Controls.Add(this.picmember);
            this.PanelEx1.Controls.Add(this.Label1);
            this.PanelEx1.Controls.Add(this.txtcode);
            this.PanelEx1.Controls.Add(this.Label2);
            this.PanelEx1.Controls.Add(this.btnexit);
            this.PanelEx1.Controls.Add(this.Label3);
            this.PanelEx1.Controls.Add(this.btn_update);
            this.PanelEx1.Controls.Add(this.Label4);
            this.PanelEx1.Controls.Add(this.btn_delete);
            this.PanelEx1.Controls.Add(this.Label5);
            this.PanelEx1.Controls.Add(this.btn_browse);
            this.PanelEx1.Controls.Add(this.Label10);
            this.PanelEx1.Controls.Add(this.txtadress);
            this.PanelEx1.Controls.Add(this.Label9);
            this.PanelEx1.Controls.Add(this.txttell);
            this.PanelEx1.Controls.Add(this.Label8);
            this.PanelEx1.Controls.Add(this.txtzamentell);
            this.PanelEx1.Controls.Add(this.Label7);
            this.PanelEx1.Controls.Add(this.txtbirthday);
            this.PanelEx1.Controls.Add(this.Label6);
            this.PanelEx1.Controls.Add(this.txtozviat);
            this.PanelEx1.Controls.Add(this.Label11);
            this.PanelEx1.Controls.Add(this.txtzamen);
            this.PanelEx1.Controls.Add(this.cmbgride);
            this.PanelEx1.Controls.Add(this.txtfather);
            this.PanelEx1.Controls.Add(this.Label12);
            this.PanelEx1.Controls.Add(this.txtsh);
            this.PanelEx1.Controls.Add(this.txtfname);
            this.PanelEx1.Controls.Add(this.txtlname);
            this.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.PanelEx1.Location = new System.Drawing.Point(1, 215);
            this.PanelEx1.Name = "PanelEx1";
            this.PanelEx1.Size = new System.Drawing.Size(648, 294);
            this.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx1.Style.GradientAngle = 90;
            this.PanelEx1.TabIndex = 181;
            // 
            // txtcode
            // 
            // 
            // 
            // 
            this.txtcode.Border.Class = "TextBoxBorder";
            this.txtcode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcode.Location = new System.Drawing.Point(356, 12);
            this.txtcode.Name = "txtcode";
            this.txtcode.ReadOnly = true;
            this.txtcode.Size = new System.Drawing.Size(139, 21);
            this.txtcode.TabIndex = 171;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Label2.Location = new System.Drawing.Point(524, 68);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(69, 13);
            this.Label2.TabIndex = 143;
            this.Label2.Text = ":نام خانوادگی";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Label3.Location = new System.Drawing.Point(501, 98);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(92, 13);
            this.Label3.TabIndex = 144;
            this.Label3.Text = ":شماره شناسنامه";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Label4.Location = new System.Drawing.Point(541, 152);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(52, 13);
            this.Label4.TabIndex = 145;
            this.Label4.Text = ":تاریخ تولد";
            // 
            // btn_delete
            // 
            this.btn_delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_delete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_delete.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Image = global::PresentationLayer.Properties.Resources.delete;
            this.btn_delete.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btn_delete.Location = new System.Drawing.Point(184, 259);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(139, 28);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "حذف";
            this.btn_delete.Tooltip = "حذف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Label5.Location = new System.Drawing.Point(553, 125);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(40, 13);
            this.Label5.TabIndex = 146;
            this.Label5.Text = ":نام پدر";
            // 
            // btn_browse
            // 
            this.btn_browse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_browse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_browse.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.Image = global::PresentationLayer.Properties.Resources.Pictures1;
            this.btn_browse.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btn_browse.Location = new System.Drawing.Point(15, 115);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(139, 28);
            this.btn_browse.TabIndex = 14;
            this.btn_browse.Text = "عکس";
            this.btn_browse.Tooltip = "عکس";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Label10.Location = new System.Drawing.Point(522, 179);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label10.Size = new System.Drawing.Size(71, 13);
            this.Label10.TabIndex = 148;
            this.Label10.Text = ":مدرک تحصیل";
            // 
            // txtadress
            // 
            // 
            // 
            // 
            this.txtadress.Border.Class = "TextBoxBorder";
            this.txtadress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtadress.Location = new System.Drawing.Point(15, 230);
            this.txtadress.MaxLength = 150;
            this.txtadress.Name = "txtadress";
            this.txtadress.Size = new System.Drawing.Size(480, 21);
            this.txtadress.TabIndex = 10;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Label9.Location = new System.Drawing.Point(524, 206);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label9.Size = new System.Drawing.Size(69, 13);
            this.Label9.TabIndex = 149;
            this.Label9.Text = ":تاریخ عضویت";
            // 
            // txttell
            // 
            // 
            // 
            // 
            this.txttell.Border.Class = "TextBoxBorder";
            this.txttell.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttell.Location = new System.Drawing.Point(15, 198);
            this.txttell.MaxLength = 12;
            this.txttell.Name = "txttell";
            this.txttell.Size = new System.Drawing.Size(139, 21);
            this.txttell.TabIndex = 13;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Label8.Location = new System.Drawing.Point(176, 148);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label8.Size = new System.Drawing.Size(53, 13);
            this.Label8.TabIndex = 150;
            this.Label8.Text = ":نام ضامن";
            // 
            // txtzamentell
            // 
            // 
            // 
            // 
            this.txtzamentell.Border.Class = "TextBoxBorder";
            this.txtzamentell.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtzamentell.Location = new System.Drawing.Point(15, 172);
            this.txtzamentell.MaxLength = 12;
            this.txtzamentell.Name = "txtzamentell";
            this.txtzamentell.Size = new System.Drawing.Size(139, 21);
            this.txtzamentell.TabIndex = 12;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Label7.Location = new System.Drawing.Point(164, 201);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label7.Size = new System.Drawing.Size(65, 13);
            this.Label7.TabIndex = 151;
            this.Label7.Text = ":شماره تلفن";
            // 
            // txtbirthday
            // 
            // 
            // 
            // 
            this.txtbirthday.Border.Class = "TextBoxBorder";
            this.txtbirthday.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtbirthday.Location = new System.Drawing.Point(356, 150);
            this.txtbirthday.MaxLength = 11;
            this.txtbirthday.Name = "txtbirthday";
            this.txtbirthday.Size = new System.Drawing.Size(139, 21);
            this.txtbirthday.TabIndex = 7;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Label6.Location = new System.Drawing.Point(550, 232);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(43, 13);
            this.Label6.TabIndex = 152;
            this.Label6.Text = ":نشانی";
            // 
            // txtozviat
            // 
            // 
            // 
            // 
            this.txtozviat.Border.Class = "TextBoxBorder";
            this.txtozviat.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtozviat.Location = new System.Drawing.Point(356, 203);
            this.txtozviat.MaxLength = 11;
            this.txtozviat.Name = "txtozviat";
            this.txtozviat.Size = new System.Drawing.Size(139, 21);
            this.txtozviat.TabIndex = 9;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Label11.Location = new System.Drawing.Point(168, 174);
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label11.Size = new System.Drawing.Size(61, 13);
            this.Label11.TabIndex = 153;
            this.Label11.Text = ":تلفن ضامن";
            // 
            // txtzamen
            // 
            // 
            // 
            // 
            this.txtzamen.Border.Class = "TextBoxBorder";
            this.txtzamen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtzamen.Location = new System.Drawing.Point(15, 145);
            this.txtzamen.MaxLength = 50;
            this.txtzamen.Name = "txtzamen";
            this.txtzamen.Size = new System.Drawing.Size(139, 21);
            this.txtzamen.TabIndex = 11;
            // 
            // cmbgride
            // 
            this.cmbgride.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbgride.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cmbgride.FormattingEnabled = true;
            this.cmbgride.Items.AddRange(new object[] {
            "دیپلم",
            "کاردانی",
            "کارشناسی",
            "کارشناسی ارشد",
            "دکترا"});
            this.cmbgride.Location = new System.Drawing.Point(356, 176);
            this.cmbgride.Name = "cmbgride";
            this.cmbgride.Size = new System.Drawing.Size(139, 21);
            this.cmbgride.TabIndex = 8;
            // 
            // txtfather
            // 
            // 
            // 
            // 
            this.txtfather.Border.Class = "TextBoxBorder";
            this.txtfather.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtfather.Location = new System.Drawing.Point(356, 123);
            this.txtfather.MaxLength = 50;
            this.txtfather.Name = "txtfather";
            this.txtfather.Size = new System.Drawing.Size(139, 21);
            this.txtfather.TabIndex = 6;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Label12.Location = new System.Drawing.Point(534, 14);
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label12.Size = new System.Drawing.Size(59, 13);
            this.Label12.TabIndex = 154;
            this.Label12.Text = ":کد عضویت";
            // 
            // txtsh
            // 
            // 
            // 
            // 
            this.txtsh.Border.Class = "TextBoxBorder";
            this.txtsh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtsh.Location = new System.Drawing.Point(356, 94);
            this.txtsh.MaxLength = 7;
            this.txtsh.Name = "txtsh";
            this.txtsh.Size = new System.Drawing.Size(139, 21);
            this.txtsh.TabIndex = 5;
            // 
            // txtfname
            // 
            // 
            // 
            // 
            this.txtfname.Border.Class = "TextBoxBorder";
            this.txtfname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtfname.Location = new System.Drawing.Point(356, 38);
            this.txtfname.MaxLength = 50;
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(139, 21);
            this.txtfname.TabIndex = 3;
            // 
            // txtlname
            // 
            // 
            // 
            // 
            this.txtlname.Border.Class = "TextBoxBorder";
            this.txtlname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtlname.Location = new System.Drawing.Point(356, 67);
            this.txtlname.MaxLength = 50;
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(139, 21);
            this.txtlname.TabIndex = 4;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(506, 11);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(86, 13);
            this.Label14.TabIndex = 182;
            this.Label14.Text = "جستجو بر اساس";
            // 
            // CmbSearch
            // 
            this.CmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSearch.FormattingEnabled = true;
            this.CmbSearch.Items.AddRange(new object[] {
            "کد عضویت",
            "نام خانوادگی"});
            this.CmbSearch.Location = new System.Drawing.Point(368, 7);
            this.CmbSearch.Name = "CmbSearch";
            this.CmbSearch.Size = new System.Drawing.Size(110, 21);
            this.CmbSearch.TabIndex = 177;
            this.CmbSearch.SelectedIndexChanged += new System.EventHandler(this.CmbSearch_SelectedIndexChanged);
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.MediumSpringGreen;
            // 
            // 
            // 
            this.txtsearch.Border.Class = "TextBoxBorder";
            this.txtsearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtsearch.Location = new System.Drawing.Point(96, 7);
            this.txtsearch.MaxLength = 50;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(128, 21);
            this.txtsearch.TabIndex = 178;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView1.DataMember = "tbl_member";
            this.DataGridView1.Location = new System.Drawing.Point(1, 43);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(648, 166);
            this.DataGridView1.TabIndex = 179;
            this.DataGridView1.TabStop = false;
            this.DataGridView1.Click += new System.EventHandler(this.DataGridView1_Click);
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Label13.Location = new System.Drawing.Point(241, 11);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(49, 13);
            this.Label13.TabIndex = 180;
            this.Label13.Text = "جستجو :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmEditMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(661, 517);
            this.Controls.Add(this.PanelEx1);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.CmbSearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.Label13);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditMember";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ویرایش اطلاعات اعضا";
            this.Load += new System.EventHandler(this.frmEditMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picmember)).EndInit();
            this.PanelEx1.ResumeLayout(false);
            this.PanelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox picmember;
        internal System.Windows.Forms.Label Label1;
        internal DevComponents.DotNetBar.ButtonX btnexit;
        internal DevComponents.DotNetBar.ButtonX btn_update;
        internal DevComponents.DotNetBar.PanelEx PanelEx1;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtcode;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal DevComponents.DotNetBar.ButtonX btn_delete;
        internal System.Windows.Forms.Label Label5;
        internal DevComponents.DotNetBar.ButtonX btn_browse;
        internal System.Windows.Forms.Label Label10;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtadress;
        internal System.Windows.Forms.Label Label9;
        internal DevComponents.DotNetBar.Controls.TextBoxX txttell;
        internal System.Windows.Forms.Label Label8;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtzamentell;
        internal System.Windows.Forms.Label Label7;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtbirthday;
        internal System.Windows.Forms.Label Label6;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtozviat;
        internal System.Windows.Forms.Label Label11;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtzamen;
        internal System.Windows.Forms.ComboBox cmbgride;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtfather;
        internal System.Windows.Forms.Label Label12;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtsh;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtfname;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtlname;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.ComboBox CmbSearch;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtsearch;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Label Label13;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}