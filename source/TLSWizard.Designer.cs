namespace GenerateIt {
    partial class TLSWizard {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TLSWizard));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialogLoadRootCert = new System.Windows.Forms.OpenFileDialog();
            this.buttonLoadRootP12 = new System.Windows.Forms.Button();
            this.checkBoxIsTrustedRoot = new System.Windows.Forms.CheckBox();
            this.buttonInstall = new System.Windows.Forms.Button();
            this.textBoxLoadStatus = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxDevCert = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDownSerialNumber = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBegin = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBoxRootPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAdminPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxDevCert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSerialNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxRootPass);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxLoadStatus);
            this.groupBox1.Controls.Add(this.buttonInstall);
            this.groupBox1.Controls.Add(this.checkBoxIsTrustedRoot);
            this.groupBox1.Controls.Add(this.buttonLoadRootP12);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Root Certificate";
            // 
            // buttonLoadRootP12
            // 
            this.buttonLoadRootP12.Location = new System.Drawing.Point(19, 28);
            this.buttonLoadRootP12.Name = "buttonLoadRootP12";
            this.buttonLoadRootP12.Size = new System.Drawing.Size(137, 23);
            this.buttonLoadRootP12.TabIndex = 0;
            this.buttonLoadRootP12.Text = "Load Root PKCS12";
            this.buttonLoadRootP12.UseVisualStyleBackColor = true;
            this.buttonLoadRootP12.Click += new System.EventHandler(this.buttonLoadRootP12_Click);
            // 
            // checkBoxIsTrustedRoot
            // 
            this.checkBoxIsTrustedRoot.AutoSize = true;
            this.checkBoxIsTrustedRoot.Enabled = false;
            this.checkBoxIsTrustedRoot.Location = new System.Drawing.Point(176, 62);
            this.checkBoxIsTrustedRoot.Name = "checkBoxIsTrustedRoot";
            this.checkBoxIsTrustedRoot.Size = new System.Drawing.Size(99, 17);
            this.checkBoxIsTrustedRoot.TabIndex = 1;
            this.checkBoxIsTrustedRoot.Text = "Is Trusted Root";
            this.checkBoxIsTrustedRoot.UseVisualStyleBackColor = true;
            // 
            // buttonInstall
            // 
            this.buttonInstall.Enabled = false;
            this.buttonInstall.Location = new System.Drawing.Point(281, 58);
            this.buttonInstall.Name = "buttonInstall";
            this.buttonInstall.Size = new System.Drawing.Size(95, 23);
            this.buttonInstall.TabIndex = 2;
            this.buttonInstall.Text = "Install locally";
            this.buttonInstall.UseVisualStyleBackColor = true;
            this.buttonInstall.Click += new System.EventHandler(this.buttonInstall_Click);
            // 
            // textBoxLoadStatus
            // 
            this.textBoxLoadStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLoadStatus.Location = new System.Drawing.Point(19, 87);
            this.textBoxLoadStatus.Multiline = true;
            this.textBoxLoadStatus.Name = "textBoxLoadStatus";
            this.textBoxLoadStatus.ReadOnly = true;
            this.textBoxLoadStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLoadStatus.Size = new System.Drawing.Size(357, 66);
            this.textBoxLoadStatus.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create Root PKCS12";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxDevCert
            // 
            this.groupBoxDevCert.Controls.Add(this.textBoxAdminPass);
            this.groupBoxDevCert.Controls.Add(this.label4);
            this.groupBoxDevCert.Controls.Add(this.label2);
            this.groupBoxDevCert.Controls.Add(this.numericUpDown1);
            this.groupBoxDevCert.Controls.Add(this.label13);
            this.groupBoxDevCert.Controls.Add(this.numericUpDownSerialNumber);
            this.groupBoxDevCert.Controls.Add(this.dateTimePickerEnd);
            this.groupBoxDevCert.Controls.Add(this.dateTimePickerBegin);
            this.groupBoxDevCert.Controls.Add(this.label7);
            this.groupBoxDevCert.Controls.Add(this.label1);
            this.groupBoxDevCert.Controls.Add(this.textBoxURL);
            this.groupBoxDevCert.Controls.Add(this.label6);
            this.groupBoxDevCert.Controls.Add(this.button2);
            this.groupBoxDevCert.Enabled = false;
            this.groupBoxDevCert.Location = new System.Drawing.Point(12, 209);
            this.groupBoxDevCert.Name = "groupBoxDevCert";
            this.groupBoxDevCert.Size = new System.Drawing.Size(397, 208);
            this.groupBoxDevCert.TabIndex = 1;
            this.groupBoxDevCert.TabStop = false;
            this.groupBoxDevCert.Text = "MC4ETH Certificate";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "create and upload";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Serial Number";
            // 
            // numericUpDownSerialNumber
            // 
            this.numericUpDownSerialNumber.Location = new System.Drawing.Point(115, 132);
            this.numericUpDownSerialNumber.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.numericUpDownSerialNumber.Name = "numericUpDownSerialNumber";
            this.numericUpDownSerialNumber.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownSerialNumber.TabIndex = 31;
            this.numericUpDownSerialNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(115, 106);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(220, 20);
            this.dateTimePickerEnd.TabIndex = 30;
            // 
            // dateTimePickerBegin
            // 
            this.dateTimePickerBegin.Location = new System.Drawing.Point(115, 80);
            this.dateTimePickerBegin.Name = "dateTimePickerBegin";
            this.dateTimePickerBegin.Size = new System.Drawing.Size(220, 20);
            this.dateTimePickerBegin.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Valid before";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Valid after";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxURL.Location = new System.Drawing.Point(115, 28);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(261, 20);
            this.textBoxURL.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "RSA Length";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(115, 158);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown1.TabIndex = 33;
            this.numericUpDown1.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(19, 159);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(357, 13);
            this.progressBar1.TabIndex = 5;
            // 
            // textBoxRootPass
            // 
            this.textBoxRootPass.Location = new System.Drawing.Point(235, 28);
            this.textBoxRootPass.Name = "textBoxRootPass";
            this.textBoxRootPass.Size = new System.Drawing.Size(141, 20);
            this.textBoxRootPass.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Password:";
            // 
            // textBoxAdminPass
            // 
            this.textBoxAdminPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAdminPass.Location = new System.Drawing.Point(115, 54);
            this.textBoxAdminPass.Name = "textBoxAdminPass";
            this.textBoxAdminPass.Size = new System.Drawing.Size(261, 20);
            this.textBoxAdminPass.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Admin\'s Password";
            // 
            // TLSWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 429);
            this.Controls.Add(this.groupBoxDevCert);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TLSWizard";
            this.Text = "TLSWizard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxDevCert.ResumeLayout(false);
            this.groupBoxDevCert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSerialNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxLoadStatus;
        private System.Windows.Forms.Button buttonInstall;
        private System.Windows.Forms.CheckBox checkBoxIsTrustedRoot;
        private System.Windows.Forms.Button buttonLoadRootP12;
        private System.Windows.Forms.OpenFileDialog openFileDialogLoadRootCert;
        private System.Windows.Forms.GroupBox groupBoxDevCert;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDownSerialNumber;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerBegin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRootPass;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBoxAdminPass;
        private System.Windows.Forms.Label label4;
    }
}