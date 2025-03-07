using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoinkEXE
{
    public partial class Form1 : Form
    {
        private string FileLocation = "";
        SoundPlayer player = new SoundPlayer();
        private OpenFileDialog ofd = new OpenFileDialog();
        private string PipeFormat;
        private object pipe;
        private object wrdpipe;

        public Form1()
        {
            InitializeComponent();
            this.player.SoundLocation = "Music.wav";
            if ((new WebClient()).DownloadString("https://pastebin.com/raw/rBW610P8").Contains("19"))
            {
                label1.Text = "     Patched";
                label1.ForeColor = System.Drawing.Color.Yellow;
                label2.Visible = true;
                label2.Text = "Yoink Executor is currently patched! Please wait for the new update!";
                label2.ForeColor = System.Drawing.Color.Yellow;
                label5.Visible = false;
                button1.Visible = false;
                metroButton1.Visible = false;
                richTextBox1.Visible = false;
            }
            else
            {
                label2.Visible = false;
                button1.Visible = true;
                metroButton1.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.FileLocation != "")
            {
                try
                {
                    File.WriteAllText(this.FileLocation, this.fastColoredTextBox1.Text);
                }
                catch
                {
                }
            }
            else
            {
                if (this.saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                {
                    return;
                }
                try
                {
                    this.FileLocation = this.saveFileDialog1.FileName;
                    File.Create(this.saveFileDialog1.FileName).Close();
                    File.WriteAllText(this.saveFileDialog1.FileName, this.fastColoredTextBox1.Text);
                }
                catch
                {
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.ofd.Filter = "Text files (*.txt)|*.txt";
            if (this.ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string str = File.ReadAllText(this.ofd.FileName);
                this.fastColoredTextBox1.Text = str;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (NamedPipes.NamedPipeExist(NamedPipes.luapipename))//check if the pipe exist
            {
                NamedPipes.LuaPipe(fastColoredTextBox1.Text);//lua pipe function to send the script
            }
            else
            {
                MessageBox.Show("Inject " + Functions.exploitdllname + " before Using this!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//if the pipe can't be found a messagebox will appear
                return;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if ((new WebClient()).DownloadString("https://pastebin.com/raw/rBW610P8").Contains("19"))
            {
                
            }
            else
            {

                timer4.Start();
                await Task.Delay(800);
                Functions.Inject();
                this.timer1.Start();

                switch (Injector.DllInjector.GetInstance.Inject("RobloxPlayerBeta", string.Concat(AppDomain.CurrentDomain.BaseDirectory, Functions.exploitdllname)))
                {
                    case Injector.DllInjectionResult.DllNotFound:
                        {
                            MessageBox.Show(string.Concat("couldn't find", Functions.exploitdllname), "Dll was not found!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            break;
                        }
                    case Injector.DllInjectionResult.GameProcessNotFound:
                        {
                            MessageBox.Show("Couldn't find RobloxPlayerBeta.exe!", "Target process was not found!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            break;
                        }
                    case Injector.DllInjectionResult.InjectionFailed:
                        {
                            MessageBox.Show("Injection Failed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            break;
                        }
                    case Injector.DllInjectionResult.Success:
                        {
                            timer2.Start();

                            break;
                        }
                    default:
                        {
                            Thread.Sleep(3000);
                            if (NamedPipes.NamedPipeExist(NamedPipes.luapipename))
                            {
                            }
                            break;
                        }
                }
            }
            
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Form1.ReleaseCapture();
                Form1.SendMessage(base.Handle, 161, 2, 0);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("Scripts"))
            {
                Directory.CreateDirectory("Scripts");
            }
            string[] files = Directory.GetFiles("Scripts");
            for (int i = 0; i < (int)files.Length; i++)
            {
                string str = files[i];
                this.listBox1.Items.Add(Path.GetFileName(str));
            }
            this.fastColoredTextBox1.Language = Language.Lua;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TabPage tabPage = new TabPage("Untitled");
                this.fastColoredTextBox1.Text = File.ReadAllText(this.listBox1.Items[this.listBox1.SelectedIndex].ToString().Replace(this.listBox1.SelectedItem.ToString(), string.Concat("Scripts\\", this.listBox1.SelectedItem.ToString())));
            }
            catch
            {
                MessageBox.Show("Please select an item!");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.player.Play();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.player.Stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Roblox is now reinstalling!\nThis could take a while, please wait patiently.", "Yoink", MessageBoxButtons.OK);
            try
            {
                Process[] processesByName = Process.GetProcessesByName("RobloxPlayerBeta");
                for (int i = 0; i < (int)processesByName.Length; i++)
                {
                    processesByName[i].Kill();
                }
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                MessageBox.Show(Convert.ToString(exception), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            try
            {
                Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));
                if (Directory.Exists("Roblox"))
                {
                    Directory.Delete("Roblox", true);
                }
            }
            catch
            {
            }
            try
            {
                Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
                if (Directory.Exists("Roblox"))
                {
                    Directory.Delete("Roblox", true);
                }
                if (File.Exists("Installer.exe"))
                {
                    File.Delete("Installer.exe");
                }
            }
            catch
            {
            }
            (new WebClient()).DownloadFile("http://setup.roblox.com/RobloxPlayerLauncher.exe", "Installer.exe");
            Process.Start("Installer.exe");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Multiple_ROBLOX temp = new Multiple_ROBLOX();
            temp.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("https://immortaldonkey.weebly.com/fix-yoink-executor.html");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
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
                    timer2.Stop();
                    timer3.Stop();
                    label1.Text = "Not Injected";
                    label1.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start("https://immortaldonkey.weebly.com/change-music.html");
        }

        private void metroListbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TabPage tabPage = new TabPage("Untitled");
                this.fastColoredTextBox1.Text = File.ReadAllText(this.listBox1.Items[this.listBox1.SelectedIndex].ToString().Replace(this.listBox1.SelectedItem.ToString(), string.Concat("Scripts\\", this.listBox1.SelectedItem.ToString())));
            }
            catch
            {
                MessageBox.Show("Please select an item!");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private async void timer2_Tick_1(object sender, EventArgs e)
        {
            if ("Not Injected".Contains(label1.Text))
            {
                label1.Text = "Injecting...";
                label1.ForeColor = System.Drawing.Color.Yellow;
            }
            await Task.Delay(50);
            if (NamedPipes.NamedPipeExist(NamedPipes.luapipename))
            {
                label1.Text = "    Injected";
                label1.ForeColor = System.Drawing.Color.Lime;
                timer3.Start();
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            timer2.Enabled = false;
            timer3.Stop();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            label1.Text = "Injecting...";
            label1.ForeColor = System.Drawing.Color.Yellow;
            timer4.Stop();
        }
    }
}
