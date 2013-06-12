using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;


namespace DMDG
{
    public partial class MSGs : Form
    {
        Timer tmr;
        Int32 tick;
        bool bypasswarning = false;
        Int32 time = 1800;
        public MSGs()
        {
            InitializeComponent();
        }

        private void MSGs_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }
        private void LoadSettings()
        {
            EnableTimer();

        }
        private void EnableTimer()
        {
            lblStartTime.Text = GetTime();

            tmr = new Timer();
            tmr.Tick += new EventHandler(TimerEventProcessor);

            // Sets the timer interval to 5 seconds.
            tmr.Interval = 1000;
            tmr.Start();

        }


        private void TimerEventProcessor(Object myObject,
                                            EventArgs myEventArgs)
        {
            tick += 1;
            lblTime.Text = GetTime();


            if (tick == time && !bypasswarning)
            {
                var result = MessageBox.Show("Your exposure is very high. We recommend you close the application and validate your environment is secure.  Press cancel to ignore future warnings.", "Exposure alert", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    time = time + 1800;
                }
                else
                {
                    bypasswarning = true;
                }
            }

        }
        public string GetTime()
        {
            string TimeInString = "";
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;
            int sec = DateTime.Now.Second;

            TimeInString = (hour < 10) ? "0" + hour.ToString() : hour.ToString();
            TimeInString += ":" + ((min < 10) ? "0" + min.ToString() : min.ToString());
            TimeInString += ":" + ((sec < 10) ? "0" + sec.ToString() : sec.ToString());
            return TimeInString;
        }

        public string EncryptRequest(string request)
        {

            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(request);


            string Key = "ryojvlzmdalyglrj";

            if (txtDoDadDo.Text.Trim() != string.Empty)
            {
                Key = txtDoDadDo.Text.Trim();
            }

            keyArray = UTF8Encoding.UTF8.GetBytes(Key);

            TripleDESCryptoServiceProvider tDes = new TripleDESCryptoServiceProvider();

            tDes.Key = keyArray;
            tDes.Mode = CipherMode.ECB;
            tDes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tDes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            tDes.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);


        }

        public string DecryptRequest(string request)
        {

            request = request.Replace(" ", "+");

            byte[] keyArray;
            byte[] toDecryptArray = Convert.FromBase64String(request);

            string Key = "ryojvlzmdalyglrj";

            if (txtDoDadDo.Text.Trim() != string.Empty)
            {
                Key = txtDoDadDo.Text.Trim();
            }

            keyArray = UTF8Encoding.UTF8.GetBytes(Key);

            TripleDESCryptoServiceProvider tDes = new TripleDESCryptoServiceProvider();
            tDes.Key = keyArray;
            tDes.Mode = CipherMode.ECB;
            tDes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tDes.CreateDecryptor();
            try
            {
                byte[] resultArray = cTransform.TransformFinalBlock(toDecryptArray, 0, toDecryptArray.Length);

                tDes.Clear();
                return UTF8Encoding.UTF8.GetString(resultArray, 0, resultArray.Length);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void cmdEncrypt_Click(object sender, EventArgs e)
        {
            if (txtClear.Text.Trim() != string.Empty)
            {
                txtCrypt.Text = EncryptRequest(txtClear.Text.Trim());
                txtClear.Text = "";
            }
        }

        private void cmdDecrypt_Click(object sender, EventArgs e)
        {
            if (txtCrypt.Text.Trim() != string.Empty)
            {
                gbDecrypted.Text = "New message ready, delete after reading.";
                txtClear.Text = DecryptRequest(txtCrypt.Text.Trim());
                txtCrypt.Text = "";
            }
        }


        private void cmdEraseDecrypted_Click(object sender, EventArgs e)
        {
            txtClear.Text = "";
        }

        private void cmdEraseEncrypted_Click(object sender, EventArgs e)
        {
            txtCrypt.Text = "";
        }


        private void mnuOneTimePad_Click(object sender, EventArgs e)
        {
            randfip.OneTimePad onetimepad = new randfip.OneTimePad();
            onetimepad.Show();
        }

        private void cmdEraseKey_Click(object sender, EventArgs e)
        {
            txtDoDadDo.Text = string.Empty;
        }

        private void cmdImportFile_Click(object sender, EventArgs e)
        {
            txtClear.Text = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName.Substring(openFileDialog1.FileName.Length - 4).ToLower() == ".txt")
                {
                    System.IO.StreamReader sr = new
                       System.IO.StreamReader(openFileDialog1.FileName);
                    txtCrypt.Text = sr.ReadToEnd();
                    sr.Close();
                }
                else
                {
                    MessageBox.Show("For security, this tool will only open text files. Other file types can compromise your security.", "File type warning", MessageBoxButtons.OK);
                }
            }

        }

    }
}
