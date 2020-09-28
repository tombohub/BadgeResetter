using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BadgeResetter
{
    public partial class Form3 : Form
    {

        private Subreddit nofap;
        private Subreddit pornfree;
        private TextBox textBoxNofap;
        private TextBox textBoxPornfree;
        
        public Form3(Subreddit nofap, Subreddit pornfree)
        {
            this.nofap = nofap;
            this.pornfree = pornfree;
            InitializeComponent();
            DisplayCaptchas();
            this.FormClosed += Form_FormClosed;
        }

        private void DisplayCaptchas()
        {
            string captcha = "<style>html,body{{margin:0; padding:0}}</style>" + 
                "<img src=\"http://www.reddit.com/captcha/{0}.png\"></img>";

            if (nofap.wrongCaptcha)
            {
                WebBrowser webBrowserNofap = new WebBrowser();
                webBrowserNofap.DocumentText = String.Format(captcha, nofap.iden);
                webBrowserNofap.Anchor = System.Windows.Forms.AnchorStyles.None;
                webBrowserNofap.Location = new System.Drawing.Point(45, 55);
                webBrowserNofap.MinimumSize = new System.Drawing.Size(20, 20);
                webBrowserNofap.Name = "webBrowserNofap";
                webBrowserNofap.ScrollBarsEnabled = false;
                webBrowserNofap.Size = new System.Drawing.Size(120, 50);
                webBrowserNofap.TabIndex = 0;
                webBrowserNofap.TabStop = false;
                Controls.Add(webBrowserNofap);
                

                textBoxNofap = new TextBox();
                textBoxNofap.Location = new System.Drawing.Point(54, 109);
                textBoxNofap.Name = "textBoxNofap";
                textBoxNofap.Size = new System.Drawing.Size(100, 20);
                textBoxNofap.TabIndex = 2;
                this.Controls.Add(textBoxNofap);
            }

            if (pornfree.wrongCaptcha)
            {
                WebBrowser webBrowserPornfree = new WebBrowser();
                webBrowserPornfree.DocumentText = String.Format(captcha, pornfree.iden);
                webBrowserPornfree.Anchor = System.Windows.Forms.AnchorStyles.None;
                webBrowserPornfree.Location = new System.Drawing.Point(45, 176);
                webBrowserPornfree.MinimumSize = new System.Drawing.Size(20, 20);
                webBrowserPornfree.Name = "webBrowserPornfree";
                webBrowserPornfree.ScrollBarsEnabled = false;
                webBrowserPornfree.Size = new System.Drawing.Size(120, 50);
                webBrowserPornfree.TabIndex = 1;
                webBrowserPornfree.TabStop = false;
                Controls.Add(webBrowserPornfree);

                textBoxPornfree = new TextBox();
                textBoxPornfree.Location = new System.Drawing.Point(54, 232);
                textBoxPornfree.Name = "textBoxPornfree";
                textBoxPornfree.Size = new System.Drawing.Size(100, 20);
                textBoxPornfree.TabIndex = 3;
                Controls.Add(textBoxPornfree);
            }
            

            
        }

        private void ResetBadge(Subreddit subreddit, string captcha)
        {
            if (subreddit.wrongCaptcha)
            {
                try
                {
                    subreddit.ResetBadge(subreddit.name, subreddit.date, subreddit.iden, captcha);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (nofap.wrongCaptcha)
            {
                string captchaNofap = textBoxNofap.Text;
                ResetBadge(nofap, captchaNofap);
            }

            if (pornfree.wrongCaptcha)
            {
                string captchaPornfree = textBoxPornfree.Text;
                ResetBadge(pornfree, captchaPornfree);
            }

            if (nofap.wrongCaptcha || pornfree.wrongCaptcha)
            {
                this.Dispose();
                Form3 form3 = new Form3(nofap, pornfree);
                form3.Show();
            }
            else
            {
                Form4 form4 = new Form4();
                this.Dispose();
                form4.Show();
            }
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
