namespace WebBrowser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnnatrag = new System.Windows.Forms.Button();
            this.btnNaprijed = new System.Windows.Forms.Button();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txtboxHttps = new System.Windows.Forms.TextBox();
            this.btnIdi = new System.Windows.Forms.Button();
            this.btnGmail = new System.Windows.Forms.Button();
            this.btnWebmail = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnnatrag
            // 
            this.btnnatrag.Location = new System.Drawing.Point(27, 13);
            this.btnnatrag.Name = "btnnatrag";
            this.btnnatrag.Size = new System.Drawing.Size(75, 23);
            this.btnnatrag.TabIndex = 0;
            this.btnnatrag.Text = "Natrag";
            this.btnnatrag.UseVisualStyleBackColor = true;
            this.btnnatrag.Click += new System.EventHandler(this.btnnatrag_Click);
            // 
            // btnNaprijed
            // 
            this.btnNaprijed.Location = new System.Drawing.Point(119, 13);
            this.btnNaprijed.Name = "btnNaprijed";
            this.btnNaprijed.Size = new System.Drawing.Size(75, 23);
            this.btnNaprijed.TabIndex = 1;
            this.btnNaprijed.Text = "Naprijed";
            this.btnNaprijed.UseVisualStyleBackColor = true;
            this.btnNaprijed.Click += new System.EventHandler(this.btnNaprijed_Click);
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(260, 16);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(53, 17);
            this.lblAdresa.TabIndex = 2;
            this.lblAdresa.Text = "Adresa";
            this.lblAdresa.Click += new System.EventHandler(this.lblAdresa_Click);
            // 
            // txtboxHttps
            // 
            this.txtboxHttps.Location = new System.Drawing.Point(332, 12);
            this.txtboxHttps.Name = "txtboxHttps";
            this.txtboxHttps.Size = new System.Drawing.Size(351, 22);
            this.txtboxHttps.TabIndex = 3;
            this.txtboxHttps.Text = "https://";
            this.txtboxHttps.TextChanged += new System.EventHandler(this.txtboxHttps_TextChanged);
            // 
            // btnIdi
            // 
            this.btnIdi.Location = new System.Drawing.Point(700, 11);
            this.btnIdi.Name = "btnIdi";
            this.btnIdi.Size = new System.Drawing.Size(75, 23);
            this.btnIdi.TabIndex = 4;
            this.btnIdi.Text = "Idi";
            this.btnIdi.UseVisualStyleBackColor = true;
            this.btnIdi.Click += new System.EventHandler(this.btnIdi_Click);
            // 
            // btnGmail
            // 
            this.btnGmail.Location = new System.Drawing.Point(796, 11);
            this.btnGmail.Name = "btnGmail";
            this.btnGmail.Size = new System.Drawing.Size(75, 23);
            this.btnGmail.TabIndex = 5;
            this.btnGmail.Text = "Gmail";
            this.btnGmail.UseVisualStyleBackColor = true;
            this.btnGmail.Click += new System.EventHandler(this.btnGmail_Click);
            // 
            // btnWebmail
            // 
            this.btnWebmail.Location = new System.Drawing.Point(888, 11);
            this.btnWebmail.Name = "btnWebmail";
            this.btnWebmail.Size = new System.Drawing.Size(75, 23);
            this.btnWebmail.TabIndex = 6;
            this.btnWebmail.Text = "Webmail";
            this.btnWebmail.UseVisualStyleBackColor = true;
            this.btnWebmail.Click += new System.EventHandler(this.btnWebmail_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(969, 11);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(75, 23);
            this.btnIspis.TabIndex = 7;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(27, 52);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1017, 490);
            this.webBrowser.TabIndex = 9;
            this.webBrowser.Url = new System.Uri("http://web2.ss-zcrnje-rovinj.skole.hr/", System.UriKind.Absolute);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnWebmail);
            this.Controls.Add(this.btnGmail);
            this.Controls.Add(this.btnIdi);
            this.Controls.Add(this.txtboxHttps);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.btnNaprijed);
            this.Controls.Add(this.btnnatrag);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnnatrag;
        private System.Windows.Forms.Button btnNaprijed;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox txtboxHttps;
        private System.Windows.Forms.Button btnIdi;
        private System.Windows.Forms.Button btnGmail;
        private System.Windows.Forms.Button btnWebmail;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

