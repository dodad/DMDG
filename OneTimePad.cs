using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace randfip
{
    public partial class OneTimePad : Form
    {

        Int64 saltseed = 16;

        public OneTimePad()
        {
            InitializeComponent();
        }

        private void cmdGenPad_Click(object sender, EventArgs e)
        {
            txtKeys.Text = "";

            int loop = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            Random r = new Random(DateTime.Now.Millisecond);

            saltseed = 16;

            for (int i = 0; i < loop + 1; i++)
            {
                txtKeys.Text += "T " + (i + 1).ToString() + " KEY.      " + CreateSalt(saltseed) + Environment.NewLine;

                if (rdoMedium.Checked)
                    txtKeys.Text += "T " + (i + 1).ToString() + " CODE.      " + new String(Enumerable.Range(0, 16).Select(n => (Char)(r.Next(32, 127))).ToArray()).Replace("`", "5").Replace("'", "4").Replace(".", "X").Replace(" ", "x").Replace(",", "+").Replace(";", "&") + Environment.NewLine + Environment.NewLine;

                if (rdoStrong.Checked)
                {
                    txtKeys.Text += "T " + (i + 1).ToString() + " CODE.      " + new String(Enumerable.Range(0, 16).Select(n => (Char)(r.Next(32, 127))).ToArray()).Replace("`", "5").Replace("'", "4").Replace(".", "X").Replace(" ", "x").Replace(",", "+").Replace(";", "&") + Environment.NewLine;

                    txtKeys.Text += "T" + (i + 1).ToString() + " COMPRESS.    " + new String(Enumerable.Range(0, 16).Select(n => (Char)(r.Next(32, 127))).ToArray()).Replace("`", "5").Replace("'", "4").Replace(".", "X").Replace(" ", "x").Replace(",", "+").Replace(";", "&") + Environment.NewLine + Environment.NewLine + Environment.NewLine;
                }
            }


        }

        private int GetExpireSetting()
        {
            int value = 0;
            switch (cboExpire.SelectedItem.ToString())
            {

                case "1 day":
                    value = 24;
                    break;
                case "1 hour":
                    value = 1;
                    break;
                case "1 week":
                    value = 7 * 24;
                    break;
                case "1 month":
                    int days = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                    value = days * 24;

                    break;


            }


            return value;

        }


        private string CreateSalt(Int64 size)
        {
            //Generate a cryptographic random number.
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            byte[] buff = new byte[size];
            rng.GetBytes(buff);

            // Return a Base64 string representation of the random number.
            return Convert.ToBase64String(buff);
        }


        private void OneTimePad_Load(object sender, EventArgs e)
        {
            this.MouseEnter += new System.EventHandler(this.OneTimePad_MouseEnter);


        }
        private void OneTimePad_MouseEnter(object sender, System.EventArgs e)
        {
            if (this.Opacity != 100)
                this.Opacity = 100;
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            // Allow the user to choose the page range he or she would
            // like to print.
            printDialog1.AllowSomePages = false;

            // Show the help button.
            printDialog1.ShowHelp = true;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(Print_Page);
            printDialog1.Document = pd;

            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
                pd.Print();

            lblPrintMsg.Text = "Remember to distroy the keys on  this pad as needed to ensure your security model is sound.  Use a new key each day at a minum.  Press Help for recomendations on sound security models using one time pad encryption.  Good luck.";

        }

        private void Print_Page(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            Graphics graphics = e.Graphics;
            Bitmap bitmap = new Bitmap(this.txtKeys.Width, this.txtKeys.Height);
            this.txtKeys.DrawToBitmap(bitmap, this.txtKeys.Bounds);
            Point p = new Point(100, 100);

            graphics.DrawImage(bitmap, p);
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void cmdHelp_Click(object sender, EventArgs e)
        {




        }

        private void lblPrintMsg_Click(object sender, EventArgs e)
        {

        }

        private void cboExpire_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblExpireMsg.Text = "Keys will only be valid for " + cboExpire.SelectedItem;


        }





    }
}
