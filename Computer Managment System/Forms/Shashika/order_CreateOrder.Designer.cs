
namespace Computer_Managment_System
{
    partial class order_CreateOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(order_CreateOrder));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBox_brand = new System.Windows.Forms.ComboBox();
            this.cmbBox_Supplier = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBox_category = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBox_itemName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBox_qty = new Bunifu.UI.WinForms.BunifuTextBox();
            this.orderItemsGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_addItem = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_tot = new System.Windows.Forms.Label();
            this.btn_CreateOrder = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.lbl_close = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(501, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Order";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(73, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // txt_date
            // 
            this.txt_date.CustomFormat = "yyyy-MM-dd";
            this.txt_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_date.Location = new System.Drawing.Point(182, 127);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(121, 21);
            this.txt_date.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(73, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Brand";
            // 
            // cmbBox_brand
            // 
            this.cmbBox_brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_brand.FormattingEnabled = true;
            this.cmbBox_brand.Location = new System.Drawing.Point(182, 174);
            this.cmbBox_brand.Name = "cmbBox_brand";
            this.cmbBox_brand.Size = new System.Drawing.Size(121, 28);
            this.cmbBox_brand.TabIndex = 4;
            this.cmbBox_brand.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbBox_Supplier
            // 
            this.cmbBox_Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_Supplier.FormattingEnabled = true;
            this.cmbBox_Supplier.Location = new System.Drawing.Point(182, 220);
            this.cmbBox_Supplier.Name = "cmbBox_Supplier";
            this.cmbBox_Supplier.Size = new System.Drawing.Size(121, 28);
            this.cmbBox_Supplier.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(73, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Supplier";
            // 
            // cmbBox_category
            // 
            this.cmbBox_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_category.FormattingEnabled = true;
            this.cmbBox_category.Location = new System.Drawing.Point(182, 265);
            this.cmbBox_category.Name = "cmbBox_category";
            this.cmbBox_category.Size = new System.Drawing.Size(121, 28);
            this.cmbBox_category.TabIndex = 8;
            this.cmbBox_category.SelectedIndexChanged += new System.EventHandler(this.cmbBox_category_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(73, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Category";
            // 
            // cmbBox_itemName
            // 
            this.cmbBox_itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_itemName.FormattingEnabled = true;
            this.cmbBox_itemName.Location = new System.Drawing.Point(438, 265);
            this.cmbBox_itemName.Name = "cmbBox_itemName";
            this.cmbBox_itemName.Size = new System.Drawing.Size(331, 28);
            this.cmbBox_itemName.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(329, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Item Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(789, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Qty";
            // 
            // txtBox_qty
            // 
            this.txtBox_qty.AcceptsReturn = false;
            this.txtBox_qty.AcceptsTab = false;
            this.txtBox_qty.AnimationSpeed = 200;
            this.txtBox_qty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBox_qty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBox_qty.AutoSizeHeight = true;
            this.txtBox_qty.BackColor = System.Drawing.Color.Transparent;
            this.txtBox_qty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBox_qty.BackgroundImage")));
            this.txtBox_qty.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtBox_qty.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBox_qty.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtBox_qty.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtBox_qty.BorderRadius = 1;
            this.txtBox_qty.BorderThickness = 1;
            this.txtBox_qty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBox_qty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_qty.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_qty.DefaultText = "";
            this.txtBox_qty.FillColor = System.Drawing.Color.White;
            this.txtBox_qty.HideSelection = true;
            this.txtBox_qty.IconLeft = null;
            this.txtBox_qty.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_qty.IconPadding = 10;
            this.txtBox_qty.IconRight = null;
            this.txtBox_qty.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_qty.Lines = new string[0];
            this.txtBox_qty.Location = new System.Drawing.Point(845, 265);
            this.txtBox_qty.MaxLength = 32767;
            this.txtBox_qty.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtBox_qty.Modified = false;
            this.txtBox_qty.Multiline = false;
            this.txtBox_qty.Name = "txtBox_qty";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBox_qty.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBox_qty.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBox_qty.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBox_qty.OnIdleState = stateProperties4;
            this.txtBox_qty.Padding = new System.Windows.Forms.Padding(3);
            this.txtBox_qty.PasswordChar = '\0';
            this.txtBox_qty.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBox_qty.PlaceholderText = "";
            this.txtBox_qty.ReadOnly = false;
            this.txtBox_qty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBox_qty.SelectedText = "";
            this.txtBox_qty.SelectionLength = 0;
            this.txtBox_qty.SelectionStart = 0;
            this.txtBox_qty.ShortcutsEnabled = true;
            this.txtBox_qty.Size = new System.Drawing.Size(67, 28);
            this.txtBox_qty.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtBox_qty.TabIndex = 12;
            this.txtBox_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBox_qty.TextMarginBottom = 0;
            this.txtBox_qty.TextMarginLeft = 3;
            this.txtBox_qty.TextMarginTop = 1;
            this.txtBox_qty.TextPlaceholder = "";
            this.txtBox_qty.UseSystemPasswordChar = false;
            this.txtBox_qty.WordWrap = true;
            // 
            // orderItemsGrid
            // 
            this.orderItemsGrid.AllowCustomTheming = false;
            this.orderItemsGrid.AllowUserToAddRows = false;
            this.orderItemsGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.orderItemsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.orderItemsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderItemsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderItemsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.orderItemsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderItemsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.orderItemsGrid.ColumnHeadersHeight = 40;
            this.orderItemsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.orderItemsGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.orderItemsGrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.orderItemsGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.orderItemsGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.orderItemsGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.orderItemsGrid.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.orderItemsGrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.orderItemsGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.orderItemsGrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.orderItemsGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.orderItemsGrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.orderItemsGrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.orderItemsGrid.CurrentTheme.Name = null;
            this.orderItemsGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.orderItemsGrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.orderItemsGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.orderItemsGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.orderItemsGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderItemsGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.orderItemsGrid.EnableHeadersVisualStyles = false;
            this.orderItemsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.orderItemsGrid.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.orderItemsGrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.orderItemsGrid.HeaderForeColor = System.Drawing.Color.White;
            this.orderItemsGrid.Location = new System.Drawing.Point(77, 319);
            this.orderItemsGrid.Name = "orderItemsGrid";
            this.orderItemsGrid.ReadOnly = true;
            this.orderItemsGrid.RowHeadersVisible = false;
            this.orderItemsGrid.RowTemplate.Height = 40;
            this.orderItemsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderItemsGrid.Size = new System.Drawing.Size(998, 327);
            this.orderItemsGrid.TabIndex = 13;
            this.orderItemsGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Serial No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Qty";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Unit Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btn_addItem
            // 
            this.btn_addItem.AllowAnimations = true;
            this.btn_addItem.AllowMouseEffects = true;
            this.btn_addItem.AllowToggling = false;
            this.btn_addItem.AnimationSpeed = 200;
            this.btn_addItem.AutoGenerateColors = false;
            this.btn_addItem.AutoRoundBorders = false;
            this.btn_addItem.AutoSizeLeftIcon = true;
            this.btn_addItem.AutoSizeRightIcon = true;
            this.btn_addItem.BackColor = System.Drawing.Color.Transparent;
            this.btn_addItem.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(79)))));
            this.btn_addItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addItem.BackgroundImage")));
            this.btn_addItem.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_addItem.ButtonText = "Add Item";
            this.btn_addItem.ButtonTextMarginLeft = 0;
            this.btn_addItem.ColorContrastOnClick = 45;
            this.btn_addItem.ColorContrastOnHover = 45;
            this.btn_addItem.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_addItem.CustomizableEdges = borderEdges1;
            this.btn_addItem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_addItem.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_addItem.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_addItem.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_addItem.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btn_addItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addItem.ForeColor = System.Drawing.Color.White;
            this.btn_addItem.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addItem.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_addItem.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_addItem.IconMarginLeft = 11;
            this.btn_addItem.IconPadding = 10;
            this.btn_addItem.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addItem.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_addItem.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_addItem.IconSize = 25;
            this.btn_addItem.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_addItem.IdleBorderRadius = 35;
            this.btn_addItem.IdleBorderThickness = 1;
            this.btn_addItem.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(79)))));
            this.btn_addItem.IdleIconLeftImage = null;
            this.btn_addItem.IdleIconRightImage = null;
            this.btn_addItem.IndicateFocus = false;
            this.btn_addItem.Location = new System.Drawing.Point(948, 254);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_addItem.OnDisabledState.BorderRadius = 35;
            this.btn_addItem.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_addItem.OnDisabledState.BorderThickness = 1;
            this.btn_addItem.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_addItem.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_addItem.OnDisabledState.IconLeftImage = null;
            this.btn_addItem.OnDisabledState.IconRightImage = null;
            this.btn_addItem.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_addItem.onHoverState.BorderRadius = 35;
            this.btn_addItem.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_addItem.onHoverState.BorderThickness = 1;
            this.btn_addItem.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_addItem.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_addItem.onHoverState.IconLeftImage = null;
            this.btn_addItem.onHoverState.IconRightImage = null;
            this.btn_addItem.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_addItem.OnIdleState.BorderRadius = 35;
            this.btn_addItem.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_addItem.OnIdleState.BorderThickness = 1;
            this.btn_addItem.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(79)))));
            this.btn_addItem.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_addItem.OnIdleState.IconLeftImage = null;
            this.btn_addItem.OnIdleState.IconRightImage = null;
            this.btn_addItem.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_addItem.OnPressedState.BorderRadius = 35;
            this.btn_addItem.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_addItem.OnPressedState.BorderThickness = 1;
            this.btn_addItem.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_addItem.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_addItem.OnPressedState.IconLeftImage = null;
            this.btn_addItem.OnPressedState.IconRightImage = null;
            this.btn_addItem.Size = new System.Drawing.Size(118, 39);
            this.btn_addItem.TabIndex = 14;
            this.btn_addItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_addItem.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_addItem.TextMarginLeft = 0;
            this.btn_addItem.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_addItem.UseDefaultRadiusAndThickness = true;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(840, 672);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total : Rs.";
            // 
            // lbl_tot
            // 
            this.lbl_tot.AutoSize = true;
            this.lbl_tot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_tot.Location = new System.Drawing.Point(943, 672);
            this.lbl_tot.Name = "lbl_tot";
            this.lbl_tot.Size = new System.Drawing.Size(0, 25);
            this.lbl_tot.TabIndex = 16;
            // 
            // btn_CreateOrder
            // 
            this.btn_CreateOrder.AllowAnimations = true;
            this.btn_CreateOrder.AllowMouseEffects = true;
            this.btn_CreateOrder.AllowToggling = false;
            this.btn_CreateOrder.AnimationSpeed = 200;
            this.btn_CreateOrder.AutoGenerateColors = false;
            this.btn_CreateOrder.AutoRoundBorders = false;
            this.btn_CreateOrder.AutoSizeLeftIcon = true;
            this.btn_CreateOrder.AutoSizeRightIcon = true;
            this.btn_CreateOrder.BackColor = System.Drawing.Color.Transparent;
            this.btn_CreateOrder.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(79)))));
            this.btn_CreateOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CreateOrder.BackgroundImage")));
            this.btn_CreateOrder.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_CreateOrder.ButtonText = "Create Order";
            this.btn_CreateOrder.ButtonTextMarginLeft = 0;
            this.btn_CreateOrder.ColorContrastOnClick = 45;
            this.btn_CreateOrder.ColorContrastOnHover = 45;
            this.btn_CreateOrder.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_CreateOrder.CustomizableEdges = borderEdges2;
            this.btn_CreateOrder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_CreateOrder.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_CreateOrder.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_CreateOrder.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_CreateOrder.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btn_CreateOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateOrder.ForeColor = System.Drawing.Color.White;
            this.btn_CreateOrder.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CreateOrder.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_CreateOrder.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_CreateOrder.IconMarginLeft = 11;
            this.btn_CreateOrder.IconPadding = 10;
            this.btn_CreateOrder.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CreateOrder.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_CreateOrder.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_CreateOrder.IconSize = 25;
            this.btn_CreateOrder.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_CreateOrder.IdleBorderRadius = 35;
            this.btn_CreateOrder.IdleBorderThickness = 1;
            this.btn_CreateOrder.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(79)))));
            this.btn_CreateOrder.IdleIconLeftImage = null;
            this.btn_CreateOrder.IdleIconRightImage = null;
            this.btn_CreateOrder.IndicateFocus = false;
            this.btn_CreateOrder.Location = new System.Drawing.Point(507, 717);
            this.btn_CreateOrder.Name = "btn_CreateOrder";
            this.btn_CreateOrder.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_CreateOrder.OnDisabledState.BorderRadius = 35;
            this.btn_CreateOrder.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_CreateOrder.OnDisabledState.BorderThickness = 1;
            this.btn_CreateOrder.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_CreateOrder.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_CreateOrder.OnDisabledState.IconLeftImage = null;
            this.btn_CreateOrder.OnDisabledState.IconRightImage = null;
            this.btn_CreateOrder.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_CreateOrder.onHoverState.BorderRadius = 35;
            this.btn_CreateOrder.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_CreateOrder.onHoverState.BorderThickness = 1;
            this.btn_CreateOrder.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_CreateOrder.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_CreateOrder.onHoverState.IconLeftImage = null;
            this.btn_CreateOrder.onHoverState.IconRightImage = null;
            this.btn_CreateOrder.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_CreateOrder.OnIdleState.BorderRadius = 35;
            this.btn_CreateOrder.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_CreateOrder.OnIdleState.BorderThickness = 1;
            this.btn_CreateOrder.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(79)))));
            this.btn_CreateOrder.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_CreateOrder.OnIdleState.IconLeftImage = null;
            this.btn_CreateOrder.OnIdleState.IconRightImage = null;
            this.btn_CreateOrder.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_CreateOrder.OnPressedState.BorderRadius = 35;
            this.btn_CreateOrder.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_CreateOrder.OnPressedState.BorderThickness = 1;
            this.btn_CreateOrder.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_CreateOrder.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_CreateOrder.OnPressedState.IconLeftImage = null;
            this.btn_CreateOrder.OnPressedState.IconRightImage = null;
            this.btn_CreateOrder.Size = new System.Drawing.Size(150, 39);
            this.btn_CreateOrder.TabIndex = 17;
            this.btn_CreateOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CreateOrder.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_CreateOrder.TextMarginLeft = 0;
            this.btn_CreateOrder.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_CreateOrder.UseDefaultRadiusAndThickness = true;
            this.btn_CreateOrder.Click += new System.EventHandler(this.btn_CreateOrder_Click);
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_close.Location = new System.Drawing.Point(1101, 9);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(43, 42);
            this.lbl_close.TabIndex = 18;
            this.lbl_close.Text = "X";
            this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click);
            // 
            // order_CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1156, 780);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.btn_CreateOrder);
            this.Controls.Add(this.lbl_tot);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_addItem);
            this.Controls.Add(this.orderItemsGrid);
            this.Controls.Add(this.txtBox_qty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbBox_itemName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbBox_category);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbBox_Supplier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBox_brand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "order_CreateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "order_CreateOrder";
            this.Load += new System.EventHandler(this.order_CreateOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txt_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBox_brand;
        private System.Windows.Forms.ComboBox cmbBox_Supplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBox_category;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBox_itemName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.UI.WinForms.BunifuTextBox txtBox_qty;
        private Bunifu.UI.WinForms.BunifuDataGridView orderItemsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_addItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_tot;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_CreateOrder;
        private System.Windows.Forms.Label lbl_close;
    }
}