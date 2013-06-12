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

        public OneTimePad()
        {
            InitializeComponent();
        }

        private void cmdGenPad_Click(object sender, EventArgs e)
        {
            txtKeys.Text = "";
            lblMonth.Text = "Month : " + DateTime.Now.Month.ToString();
            lblMonth.Visible = true;
            int loop = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            Random r =new Random(DateTime.Now.Millisecond);
            
            for (int i = 0; i < loop + 1; i++)
            {
                txtKeys.Text += "day " + (i + 1).ToString() + ".    " + new String(Enumerable.Range(0, 16).Select(n => (Char)(r.Next(32, 127))).ToArray()).Replace("`","5").Replace("'","4").Replace(".", "X").Replace(" ", "x").Replace(",", "+").Replace(";", "&") + Environment.NewLine;
            }
        }
        
        private void OneTimePad_Load(object sender, EventArgs e)
        {
            this.MouseEnter += new System.EventHandler(this.OneTimePad_MouseEnter);
           

        }
        private void OneTimePad_MouseEnter(object sender, System.EventArgs e)
        {
            if(this.Opacity !=100)
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
            if(result== DialogResult.OK)
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

      
     

    }
}
