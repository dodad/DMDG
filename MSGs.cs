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
using System.Text.RegularExpressions;


namespace DMDG
{
    public partial class MSGs : Form
    {
        Timer tmr;
        Int32 tick;
        bool bypasswarning = false;
        Int32 time = 1800;
        int msgnum = 0;

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
            cboStrenght.SelectedIndex = 0;
            InitStrenght();
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
        private string CreateSalt(int size)
        {
            //Generate a cryptographic random number.
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            byte[] buff = new byte[size];
            rng.GetBytes(buff);

            // Return a Base64 string representation of the random number.
            return Convert.ToBase64String(buff);
        }

        public string EncryptRequest(string request)
        {

            byte[] keyArray;
            byte[] toEncryptArray;
            string messagebuffer = string.Empty;

            //default stupid key. This is weak for testing reasons. if you want a strong key then you need to build your own once you download the code.
            string Key = "ryojvlzmdalyglrj";
            string Code = string.Empty;
            string Compress = string.Empty;

            if (txtDoDadDo.Text.Trim() != string.Empty)
                Key = txtDoDadDo.Text.Trim();

            if (txtCode.Text.Trim() != string.Empty)
                Code = txtCode.Text.Trim();

            if (txtCompress.Text.Trim() != string.Empty)
                Compress = txtCompress.Text.Trim();

            keyArray = UTF8Encoding.UTF8.GetBytes(Key);

            try
            {
                for (Int32 loop = 0; loop < request.Length; loop++)
                {
                    toEncryptArray = UTF8Encoding.UTF8.GetBytes(request.Substring(loop, 1));

                    TripleDESCryptoServiceProvider tDes = new TripleDESCryptoServiceProvider();

                    tDes.Key = keyArray;

                    tDes.Mode = CipherMode.ECB;

                    tDes.Padding = PaddingMode.PKCS7;

                    ICryptoTransform cTransform = tDes.CreateEncryptor();
                    byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                    tDes.Clear();

                    messagebuffer += Convert.ToBase64String(resultArray, 0, resultArray.Length) + Environment.NewLine;
                }





            }
            catch { }
            try
            {
            }
            catch { }
            try
            {

            }
            catch { }


            return messagebuffer;

        }

        public string DecryptRequest(string request)
        {

            request = request.Replace(" ", "+");
            string[] messageinbuffer = Regex.Split(request, "\r\n");
            string messageoutbuffer = string.Empty;

            byte[] keyArray;
            byte[] toDecryptArray;
            byte[] resultArray;
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
                for (Int32 loop = 0; loop < messageinbuffer.Length; loop++)
                {

                    toDecryptArray = Convert.FromBase64String(messageinbuffer[loop].Trim());

                    resultArray = cTransform.TransformFinalBlock(toDecryptArray, 0, toDecryptArray.Length);

                    tDes.Clear();


                    messageoutbuffer += UTF8Encoding.UTF8.GetString(resultArray, 0, resultArray.Length);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return messageoutbuffer;

        }

        private void cmdEncrypt_Click(object sender, EventArgs e)
        {
            if (txtClear.Text.Trim() != string.Empty)
            {
                msgnum++;
                txtCrypt.Text = EncryptRequest(txtClear.Text.Trim());
                txtClear.Text = "";
                lblNumMsgs.Text = msgnum.ToString();
            }
        }

        private void cmdDecrypt_Click(object sender, EventArgs e)
        {
            if (txtCrypt.Text.Trim() != string.Empty)
            {
                msgnum++;

                gbDecrypted.Text = "New message ready, delete after reading.";
                txtClear.Text = DecryptRequest(txtCrypt.Text.Trim());
                txtCrypt.Text = "";

                lblNumMsgs.Text = msgnum.ToString();
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
            InitKeys();
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
        private void InitStrenght()
        {
            txtCode.BackColor = Color.Gray;
            txtCompress.BackColor = Color.Gray;
            txtCode.Enabled = false;
            txtCompress.Enabled = false;

        }
        private void InitKeys()
        {
            txtDoDadDo.Text = string.Empty;
            txtCode.Text = string.Empty;
            txtCompress.Text = string.Empty;

        }
        private void cboStrenght_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitStrenght();
            InitKeys();

            switch (cboStrenght.SelectedItem.ToString())
            {
                case "Medium":
                    txtCode.Enabled = true;
                    txtCode.BackColor = Color.White;
                    break;

                case "Strong":
                    txtCode.BackColor = Color.White;
                    txtCompress.BackColor = Color.White;
                    txtCode.Enabled = true;
                    txtCompress.Enabled = true;
                    break;

            }

        }

    }
}
