using DiscordRpcDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yoink
{
    public partial class Loading : Form
    {
        private DiscordRpc.RichPresence presence;
        private DiscordRpc.EventHandlers handlers;
        Timer timer2 = new Timer();
        public Loading()
        {
            InitializeComponent();
            this.handlers = new DiscordRpc.EventHandlers();
            DiscordRpc.Initialize("560598164046872580", ref this.handlers, true, null);
            this.handlers = new DiscordRpc.EventHandlers();
            DiscordRpc.Initialize("560598164046872580", ref this.handlers, true, null);
            this.presence.details = "Full Lua Script Executor";
            this.presence.state = "Made by Immortal Donkey";
            this.presence.largeImageKey = "yoink_icon_big";
            this.presence.largeImageText = "https://www.immortaldonkeyhacks.weebly.com/free-lua-executor";
            DiscordRpc.UpdatePresence(ref this.presence);
            if ((new WebClient()).DownloadString("https://pastebin.com/raw/W3GzAp5e").Contains("44"))
            {
                MessageBox.Show("A new update for Yoink has been detected!\nYou will now be redirected to the download website!", "Yoink");
                Process.Start("https://immortaldonkeyhacks.weebly.com/free-lua-executor.html");
                Task.Delay(1000);
                Environment.Exit(0);
            }
            else
            {
                IsProcessRunning("WinRAR");
                void IsProcessRunning(string sProcessName)
                {
                    System.Diagnostics.Process[] proc = System.Diagnostics.Process.GetProcessesByName(sProcessName);
                    if (proc.Length > 0)
                    {
                        MessageBox.Show("Please close all WinRAR windows\n\nIF YOU ARE RUNNING YOINK FROM WINRAR, PLEASE EXTRACT THE YOINK EXECUTOR FOLDER TO YOUR DESKTOP AND CLOSE WINRAR", "Yoink", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Environment.Exit(0);
                    }
                    else
                    {
                        panel2.Left = 0;
                    }
                }
            }
            timer4.Start();
        }

        int plus = 2;


        void move(object sender, EventArgs e)
        {
            panel2.Left = panel2.Left + plus;

            if (panel2.Left > 115)
            {
                plus = -2;
            }
            if (panel2.Left < 0)
            {
                plus = 2;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(move);
            timer1.Start();
            timer1.Interval = 1;
            timer3.Start();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
        }

        private async void Timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            for (int i = 1; i <= 9; i++)
            {
                base.Opacity -= 0.1;
                await Task.Delay(1);
            }
            base.Opacity = 0.95;
            try
            {
                this.Hide();
                new Login().Show();
            }
            catch
            {
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
