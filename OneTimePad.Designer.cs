namespace randfip
{
    partial class OneTimePad
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
            this.cmdGenPad = new System.Windows.Forms.Button();
            this.txtKeys = new System.Windows.Forms.TextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.lblPrintMsg = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdHelp = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.grpKeySettings = new System.Windows.Forms.GroupBox();
            this.rdoWeak = new System.Windows.Forms.RadioButton();
            this.rdoMedium = new System.Windows.Forms.RadioButton();
            this.rdoStrong = new System.Windows.Forms.RadioButton();
            this.cboExpire = new System.Windows.Forms.ComboBox();
            this.lblExpire = new System.Windows.Forms.Label();
            this.lblExpireMsg = new System.Windows.Forms.Label();
            this.grpKeySettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdGenPad
            // 
            this.cmdGenPad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdGenPad.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdGenPad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.cmdGenPad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGenPad.Location = new System.Drawing.Point(945, 12);
            this.cmdGenPad.Name = "cmdGenPad";
            this.cmdGenPad.Size = new System.Drawing.Size(75, 23);
            this.cmdGenPad.TabIndex = 0;
            this.cmdGenPad.Text = "Gen Pad";
            this.cmdGenPad.UseVisualStyleBackColor = true;
            this.cmdGenPad.Click += new System.EventHandler(this.cmdGenPad_Click);
            // 
            // txtKeys
            // 
            this.txtKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeys.Location = new System.Drawing.Point(11, 13);
            this.txtKeys.Multiline = true;
            this.txtKeys.Name = "txtKeys";
            this.txtKeys.Size = new System.Drawing.Size(660, 557);
            this.txtKeys.TabIndex = 1;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // cmdPrint
            // 
            this.cmdPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPrint.Location = new System.Drawing.Point(944, 70);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(75, 23);
            this.cmdPrint.TabIndex = 3;
            this.cmdPrint.Text = "Print Pad";
            this.cmdPrint.UseVisualStyleBackColor = true;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // lblPrintMsg
            // 
            this.lblPrintMsg.ForeColor = System.Drawing.Color.Black;
            this.lblPrintMsg.Location = new System.Drawing.Point(942, 178);
            this.lblPrintMsg.Name = "lblPrintMsg";
            this.lblPrintMsg.Size = new System.Drawing.Size(86, 237);
            this.lblPrintMsg.TabIndex = 4;
            this.lblPrintMsg.Click += new System.EventHandler(this.lblPrintMsg_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose.Location = new System.Drawing.Point(945, 41);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 5;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdHelp
            // 
            this.cmdHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdHelp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.cmdHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdHelp.Location = new System.Drawing.Point(945, 152);
            this.cmdHelp.Name = "cmdHelp";
            this.cmdHelp.Size = new System.Drawing.Size(75, 23);
            this.cmdHelp.TabIndex = 7;
            this.cmdHelp.Text = "Help";
            this.cmdHelp.UseVisualStyleBackColor = true;
            this.cmdHelp.Click += new System.EventHandler(this.cmdHelp_Click);
            // 
            // grpKeySettings
            // 
            this.grpKeySettings.Controls.Add(this.lblExpireMsg);
            this.grpKeySettings.Controls.Add(this.lblExpire);
            this.grpKeySettings.Controls.Add(this.cboExpire);
            this.grpKeySettings.Controls.Add(this.rdoStrong);
            this.grpKeySettings.Controls.Add(this.rdoMedium);
            this.grpKeySettings.Controls.Add(this.rdoWeak);
            this.grpKeySettings.Location = new System.Drawing.Point(690, 13);
            this.grpKeySettings.Name = "grpKeySettings";
            this.grpKeySettings.Size = new System.Drawing.Size(246, 118);
            this.grpKeySettings.TabIndex = 8;
            this.grpKeySettings.TabStop = false;
            this.grpKeySettings.Text = "Key Settings";
            // 
            // rdoWeak
            // 
            this.rdoWeak.AutoSize = true;
            this.rdoWeak.Location = new System.Drawing.Point(17, 28);
            this.rdoWeak.Name = "rdoWeak";
            this.rdoWeak.Size = new System.Drawing.Size(54, 17);
            this.rdoWeak.TabIndex = 0;
            this.rdoWeak.TabStop = true;
            this.rdoWeak.Text = "Weak";
            this.rdoWeak.UseVisualStyleBackColor = true;
            // 
            // rdoMedium
            // 
            this.rdoMedium.AutoSize = true;
            this.rdoMedium.Location = new System.Drawing.Point(17, 54);
            this.rdoMedium.Name = "rdoMedium";
            this.rdoMedium.Size = new System.Drawing.Size(62, 17);
            this.rdoMedium.TabIndex = 1;
            this.rdoMedium.TabStop = true;
            this.rdoMedium.Text = "Medium";
            this.rdoMedium.UseVisualStyleBackColor = true;
            // 
            // rdoStrong
            // 
            this.rdoStrong.AutoSize = true;
            this.rdoStrong.Location = new System.Drawing.Point(17, 80);
            this.rdoStrong.Name = "rdoStrong";
            this.rdoStrong.Size = new System.Drawing.Size(56, 17);
            this.rdoStrong.TabIndex = 2;
            this.rdoStrong.TabStop = true;
            this.rdoStrong.Text = "Strong";
            this.rdoStrong.UseVisualStyleBackColor = true;
            // 
            // cboExpire
            // 
            this.cboExpire.FormattingEnabled = true;
            this.cboExpire.Items.AddRange(new object[] {
            "1 hour",
            "1 day",
            "1 week",
            "1 month"});
            this.cboExpire.Location = new System.Drawing.Point(95, 30);
            this.cboExpire.Name = "cboExpire";
            this.cboExpire.Size = new System.Drawing.Size(121, 21);
            this.cboExpire.TabIndex = 3;
            this.cboExpire.SelectedIndexChanged += new System.EventHandler(this.cboExpire_SelectedIndexChanged);
            // 
            // lblExpire
            // 
            this.lblExpire.AutoSize = true;
            this.lblExpire.Location = new System.Drawing.Point(95, 11);
            this.lblExpire.Name = "lblExpire";
            this.lblExpire.Size = new System.Drawing.Size(72, 13);
            this.lblExpire.TabIndex = 4;
            this.lblExpire.Text = "Expire Setting";
            // 
            // lblExpireMsg
            // 
            this.lblExpireMsg.Location = new System.Drawing.Point(95, 58);
            this.lblExpireMsg.Name = "lblExpireMsg";
            this.lblExpireMsg.Size = new System.Drawing.Size(145, 57);
            this.lblExpireMsg.TabIndex = 5;
            // 
            // OneTimePad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1032, 581);
            this.ControlBox = false;
            this.Controls.Add(this.grpKeySettings);
            this.Controls.Add(this.cmdHelp);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.lblPrintMsg);
            this.Controls.Add(this.cmdPrint);
            this.Controls.Add(this.txtKeys);
            this.Controls.Add(this.cmdGenPad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OneTimePad";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "One Time Pad Generator";
            this.Load += new System.EventHandler(this.OneTimePad_Load);
            this.grpKeySettings.ResumeLayout(false);
            this.grpKeySettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdGenPad;
        private System.Windows.Forms.TextBox txtKeys;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button cmdPrint;
        private System.Windows.Forms.Label lblPrintMsg;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdHelp;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.GroupBox grpKeySettings;
        private System.Windows.Forms.RadioButton rdoStrong;
        private System.Windows.Forms.RadioButton rdoMedium;
        private System.Windows.Forms.RadioButton rdoWeak;
        private System.Windows.Forms.Label lblExpire;
        private System.Windows.Forms.ComboBox cboExpire;
        private System.Windows.Forms.Label lblExpireMsg;
    }
}

