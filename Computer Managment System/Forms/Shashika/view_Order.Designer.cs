
namespace Computer_Managment_System
{
    partial class view_Order
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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view_Order));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuPages1 = new Bunifu.UI.WinForms.BunifuPages();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_deleteOrder = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.lbl_totAmount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_OrderUpdate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_Brand = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_OrderID = new System.Windows.Forms.Label();
            this.orderItemGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_close = new System.Windows.Forms.Label();
            this.bunifuPages1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPages1
            // 
            this.bunifuPages1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.bunifuPages1.AllowTransitions = false;
            this.bunifuPages1.Controls.Add(this.tabPage1);
            this.bunifuPages1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPages1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPages1.Multiline = true;
            this.bunifuPages1.Name = "bunifuPages1";
            this.bunifuPages1.Page = this.tabPage1;
            this.bunifuPages1.PageIndex = 0;
            this.bunifuPages1.PageName = "tabPage1";
            this.bunifuPages1.PageTitle = "ViewOrder";
            this.bunifuPages1.SelectedIndex = 0;
            this.bunifuPages1.Size = new System.Drawing.Size(1172, 703);
            this.bunifuPages1.TabIndex = 20;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuPages1.Transition = animation1;
            this.bunifuPages1.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.tabPage1.Controls.Add(this.btn_deleteOrder);
            this.tabPage1.Controls.Add(this.lbl_totAmount);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.btn_OrderUpdate);
            this.tabPage1.Controls.Add(this.lbl_Email);
            this.tabPage1.Controls.Add(this.lbl_Phone);
            this.tabPage1.Controls.Add(this.lbl_Address);
            this.tabPage1.Controls.Add(this.lbl_name);
            this.tabPage1.Controls.Add(this.lbl_Status);
            this.tabPage1.Controls.Add(this.lbl_Brand);
            this.tabPage1.Controls.Add(this.lbl_Date);
            this.tabPage1.Controls.Add(this.lbl_OrderID);
            this.tabPage1.Controls.Add(this.orderItemGrid);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lbl_close);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1164, 677);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ViewOrder";
            // 
            // btn_deleteOrder
            // 
            this.btn_deleteOrder.AllowAnimations = true;
            this.btn_deleteOrder.AllowMouseEffects = true;
            this.btn_deleteOrder.AllowToggling = false;
            this.btn_deleteOrder.AnimationSpeed = 200;
            this.btn_deleteOrder.AutoGenerateColors = false;
            this.btn_deleteOrder.AutoRoundBorders = false;
            this.btn_deleteOrder.AutoSizeLeftIcon = true;
            this.btn_deleteOrder.AutoSizeRightIcon = true;
            this.btn_deleteOrder.BackColor = System.Drawing.Color.Transparent;
            this.btn_deleteOrder.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_deleteOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_deleteOrder.BackgroundImage")));
            this.btn_deleteOrder.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_deleteOrder.ButtonText = "Delete";
            this.btn_deleteOrder.ButtonTextMarginLeft = 0;
            this.btn_deleteOrder.ColorContrastOnClick = 45;
            this.btn_deleteOrder.ColorContrastOnHover = 45;
            this.btn_deleteOrder.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_deleteOrder.CustomizableEdges = borderEdges1;
            this.btn_deleteOrder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_deleteOrder.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_deleteOrder.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_deleteOrder.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_deleteOrder.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btn_deleteOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_deleteOrder.ForeColor = System.Drawing.Color.White;
            this.btn_deleteOrder.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deleteOrder.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_deleteOrder.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_deleteOrder.IconMarginLeft = 11;
            this.btn_deleteOrder.IconPadding = 10;
            this.btn_deleteOrder.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_deleteOrder.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_deleteOrder.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_deleteOrder.IconSize = 25;
            this.btn_deleteOrder.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_deleteOrder.IdleBorderRadius = 1;
            this.btn_deleteOrder.IdleBorderThickness = 1;
            this.btn_deleteOrder.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_deleteOrder.IdleIconLeftImage = null;
            this.btn_deleteOrder.IdleIconRightImage = null;
            this.btn_deleteOrder.IndicateFocus = false;
            this.btn_deleteOrder.Location = new System.Drawing.Point(216, 602);
            this.btn_deleteOrder.Name = "btn_deleteOrder";
            this.btn_deleteOrder.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_deleteOrder.OnDisabledState.BorderRadius = 1;
            this.btn_deleteOrder.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_deleteOrder.OnDisabledState.BorderThickness = 1;
            this.btn_deleteOrder.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_deleteOrder.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_deleteOrder.OnDisabledState.IconLeftImage = null;
            this.btn_deleteOrder.OnDisabledState.IconRightImage = null;
            this.btn_deleteOrder.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_deleteOrder.onHoverState.BorderRadius = 1;
            this.btn_deleteOrder.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_deleteOrder.onHoverState.BorderThickness = 1;
            this.btn_deleteOrder.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_deleteOrder.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_deleteOrder.onHoverState.IconLeftImage = null;
            this.btn_deleteOrder.onHoverState.IconRightImage = null;
            this.btn_deleteOrder.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_deleteOrder.OnIdleState.BorderRadius = 1;
            this.btn_deleteOrder.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_deleteOrder.OnIdleState.BorderThickness = 1;
            this.btn_deleteOrder.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_deleteOrder.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_deleteOrder.OnIdleState.IconLeftImage = null;
            this.btn_deleteOrder.OnIdleState.IconRightImage = null;
            this.btn_deleteOrder.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_deleteOrder.OnPressedState.BorderRadius = 1;
            this.btn_deleteOrder.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_deleteOrder.OnPressedState.BorderThickness = 1;
            this.btn_deleteOrder.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_deleteOrder.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_deleteOrder.OnPressedState.IconLeftImage = null;
            this.btn_deleteOrder.OnPressedState.IconRightImage = null;
            this.btn_deleteOrder.Size = new System.Drawing.Size(150, 39);
            this.btn_deleteOrder.TabIndex = 40;
            this.btn_deleteOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_deleteOrder.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_deleteOrder.TextMarginLeft = 0;
            this.btn_deleteOrder.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_deleteOrder.UseDefaultRadiusAndThickness = true;
            this.btn_deleteOrder.Click += new System.EventHandler(this.btn_deleteOrder_Click);
            // 
            // lbl_totAmount
            // 
            this.lbl_totAmount.AutoSize = true;
            this.lbl_totAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_totAmount.Location = new System.Drawing.Point(948, 578);
            this.lbl_totAmount.Name = "lbl_totAmount";
            this.lbl_totAmount.Size = new System.Drawing.Size(67, 25);
            this.lbl_totAmount.TabIndex = 39;
            this.lbl_totAmount.Text = "Value";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(840, 578);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 25);
            this.label9.TabIndex = 38;
            this.label9.Text = "Total : Rs.";
            // 
            // btn_OrderUpdate
            // 
            this.btn_OrderUpdate.AllowAnimations = true;
            this.btn_OrderUpdate.AllowMouseEffects = true;
            this.btn_OrderUpdate.AllowToggling = false;
            this.btn_OrderUpdate.AnimationSpeed = 200;
            this.btn_OrderUpdate.AutoGenerateColors = false;
            this.btn_OrderUpdate.AutoRoundBorders = false;
            this.btn_OrderUpdate.AutoSizeLeftIcon = true;
            this.btn_OrderUpdate.AutoSizeRightIcon = true;
            this.btn_OrderUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btn_OrderUpdate.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_OrderUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_OrderUpdate.BackgroundImage")));
            this.btn_OrderUpdate.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_OrderUpdate.ButtonText = "Update";
            this.btn_OrderUpdate.ButtonTextMarginLeft = 0;
            this.btn_OrderUpdate.ColorContrastOnClick = 45;
            this.btn_OrderUpdate.ColorContrastOnHover = 45;
            this.btn_OrderUpdate.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_OrderUpdate.CustomizableEdges = borderEdges2;
            this.btn_OrderUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_OrderUpdate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_OrderUpdate.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_OrderUpdate.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_OrderUpdate.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btn_OrderUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_OrderUpdate.ForeColor = System.Drawing.Color.White;
            this.btn_OrderUpdate.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_OrderUpdate.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_OrderUpdate.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_OrderUpdate.IconMarginLeft = 11;
            this.btn_OrderUpdate.IconPadding = 10;
            this.btn_OrderUpdate.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_OrderUpdate.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_OrderUpdate.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_OrderUpdate.IconSize = 25;
            this.btn_OrderUpdate.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_OrderUpdate.IdleBorderRadius = 1;
            this.btn_OrderUpdate.IdleBorderThickness = 1;
            this.btn_OrderUpdate.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_OrderUpdate.IdleIconLeftImage = null;
            this.btn_OrderUpdate.IdleIconRightImage = null;
            this.btn_OrderUpdate.IndicateFocus = false;
            this.btn_OrderUpdate.Location = new System.Drawing.Point(43, 602);
            this.btn_OrderUpdate.Name = "btn_OrderUpdate";
            this.btn_OrderUpdate.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_OrderUpdate.OnDisabledState.BorderRadius = 1;
            this.btn_OrderUpdate.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_OrderUpdate.OnDisabledState.BorderThickness = 1;
            this.btn_OrderUpdate.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_OrderUpdate.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_OrderUpdate.OnDisabledState.IconLeftImage = null;
            this.btn_OrderUpdate.OnDisabledState.IconRightImage = null;
            this.btn_OrderUpdate.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_OrderUpdate.onHoverState.BorderRadius = 1;
            this.btn_OrderUpdate.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_OrderUpdate.onHoverState.BorderThickness = 1;
            this.btn_OrderUpdate.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_OrderUpdate.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_OrderUpdate.onHoverState.IconLeftImage = null;
            this.btn_OrderUpdate.onHoverState.IconRightImage = null;
            this.btn_OrderUpdate.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_OrderUpdate.OnIdleState.BorderRadius = 1;
            this.btn_OrderUpdate.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_OrderUpdate.OnIdleState.BorderThickness = 1;
            this.btn_OrderUpdate.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_OrderUpdate.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_OrderUpdate.OnIdleState.IconLeftImage = null;
            this.btn_OrderUpdate.OnIdleState.IconRightImage = null;
            this.btn_OrderUpdate.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_OrderUpdate.OnPressedState.BorderRadius = 1;
            this.btn_OrderUpdate.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_OrderUpdate.OnPressedState.BorderThickness = 1;
            this.btn_OrderUpdate.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_OrderUpdate.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_OrderUpdate.OnPressedState.IconLeftImage = null;
            this.btn_OrderUpdate.OnPressedState.IconRightImage = null;
            this.btn_OrderUpdate.Size = new System.Drawing.Size(150, 39);
            this.btn_OrderUpdate.TabIndex = 37;
            this.btn_OrderUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_OrderUpdate.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_OrderUpdate.TextMarginLeft = 0;
            this.btn_OrderUpdate.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_OrderUpdate.UseDefaultRadiusAndThickness = true;
            this.btn_OrderUpdate.Click += new System.EventHandler(this.btn_OrderUpdate_Click);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Email.Location = new System.Drawing.Point(135, 202);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(59, 25);
            this.lbl_Email.TabIndex = 36;
            this.lbl_Email.Text = "Value";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Phone.Location = new System.Drawing.Point(135, 164);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(59, 25);
            this.lbl_Phone.TabIndex = 35;
            this.lbl_Phone.Text = "Value";
            // 
            // lbl_Address
            // 
            this.lbl_Address.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Address.Location = new System.Drawing.Point(135, 127);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(518, 25);
            this.lbl_Address.TabIndex = 34;
            this.lbl_Address.Text = "Value";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_name.Location = new System.Drawing.Point(135, 89);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(59, 25);
            this.lbl_name.TabIndex = 33;
            this.lbl_name.Text = "Value";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Status.Location = new System.Drawing.Point(999, 202);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(59, 25);
            this.lbl_Status.TabIndex = 32;
            this.lbl_Status.Text = "Value";
            // 
            // lbl_Brand
            // 
            this.lbl_Brand.AutoSize = true;
            this.lbl_Brand.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Brand.Location = new System.Drawing.Point(999, 164);
            this.lbl_Brand.Name = "lbl_Brand";
            this.lbl_Brand.Size = new System.Drawing.Size(59, 25);
            this.lbl_Brand.TabIndex = 31;
            this.lbl_Brand.Text = "Value";
            // 
            // lbl_Date
            // 
            this.lbl_Date.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Date.Location = new System.Drawing.Point(999, 127);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(125, 25);
            this.lbl_Date.TabIndex = 30;
            this.lbl_Date.Text = "Value";
            // 
            // lbl_OrderID
            // 
            this.lbl_OrderID.AutoSize = true;
            this.lbl_OrderID.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_OrderID.Location = new System.Drawing.Point(999, 89);
            this.lbl_OrderID.Name = "lbl_OrderID";
            this.lbl_OrderID.Size = new System.Drawing.Size(59, 25);
            this.lbl_OrderID.TabIndex = 29;
            this.lbl_OrderID.Text = "Value";
            // 
            // orderItemGrid
            // 
            this.orderItemGrid.AllowCustomTheming = false;
            this.orderItemGrid.AllowUserToAddRows = false;
            this.orderItemGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.orderItemGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.orderItemGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderItemGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderItemGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.orderItemGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderItemGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.orderItemGrid.ColumnHeadersHeight = 40;
            this.orderItemGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.orderItemGrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.orderItemGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.orderItemGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.orderItemGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.orderItemGrid.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.orderItemGrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.orderItemGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.orderItemGrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.orderItemGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.orderItemGrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.orderItemGrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.orderItemGrid.CurrentTheme.Name = null;
            this.orderItemGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.orderItemGrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.orderItemGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.orderItemGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.orderItemGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderItemGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.orderItemGrid.EnableHeadersVisualStyles = false;
            this.orderItemGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.orderItemGrid.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.orderItemGrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.orderItemGrid.HeaderForeColor = System.Drawing.Color.White;
            this.orderItemGrid.Location = new System.Drawing.Point(43, 284);
            this.orderItemGrid.Name = "orderItemGrid";
            this.orderItemGrid.RowHeadersVisible = false;
            this.orderItemGrid.RowTemplate.Height = 40;
            this.orderItemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderItemGrid.Size = new System.Drawing.Size(1071, 269);
            this.orderItemGrid.TabIndex = 28;
            this.orderItemGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(886, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(38, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(38, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Email";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(38, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Phone";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(38, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(886, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Brand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(886, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(886, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Order ID ";
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_close.Location = new System.Drawing.Point(1102, 15);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(43, 42);
            this.lbl_close.TabIndex = 19;
            this.lbl_close.Text = "X";
            this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click_1);
            // 
            // view_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1172, 703);
            this.Controls.Add(this.bunifuPages1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "view_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View";
            this.Load += new System.EventHandler(this.view_Order_Load);
            this.bunifuPages1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPages bunifuPages1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_close;
        private Bunifu.UI.WinForms.BunifuDataGridView orderItemGrid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_Brand;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_OrderID;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_OrderUpdate;
        private System.Windows.Forms.Label lbl_totAmount;
        private System.Windows.Forms.Label label9;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_deleteOrder;
    }
}