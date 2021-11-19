
namespace Computer_Managment_System.Forms.Anuththara
{
    partial class ServiceRepair_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceRepair_Report));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dp_generatorDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.txt_generatorName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_generate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.serviceReport = new Bunifu.Reports.BunifuReports(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lbl_close = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.dp_generatorDate);
            this.panel1.Controls.Add(this.txt_generatorName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_generate);
            this.panel1.Location = new System.Drawing.Point(42, 96);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 202);
            this.panel1.TabIndex = 8;
            // 
            // dp_generatorDate
            // 
            this.dp_generatorDate.BackColor = System.Drawing.Color.White;
            this.dp_generatorDate.BorderColor = System.Drawing.Color.Silver;
            this.dp_generatorDate.BorderRadius = 0;
            this.dp_generatorDate.Color = System.Drawing.Color.Silver;
            this.dp_generatorDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dp_generatorDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dp_generatorDate.DisabledColor = System.Drawing.Color.Gray;
            this.dp_generatorDate.DisplayWeekNumbers = false;
            this.dp_generatorDate.DPHeight = 0;
            this.dp_generatorDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dp_generatorDate.FillDatePicker = false;
            this.dp_generatorDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dp_generatorDate.ForeColor = System.Drawing.Color.Black;
            this.dp_generatorDate.Icon = ((System.Drawing.Image)(resources.GetObject("dp_generatorDate.Icon")));
            this.dp_generatorDate.IconColor = System.Drawing.Color.Black;
            this.dp_generatorDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dp_generatorDate.LeftTextMargin = 5;
            this.dp_generatorDate.Location = new System.Drawing.Point(138, 97);
            this.dp_generatorDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dp_generatorDate.MinimumSize = new System.Drawing.Size(4, 32);
            this.dp_generatorDate.Name = "dp_generatorDate";
            this.dp_generatorDate.Size = new System.Drawing.Size(242, 32);
            this.dp_generatorDate.TabIndex = 3;
            this.dp_generatorDate.Value = new System.DateTime(2021, 10, 10, 2, 49, 0, 0);
            // 
            // txt_generatorName
            // 
            this.txt_generatorName.AcceptsReturn = false;
            this.txt_generatorName.AcceptsTab = false;
            this.txt_generatorName.AnimationSpeed = 200;
            this.txt_generatorName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_generatorName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_generatorName.AutoSizeHeight = true;
            this.txt_generatorName.BackColor = System.Drawing.Color.Transparent;
            this.txt_generatorName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_generatorName.BackgroundImage")));
            this.txt_generatorName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_generatorName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_generatorName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_generatorName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_generatorName.BorderRadius = 1;
            this.txt_generatorName.BorderThickness = 1;
            this.txt_generatorName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_generatorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_generatorName.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_generatorName.DefaultText = "";
            this.txt_generatorName.FillColor = System.Drawing.Color.White;
            this.txt_generatorName.HideSelection = true;
            this.txt_generatorName.IconLeft = null;
            this.txt_generatorName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_generatorName.IconPadding = 10;
            this.txt_generatorName.IconRight = null;
            this.txt_generatorName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_generatorName.Lines = new string[0];
            this.txt_generatorName.Location = new System.Drawing.Point(138, 42);
            this.txt_generatorName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_generatorName.MaxLength = 32767;
            this.txt_generatorName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_generatorName.Modified = false;
            this.txt_generatorName.Multiline = false;
            this.txt_generatorName.Name = "txt_generatorName";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_generatorName.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_generatorName.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_generatorName.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_generatorName.OnIdleState = stateProperties4;
            this.txt_generatorName.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_generatorName.PasswordChar = '\0';
            this.txt_generatorName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_generatorName.PlaceholderText = "Mr/Ms";
            this.txt_generatorName.ReadOnly = false;
            this.txt_generatorName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_generatorName.SelectedText = "";
            this.txt_generatorName.SelectionLength = 0;
            this.txt_generatorName.SelectionStart = 0;
            this.txt_generatorName.ShortcutsEnabled = true;
            this.txt_generatorName.Size = new System.Drawing.Size(241, 30);
            this.txt_generatorName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_generatorName.TabIndex = 2;
            this.txt_generatorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_generatorName.TextMarginBottom = 0;
            this.txt_generatorName.TextMarginLeft = 3;
            this.txt_generatorName.TextMarginTop = 1;
            this.txt_generatorName.TextPlaceholder = "Mr/Ms";
            this.txt_generatorName.UseSystemPasswordChar = false;
            this.txt_generatorName.WordWrap = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(34, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Generator Name";
            // 
            // btn_generate
            // 
            this.btn_generate.AllowAnimations = true;
            this.btn_generate.AllowMouseEffects = true;
            this.btn_generate.AllowToggling = false;
            this.btn_generate.AnimationSpeed = 200;
            this.btn_generate.AutoGenerateColors = false;
            this.btn_generate.AutoRoundBorders = false;
            this.btn_generate.AutoSizeLeftIcon = true;
            this.btn_generate.AutoSizeRightIcon = true;
            this.btn_generate.BackColor = System.Drawing.Color.Transparent;
            this.btn_generate.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_generate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_generate.BackgroundImage")));
            this.btn_generate.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_generate.ButtonText = "Generate";
            this.btn_generate.ButtonTextMarginLeft = 0;
            this.btn_generate.ColorContrastOnClick = 45;
            this.btn_generate.ColorContrastOnHover = 45;
            this.btn_generate.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_generate.CustomizableEdges = borderEdges1;
            this.btn_generate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_generate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_generate.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_generate.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_generate.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btn_generate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_generate.ForeColor = System.Drawing.Color.White;
            this.btn_generate.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_generate.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_generate.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_generate.IconMarginLeft = 11;
            this.btn_generate.IconPadding = 10;
            this.btn_generate.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_generate.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_generate.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_generate.IconSize = 25;
            this.btn_generate.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_generate.IdleBorderRadius = 30;
            this.btn_generate.IdleBorderThickness = 1;
            this.btn_generate.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_generate.IdleIconLeftImage = null;
            this.btn_generate.IdleIconRightImage = null;
            this.btn_generate.IndicateFocus = false;
            this.btn_generate.Location = new System.Drawing.Point(250, 150);
            this.btn_generate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_generate.OnDisabledState.BorderRadius = 30;
            this.btn_generate.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_generate.OnDisabledState.BorderThickness = 1;
            this.btn_generate.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_generate.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_generate.OnDisabledState.IconLeftImage = null;
            this.btn_generate.OnDisabledState.IconRightImage = null;
            this.btn_generate.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_generate.onHoverState.BorderRadius = 30;
            this.btn_generate.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_generate.onHoverState.BorderThickness = 1;
            this.btn_generate.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_generate.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_generate.onHoverState.IconLeftImage = null;
            this.btn_generate.onHoverState.IconRightImage = null;
            this.btn_generate.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_generate.OnIdleState.BorderRadius = 30;
            this.btn_generate.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_generate.OnIdleState.BorderThickness = 1;
            this.btn_generate.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_generate.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_generate.OnIdleState.IconLeftImage = null;
            this.btn_generate.OnIdleState.IconRightImage = null;
            this.btn_generate.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_generate.OnPressedState.BorderRadius = 30;
            this.btn_generate.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_generate.OnPressedState.BorderThickness = 1;
            this.btn_generate.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_generate.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_generate.OnPressedState.IconLeftImage = null;
            this.btn_generate.OnPressedState.IconRightImage = null;
            this.btn_generate.Size = new System.Drawing.Size(128, 32);
            this.btn_generate.TabIndex = 0;
            this.btn_generate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_generate.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_generate.TextMarginLeft = 0;
            this.btn_generate.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_generate.UseDefaultRadiusAndThickness = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // serviceReport
            // 
            this.serviceReport.AlternativeRowBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.serviceReport.AlternativeRowGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.serviceReport.HeaderBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(183)))), ((int)(((byte)(197)))));
            this.serviceReport.HeaderFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.serviceReport.HeaderGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.serviceReport.RowDefaultBackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.serviceReport.RowDefaultFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.serviceReport.RowDefaultGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_close.Location = new System.Drawing.Point(447, 3);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(43, 42);
            this.lbl_close.TabIndex = 19;
            this.lbl_close.Text = "X";
            this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click);
            // 
            // ServiceRepair_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(490, 379);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ServiceRepair_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiceRepair_Report";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuDatePicker dp_generatorDate;
        private Bunifu.UI.WinForms.BunifuTextBox txt_generatorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_generate;
        private Bunifu.Reports.BunifuReports serviceReport;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lbl_close;
    }
}