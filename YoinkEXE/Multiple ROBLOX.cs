using DiscordRpcDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoinkEXE
{
    public partial class Multiple_ROBLOX : Form
    {
        private DiscordRpc.RichPresence presence;
        private DiscordRpc.EventHandlers handlers;
        public Multiple_ROBLOX()
        {
            InitializeComponent();
            timer1.Start();
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Multiple_ROBLOX.ReleaseCapture();
                Multiple_ROBLOX.SendMessage(base.Handle, 161, 2, 0);
            }
        }

        [DllImport("User32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public class FileObject
        {
            public string FileContent
            {
                get;
                set;
            }

            public string FileName
            {
                get;
                set;
            }

            public FileObject()
            {
            }
        }

        private void Multiple_ROBLOX_Load(object sender, EventArgs e)
        {
            Mutex mutex = new Mutex(true, "ROBLOX_singletonMutex");
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            base.Close();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

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
                base.Close();
            }
            catch
            {
            }
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 9; i++)
            {
                base.Opacity -= 0.1;
                await Task.Delay(1);
            }
            base.WindowState = FormWindowState.Minimized;
            base.Opacity = 0.95;
        }

        private async void timer1_Tick_1(object sender, EventArgs e)
        {
            this.timer1.Stop();
            for (int i = 1; i <= 9; i++)
            {
                base.Opacity += 0.1;
                await Task.Delay(1);
            }
            base.Opacity = 1;
        }
    }
}
