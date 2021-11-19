
namespace Computer_Managment_System
{
    partial class ViewQuotationList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewQuotationList));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.lbl_Order = new System.Windows.Forms.Label();
            this.QuotationListGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.lbl_close = new System.Windows.Forms.Label();
            this.lbl_Refresh = new System.Windows.Forms.Label();
            this.btn_printReportQ = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.qReports = new Bunifu.Reports.BunifuReports(this.components);
            this.txtBox_SearchCustomer = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.imgLogo = new Bunifu.UI.WinForms.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.QuotationListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Order
            // 
            this.lbl_Order.AutoSize = true;
            this.lbl_Order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.lbl_Order.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order.ForeColor = System.Drawing.Color.White;
            this.lbl_Order.Location = new System.Drawing.Point(540, 39);
            this.lbl_Order.Name = "lbl_Order";
            this.lbl_Order.Size = new System.Drawing.Size(191, 37);
            this.lbl_Order.TabIndex = 2;
            this.lbl_Order.Text = "Quotation List";
            this.lbl_Order.Click += new System.EventHandler(this.lbl_Order_Click);
            // 
            // QuotationListGrid
            // 
            this.QuotationListGrid.AllowCustomTheming = false;
            this.QuotationListGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.QuotationListGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.QuotationListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.QuotationListGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuotationListGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.QuotationListGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QuotationListGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.QuotationListGrid.ColumnHeadersHeight = 40;
            this.QuotationListGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.QuotationListGrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.QuotationListGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.QuotationListGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.QuotationListGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.QuotationListGrid.CurrentTheme.BackColor = System.Drawing.Color.DarkSlateGray;
            this.QuotationListGrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.QuotationListGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.QuotationListGrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.QuotationListGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.QuotationListGrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.QuotationListGrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.QuotationListGrid.CurrentTheme.Name = null;
            this.QuotationListGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.QuotationListGrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.QuotationListGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.QuotationListGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.QuotationListGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.QuotationListGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.QuotationListGrid.EnableHeadersVisualStyles = false;
            this.QuotationListGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.QuotationListGrid.HeaderBackColor = System.Drawing.Color.DarkSlateGray;
            this.QuotationListGrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.QuotationListGrid.HeaderForeColor = System.Drawing.Color.White;
            this.QuotationListGrid.Location = new System.Drawing.Point(48, 160);
            this.QuotationListGrid.Name = "QuotationListGrid";
            this.QuotationListGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QuotationListGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.QuotationListGrid.RowHeadersVisible = false;
            this.QuotationListGrid.RowTemplate.Height = 40;
            this.QuotationListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.QuotationListGrid.Size = new System.Drawing.Size(1190, 466);
            this.QuotationListGrid.TabIndex = 4;
            this.QuotationListGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkSlateGray;
            this.QuotationListGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.QuotationListGrid_CellContentClick);
            this.QuotationListGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.QuotationListGrid_CellDoubleClick);
            this.QuotationListGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.orderListGrid_CellMouseDoubleClick);
            this.QuotationListGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.orderListGrid_RowHeaderMouseClick);
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_close.Location = new System.Drawing.Point(1241, 9);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(43, 42);
            this.lbl_close.TabIndex = 20;
            this.lbl_close.Text = "X";
            this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click);
            // 
            // lbl_Refresh
            // 
            this.lbl_Refresh.AutoSize = true;
            this.lbl_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Refresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Refresh.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Refresh.Location = new System.Drawing.Point(1187, 128);
            this.lbl_Refresh.Name = "lbl_Refresh";
            this.lbl_Refresh.Size = new System.Drawing.Size(51, 19);
            this.lbl_Refresh.TabIndex = 21;
            this.lbl_Refresh.Text = "refresh";
            this.lbl_Refresh.Click += new System.EventHandler(this.lbl_Refresh_Click);
            // 
            // btn_printReportQ
            // 
            this.btn_printReportQ.AllowAnimations = true;
            this.btn_printReportQ.AllowMouseEffects = true;
            this.btn_printReportQ.AllowToggling = false;
            this.btn_printReportQ.AnimationSpeed = 200;
            this.btn_printReportQ.AutoGenerateColors = false;
            this.btn_printReportQ.AutoRoundBorders = false;
            this.btn_printReportQ.AutoSizeLeftIcon = true;
            this.btn_printReportQ.AutoSizeRightIcon = true;
            this.btn_printReportQ.BackColor = System.Drawing.Color.Transparent;
            this.btn_printReportQ.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_printReportQ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_printReportQ.BackgroundImage")));
            this.btn_printReportQ.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_printReportQ.ButtonText = "Report";
            this.btn_printReportQ.ButtonTextMarginLeft = 0;
            this.btn_printReportQ.ColorContrastOnClick = 45;
            this.btn_printReportQ.ColorContrastOnHover = 45;
            this.btn_printReportQ.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_printReportQ.CustomizableEdges = borderEdges1;
            this.btn_printReportQ.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_printReportQ.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_printReportQ.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_printReportQ.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_printReportQ.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btn_printReportQ.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_printReportQ.ForeColor = System.Drawing.Color.White;
            this.btn_printReportQ.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_printReportQ.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_printReportQ.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_printReportQ.IconMarginLeft = 11;
            this.btn_printReportQ.IconPadding = 10;
            this.btn_printReportQ.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_printReportQ.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_printReportQ.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_printReportQ.IconSize = 25;
            this.btn_printReportQ.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_printReportQ.IdleBorderRadius = 35;
            this.btn_printReportQ.IdleBorderThickness = 1;
            this.btn_printReportQ.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_printReportQ.IdleIconLeftImage = null;
            this.btn_printReportQ.IdleIconRightImage = null;
            this.btn_printReportQ.IndicateFocus = false;
            this.btn_printReportQ.Location = new System.Drawing.Point(48, 643);
            this.btn_printReportQ.Name = "btn_printReportQ";
            this.btn_printReportQ.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_printReportQ.OnDisabledState.BorderRadius = 35;
            this.btn_printReportQ.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_printReportQ.OnDisabledState.BorderThickness = 1;
            this.btn_printReportQ.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_printReportQ.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_printReportQ.OnDisabledState.IconLeftImage = null;
            this.btn_printReportQ.OnDisabledState.IconRightImage = null;
            this.btn_printReportQ.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_printReportQ.onHoverState.BorderRadius = 35;
            this.btn_printReportQ.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_printReportQ.onHoverState.BorderThickness = 1;
            this.btn_printReportQ.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_printReportQ.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_printReportQ.onHoverState.IconLeftImage = null;
            this.btn_printReportQ.onHoverState.IconRightImage = null;
            this.btn_printReportQ.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_printReportQ.OnIdleState.BorderRadius = 35;
            this.btn_printReportQ.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_printReportQ.OnIdleState.BorderThickness = 1;
            this.btn_printReportQ.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_printReportQ.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_printReportQ.OnIdleState.IconLeftImage = null;
            this.btn_printReportQ.OnIdleState.IconRightImage = null;
            this.btn_printReportQ.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_printReportQ.OnPressedState.BorderRadius = 35;
            this.btn_printReportQ.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_printReportQ.OnPressedState.BorderThickness = 1;
            this.btn_printReportQ.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_printReportQ.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_printReportQ.OnPressedState.IconLeftImage = null;
            this.btn_printReportQ.OnPressedState.IconRightImage = null;
            this.btn_printReportQ.Size = new System.Drawing.Size(150, 39);
            this.btn_printReportQ.TabIndex = 50;
            this.btn_printReportQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_printReportQ.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_printReportQ.TextMarginLeft = 0;
            this.btn_printReportQ.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_printReportQ.UseDefaultRadiusAndThickness = true;
            this.btn_printReportQ.Click += new System.EventHandler(this.btn_printReportQ_Click);
            // 
            // qReports
            // 
            this.qReports.AlternativeRowBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.qReports.AlternativeRowGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.qReports.HeaderBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(183)))), ((int)(((byte)(197)))));
            this.qReports.HeaderFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.qReports.HeaderGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.qReports.RowDefaultBackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.qReports.RowDefaultFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.qReports.RowDefaultGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            // 
            // txtBox_SearchCustomer
            // 
            this.txtBox_SearchCustomer.AcceptsReturn = false;
            this.txtBox_SearchCustomer.AcceptsTab = false;
            this.txtBox_SearchCustomer.AnimationSpeed = 200;
            this.txtBox_SearchCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBox_SearchCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBox_SearchCustomer.AutoSizeHeight = true;
            this.txtBox_SearchCustomer.BackColor = System.Drawing.Color.Transparent;
            this.txtBox_SearchCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBox_SearchCustomer.BackgroundImage")));
            this.txtBox_SearchCustomer.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtBox_SearchCustomer.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBox_SearchCustomer.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtBox_SearchCustomer.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtBox_SearchCustomer.BorderRadius = 35;
            this.txtBox_SearchCustomer.BorderThickness = 1;
            this.txtBox_SearchCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBox_SearchCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_SearchCustomer.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtBox_SearchCustomer.DefaultText = "";
            this.txtBox_SearchCustomer.FillColor = System.Drawing.Color.White;
            this.txtBox_SearchCustomer.HideSelection = true;
            this.txtBox_SearchCustomer.IconLeft = null;
            this.txtBox_SearchCustomer.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_SearchCustomer.IconPadding = 10;
            this.txtBox_SearchCustomer.IconRight = null;
            this.txtBox_SearchCustomer.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_SearchCustomer.Lines = new string[0];
            this.txtBox_SearchCustomer.Location = new System.Drawing.Point(219, 108);
            this.txtBox_SearchCustomer.MaxLength = 32767;
            this.txtBox_SearchCustomer.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtBox_SearchCustomer.Modified = false;
            this.txtBox_SearchCustomer.Multiline = false;
            this.txtBox_SearchCustomer.Name = "txtBox_SearchCustomer";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBox_SearchCustomer.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBox_SearchCustomer.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBox_SearchCustomer.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBox_SearchCustomer.OnIdleState = stateProperties4;
            this.txtBox_SearchCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.txtBox_SearchCustomer.PasswordChar = '\0';
            this.txtBox_SearchCustomer.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBox_SearchCustomer.PlaceholderText = "Ex: Madhushan Liyanage";
            this.txtBox_SearchCustomer.ReadOnly = false;
            this.txtBox_SearchCustomer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBox_SearchCustomer.SelectedText = "";
            this.txtBox_SearchCustomer.SelectionLength = 0;
            this.txtBox_SearchCustomer.SelectionStart = 0;
            this.txtBox_SearchCustomer.ShortcutsEnabled = true;
            this.txtBox_SearchCustomer.Size = new System.Drawing.Size(393, 39);
            this.txtBox_SearchCustomer.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtBox_SearchCustomer.TabIndex = 51;
            this.txtBox_SearchCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBox_SearchCustomer.TextMarginBottom = 0;
            this.txtBox_SearchCustomer.TextMarginLeft = 3;
            this.txtBox_SearchCustomer.TextMarginTop = 1;
            this.txtBox_SearchCustomer.TextPlaceholder = "Ex: Madhushan Liyanage";
            this.txtBox_SearchCustomer.UseSystemPasswordChar = false;
            this.txtBox_SearchCustomer.WordWrap = true;
            this.txtBox_SearchCustomer.TextChanged += new System.EventHandler(this.txtBox_SearchCustomer_TextChanged);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuLabel1.Location = new System.Drawing.Point(48, 108);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(156, 30);
            this.bunifuLabel1.TabIndex = 52;
            this.bunifuLabel1.Text = "Customer Name";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // imgLogo
            // 
            this.imgLogo.ActiveImage = null;
            this.imgLogo.AllowAnimations = true;
            this.imgLogo.AllowBuffering = false;
            this.imgLogo.AllowToggling = false;
            this.imgLogo.AllowZooming = true;
            this.imgLogo.AllowZoomingOnFocus = false;
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.imgLogo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imgLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgLogo.ErrorImage")));
            this.imgLogo.FadeWhenInactive = false;
            this.imgLogo.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.ImageActive = null;
            this.imgLogo.ImageLocation = null;
            this.imgLogo.ImageMargin = 1;
            this.imgLogo.ImageSize = new System.Drawing.Size(120, 114);
            this.imgLogo.ImageZoomSize = new System.Drawing.Size(121, 115);
            this.imgLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgLogo.InitialImage")));
            this.imgLogo.Location = new System.Drawing.Point(588, 295);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Rotation = 0;
            this.imgLogo.ShowActiveImage = true;
            this.imgLogo.ShowCursorChanges = true;
            this.imgLogo.ShowImageBorders = true;
            this.imgLogo.ShowSizeMarkers = false;
            this.imgLogo.Size = new System.Drawing.Size(121, 115);
            this.imgLogo.TabIndex = 53;
            this.imgLogo.ToolTipText = "";
            this.imgLogo.Visible = false;
            this.imgLogo.WaitOnLoad = false;
            this.imgLogo.Zoom = 1;
            this.imgLogo.ZoomSpeed = 10;
            // 
            // ViewQuotationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1296, 705);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.txtBox_SearchCustomer);
            this.Controls.Add(this.btn_printReportQ);
            this.Controls.Add(this.lbl_Refresh);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.QuotationListGrid);
            this.Controls.Add(this.lbl_Order);
            this.Controls.Add(this.imgLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewQuotationList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Quotation List";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuotationListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Order;
        private Bunifu.UI.WinForms.BunifuDataGridView QuotationListGrid;
        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Label lbl_Refresh;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_printReportQ;
        private Bunifu.Reports.BunifuReports qReports;
        private Bunifu.UI.WinForms.BunifuTextBox txtBox_SearchCustomer;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuImageButton imgLogo;
    }
}