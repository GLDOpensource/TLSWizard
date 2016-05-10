using OpenSSL.Core;
using OpenSSL.Crypto;
using OpenSSL.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GenerateIt {
    public partial class TLSWizard : Form {
        public TLSWizard() {
            InitializeComponent();
        }

        private void buttonLoadRootP12_Click(object sender, EventArgs e) {
            if(string.IsNullOrEmpty(textBoxRootPass.Text)){
                if(MessageBox.Show("Password field is empty. Proceed ?","Not Password given",MessageBoxButtons.YesNo)!= System.Windows.Forms.DialogResult.Yes)
                    return;
            }
            if (openFileDialogLoadRootCert.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            LoadRootCert(openFileDialogLoadRootCert.FileName,textBoxRootPass.Text);

        }

        System.Security.Cryptography.X509Certificates.X509Certificate2 m_wincert = null;

        private void LoadRootCert(string filename, string passwort) {
            try {
                groupBoxDevCert.Enabled = false;

                progressBar1.Style = ProgressBarStyle.Marquee;
                Application.DoEvents();
                textBoxLoadStatus.Text = "";
                Application.DoEvents();

                if (m_x509_RootCA != null)
                    m_x509_RootCA.Dispose();
                m_x509_RootCA = null;
                m_wincert = null;
                textBoxLoadStatus.Text += "OpenSSL: certload ";
                Application.DoEvents();

                BIO bCAKey = BIO.File(filename, "rb");
                m_x509_RootCA = X509Certificate.FromPKCS12(bCAKey, passwort);
                textBoxLoadStatus.Text += "success"+ Environment.NewLine;
                textBoxLoadStatus.Text += "WinAPI: certload ";
                Application.DoEvents();

                m_wincert = new System.Security.Cryptography.X509Certificates.X509Certificate2(filename, passwort);
                textBoxLoadStatus.Text += "success" + Environment.NewLine;
                textBoxLoadStatus.Text += "WinAPI: search trusted root store ";
                Application.DoEvents();

                System.Security.Cryptography.X509Certificates.X509Store store = new System.Security.Cryptography.X509Certificates.X509Store(System.Security.Cryptography.X509Certificates.StoreName.Root, System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser);

                store.Open(System.Security.Cryptography.X509Certificates.OpenFlags.MaxAllowed);

                // test is installed
                checkBoxIsTrustedRoot.Checked = store.Certificates.Contains(m_wincert);

                // or add to store
                //  store.Add(wincert);

                store.Close();
                buttonInstall.Enabled = !checkBoxIsTrustedRoot.Checked;
                if (checkBoxIsTrustedRoot.Checked)
                    textBoxLoadStatus.Text += "-> already installed" + Environment.NewLine;
                else
                    textBoxLoadStatus.Text += "-> not installed" + Environment.NewLine;
                groupBoxDevCert.Enabled = true;
            }
            catch (Exception exception) {
                List<string> dogs = new List<string>();
                while (exception.InnerException != null){
                    dogs.Add(exception.Source + " : " + exception.Message);
                    exception = exception.InnerException;
                }
                dogs.Add(exception.Source+" : "+exception.Message);
                MessageBox.Show(string.Join(Environment.NewLine,  dogs.ToArray()));
            }
            progressBar1.Style = ProgressBarStyle.Blocks;
        }

        private void button1_Click(object sender, EventArgs e) {
            using (Create_Root_Certificate fcr = new Create_Root_Certificate()) {
                if (fcr.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;
                LoadRootCert(fcr.p12Filename, fcr.p12Passwort);
            }

            
        }

        X509Certificate m_x509_RootCA = null;


        private void button2_Click(object sender, EventArgs e) {
            

            using (X509Name subject = new X509Name(textBoxURL.Text)) {
                try {

                    using (var rsa = new RSA()) {
                        rsa.GenerateKeys(1024, OddRandomUint32.Next(), null, null);
                        using (var key = new CryptoKey(rsa)) {
                            var request = new X509Request(1, subject, m_x509_RootCA.PrivateKey);

                            var cert = request.CreateCertificate(1000, key);
                            cert.Issuer = m_x509_RootCA.Issuer;
                            //   cert.Subject.AddEntryByName("C","DE");
                            cert.NotBefore = dateTimePickerBegin.Value;
                            cert.NotAfter = dateTimePickerEnd.Value;
                            cert.SerialNumber = (int)numericUpDownSerialNumber.Value;
                            cert.PublicKey = key;
                            cert.Sign(m_x509_RootCA.PrivateKey, MessageDigest.SHA256);
                            //File.WriteAllText("debcert.pem", cert.PEM);
                            //File.WriteAllText("deb_key.pem", rsa.PrivateKeyAsPEM);

                            // upload to device
                            using (MC4RPC conn = new MC4RPC(textBoxURL.Text, "admin", textBoxAdminPass.Text)) {
                                if (conn.uploadTLS(cert.PEM, rsa.PrivateKeyAsPEM)) {
                                    if (MessageBox.Show("Certificate and Key were installed successfully.\n Restart Webserver or reboot device manually, please. \n\nClose App ?", "Installation succeeded", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                        Close();
                                }
                                else
                                    MessageBox.Show("Certificate and Key were not installed.", "Installation failed");
                            }


                        }
                    }
                }
                catch (Exception exception) {
                    MessageBox.Show(exception.Message);
                }
            }
            
        }

        private void buttonInstall_Click(object sender, EventArgs e) {
            try {
                System.Security.Cryptography.X509Certificates.X509Store store = new System.Security.Cryptography.X509Certificates.X509Store(System.Security.Cryptography.X509Certificates.StoreName.Root, System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser);
                store.Open(System.Security.Cryptography.X509Certificates.OpenFlags.MaxAllowed);
                store.Add(m_wincert);
                store.Close();
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message, "Couldn't install...");
            }
        }
    }
}
