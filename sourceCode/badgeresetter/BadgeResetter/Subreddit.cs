using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace BadgeResetter
{
    public class Subreddit
    {
        public string iden { get; private set; }
        public string name { get; set; }
        public string date { get; set; }
        public bool wrongCaptcha { get; set; }

        public void ResetBadge(string name, string date, string iden = "", string captcha = "")
        {
            string postData = "to=badgebot" +
                              "&subject=" + name +
                              "&text=" + date +
                              "&uh=" + User.modhash +
                              "&iden=" + iden +
                              "&captcha=" + captcha +
                              "&api_type=json";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.reddit.com/api/compose");
            request.Method = "POST";
            request.ContentLength = postData.Length;
            request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
            request.UserAgent = "testing testing cikatomo";
            request.Headers.Set("Cookie", User.cookie);

            StreamWriter write = new StreamWriter(request.GetRequestStream());
            write.Write(postData);
            write.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader read = new StreamReader(response.GetResponseStream());
            string json = read.ReadToEnd();
            response.Close();


            JavaScriptSerializer ser = new JavaScriptSerializer();
            dynamic jsonDeserialized = ser.DeserializeObject(json);


            object[] errors = jsonDeserialized["json"]["errors"];

            if (errors.Length > 0)
            {
                this.iden = jsonDeserialized["json"]["captcha"];
                this.wrongCaptcha = true;
                string errorType = jsonDeserialized["json"]["errors"][0][0];
                string errorMessage = jsonDeserialized["json"]["errors"][0][1];
                throw new Exception("Reddit says: " + errorType + ": " + errorMessage);
            }

            this.wrongCaptcha = false;
        }
    }
}
