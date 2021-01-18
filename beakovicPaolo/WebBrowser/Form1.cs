using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnnatrag_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void btnNaprijed_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void txtboxHttps_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIdi_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(txtboxHttps.Text);
        }

        private void btnGmail_Click(object sender, EventArgs e)
        {
            
            webBrowser.Navigate("https://www.gmail.com");
        }

        private void btnWebmail_Click(object sender, EventArgs e)
        {
            
            webBrowser.Navigate("https://webmail.carnet.hr");
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            webBrowser.Print();
        }

        private void lblAdresa_Click(object sender, EventArgs e)
        {

        }
    }
}
