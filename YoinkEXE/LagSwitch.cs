using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetFwTypeLib;

namespace YoinkEXE
{
    public partial class LagSwitch : Form
    {
        public LagSwitch()
        {
            InitializeComponent();
            label3.Visible = false;
            label2.Text = "Server is stable...";
            this.label2.ForeColor = Color.Lime;
            timer2.Start();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Lagging Server...";
            this.label2.ForeColor = Color.Red;
            label3.Visible = true;
            timer1.Start();
            try
            {
                INetFwRule fileName = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
                fileName.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
                fileName.ApplicationName = Process.GetProcessById(Process.GetProcessesByName("RobloxPlayerBeta")[0].Id).MainModule.FileName;
                fileName.Description = "Yoink Executor Lag Switch";
                fileName.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
                fileName.Enabled = true;
                fileName.InterfaceTypes = "All";
                fileName.Name = "Yoink Executor Lag Switch";
                ((INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"))).Rules.Add(fileName);
                await Task.Delay(7000);
                try
                {
                    ((INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"))).Rules.Remove("Yoink Executor Lag Switch");
                }
                catch
                {
                }
            }
            catch
            {
                MessageBox.Show("Please open ROBLOX first!");
                base.Close();
            }
        }

        private void LagSwitch_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Delay(1000);
            label3.Visible = false;
            label2.Text = "Server is stable...";
            this.label2.ForeColor = Color.Lime;
            try
            {
                ((INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"))).Rules.Remove("Yoink Executor Lag Switch");
            }
            catch
            {
            }
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                LagSwitch.ReleaseCapture();
                LagSwitch.SendMessage(base.Handle, 161, 2, 0);
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = "(7)";
            timer1.Stop();
            label3.Visible = true;
            await Task.Delay(1000);
            label3.Text = "(6)";
            await Task.Delay(1000);
            label3.Text = "(5)";
            await Task.Delay(1000);
            label3.Text = "(4)";
            await Task.Delay(1000);
            label3.Text = "(3)";
            await Task.Delay(1000);
            label3.Text = "(2)";
            await Task.Delay(1000);
            label3.Text = "(1)";
            await Task.Delay(1000);
            label3.Text = "(0)";
            await Task.Delay(400);
            label3.Visible = false;
            label2.Text = "Server is stable...";
            label2.ForeColor = Color.Lime;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            IsProcessRunning("RobloxPlayerBeta");
            void IsProcessRunning(string sProcessName)
            {
                System.Diagnostics.Process[] proc = System.Diagnostics.Process.GetProcessesByName(sProcessName);
                if (proc.Length > 0)
                {
                    
                }
                else
                {
                    ((INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"))).Rules.Remove("Yoink Executor Lag Switch");
                    base.Close();
                }
            }
        }
    }
}
