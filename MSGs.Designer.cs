namespace DMDG
{
    partial class MSGs
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
            this.txtClear = new System.Windows.Forms.TextBox();
            this.txtCrypt = new System.Windows.Forms.TextBox();
            this.cmdDecrypt = new System.Windows.Forms.Button();
            this.cmdEncrypt = new System.Windows.Forms.Button();
            this.txtDoDadDo = new System.Windows.Forms.TextBox();
            this.gbDecrypted = new System.Windows.Forms.GroupBox();
            this.cmdEraseDecrypted = new System.Windows.Forms.Button();
            this.gbEnterKey = new System.Windows.Forms.GroupBox();
            this.cmdEraseKey = new System.Windows.Forms.Button();
            this.gbEncrypted = new System.Windows.Forms.GroupBox();
            this.cmdEraseEncrypted = new System.Windows.Forms.Button();
            this.cmdImportFile = new System.Windows.Forms.Button();
            this.gbTimeExposure = new System.Windows.Forms.GroupBox();
            this.lblStartTimeLabel = new System.Windows.Forms.Label();
            this.lblCurrentTimeLabel = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mnuOneTimePad = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtCompress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboStrenght = new System.Windows.Forms.ComboBox();
            this.lblNumMsgsLabel = new System.Windows.Forms.Label();
            this.lblNumMsgs = new System.Windows.Forms.Label();
            this.gbDecrypted.SuspendLayout();
            this.gbEnterKey.SuspendLayout();
            this.gbEncrypted.SuspendLayout();
            this.gbTimeExposure.SuspendLayout();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtClear
            // 
            this.txtClear.Location = new System.Drawing.Point(9, 19);
            this.txtClear.Multiline = true;
            this.txtClear.Name = "txtClear";
            this.txtClear.Size = new System.Drawing.Size(729, 151);
            this.txtClear.TabIndex = 0;
            // 
            // txtCrypt
            // 
            this.txtCrypt.Location = new System.Drawing.Point(6, 19);
            this.txtCrypt.Multiline = true;
            this.txtCrypt.Name = "txtCrypt";
            this.txtCrypt.Size = new System.Drawing.Size(732, 161);
            this.txtCrypt.TabIndex = 1;
            // 
            // cmdDecrypt
            // 
            this.cmdDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdDecrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDecrypt.Location = new System.Drawing.Point(124, 187);
            this.cmdDecrypt.Name = "cmdDecrypt";
            this.cmdDecrypt.Size = new System.Drawing.Size(116, 23);
            this.cmdDecrypt.TabIndex = 4;
            this.cmdDecrypt.Text = "Decrypt Message";
            this.cmdDecrypt.UseVisualStyleBackColor = true;
            this.cmdDecrypt.Click += new System.EventHandler(this.cmdDecrypt_Click);
            // 
            // cmdEncrypt
            // 
            this.cmdEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdEncrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEncrypt.Location = new System.Drawing.Point(21, 176);
            this.cmdEncrypt.Name = "cmdEncrypt";
            this.cmdEncrypt.Size = new System.Drawing.Size(116, 23);
            this.cmdEncrypt.TabIndex = 5;
            this.cmdEncrypt.Text = "Encrypt Message";
            this.cmdEncrypt.UseVisualStyleBackColor = true;
            this.cmdEncrypt.Click += new System.EventHandler(this.cmdEncrypt_Click);
            // 
            // txtDoDadDo
            // 
            this.txtDoDadDo.Location = new System.Drawing.Point(66, 17);
            this.txtDoDadDo.Name = "txtDoDadDo";
            this.txtDoDadDo.Size = new System.Drawing.Size(226, 20);
            this.txtDoDadDo.TabIndex = 6;
            // 
            // gbDecrypted
            // 
            this.gbDecrypted.Controls.Add(this.cmdEraseDecrypted);
            this.gbDecrypted.Controls.Add(this.txtClear);
            this.gbDecrypted.Controls.Add(this.cmdEncrypt);
            this.gbDecrypted.Location = new System.Drawing.Point(9, 211);
            this.gbDecrypted.Name = "gbDecrypted";
            this.gbDecrypted.Size = new System.Drawing.Size(752, 206);
            this.gbDecrypted.TabIndex = 7;
            this.gbDecrypted.TabStop = false;
            this.gbDecrypted.Text = "Enter message below:";
            // 
            // cmdEraseDecrypted
            // 
            this.cmdEraseDecrypted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdEraseDecrypted.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdEraseDecrypted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEraseDecrypted.Location = new System.Drawing.Point(152, 176);
            this.cmdEraseDecrypted.Name = "cmdEraseDecrypted";
            this.cmdEraseDecrypted.Size = new System.Drawing.Size(116, 23);
            this.cmdEraseDecrypted.TabIndex = 6;
            this.cmdEraseDecrypted.Text = "Erase Message";
            this.cmdEraseDecrypted.UseVisualStyleBackColor = true;
            this.cmdEraseDecrypted.Click += new System.EventHandler(this.cmdEraseDecrypted_Click);
            // 
            // gbEnterKey
            // 
            this.gbEnterKey.Controls.Add(this.cboStrenght);
            this.gbEnterKey.Controls.Add(this.label3);
            this.gbEnterKey.Controls.Add(this.label2);
            this.gbEnterKey.Controls.Add(this.label1);
            this.gbEnterKey.Controls.Add(this.txtCompress);
            this.gbEnterKey.Controls.Add(this.txtCode);
            this.gbEnterKey.Controls.Add(this.cmdEraseKey);
            this.gbEnterKey.Controls.Add(this.txtDoDadDo);
            this.gbEnterKey.Location = new System.Drawing.Point(9, 42);
            this.gbEnterKey.Name = "gbEnterKey";
            this.gbEnterKey.Size = new System.Drawing.Size(314, 157);
            this.gbEnterKey.TabIndex = 8;
            this.gbEnterKey.TabStop = false;
            this.gbEnterKey.Text = "Enter values from one time pad:";
            // 
            // cmdEraseKey
            // 
            this.cmdEraseKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdEraseKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdEraseKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEraseKey.Location = new System.Drawing.Point(14, 122);
            this.cmdEraseKey.Name = "cmdEraseKey";
            this.cmdEraseKey.Size = new System.Drawing.Size(116, 23);
            this.cmdEraseKey.TabIndex = 7;
            this.cmdEraseKey.Text = "Erase Values";
            this.cmdEraseKey.UseVisualStyleBackColor = true;
            this.cmdEraseKey.Click += new System.EventHandler(this.cmdEraseKey_Click);
            // 
            // gbEncrypted
            // 
            this.gbEncrypted.Controls.Add(this.cmdEraseEncrypted);
            this.gbEncrypted.Controls.Add(this.cmdImportFile);
            this.gbEncrypted.Controls.Add(this.txtCrypt);
            this.gbEncrypted.Controls.Add(this.cmdDecrypt);
            this.gbEncrypted.Location = new System.Drawing.Point(9, 423);
            this.gbEncrypted.Name = "gbEncrypted";
            this.gbEncrypted.Size = new System.Drawing.Size(752, 216);
            this.gbEncrypted.TabIndex = 9;
            this.gbEncrypted.TabStop = false;
            this.gbEncrypted.Text = "Enter encrypted message below:";
            // 
            // cmdEraseEncrypted
            // 
            this.cmdEraseEncrypted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdEraseEncrypted.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdEraseEncrypted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEraseEncrypted.Location = new System.Drawing.Point(242, 187);
            this.cmdEraseEncrypted.Name = "cmdEraseEncrypted";
            this.cmdEraseEncrypted.Size = new System.Drawing.Size(116, 23);
            this.cmdEraseEncrypted.TabIndex = 5;
            this.cmdEraseEncrypted.Text = "Erase Message";
            this.cmdEraseEncrypted.UseVisualStyleBackColor = true;
            this.cmdEraseEncrypted.Click += new System.EventHandler(this.cmdEraseEncrypted_Click);
            // 
            // cmdImportFile
            // 
            this.cmdImportFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdImportFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdImportFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdImportFile.Location = new System.Drawing.Point(6, 187);
            this.cmdImportFile.Name = "cmdImportFile";
            this.cmdImportFile.Size = new System.Drawing.Size(116, 23);
            this.cmdImportFile.TabIndex = 10;
            this.cmdImportFile.Text = "Import Encrypted File";
            this.cmdImportFile.UseVisualStyleBackColor = true;
            this.cmdImportFile.Click += new System.EventHandler(this.cmdImportFile_Click);
            // 
            // gbTimeExposure
            // 
            this.gbTimeExposure.Controls.Add(this.lblNumMsgs);
            this.gbTimeExposure.Controls.Add(this.lblNumMsgsLabel);
            this.gbTimeExposure.Controls.Add(this.lblStartTimeLabel);
            this.gbTimeExposure.Controls.Add(this.lblCurrentTimeLabel);
            this.gbTimeExposure.Controls.Add(this.lblStartTime);
            this.gbTimeExposure.Controls.Add(this.lblTime);
            this.gbTimeExposure.Location = new System.Drawing.Point(329, 42);
            this.gbTimeExposure.Name = "gbTimeExposure";
            this.gbTimeExposure.Size = new System.Drawing.Size(432, 157);
            this.gbTimeExposure.TabIndex = 11;
            this.gbTimeExposure.TabStop = false;
            this.gbTimeExposure.Text = "Time Exposure";
            // 
            // lblStartTimeLabel
            // 
            this.lblStartTimeLabel.AutoSize = true;
            this.lblStartTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTimeLabel.Location = new System.Drawing.Point(7, 50);
            this.lblStartTimeLabel.Name = "lblStartTimeLabel";
            this.lblStartTimeLabel.Size = new System.Drawing.Size(69, 13);
            this.lblStartTimeLabel.TabIndex = 13;
            this.lblStartTimeLabel.Text = "Start Time:";
            // 
            // lblCurrentTimeLabel
            // 
            this.lblCurrentTimeLabel.AutoSize = true;
            this.lblCurrentTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTimeLabel.Location = new System.Drawing.Point(7, 20);
            this.lblCurrentTimeLabel.Name = "lblCurrentTimeLabel";
            this.lblCurrentTimeLabel.Size = new System.Drawing.Size(83, 13);
            this.lblCurrentTimeLabel.TabIndex = 12;
            this.lblCurrentTimeLabel.Text = "Current Time:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.Location = new System.Drawing.Point(98, 48);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(141, 23);
            this.lblStartTime.TabIndex = 11;
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(98, 20);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(141, 23);
            this.lblTime.TabIndex = 10;
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOneTimePad});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(773, 24);
            this.mnuMenu.TabIndex = 12;
            this.mnuMenu.Text = "Menu";
            // 
            // mnuOneTimePad
            // 
            this.mnuOneTimePad.Name = "mnuOneTimePad";
            this.mnuOneTimePad.Size = new System.Drawing.Size(164, 20);
            this.mnuOneTimePad.Text = "Generate new one time pad";
            this.mnuOneTimePad.Click += new System.EventHandler(this.mnuOneTimePad_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(66, 50);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(226, 20);
            this.txtCode.TabIndex = 6;
            // 
            // txtCompress
            // 
            this.txtCompress.Location = new System.Drawing.Point(66, 83);
            this.txtCompress.Name = "txtCompress";
            this.txtCompress.Size = new System.Drawing.Size(226, 20);
            this.txtCompress.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Compress";
            // 
            // cboStrenght
            // 
            this.cboStrenght.FormattingEnabled = true;
            this.cboStrenght.Items.AddRange(new object[] {
            "Weak",
            "Medium",
            "Strong"});
            this.cboStrenght.Location = new System.Drawing.Point(152, 122);
            this.cboStrenght.Name = "cboStrenght";
            this.cboStrenght.Size = new System.Drawing.Size(121, 21);
            this.cboStrenght.TabIndex = 11;
            this.cboStrenght.SelectedIndexChanged += new System.EventHandler(this.cboStrenght_SelectedIndexChanged);
            // 
            // lblNumMsgsLabel
            // 
            this.lblNumMsgsLabel.AutoSize = true;
            this.lblNumMsgsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMsgsLabel.Location = new System.Drawing.Point(7, 83);
            this.lblNumMsgsLabel.Name = "lblNumMsgsLabel";
            this.lblNumMsgsLabel.Size = new System.Drawing.Size(67, 13);
            this.lblNumMsgsLabel.TabIndex = 14;
            this.lblNumMsgsLabel.Text = "Messages:";
            // 
            // lblNumMsgs
            // 
            this.lblNumMsgs.Location = new System.Drawing.Point(98, 80);
            this.lblNumMsgs.Name = "lblNumMsgs";
            this.lblNumMsgs.Size = new System.Drawing.Size(141, 23);
            this.lblNumMsgs.TabIndex = 15;
            // 
            // MSGs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(773, 650);
            this.Controls.Add(this.gbTimeExposure);
            this.Controls.Add(this.gbEncrypted);
            this.Controls.Add(this.gbEnterKey);
            this.Controls.Add(this.gbDecrypted);
            this.Controls.Add(this.mnuMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "MSGs";
            this.ShowIcon = false;
            this.Text = "Encrypt - Decrypt Messages";
            this.Load += new System.EventHandler(this.MSGs_Load);
            this.gbDecrypted.ResumeLayout(false);
            this.gbDecrypted.PerformLayout();
            this.gbEnterKey.ResumeLayout(false);
            this.gbEnterKey.PerformLayout();
            this.gbEncrypted.ResumeLayout(false);
            this.gbEncrypted.PerformLayout();
            this.gbTimeExposure.ResumeLayout(false);
            this.gbTimeExposure.PerformLayout();
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClear;
        private System.Windows.Forms.TextBox txtCrypt;
        private System.Windows.Forms.Button cmdDecrypt;
        private System.Windows.Forms.Button cmdEncrypt;
        private System.Windows.Forms.TextBox txtDoDadDo;
        private System.Windows.Forms.GroupBox gbDecrypted;
        private System.Windows.Forms.GroupBox gbEnterKey;
        private System.Windows.Forms.GroupBox gbEncrypted;
        private System.Windows.Forms.Button cmdImportFile;
        private System.Windows.Forms.Button cmdEraseEncrypted;
        private System.Windows.Forms.Button cmdEraseDecrypted;
        private System.Windows.Forms.GroupBox gbTimeExposure;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblStartTimeLabel;
        private System.Windows.Forms.Label lblCurrentTimeLabel;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuOneTimePad;
        private System.Windows.Forms.Button cmdEraseKey;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtCompress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStrenght;
        private System.Windows.Forms.Label lblNumMsgs;
        private System.Windows.Forms.Label lblNumMsgsLabel;
    }
}

