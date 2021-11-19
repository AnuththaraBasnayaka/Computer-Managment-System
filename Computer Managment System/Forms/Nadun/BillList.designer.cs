
namespace Computer_Managment_System
{
    partial class BillList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillList));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.billLineUpGRID = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.textBoxSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_close = new System.Windows.Forms.Label();
            this.lbl_Refresh = new System.Windows.Forms.Label();
            this.btn_reportInvoice = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.pickDate = new System.Windows.Forms.DateTimePicker();
            this.printReport = new Bunifu.Reports.BunifuReports(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.billLineUpGRID)).BeginInit();
            this.SuspendLayout();
            // 
            // billLineUpGRID
            // 
            this.billLineUpGRID.AllowCustomTheming = false;
            this.billLineUpGRID.AllowUserToAddRows = false;
            this.billLineUpGRID.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.billLineUpGRID.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.billLineUpGRID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.billLineUpGRID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billLineUpGRID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.billLineUpGRID.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.billLineUpGRID.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.billLineUpGRID.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.billLineUpGRID.ColumnHeadersHeight = 40;
            this.billLineUpGRID.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.billLineUpGRID.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.billLineUpGRID.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.billLineUpGRID.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.billLineUpGRID.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.billLineUpGRID.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.billLineUpGRID.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.billLineUpGRID.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.billLineUpGRID.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.billLineUpGRID.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.billLineUpGRID.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.billLineUpGRID.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.billLineUpGRID.CurrentTheme.Name = null;
            this.billLineUpGRID.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.billLineUpGRID.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.billLineUpGRID.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.billLineUpGRID.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.billLineUpGRID.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.billLineUpGRID.DefaultCellStyle = dataGridViewCellStyle9;
            this.billLineUpGRID.EnableHeadersVisualStyles = false;
            this.billLineUpGRID.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.billLineUpGRID.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.billLineUpGRID.HeaderBgColor = System.Drawing.Color.Empty;
            this.billLineUpGRID.HeaderForeColor = System.Drawing.Color.White;
            this.billLineUpGRID.Location = new System.Drawing.Point(37, 137);
            this.billLineUpGRID.Name = "billLineUpGRID";
            this.billLineUpGRID.ReadOnly = true;
            this.billLineUpGRID.RowHeadersVisible = false;
            this.billLineUpGRID.RowTemplate.Height = 40;
            this.billLineUpGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.billLineUpGRID.Size = new System.Drawing.Size(996, 453);
            this.billLineUpGRID.TabIndex = 7;
            this.billLineUpGRID.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.billLineUpGRID.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDataGridView1_CellContentClick);
            this.billLineUpGRID.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.billLineUpGRID_CellMouseClick);
            this.billLineUpGRID.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.billLineUpGRID_CellMouseDoubleClick);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.AcceptsReturn = false;
            this.textBoxSearch.AcceptsTab = false;
            this.textBoxSearch.AnimationSpeed = 200;
            this.textBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxSearch.AutoSizeHeight = true;
            this.textBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.textBoxSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxSearch.BackgroundImage")));
            this.textBoxSearch.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.textBoxSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textBoxSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.textBoxSearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.textBoxSearch.BorderRadius = 30;
            this.textBoxSearch.BorderThickness = 1;
            this.textBoxSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSearch.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.textBoxSearch.DefaultText = "";
            this.textBoxSearch.FillColor = System.Drawing.Color.White;
            this.textBoxSearch.HideSelection = true;
            this.textBoxSearch.IconLeft = null;
            this.textBoxSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSearch.IconPadding = 10;
            this.textBoxSearch.IconRight = null;
            this.textBoxSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSearch.Lines = new string[0];
            this.textBoxSearch.Location = new System.Drawing.Point(130, 89);
            this.textBoxSearch.MaxLength = 32767;
            this.textBoxSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.textBoxSearch.Modified = false;
            this.textBoxSearch.Multiline = false;
            this.textBoxSearch.Name = "textBoxSearch";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxSearch.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.textBoxSearch.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxSearch.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxSearch.OnIdleState = stateProperties12;
            this.textBoxSearch.Padding = new System.Windows.Forms.Padding(3);
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.textBoxSearch.PlaceholderText = "Enter text";
            this.textBoxSearch.ReadOnly = false;
            this.textBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.SelectionLength = 0;
            this.textBoxSearch.SelectionStart = 0;
            this.textBoxSearch.ShortcutsEnabled = true;
            this.textBoxSearch.Size = new System.Drawing.Size(264, 32);
            this.textBoxSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.textBoxSearch.TabIndex = 8;
            this.textBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxSearch.TextMarginBottom = 0;
            this.textBoxSearch.TextMarginLeft = 3;
            this.textBoxSearch.TextMarginTop = 1;
            this.textBoxSearch.TextPlaceholder = "Enter text";
            this.textBoxSearch.UseSystemPasswordChar = false;
            this.textBoxSearch.WordWrap = true;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.bunifuTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(406, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Invoices LineUp";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(35, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_close.Location = new System.Drawing.Point(1016, 8);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(43, 42);
            this.lbl_close.TabIndex = 35;
            this.lbl_close.Text = "X";
            this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click);
            // 
            // lbl_Refresh
            // 
            this.lbl_Refresh.AutoSize = true;
            this.lbl_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Refresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Refresh.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Refresh.Location = new System.Drawing.Point(979, 111);
            this.lbl_Refresh.Name = "lbl_Refresh";
            this.lbl_Refresh.Size = new System.Drawing.Size(51, 19);
            this.lbl_Refresh.TabIndex = 36;
            this.lbl_Refresh.Text = "refresh";
            this.lbl_Refresh.Click += new System.EventHandler(this.lbl_Refresh_Click);
            // 
            // btn_reportInvoice
            // 
            this.btn_reportInvoice.AllowAnimations = true;
            this.btn_reportInvoice.AllowMouseEffects = true;
            this.btn_reportInvoice.AllowToggling = false;
            this.btn_reportInvoice.AnimationSpeed = 200;
            this.btn_reportInvoice.AutoGenerateColors = false;
            this.btn_reportInvoice.AutoRoundBorders = false;
            this.btn_reportInvoice.AutoSizeLeftIcon = true;
            this.btn_reportInvoice.AutoSizeRightIcon = true;
            this.btn_reportInvoice.BackColor = System.Drawing.Color.Transparent;
            this.btn_reportInvoice.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_reportInvoice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_reportInvoice.BackgroundImage")));
            this.btn_reportInvoice.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_reportInvoice.ButtonText = "Report";
            this.btn_reportInvoice.ButtonTextMarginLeft = 0;
            this.btn_reportInvoice.ColorContrastOnClick = 45;
            this.btn_reportInvoice.ColorContrastOnHover = 45;
            this.btn_reportInvoice.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btn_reportInvoice.CustomizableEdges = borderEdges3;
            this.btn_reportInvoice.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_reportInvoice.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_reportInvoice.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_reportInvoice.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_reportInvoice.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btn_reportInvoice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_reportInvoice.ForeColor = System.Drawing.Color.White;
            this.btn_reportInvoice.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportInvoice.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_reportInvoice.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_reportInvoice.IconMarginLeft = 11;
            this.btn_reportInvoice.IconPadding = 10;
            this.btn_reportInvoice.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reportInvoice.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_reportInvoice.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_reportInvoice.IconSize = 25;
            this.btn_reportInvoice.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_reportInvoice.IdleBorderRadius = 35;
            this.btn_reportInvoice.IdleBorderThickness = 1;
            this.btn_reportInvoice.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_reportInvoice.IdleIconLeftImage = null;
            this.btn_reportInvoice.IdleIconRightImage = null;
            this.btn_reportInvoice.IndicateFocus = false;
            this.btn_reportInvoice.Location = new System.Drawing.Point(37, 614);
            this.btn_reportInvoice.Name = "btn_reportInvoice";
            this.btn_reportInvoice.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_reportInvoice.OnDisabledState.BorderRadius = 35;
            this.btn_reportInvoice.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_reportInvoice.OnDisabledState.BorderThickness = 1;
            this.btn_reportInvoice.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_reportInvoice.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_reportInvoice.OnDisabledState.IconLeftImage = null;
            this.btn_reportInvoice.OnDisabledState.IconRightImage = null;
            this.btn_reportInvoice.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_reportInvoice.onHoverState.BorderRadius = 35;
            this.btn_reportInvoice.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_reportInvoice.onHoverState.BorderThickness = 1;
            this.btn_reportInvoice.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_reportInvoice.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_reportInvoice.onHoverState.IconLeftImage = null;
            this.btn_reportInvoice.onHoverState.IconRightImage = null;
            this.btn_reportInvoice.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_reportInvoice.OnIdleState.BorderRadius = 35;
            this.btn_reportInvoice.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_reportInvoice.OnIdleState.BorderThickness = 1;
            this.btn_reportInvoice.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_reportInvoice.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_reportInvoice.OnIdleState.IconLeftImage = null;
            this.btn_reportInvoice.OnIdleState.IconRightImage = null;
            this.btn_reportInvoice.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_reportInvoice.OnPressedState.BorderRadius = 35;
            this.btn_reportInvoice.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_reportInvoice.OnPressedState.BorderThickness = 1;
            this.btn_reportInvoice.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_reportInvoice.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_reportInvoice.OnPressedState.IconLeftImage = null;
            this.btn_reportInvoice.OnPressedState.IconRightImage = null;
            this.btn_reportInvoice.Size = new System.Drawing.Size(150, 39);
            this.btn_reportInvoice.TabIndex = 80;
            this.btn_reportInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_reportInvoice.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_reportInvoice.TextMarginLeft = 0;
            this.btn_reportInvoice.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_reportInvoice.UseDefaultRadiusAndThickness = true;
            this.btn_reportInvoice.Click += new System.EventHandler(this.btn_reportInvoice_Click);
            // 
            // pickDate
            // 
            this.pickDate.CalendarForeColor = System.Drawing.Color.DodgerBlue;
            this.pickDate.CalendarTitleForeColor = System.Drawing.Color.DodgerBlue;
            this.pickDate.CustomFormat = "yyyy-MM-dd";
            this.pickDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickDate.Location = new System.Drawing.Point(215, 623);
            this.pickDate.Name = "pickDate";
            this.pickDate.Size = new System.Drawing.Size(128, 26);
            this.pickDate.TabIndex = 81;
            // 
            // printReport
            // 
            this.printReport.AlternativeRowBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.printReport.AlternativeRowGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.printReport.HeaderBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(183)))), ((int)(((byte)(197)))));
            this.printReport.HeaderFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.printReport.HeaderGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.printReport.RowDefaultBackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.printReport.RowDefaultFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.printReport.RowDefaultGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            // 
            // BillList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1069, 681);
            this.Controls.Add(this.pickDate);
            this.Controls.Add(this.btn_reportInvoice);
            this.Controls.Add(this.lbl_Refresh);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.billLineUpGRID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillList";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.BillList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billLineUpGRID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuDataGridView billLineUpGRID;
        private Bunifu.UI.WinForms.BunifuTextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Label lbl_Refresh;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_reportInvoice;
        private System.Windows.Forms.DateTimePicker pickDate;
        private Bunifu.Reports.BunifuReports printReport;
    }
}