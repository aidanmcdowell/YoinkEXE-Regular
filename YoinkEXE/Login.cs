using DiscordRpcDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoinkEXE;

namespace Yoink
{
    public partial class Login : Form
    {
        private DiscordRpc.RichPresence presence;
        private DiscordRpc.EventHandlers handlers;
        public Login()
        {
            InitializeComponent();
            timer6.Start();
            timer5.Start();
            timer1.Start();
            timer2.Start();
            textBox2.Visible = false;
            this.handlers = new DiscordRpc.EventHandlers();
            DiscordRpc.Initialize("560598164046872580", ref this.handlers, true, null);
            this.handlers = new DiscordRpc.EventHandlers();
            DiscordRpc.Initialize("560598164046872580", ref this.handlers, true, null);
            this.presence.details = "Full Lua Script Executor";
            this.presence.state = "Made by Immortal Donkey";
            this.presence.largeImageKey = "yoink_icon_big";
            this.presence.largeImageText = "https://www.immortaldonkeyhacks.weebly.com/free-lua-executor";
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString("https://yoink.roxploits.com/KmNzy4jrho6QUCzge39ig.php");
            if (reply == textBox1.Text)
            {
                for (int i = 1; i <= 9; i++)
                {
                    base.Opacity -= 0.1;
                    await Task.Delay(1);
                }
                base.Opacity = 0.95;
                try
                {
                    this.Hide();
                    new Exploit().Show();
                    Process.Start("https://discord.gg/3ZvDe6j");
                }
                catch
                {
                }
            }
            else
            {
                if ((new WebClient()).DownloadString("https://pastebin.com/raw/FVgM7HDK") == this.textBox1.Text)
                {
                    for (int i = 1; i <= 9; i++)
                    {
                        base.Opacity -= 0.1;
                        await Task.Delay(1);
                    }
                    base.Opacity = 0.95;
                    try
                    {
                        base.Close();
                        new Exploit().Show();
                    }
                    catch
                    {
                    }
                }
                else
                {
                    MessageBox.Show("Login Failed, Click 'Get Key' for the new key!",
                    "Yoink",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://yoink.roxploits.com/");
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 9; i++)
            {
                base.Opacity -= 0.1;
                await Task.Delay(1);
            }
            base.Opacity = 0.95;
            try
            {
                Application.Exit();
            }
            catch
            {
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                WebClient client = new WebClient();
                string reply = client.DownloadString("https://yoink.roxploits.com/KmNzy4jrho6QUCzge39ig.php");
                if (reply == textBox1.Text)
                {
                    this.Hide();
                    new Exploit().Show();
                }
                else
                {
                    if ((new WebClient()).DownloadString("https://pastebin.com/raw/FVgM7HDK") == this.textBox1.Text)
                    {
                        this.Hide();
                        new Exploit().Show();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed, Click 'Get Key' for the new key!",
                        "Yoink",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IsProcessRunning("dnSpy-x86");
            void IsProcessRunning(string sProcessName)
            {
                System.Diagnostics.Process[] proc = System.Diagnostics.Process.GetProcessesByName(sProcessName);
                if (proc.Length > 0)
                {
                    timer1.Stop();
                    Uri url = new Uri(textBox2.Text);
                    webBrowser1.Update();
                    webBrowser1.Url = url;
                    Environment.Exit(6);
                }
                else
                {

                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            IsProcessRunning("dnSpy");
            void IsProcessRunning(string sProcessName)
            {
                System.Diagnostics.Process[] proc = System.Diagnostics.Process.GetProcessesByName(sProcessName);
                if (proc.Length > 0)
                {
                    timer2.Stop();
                    Uri url = new Uri(textBox2.Text);
                    webBrowser1.Update();
                    webBrowser1.Url = url;
                    Environment.Exit(6);
                }
                else
                {

                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            IsProcessRunning("Fiddler");
            void IsProcessRunning(string sProcessName)
            {
                System.Diagnostics.Process[] proc = System.Diagnostics.Process.GetProcessesByName(sProcessName);
                if (proc.Length > 0)
                {
                    timer2.Stop();
                    Uri url = new Uri(textBox2.Text);
                    webBrowser1.Update();
                    webBrowser1.Url = url;
                    Environment.Exit(6);
                }
                else
                {

                }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            IsProcessRunning("JetBrains dotPeek");
            void IsProcessRunning(string sProcessName)
            {
                System.Diagnostics.Process[] proc = System.Diagnostics.Process.GetProcessesByName(sProcessName);
                if (proc.Length > 0)
                {
                    timer2.Stop();
                    Uri url = new Uri(textBox2.Text);
                    webBrowser1.Update();
                    webBrowser1.Url = url;
                    Environment.Exit(6);
                }
                else
                {

                }
            }
        }

        private async void timer5_Tick(object sender, EventArgs e)
        {
            this.timer5.Stop();
            for (int i = 1; i <= 9; i++)
            {
                base.Opacity += 0.1;
                await Task.Delay(1);
            }
            base.Opacity = 1;
        }

        private void timer7_Tick(object sender, EventArgs e)
        {

        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (NamedPipes.NamedPipeExist(NamedPipes.luapipename))
            {

            }
            else
            {
                timer6.Stop();
                WebClient webClient = new WebClient();
                string str1 = webClient.DownloadString("https://pastebin.com/raw/dtSjwNw2");
                webClient.DownloadFile(str1, "Yoink.dll");
            }  
        }
    }
}
