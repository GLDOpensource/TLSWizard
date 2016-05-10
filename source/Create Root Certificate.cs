using OpenSSL.Core;
using OpenSSL.Crypto;
using OpenSSL.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GenerateIt {
    public partial class Create_Root_Certificate : Form {
        public Create_Root_Certificate() {
            InitializeComponent();
        }

        RSA m_rsaKey = null;

        private void buttonSavePK12_Click(object sender, EventArgs e) {
            saveFileDialogPK12.FileName = textBoxDisplayName.Text + ".p12";
            if (saveFileDialogPK12.ShowDialog() != DialogResult.OK)
                return;

            try {
               
                using ( X509Name subject = new X509Name(textBoxCN.Text)) {
                    subject.Country = textBoxCountry.Text;
                    subject.Organization = textBoxOrg.Text;
                    subject.OrganizationUnit = textBoxOU.Text;

                    using (var key = new CryptoKey(m_rsaKey)) {
                        var request = new X509Request(1, subject, key);
                        var cert = request.CreateCertificate(1000, key);
                        cert.Issuer = subject;

                        cert.NotBefore = dateTimePickerBegin.Value;
                        cert.NotAfter = dateTimePickerEnd.Value; ;
                        cert.SerialNumber = (int)numericUpDownSerialNumber.Value;
                        cert.PublicKey = key;
                        cert.Sign(key, MessageDigest.SHA512);
                        using (BIO outie = BIO.File(saveFileDialogPK12.FileName, "wb")) {
                            PKCS12 p12 = new PKCS12(textBoxPassword.Text, textBoxDisplayName.Text, key, cert, new OpenSSL.Core.Stack<X509Certificate>(), PKCS12.PBE.SHA1_3DES, PKCS12.PBE.SHA1_RC2_40, 0, PKCS12.KeyType.KEY_DEFAULT);
                            p12.Write(outie);
                        }
                    }
                }
            }
            catch (Exception exception) { 
                MessageBox.Show(exception.Message);
            }
            switch(MessageBox.Show("Cert saved. Use in previous dialog as root ?","Operation successful",MessageBoxButtons.YesNoCancel)){
                case System.Windows.Forms.DialogResult.Yes: this.DialogResult = DialogResult.OK; p12Filename = saveFileDialogPK12.FileName; Close(); break;
                case System.Windows.Forms.DialogResult.No: this.DialogResult = DialogResult.Cancel; p12Filename = ""; Close(); break;
                default: break;
            }  
        }

        private void Create_Root_Certificate_FormClosed(object sender, FormClosedEventArgs e) {
            if (m_rsaKey != null)
                m_rsaKey.Dispose();
            m_rsaKey = null;
        }

        private void buttonLoadRSA_Click(object sender, EventArgs e) {
            try { 
                using (BIO readBIO = BIO.File(openFileDialogLoadRSA.FileName, "rb")) {
                    PKCS12 p12 = new PKCS12(readBIO,textBoxRSAPass.Text);
                   
                }
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }

            
        }

        private void buttonCreateRSA_Click(object sender, EventArgs e) {
            try {
                groupBoxCert.Enabled = false;

                m_rsaKey = new RSA();
                m_rsaKey.GenerateKeys((int)numericUpDownRSALen.Value, OddRandomUint32.Next(), null, null);
                textBoxRSAInfo.Text = m_rsaKey.ToString();
                groupBoxCert.Enabled = true;
            }
            catch (Exception exception) {
                textBoxRSAInfo.Text = exception.Message;
            }
        }



        public string p12Filename { get; set; }
        public string p12Passwort { get {
            return textBoxPassword.Text;
        } }
    }
}
