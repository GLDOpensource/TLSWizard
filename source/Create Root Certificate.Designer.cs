namespace GenerateIt {
    partial class Create_Root_Certificate {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_Root_Certificate));
            this.buttonLoadRSA = new System.Windows.Forms.Button();
            this.buttonCreateRSA = new System.Windows.Forms.Button();
            this.textBoxRSAInfo = new System.Windows.Forms.TextBox();
            this.textBoxCN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOrg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOU = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDownRSALen = new System.Windows.Forms.NumericUpDown();
            this.textBoxRSAPass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxCert = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDownSerialNumber = new System.Windows.Forms.NumericUpDown();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDisplayName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBegin = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSavePK12 = new System.Windows.Forms.Button();
            this.openFileDialogLoadRSA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogPK12 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRSALen)).BeginInit();
            this.groupBoxCert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSerialNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoadRSA
            // 
            this.buttonLoadRSA.Enabled = false;
            this.buttonLoadRSA.Location = new System.Drawing.Point(19, 19);
            this.buttonLoadRSA.Name = "buttonLoadRSA";
            this.buttonLoadRSA.Size = new System.Drawing.Size(135, 23);
            this.buttonLoadRSA.TabIndex = 0;
            this.buttonLoadRSA.Text = "Load from old PKCS12";
            this.buttonLoadRSA.UseVisualStyleBackColor = true;
            this.buttonLoadRSA.Click += new System.EventHandler(this.buttonLoadRSA_Click);
            // 
            // buttonCreateRSA
            // 
            this.buttonCreateRSA.Location = new System.Drawing.Point(20, 48);
            this.buttonCreateRSA.Name = "buttonCreateRSA";
            this.buttonCreateRSA.Size = new System.Drawing.Size(134, 23);
            this.buttonCreateRSA.TabIndex = 1;
            this.buttonCreateRSA.Text = "Create RSA";
            this.buttonCreateRSA.UseVisualStyleBackColor = true;
            this.buttonCreateRSA.Click += new System.EventHandler(this.buttonCreateRSA_Click);
            // 
            // textBoxRSAInfo
            // 
            this.textBoxRSAInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRSAInfo.Location = new System.Drawing.Point(21, 80);
            this.textBoxRSAInfo.Multiline = true;
            this.textBoxRSAInfo.Name = "textBoxRSAInfo";
            this.textBoxRSAInfo.ReadOnly = true;
            this.textBoxRSAInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRSAInfo.Size = new System.Drawing.Size(360, 49);
            this.textBoxRSAInfo.TabIndex = 3;
            // 
            // textBoxCN
            // 
            this.textBoxCN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCN.Location = new System.Drawing.Point(120, 26);
            this.textBoxCN.Name = "textBoxCN";
            this.textBoxCN.Size = new System.Drawing.Size(261, 20);
            this.textBoxCN.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Issuer (CN)";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCountry.Location = new System.Drawing.Point(120, 52);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(261, 20);
            this.textBoxCountry.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Country";
            // 
            // textBoxOrg
            // 
            this.textBoxOrg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOrg.Location = new System.Drawing.Point(120, 78);
            this.textBoxOrg.Name = "textBoxOrg";
            this.textBoxOrg.Size = new System.Drawing.Size(261, 20);
            this.textBoxOrg.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Organization";
            // 
            // textBoxOU
            // 
            this.textBoxOU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOU.Location = new System.Drawing.Point(120, 104);
            this.textBoxOU.Name = "textBoxOU";
            this.textBoxOU.Size = new System.Drawing.Size(261, 20);
            this.textBoxOU.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Organiz.Unit";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.numericUpDownRSALen);
            this.groupBox1.Controls.Add(this.textBoxRSAPass);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.buttonLoadRSA);
            this.groupBox1.Controls.Add(this.buttonCreateRSA);
            this.groupBox1.Controls.Add(this.textBoxRSAInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 144);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crypto Key Pair";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(361, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Bits";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(176, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Length";
            // 
            // numericUpDownRSALen
            // 
            this.numericUpDownRSALen.Location = new System.Drawing.Point(235, 51);
            this.numericUpDownRSALen.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.numericUpDownRSALen.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownRSALen.Name = "numericUpDownRSALen";
            this.numericUpDownRSALen.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRSALen.TabIndex = 7;
            this.numericUpDownRSALen.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // textBoxRSAPass
            // 
            this.textBoxRSAPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRSAPass.Enabled = false;
            this.textBoxRSAPass.Location = new System.Drawing.Point(235, 22);
            this.textBoxRSAPass.Name = "textBoxRSAPass";
            this.textBoxRSAPass.Size = new System.Drawing.Size(120, 20);
            this.textBoxRSAPass.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(176, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Password";
            // 
            // groupBoxCert
            // 
            this.groupBoxCert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCert.Controls.Add(this.label13);
            this.groupBoxCert.Controls.Add(this.numericUpDownSerialNumber);
            this.groupBoxCert.Controls.Add(this.textBoxPassword);
            this.groupBoxCert.Controls.Add(this.label9);
            this.groupBoxCert.Controls.Add(this.textBoxDisplayName);
            this.groupBoxCert.Controls.Add(this.label8);
            this.groupBoxCert.Controls.Add(this.dateTimePickerEnd);
            this.groupBoxCert.Controls.Add(this.dateTimePickerBegin);
            this.groupBoxCert.Controls.Add(this.label7);
            this.groupBoxCert.Controls.Add(this.label1);
            this.groupBoxCert.Controls.Add(this.buttonSavePK12);
            this.groupBoxCert.Controls.Add(this.textBoxOU);
            this.groupBoxCert.Controls.Add(this.label3);
            this.groupBoxCert.Controls.Add(this.label6);
            this.groupBoxCert.Controls.Add(this.textBoxCN);
            this.groupBoxCert.Controls.Add(this.textBoxOrg);
            this.groupBoxCert.Controls.Add(this.label4);
            this.groupBoxCert.Controls.Add(this.label5);
            this.groupBoxCert.Controls.Add(this.textBoxCountry);
            this.groupBoxCert.Enabled = false;
            this.groupBoxCert.Location = new System.Drawing.Point(12, 162);
            this.groupBoxCert.Name = "groupBoxCert";
            this.groupBoxCert.Size = new System.Drawing.Size(399, 308);
            this.groupBoxCert.TabIndex = 15;
            this.groupBoxCert.TabStop = false;
            this.groupBoxCert.Text = "Certificate";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Serial Number";
            // 
            // numericUpDownSerialNumber
            // 
            this.numericUpDownSerialNumber.Location = new System.Drawing.Point(120, 183);
            this.numericUpDownSerialNumber.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.numericUpDownSerialNumber.Name = "numericUpDownSerialNumber";
            this.numericUpDownSerialNumber.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownSerialNumber.TabIndex = 23;
            this.numericUpDownSerialNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.Location = new System.Drawing.Point(120, 235);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(159, 20);
            this.textBoxPassword.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Password";
            // 
            // textBoxDisplayName
            // 
            this.textBoxDisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDisplayName.Location = new System.Drawing.Point(120, 209);
            this.textBoxDisplayName.Name = "textBoxDisplayName";
            this.textBoxDisplayName.Size = new System.Drawing.Size(261, 20);
            this.textBoxDisplayName.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Display Name";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(120, 157);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(220, 20);
            this.dateTimePickerEnd.TabIndex = 18;
            // 
            // dateTimePickerBegin
            // 
            this.dateTimePickerBegin.Location = new System.Drawing.Point(120, 131);
            this.dateTimePickerBegin.Name = "dateTimePickerBegin";
            this.dateTimePickerBegin.Size = new System.Drawing.Size(220, 20);
            this.dateTimePickerBegin.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Valid before";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Valid after";
            // 
            // buttonSavePK12
            // 
            this.buttonSavePK12.Location = new System.Drawing.Point(235, 273);
            this.buttonSavePK12.Name = "buttonSavePK12";
            this.buttonSavePK12.Size = new System.Drawing.Size(135, 23);
            this.buttonSavePK12.TabIndex = 14;
            this.buttonSavePK12.Text = "Save PKCS12";
            this.buttonSavePK12.UseVisualStyleBackColor = true;
            this.buttonSavePK12.Click += new System.EventHandler(this.buttonSavePK12_Click);
            // 
            // openFileDialogLoadRSA
            // 
            this.openFileDialogLoadRSA.FileName = "rsa.pem";
            // 
            // saveFileDialogPK12
            // 
            this.saveFileDialogPK12.Filter = "P12 Files|*.p12|All files|*.*";
            // 
            // Create_Root_Certificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 482);
            this.Controls.Add(this.groupBoxCert);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Create_Root_Certificate";
            this.Text = "Create Root Certificate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Create_Root_Certificate_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRSALen)).EndInit();
            this.groupBoxCert.ResumeLayout(false);
            this.groupBoxCert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSerialNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadRSA;
        private System.Windows.Forms.Button buttonCreateRSA;
        private System.Windows.Forms.TextBox textBoxRSAInfo;
        private System.Windows.Forms.TextBox textBoxCN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOrg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxOU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxCert;
        private System.Windows.Forms.Button buttonSavePK12;
        private System.Windows.Forms.TextBox textBoxDisplayName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerBegin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openFileDialogLoadRSA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogPK12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDownRSALen;
        private System.Windows.Forms.TextBox textBoxRSAPass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDownSerialNumber;
    }
}