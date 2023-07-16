using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using System.Collections.Generic;


namespace Discord_Webhook_Tool_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendWebHook();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://support.discord.com/hc/ja/articles/228383668-%E3%82%BF%E3%82%A4%E3%83%88%E3%83%AB-Webhooks%E3%81%B8%E3%81%AE%E5%BA%8F%E7%AB%A0");
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://qiita.com/Uchiiita/items/d65e0f77a8a476aa5ee7#:~:text=%E3%80%8C%E3%82%B5%E3%83%BC%E3%83%90%E3%83%BC%E8%A8%AD%E5%AE%9A%E3%80%8D%E2%86%92%E3%80%8C%E9%80%A3%E6%90%BA%E3%82%B5%E3%83%BC%E3%83%93%E3%82%B9%E3%80%8D%E2%86%92%E3%80%8C%E3%82%A6%E3%82%A7%E3%83%96%E3%83%95%E3%83%83%E3%82%AF%E3%82%92%E4%BD%9C%E6%88%90%E3%80%8D%E2%86%92%E3%80%8C%E3%82%A6%E3%82%A7%E3%83%96%E3%83%95%E3%83%83%E3%82%AFURL%E3%82%92%E3%82%B3%E3%83%94%E3%83%BC%E3%80%8D%E3%81%AE%E9%A0%86%E3%81%A7%E5%8F%96%E5%BE%97%E3%81%A7%E3%81%8D%E3%81%BE%E3%81%99%E3%80%82");
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            About f = new About();
            f.ShowDialog(this);
            f.Dispose();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void menuItem11_Click(object sender, EventArgs e)
        {
            HowToUse f = new HowToUse();
            f.Show(this);
        }
        private void SendWebHook()
        {
            HttpClient httpClient = new HttpClient();
            Dictionary<string, string> strs = new Dictionary<string, string>()
        {
            { "content", textBox4.Text },
            { "username", textBox2.Text },
            { "avatar_url", textBox3.Text }
        };
            TaskAwaiter<HttpResponseMessage> awaiter = httpClient.PostAsync(textBox1.Text, new
            FormUrlEncodedContent(strs)).GetAwaiter();
            awaiter.GetResult();
        }
    }
}