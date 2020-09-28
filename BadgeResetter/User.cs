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
    public class User
    {

        public static string modhash { get; private set; }
        public static string cookie { get; private set; }
        


        /// <summary>
        /// Login to Reddit and sets modhash and cookie
        /// </summary>
        /// <param name="username">Reddit Username</param>
        /// <param name="password">Reddit Password</param>
        
        public static void Login(string username, string password)
        {
            string postData = "user="       + username + 
                              "&passwd="    + password + 
                              "&api_type=json";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://ssl.reddit.com/api/login/" + username);
            request.Method         = "POST";
            request.ContentLength  = postData.Length;
            request.ContentType    = "application/x-www-form-urlencoded; charset=UTF-8";
            request.UserAgent      = "BadgeResetter";

            StreamWriter write = new StreamWriter(request.GetRequestStream());
            write.Write(postData);
            write.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader read        = new StreamReader(response.GetResponseStream());
            string json              = read.ReadToEnd();
            response.Close();


            JavaScriptSerializer ser = new JavaScriptSerializer();
            dynamic jsonDeserialized = ser.DeserializeObject(json);

            
            object[] errors = jsonDeserialized["json"]["errors"];

            if (errors.Length > 0)
            {
                string errorMessage = jsonDeserialized["json"]["errors"][0][1];
                throw new Exception("Reddit says: " + errorMessage);
            }

            modhash = jsonDeserialized["json"]["data"]["modhash"];
            cookie  = "reddit_session=" + jsonDeserialized["json"]["data"]["cookie"];
        }

        
        
        
    }
}
