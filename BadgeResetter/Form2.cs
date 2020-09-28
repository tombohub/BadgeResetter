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
            Subreddit stopSmoking = new Subreddit();
            Subreddit stopDrinking = new Subreddit();

            if (checkboxStopSmoking.Checked)
            {
                stopSmoking.date = datePickerStopSmoking.Value.ToString("yyyy-MM-dd");
                stopSmoking.name = "/r/stopsmoking";
                

                try
                {
                    stopSmoking.ResetBadge(stopSmoking.name, stopSmoking.date);
                }
                catch
                {
                    errorExists = true;
                }
            }

            if (checkboxStopDrinking.Checked)
            {
                stopDrinking.date = datePickerStopDrinking.Value.ToString("yyyy-MM-dd");
                stopDrinking.name = "/r/stopdrinking";
                stopDrinking.wrongCaptcha = true;

                try
                {
                    stopDrinking.ResetBadge(stopDrinking.name, stopDrinking.date);
                }
                catch
                {
                    errorExists = true;
                }
            }

            
            if (errorExists)
            {
                Form3 form3 = new Form3(stopSmoking, stopDrinking);
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
