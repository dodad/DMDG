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
            this.lblMonth = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.lblPrintMsg = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdHelp = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // cmdGenPad
            // 
            this.cmdGenPad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdGenPad.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdGenPad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.cmdGenPad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGenPad.Location = new System.Drawing.Point(267, 12);
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
            this.txtKeys.Location = new System.Drawing.Point(12, 12);
            this.txtKeys.Multiline = true;
            this.txtKeys.Name = "txtKeys";
            this.txtKeys.Size = new System.Drawing.Size(246, 557);
            this.txtKeys.TabIndex = 1;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(270, 118);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(0, 13);
            this.lblMonth.TabIndex = 2;
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
            this.cmdPrint.Location = new System.Drawing.Point(266, 70);
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
            this.lblPrintMsg.Location = new System.Drawing.Point(264, 178);
            this.lblPrintMsg.Name = "lblPrintMsg";
            this.lblPrintMsg.Size = new System.Drawing.Size(86, 237);
            this.lblPrintMsg.TabIndex = 4;
            // 
            // cmdClose
            // 
            this.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose.Location = new System.Drawing.Point(267, 41);
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
            this.cmdHelp.Location = new System.Drawing.Point(267, 152);
            this.cmdHelp.Name = "cmdHelp";
            this.cmdHelp.Size = new System.Drawing.Size(75, 23);
            this.cmdHelp.TabIndex = 7;
            this.cmdHelp.Text = "Help";
            this.cmdHelp.UseVisualStyleBackColor = true;
            this.cmdHelp.Click += new System.EventHandler(this.cmdHelp_Click);
            // 
            // OneTimePad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(354, 581);
            this.ControlBox = false;
            this.Controls.Add(this.cmdHelp);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.lblPrintMsg);
            this.Controls.Add(this.cmdPrint);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.txtKeys);
            this.Controls.Add(this.cmdGenPad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OneTimePad";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "One Time Pad Generator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OneTimePad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdGenPad;
        private System.Windows.Forms.TextBox txtKeys;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button cmdPrint;
        private System.Windows.Forms.Label lblPrintMsg;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdHelp;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

