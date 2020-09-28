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

        private Subreddit stopSmoking;
        private Subreddit stopDrinking;
        private TextBox textBoxStopSmoking;
        private TextBox textBoxStopDrinking;
        
        public Form3(Subreddit stopSmoking, Subreddit stopDrinking)
        {
            this.stopSmoking = stopSmoking;
            this.stopDrinking = stopDrinking;
            InitializeComponent();
            DisplayCaptchas();
            this.FormClosed += Form_FormClosed;
        }

        private void DisplayCaptchas()
        {
            string captcha = "<style>html,body{{margin:0; padding:0}}</style>" + 
                "<img src=\"http://www.reddit.com/captcha/{0}.png\"></img>";

            if (stopSmoking.wrongCaptcha)
            {
                WebBrowser webBrowserStopSmoking = new WebBrowser();
                webBrowserStopSmoking.DocumentText = String.Format(captcha, stopSmoking.iden);
                webBrowserStopSmoking.Anchor = System.Windows.Forms.AnchorStyles.None;
                webBrowserStopSmoking.Location = new System.Drawing.Point(45, 55);
                webBrowserStopSmoking.MinimumSize = new System.Drawing.Size(20, 20);
                webBrowserStopSmoking.Name = "webBrowserStopSmoking";
                webBrowserStopSmoking.ScrollBarsEnabled = false;
                webBrowserStopSmoking.Size = new System.Drawing.Size(120, 50);
                webBrowserStopSmoking.TabIndex = 0;
                webBrowserStopSmoking.TabStop = false;
                Controls.Add(webBrowserStopSmoking);
                

                textBoxStopSmoking = new TextBox();
                textBoxStopSmoking.Location = new System.Drawing.Point(54, 109);
                textBoxStopSmoking.Name = "textBoxStopSmoking";
                textBoxStopSmoking.Size = new System.Drawing.Size(100, 20);
                textBoxStopSmoking.TabIndex = 2;
                this.Controls.Add(textBoxStopSmoking);
            }

            if (stopDrinking.wrongCaptcha)
            {
                WebBrowser webBrowserStopDrinking = new WebBrowser();
                webBrowserStopDrinking.DocumentText = String.Format(captcha, stopDrinking.iden);
                webBrowserStopDrinking.Anchor = System.Windows.Forms.AnchorStyles.None;
                webBrowserStopDrinking.Location = new System.Drawing.Point(45, 176);
                webBrowserStopDrinking.MinimumSize = new System.Drawing.Size(20, 20);
                webBrowserStopDrinking.Name = "webBrowserStopDrinking";
                webBrowserStopDrinking.ScrollBarsEnabled = false;
                webBrowserStopDrinking.Size = new System.Drawing.Size(120, 50);
                webBrowserStopDrinking.TabIndex = 1;
                webBrowserStopDrinking.TabStop = false;
                Controls.Add(webBrowserStopDrinking);

                textBoxStopDrinking = new TextBox();
                textBoxStopDrinking.Location = new System.Drawing.Point(54, 232);
                textBoxStopDrinking.Name = "textBoxStopDrinking";
                textBoxStopDrinking.Size = new System.Drawing.Size(100, 20);
                textBoxStopDrinking.TabIndex = 3;
                Controls.Add(textBoxStopDrinking);
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
            if (stopSmoking.wrongCaptcha)
            {
                string captchaNofap = textBoxStopSmoking.Text;
                ResetBadge(stopSmoking, captchaNofap);
            }

            if (stopDrinking.wrongCaptcha)
            {
                string captchaPornfree = textBoxStopDrinking.Text;
                ResetBadge(stopDrinking, captchaPornfree);
            }

            if (stopSmoking.wrongCaptcha || stopDrinking.wrongCaptcha)
            {
                this.Dispose();
                Form3 form3 = new Form3(stopSmoking, stopDrinking);
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
