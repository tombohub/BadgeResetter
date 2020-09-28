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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.FormClosed += Form_FormClosed;                        
        }

        public void resetBadge_Click(object sender, EventArgs e)
        {

            bool errorExists = false;
            Subreddit noFap = new Subreddit();
            Subreddit pornFree = new Subreddit();

            if (checkboxNoFap.Checked)
            {
                noFap.date = datePickerNoFap.Value.ToString("yyyy-MM-dd");
                noFap.name = "/r/stopdrinking";
                

                try
                {
                    noFap.ResetBadge(noFap.name, noFap.date);
                }
                catch
                {
                    errorExists = true;
                }
            }

            if (checkboxPornFree.Checked)
            {
                pornFree.date = datePickerPornFree.Value.ToString("yyyy-MM-dd");
                pornFree.name = "/r/stopsmoking";
                pornFree.wrongCaptcha = true;

                try
                {
                    pornFree.ResetBadge(pornFree.name, pornFree.date);
                }
                catch
                {
                    errorExists = true;
                }
            }

            
            if (errorExists)
            {
                Form3 form3 = new Form3(noFap, pornFree);
                this.Dispose();
                form3.Show();
            }
            
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
