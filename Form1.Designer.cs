
namespace TLSTesterNet5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSSLPort = new System.Windows.Forms.TextBox();
            this.txtLoops = new System.Windows.Forms.TextBox();
            this.chkLoopEnabled = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSSLVersion = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDefaultRequest = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkEnableProxy = new System.Windows.Forms.CheckBox();
            this.chkUseDefaultCredentials = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProxyAddress = new System.Windows.Forms.TextBox();
            this.chkByPassOnLocal = new System.Windows.Forms.CheckBox();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(21, 27);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(156, 23);
            this.txtURL.TabIndex = 0;
            this.txtURL.Text = "www.bing.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "URI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "SSL PORT";
            // 
            // txtSSLPort
            // 
            this.txtSSLPort.Location = new System.Drawing.Point(197, 27);
            this.txtSSLPort.Name = "txtSSLPort";
            this.txtSSLPort.Size = new System.Drawing.Size(156, 23);
            this.txtSSLPort.TabIndex = 3;
            this.txtSSLPort.Text = "443";
            // 
            // txtLoops
            // 
            this.txtLoops.Location = new System.Drawing.Point(366, 27);
            this.txtLoops.Name = "txtLoops";
            this.txtLoops.Size = new System.Drawing.Size(156, 23);
            this.txtLoops.TabIndex = 5;
            this.txtLoops.Text = "100";
            // 
            // chkLoopEnabled
            // 
            this.chkLoopEnabled.AutoSize = true;
            this.chkLoopEnabled.Location = new System.Drawing.Point(366, 5);
            this.chkLoopEnabled.Name = "chkLoopEnabled";
            this.chkLoopEnabled.Size = new System.Drawing.Size(102, 19);
            this.chkLoopEnabled.TabIndex = 6;
            this.chkLoopEnabled.Text = "ENABLE LOOP";
            this.chkLoopEnabled.UseVisualStyleBackColor = true;
            this.chkLoopEnabled.CheckedChanged += new System.EventHandler(this.chkLoopEnabled_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "SSL Version";
            // 
            // cmbSSLVersion
            // 
            this.cmbSSLVersion.FormattingEnabled = true;
            this.cmbSSLVersion.Location = new System.Drawing.Point(21, 83);
            this.cmbSSLVersion.Name = "cmbSSLVersion";
            this.cmbSSLVersion.Size = new System.Drawing.Size(156, 23);
            this.cmbSSLVersion.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "MAKE REQUEST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnMakeCall_Click);
            // 
            // btnDefaultRequest
            // 
            this.btnDefaultRequest.Location = new System.Drawing.Point(197, 90);
            this.btnDefaultRequest.Name = "btnDefaultRequest";
            this.btnDefaultRequest.Size = new System.Drawing.Size(156, 23);
            this.btnDefaultRequest.TabIndex = 10;
            this.btnDefaultRequest.Text = "DEFAULT REQUEST";
            this.btnDefaultRequest.UseVisualStyleBackColor = true;
            this.btnDefaultRequest.Click += new System.EventHandler(this.btnDefaultRequest_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(366, 65);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(156, 48);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "CLEAR REQUESTS";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkEnableProxy
            // 
            this.chkEnableProxy.AutoSize = true;
            this.chkEnableProxy.Location = new System.Drawing.Point(21, 122);
            this.chkEnableProxy.Name = "chkEnableProxy";
            this.chkEnableProxy.Size = new System.Drawing.Size(108, 19);
            this.chkEnableProxy.TabIndex = 12;
            this.chkEnableProxy.Text = "ENABLE PROXY";
            this.chkEnableProxy.UseVisualStyleBackColor = true;
            // 
            // chkUseDefaultCredentials
            // 
            this.chkUseDefaultCredentials.AutoSize = true;
            this.chkUseDefaultCredentials.Location = new System.Drawing.Point(21, 147);
            this.chkUseDefaultCredentials.Name = "chkUseDefaultCredentials";
            this.chkUseDefaultCredentials.Size = new System.Drawing.Size(167, 19);
            this.chkUseDefaultCredentials.TabIndex = 13;
            this.chkUseDefaultCredentials.Text = "USE DEFAULTCREDENTIALS";
            this.chkUseDefaultCredentials.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "PROXY ADDRESS";
            // 
            // txtProxyAddress
            // 
            this.txtProxyAddress.Location = new System.Drawing.Point(197, 143);
            this.txtProxyAddress.Name = "txtProxyAddress";
            this.txtProxyAddress.Size = new System.Drawing.Size(156, 23);
            this.txtProxyAddress.TabIndex = 15;
            this.txtProxyAddress.Text = "http://127.0.0.1:8888";
            // 
            // chkByPassOnLocal
            // 
            this.chkByPassOnLocal.AutoSize = true;
            this.chkByPassOnLocal.Location = new System.Drawing.Point(366, 147);
            this.chkByPassOnLocal.Name = "chkByPassOnLocal";
            this.chkByPassOnLocal.Size = new System.Drawing.Size(106, 19);
            this.chkByPassOnLocal.TabIndex = 16;
            this.chkByPassOnLocal.Text = "ByPassOnLocal";
            this.chkByPassOnLocal.UseVisualStyleBackColor = true;
            // 
            // rtbResults
            // 
            this.rtbResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbResults.Location = new System.Drawing.Point(21, 172);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.Size = new System.Drawing.Size(501, 299);
            this.rtbResults.TabIndex = 17;
            this.rtbResults.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 477);
            this.Controls.Add(this.rtbResults);
            this.Controls.Add(this.chkByPassOnLocal);
            this.Controls.Add(this.txtProxyAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkUseDefaultCredentials);
            this.Controls.Add(this.chkEnableProxy);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDefaultRequest);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbSSLVersion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkLoopEnabled);
            this.Controls.Add(this.txtLoops);
            this.Controls.Add(this.txtSSLPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtURL);
            this.Name = "Form1";
            this.Text = "TLS Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSSLPort;
        private System.Windows.Forms.TextBox txtLoops;
        private System.Windows.Forms.CheckBox chkLoopEnabled;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSSLVersion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDefaultRequest;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkEnableProxy;
        private System.Windows.Forms.CheckBox chkUseDefaultCredentials;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProxyAddress;
        private System.Windows.Forms.CheckBox chkByPassOnLocal;
        private System.Windows.Forms.RichTextBox rtbResults;
    }
}

