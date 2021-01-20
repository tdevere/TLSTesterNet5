using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TLSTesterNet5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //New Branch
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var items = Enum.GetValues(typeof(System.Net.SecurityProtocolType));
            foreach (var item in items)
            {
                cmbSSLVersion.Items.Add(item);
            }

            cmbSSLVersion.SelectedIndex = cmbSSLVersion.Items.Count - 1;

            ServicePointManager.ServerCertificateValidationCallback += new System.Net.Security.RemoteCertificateValidationCallback(ValidateCertificate);
        }

        public static bool ValidateCertificate(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {

            Trace.Write("custom validation code was hit here" + System.Environment.NewLine);

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbResults.Clear();
        }

        private void btnMakeCall_Click(object sender, EventArgs e)
        {
            if (SecurityProtocolType())
            {
                try
                {
                    rtbResults.Text += String.Format("{0} Security Protocol has been selected", cmbSSLVersion.SelectedItem.ToString());
                    rtbResults.Text += (Environment.NewLine);
                    rtbResults.Text += String.Format("Calling {0} ", txtURL.Text.ToString());
                    rtbResults.Text += (Environment.NewLine);

                    WebRequest request = WebRequest.Create("https://" + txtURL.Text.Trim() + ":" + txtSSLPort.Text.Trim());

                    if (chkEnableProxy.Checked)
                    {
                        request.Proxy = new WebProxy(txtProxyAddress.Text.Trim(), chkByPassOnLocal.Checked);

                    }

                    if (chkUseDefaultCredentials.Checked)
                    {
                        request.Credentials = CredentialCache.DefaultCredentials;
                    }

                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    Stream dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    string responseFromServer = reader.ReadToEnd();
                    rtbResults.Text += String.Format("StatusDescription {0} ", ((HttpWebResponse)response).StatusDescription);
                    rtbResults.Text += (Environment.NewLine);

                }
                catch (Exception ex)
                {
                    rtbResults.Text += String.Format("Error {0} - Check your URL", ex.Message);
                    rtbResults.Text += (Environment.NewLine);

                }
            }
        }

        private bool SecurityProtocolType()
        {
            bool bContinue = true;
            switch (cmbSSLVersion.SelectedItem.ToString())
            {
                //case "Ssl3":
                //    System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Ssl3;
                //    break;
                case "Tls":
                    System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls;
                    break;
                case "Tls11":
                    System.Net.ServicePointManager.SecurityProtocol = (System.Net.SecurityProtocolType)768;
                    break;
                case "Tls12":
                    System.Net.ServicePointManager.SecurityProtocol = (System.Net.SecurityProtocolType)3072;
                    break;
                case "Tls1_Not_Availalbe_Natively":
                    System.Net.ServicePointManager.SecurityProtocol = (System.Net.SecurityProtocolType)768;
                    break;
                case "Tls12_Not_Availalbe_Natively":
                    System.Net.ServicePointManager.SecurityProtocol = (System.Net.SecurityProtocolType)3072;
                    break;
                default:
                    System.Net.ServicePointManager.SecurityProtocol = (System.Net.SecurityProtocolType)0;
                    rtbResults.Text += String.Format("Using System.Default.");
                    rtbResults.Text += (Environment.NewLine);
                    //bContinue = false;
                    break;
            }

            return bContinue;
        }

        private void chkLoopEnabled_CheckedChanged(object sender, EventArgs e)
        {
            txtLoops.Enabled = chkLoopEnabled.Enabled;
        }

        private void btnDefaultRequest_Click(object sender, EventArgs e)
        {
            rtbResults.Text = "ServicePointManager.SecurityProtocol = " + ServicePointManager.SecurityProtocol.ToString();
            rtbResults.Text += (Environment.NewLine);
            try
            {
                WebRequest request = WebRequest.Create("https://" + txtURL.Text.Trim() + ":" + txtSSLPort.Text.Trim());
                request.Proxy = null;
                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                rtbResults.Text += String.Format("StatusDescription {0} ", ((HttpWebResponse)response).StatusDescription);
                rtbResults.Text += (Environment.NewLine);
            }
            catch (Exception ex)
            {
                rtbResults.Text += ex;
                rtbResults.Text += (Environment.NewLine);
            }
        }
    }
}
