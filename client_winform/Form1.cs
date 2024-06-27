using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace client_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //почему асинк
        private async void button1_Click(object sender, EventArgs e)
        {
            string jsonData = await Task.Factory.StartNew(() => JsonConvert.SerializeObject(textBox1.Text));

            //http://localhost:51437/Home/Hello
            WebRequest webRequest = WebRequest.Create("http://localhost:51437/Home/Hello");

            webRequest.Method = "POST";

            string query = $"name={jsonData}";

            byte[] byteMessage = Encoding.UTF8.GetBytes(query);

            webRequest.ContentType = "application/x-www-form-urlencoded";

            webRequest.ContentLength = byteMessage.Length;

            using(Stream stream = await webRequest.GetRequestStreamAsync())
            {
                await stream.WriteAsync(byteMessage, 0, byteMessage.Length);
            }

            WebResponse webResponse = await webRequest.GetResponseAsync();

            string answer = null;

            using (Stream s = webResponse.GetResponseStream())
            {
                using (StreamReader sR = new StreamReader(s))
                {
                    answer = await sR.ReadToEndAsync();
                }
            }
            
            webResponse.Close();

            MessageBox.Show(answer);
        }
    }
}
