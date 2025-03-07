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
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using YoinkEXE;
using DiscordRpcDemo;
using Microsoft.Win32;

namespace Yoink
{
    public partial class Exploit : Form
    {
        private string FileLocation = "";
        private DiscordRpc.RichPresence presence;
        private DiscordRpc.EventHandlers handlers;
        SoundPlayer player = new SoundPlayer();
        private OpenFileDialog ofd = new OpenFileDialog();
        private string PipeFormat;
        private object pipe;
        private object wrdpipe;

        string topMostValue = File.ReadAllText("Properties/TopMost.txt");
        string fadeValue = File.ReadAllText("Properties/Fading.txt");
        string autoinjectValue = File.ReadAllText("Properties/Auto-Inject.txt");

        public Exploit()
        {
            InitializeComponent();
            try
            {
                if (topMostValue == "1")
                {
                   checkBox1.Checked = true;
                }
                else
                {
                    checkBox1.Checked = false;
                }


                if (autoinjectValue == "1")
                {
                    checkBox3.Checked = true;
                }
                else
                {
                    checkBox3.Checked = false;
                }


                if (fadeValue == "true")
                {
                    checkBox2.Checked = true;
                }
                else
                {
                    checkBox2.Checked = false;
                }
            }
            catch { }
            panel16.Visible = false;
            timer15.Start();
            timer8.Start();
            timer9.Start();
            timer11.Start();
            timer13.Start();
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
            this.Size = new Size(710, 351);
            this.player.SoundLocation = "Music.wav";
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Lua;
            if ((new WebClient()).DownloadString("https://pastebin.com/raw/rBW610P8").Contains("30"))
            {
                label4.Visible = false;
                label2.Visible = true;
                button11.Visible = false;
            }
            else
            {
                label2.Visible = false;
            }

            if ((new WebClient()).DownloadString("https://pastebin.com/raw/rBW610P8").Contains("30"))
            {
                if (!File.Exists("Updater.exe"))
                {
                    MessageBox.Show("Yoink Updater was not found. Please redownload Yoink");
                }
                else
                {
                    Process.Start("Updater.exe");
                }
            }
            else
            {

            }
        }

        private async void Button4_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 9; i++)
            {
                base.Opacity -= 0.1;
                await Task.Delay(1);
            }
            base.Opacity = 1;
            try
            {
                Process[] processesByName = Process.GetProcessesByName("YoinkEXE");
                for (int i = 0; i < (int)processesByName.Length; i++)
                {
                    processesByName[i].Kill();
                }
                Application.Exit();
            }
            catch
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void flatTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    TabPage tabPage = new TabPage("Untitled");
            //    this.fastColoredTextBox1.Text = File.ReadAllText(this.listBox1.Items[this.listBox1.SelectedIndex].ToString().Replace(this.listBox1.SelectedItem.ToString(), string.Concat("Scripts\\", this.listBox1.SelectedItem.ToString())));
            //}
            //catch
            //{
            //    MessageBox.Show("Please select an item!");
            //}
        }

        private void Exploit_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Scripts");
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] files = directoryInfo.GetFiles("*.lua");
            foreach (FileInfo fileInfo in files)
            {
                this.dirs.Add(fileInfo.Name, File.ReadAllText(fileInfo.FullName));
                this.listBox1.Items.Add(fileInfo.Name);
            }
            FileInfo[] files2 = directoryInfo.GetFiles("*.txt");
            foreach (FileInfo fileInfo2 in files2)
            {
                this.dirs.Add(fileInfo2.Name, File.ReadAllText(fileInfo2.FullName));
                this.listBox1.Items.Add(fileInfo2.Name);
            }

            this.editor = this.webBrowser3;
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
                string friendlyName = AppDomain.CurrentDomain.FriendlyName;
                if (registryKey.GetValue(friendlyName) == null)
                {
                    registryKey.SetValue(friendlyName, 11001, RegistryValueKind.DWord);
                }
            }
            catch (Exception exception)
            {
            }
            this.editor.Url = new Uri(string.Format("file:///{0}/Properties/Monaco/Monaco.html", Directory.GetCurrentDirectory()));
            this.webBrowser3.Document.InvokeScript("SetTheme", new object[] { "Dark" });
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 9; i++)
            {
                base.Opacity -= 0.1;
                await Task.Delay(1);
            }
            base.WindowState = FormWindowState.Minimized;
            base.Opacity = 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start("https://immortaldonkey.weebly.com/change-music.html");
        }

        private async Task button11_ClickAsync(object sender, EventArgs e)
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
                    label4.Text = "waiting for roblox...";
                    label4.ForeColor = System.Drawing.Color.Red;
                }
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
            label4.Text = "connecting...";
            label4.ForeColor = System.Drawing.Color.Yellow;
            timer4.Stop();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.player.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Text files (.txt)|*.txt"
            };
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string text = File.ReadAllText(ofd.FileName);
                this.webBrowser3.Document.InvokeScript("SetText", new string[] {text});
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            using (SaveFileDialog SFD = new SaveFileDialog())
            {
                SFD.Filter = "Text File (*.txt)|*.txt|Lua Script (*.lua)|*.lua|All Files (*.*)|*.*";
                SFD.Title = "Yoink Save Script";
                SFD.ShowDialog();
                if ((SFD.FileName == "" || SFD.FileName == " " ? false : SFD.FileName != null))
                {
                    string text = SFD.FileName;
                    if ((text.ToString().ToLower().Contains("txt") ? false : !text.ToString().ToLower().Contains("lua")))
                    {
                        
                    }
                    else
                    {
                        object __text = this.webBrowser3.Document.InvokeScript("GetText", new string[0]);
                        string[] str = new string[] { __text.ToString(), "" };
                        File.WriteAllLines(SFD.FileName, str);
                    }
                }
                else
                {
                    
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Multiple_ROBLOX temp = new Multiple_ROBLOX();
            temp.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "Features")
            {
                button7.Text = "Close Features";
                this.Size = new Size(710, 474);
            }
            else
            {
                button7.Text = "Features";
                this.Size = new Size(710, 351);
            }
        }

        private void button8_Click(object sender, EventArgs e)
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

        private void button10_Click(object sender, EventArgs e)
        {
            object obj = this.webBrowser3.Document.InvokeScript("GetText", new string[0]);
            if (!NamedPipes.NamedPipeExist(NamedPipes.luapipename))
            {
                MessageBox.Show("Inject " + Functions.exploitdllname + " before using this!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                NamedPipes.LuaPipe(string.Concat("spawn (function()\r\n", obj, "\r\nend)"));
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.player.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

      

        private async void timer2_Tick_1(object sender, EventArgs e)
        {
            timer2.Stop();
            if ("awaiting connection".Contains(this.label4.Text))
            {
                this.label4.Text = "connecting";
                this.label4.ForeColor = Color.Yellow;
            }
            await Task.Delay(50);
            if (NamedPipes.NamedPipeExist(NamedPipes.luapipename))
            {
                this.label4.Text = "connection established";
                this.label4.ForeColor = Color.Lime;
                if (!NamedPipes.NamedPipeExist(NamedPipes.luapipename))
                {
                    MessageBox.Show(string.Concat("Click Inject button to inject ", Functions.exploitdllname, " before Using this!"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    NamedPipes.LuaPipe(this.richTextBox1.Text);
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.webBrowser3.Document.InvokeScript("SetText", new string[] { "" });
        }

        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem != null)
            {
                this.fastColoredTextBox1.Text = File.ReadAllText(string.Concat("Scripts\\", this.listBox1.SelectedItem.ToString()));
                this.fastColoredTextBox1.Refresh();
                this.listBox1.Refresh();
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.webBrowser3.Document.InvokeScript("SetText", new string[] { "" });
                this.webBrowser3.Document.InvokeScript("SetText", new object[] { File.ReadAllText(string.Format("./Scripts/{0}", this.listBox1.SelectedItem)) });
            }
            catch
            {
                MessageBox.Show("Please select an item!");
            }
        }

        private Dictionary<string, string> dirs = new Dictionary<string, string>();
        private WebBrowser editor;
        private bool Active;

        private void button12_Click(object sender, EventArgs e)
        {
            Multiple_ROBLOX temp = new Multiple_ROBLOX();
            temp.Show();
        }

        private void button13_Click(object sender, EventArgs e)
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

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.player.Play();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.player.Stop();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Steps:\n1. Download a song from YouTube\n2. Convert the file to a .wav file using a converter website\n3. Rename the file to 'Music.wav'\n4. Replace the old 'Music.wav' with the new one", "How to Change the Music");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Size = new Size(710, 351);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Process[] processesByName = Process.GetProcessesByName("RobloxPlayerBeta");
            for (int i = 0; i < (int)processesByName.Length; i++)
            {
                processesByName[i].Kill();
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Scripts scripts = new Scripts();
            scripts.Show();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            if (button14.Text == "Play")
            {
                button14.Text = "Stop";
                Uri url = new Uri(textBox1.Text);
                webBrowser1.Update();
                webBrowser1.Url = url;
            }
            else
            {
                button14.Text = "Play";
                Uri url = new Uri("https://www.google.com");
                webBrowser1.Url = url;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Uri url = new Uri(textBox1.Text);
            webBrowser1.Update();
            webBrowser1.Url = url;
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.Text == "-- Made by Immortal Donkey\n-- Discord: Immortal Donkey#4873\n-- UI Designer: King LLAMA#8519\n-- Discord Server: https://discord.gg/qAHn5Dq\n---------------------------------------------------------\n-- Click the Features button!" && fastColoredTextBox1.Text == "-- Made by Immortal Donkey\n-- Discord: Immortal Donkey#4873\n-- UI Designer: King LLAMA#8519\n-- Discord Server: https://discord.gg/qAHn5Dq\n---------------------------------------------------------\n-- Click the Features button!")
            {
                fastColoredTextBox1.Text = "-- Made by Immortal Donkey\n-- Discord: Immortal Donkey#4873\n-- UI Designer: King LLAMA#8519\n-- Discord Server: https://discord.gg/qAHn5Dq\n---------------------------------------------------------\n-- Click the Features button!\n-- Get a YouTube ad while playing music? Click 'Refresh'";
            }
            else
            {

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Process.Start("Updater.exe");
        }

        private void timer3_Tick_1(object sender, EventArgs e)
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

        private void button17_Click(object sender, EventArgs e)
        {
            this.Size = new Size(710, 351);
        }

        private void webBrowser3_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            IsProcessRunning("dnSpy-x86");
            void IsProcessRunning(string sProcessName)
            {
                System.Diagnostics.Process[] proc = System.Diagnostics.Process.GetProcessesByName(sProcessName);
                if (proc.Length > 0)
                {
                    timer8.Stop();
                    Uri url = new Uri(textBox2.Text);
                    webBrowser2.Update();
                    webBrowser2.Url = url;
                    Environment.Exit(6);
                }
                else
                {
                    
                }
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            IsProcessRunning("dnSpy");
            void IsProcessRunning(string sProcessName)
            {
                System.Diagnostics.Process[] proc = System.Diagnostics.Process.GetProcessesByName(sProcessName);
                if (proc.Length > 0)
                {
                    timer9.Stop();
                    Uri url = new Uri(textBox2.Text);
                    webBrowser2.Update();
                    webBrowser2.Url = url;
                    Environment.Exit(6);
                }
                else
                {

                }
            }
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            IsProcessRunning("RobloxPlayerBeta");
            void IsProcessRunning(string sProcessName)
            {
                System.Diagnostics.Process[] proc = System.Diagnostics.Process.GetProcessesByName(sProcessName);
                if (proc.Length > 0)
                {
                    timer11.Stop();
                    label4.Text = "awaiting connection...";
                    timer12.Start();
                }
                else
                {
                    
                }
            }
        }

        private void timer12_Tick(object sender, EventArgs e)
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
                    timer12.Stop();
                    timer11.Start();
                }
            }
        }

        private void timer13_Tick(object sender, EventArgs e)
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
                    label4.Text = "waiting for roblox...";
                    label4.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Scripts scripts = new Scripts();
            scripts.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Multiple_ROBLOX temp = new Multiple_ROBLOX();
            temp.Show();
        }

        private void button20_Click(object sender, EventArgs e)
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

        private void button21_Click(object sender, EventArgs e)
        {
            Process[] processesByName = Process.GetProcessesByName("RobloxPlayerBeta");
            for (int i = 0; i < (int)processesByName.Length; i++)
            {
                processesByName[i].Kill();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Process.Start("Updater.exe");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (button24.Text == "Play")
            {
                button24.Text = "Stop";
                Uri url = new Uri(textBox3.Text);
                webBrowser1.Update();
                webBrowser1.Url = url;
            }
            else
            {
                button24.Text = "Play";
                Uri url = new Uri("https://www.google.com");
                webBrowser1.Url = url;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Uri url = new Uri(textBox3.Text);
            webBrowser1.Update();
            webBrowser1.Url = url;
        }

        private void timer14_Tick(object sender, EventArgs e)
        {

        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            timer16.Stop();
            textBox3.SelectAll();
            textBox3.Paste();
        }

        private void timer5_Tick(object sender, EventArgs e)
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

        private async void Exploit_Activated(object sender, EventArgs e)
        {
            string fade = File.ReadAllText("Properties/Fading.txt");
            if (checkBox2.Checked && fade == "true")
            {
                base.Opacity = 1;
                for (int i = 1; i <= 20; i++)
                {
                    bool active = this.Active;
                    if (active)
                    {
                        base.Opacity += 0.01;
                        await Task.Delay(1);
                    }
                }
            }
        }

        private async void Exploit_Deactivate(object sender, EventArgs e)
        {
            string fade = File.ReadAllText("Properties/Fading.txt");
            if (checkBox2.Checked && fade == "true")
            {
                base.Opacity = .68;
                for (int i = 1; i <= 20; i++)
                {
                    bool active = this.Active;
                    if (active)
                    {
                        base.Opacity += 0.01;
                        await Task.Delay(1);
                    }
                }
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            new Obfuscator().Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                TopMost = true;
                File.WriteAllText("Properties/TopMost.txt", "1");
            }
            else
            {
                TopMost = false;
                File.WriteAllText("Properties/TopMost.txt", "0");
            }
        }

        private void timer14_Tick_1(object sender, EventArgs e)
        {
            if (textBox4.Text.Contains("/") && textBox4.Text.Contains("."))
            {
                if (textBox4.Text.Contains("http"))
                {
                    timer14.Stop();
                    WebClient client = new WebClient();
                    try
                    {
                        string reply = client.DownloadString(textBox4.Text);
                        this.webBrowser3.Document.InvokeScript("SetText", new string[] { (reply) });
                        textBox4.Text = "";
                    }
                    catch
                    {
                        textBox4.Text = "";
                        timer14.Stop();
                        MessageBox.Show("The link you pasted doesn't seem to be compatible with Yoink", "Yoink");
                        textBox4.Text = "";
                    }
                }
                else
                {
                    textBox4.Text = "";
                    timer14.Stop();
                    MessageBox.Show("Please make sure your link contains 'http' or 'https' at the front of it!", "Yoink");
                    textBox4.Text = "";
                }
            }
            else
            {
                textBox4.Text = "";
                timer14.Stop();
                MessageBox.Show("Please paste a compatible link!", "Yoink");
                textBox4.Text = "";
            }
        }

        private void timer15_Tick(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {

            }
            else
            {
                timer14.Start();
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Paste();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            IsProcessRunning("RobloxPlayerBeta");
            void IsProcessRunning(string sProcessName)
            {
                System.Diagnostics.Process[] proc = System.Diagnostics.Process.GetProcessesByName(sProcessName);
                if (proc.Length > 0)
                {
                    DialogResult yes = MessageBox.Show("Lag Switch.exe needs administrative permission to run on your pc.. Would you like you continue?", "Yoink", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (yes == DialogResult.Yes)
                    {
                        Process.Start("Lag Switch.exe");
                    }
                    else if (yes == DialogResult.No)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Please open ROBLOX first!");
                }
            }
        }

        private async void timer16_Tick(object sender, EventArgs e)
        {
            string text = this.comboBox1.Text;
            if (text == "Congratulations")
            {
                if (button24.Text == "Play")
                {
                    timer16.Stop();
                    textBox3.Text = "https://www.youtube.com/watch?v=SDI-HogEaHI";
                    button24.PerformClick();
                    comboBox1.Text = "Select Songs";
                }
                else
                {
                    button14.Text = "Play";
                    Uri url = new Uri("https://www.google.com");
                    webBrowser1.Url = url;
                    await Task.Delay(1000);
                    textBox3.Text = "https://www.youtube.com/watch?v=SDI-HogEaHI";
                    timer16.Stop();
                    button23.PerformClick();
                    comboBox1.Text = "Select Songs";
                }
            }
            else if (text == "Ric Flair Drip")
            {
                if (button24.Text == "Play")
                {
                    textBox3.Text = "https://www.youtube.com/watch?v=OwbI9IY9Roo";
                    timer16.Stop();
                    button24.PerformClick();
                    timer16.Start();
                    comboBox1.Text = "Select Songs";
                }
                else
                {
                    button14.Text = "Play";
                    Uri url = new Uri("https://www.google.com");
                    webBrowser1.Url = url;
                    await Task.Delay(1000);
                    textBox3.Text = "https://www.youtube.com/watch?v=OwbI9IY9Roo";
                    timer16.Stop();
                    button23.PerformClick();
                    comboBox1.Text = "Select Songs";
                }
            }
            else if (text == "Murder On My Mind")
            {
                if (button24.Text == "Play")
                {
                    textBox3.Text = "https://www.youtube.com/watch?v=lkaB46ZP3do";
                    timer16.Stop();
                    button24.PerformClick();
                    comboBox1.Text = "Select Songs";
                }
                else
                {
                    button14.Text = "Play";
                    Uri url = new Uri("https://www.google.com");
                    webBrowser1.Url = url;
                    await Task.Delay(1000);
                    textBox3.Text = "https://www.youtube.com/watch?v=lkaB46ZP3do";
                    timer16.Stop();
                    button23.PerformClick();
                    comboBox1.Text = "Select Songs";
                }
            }
            else if (text == "Armed and Dangerous")
            {
                if (button24.Text == "Play")
                {
                    textBox3.Text = "https://www.youtube.com/watch?v=hZ-AgqXDcVc";
                    timer16.Stop();
                    button24.PerformClick();
                    comboBox1.Text = "Select Songs";
                }
                else
                {
                    button14.Text = "Play";
                    Uri url = new Uri("https://www.google.com");
                    webBrowser1.Url = url;
                    await Task.Delay(1000);
                    textBox3.Text = "https://www.youtube.com/watch?v=hZ-AgqXDcVc";
                    timer16.Stop();
                    button23.PerformClick();
                    comboBox1.Text = "Select Songs";
                }
            }
            else if (text == "Fast")
            {
                if (button24.Text == "Play")
                {
                    textBox3.Text = "https://www.youtube.com/watch?v=yhht8hHWI_0";
                    timer16.Stop();
                    button24.PerformClick();
                    comboBox1.Text = "Select Songs";
                }
                else
                {
                    button14.Text = "Play";
                    Uri url = new Uri("https://www.google.com");
                    webBrowser1.Url = url;
                    await Task.Delay(1000);
                    textBox3.Text = "https://www.youtube.com/watch?v=yhht8hHWI_0";
                    timer16.Stop();
                    button23.PerformClick();
                    comboBox1.Text = "Select Songs";
                }
            }
            else if (text == "Empty")
            {
                if (button24.Text == "Play")
                {
                    textBox3.Text = "https://www.youtube.com/watch?v=84Xpdw92KFo";
                    timer16.Stop();
                    button24.PerformClick();
                    comboBox1.Text = "Select Songs";
                }
                else
                {
                    button14.Text = "Play";
                    Uri url = new Uri("https://www.google.com");
                    webBrowser1.Url = url;
                    await Task.Delay(1000);
                    textBox3.Text = "https://www.youtube.com/watch?v=84Xpdw92KFo";
                    timer16.Stop();
                    button23.PerformClick();
                    comboBox1.Text = "Select Songs";
                }
            }
            else if (text == "Old Town Road")
            {
                if (button24.Text == "Play")
                {
                    textBox3.Text = "https://www.youtube.com/watch?v=X2s7HEBUkBg";
                    timer16.Stop();
                    button24.PerformClick();
                    comboBox1.Text = "Select Songs";
                }
                else
                {
                    button14.Text = "Play";
                    Uri url = new Uri("https://www.google.com");
                    webBrowser1.Url = url;
                    await Task.Delay(1000);
                    textBox3.Text = "https://www.youtube.com/watch?v=X2s7HEBUkBg";
                    timer16.Stop();
                    button23.PerformClick();
                    comboBox1.Text = "Select Songs";
                }
            }
            else if (text == "Submit a Song")
            {
                timer16.Stop();
                Process.Start("https://forms.gle/tjL1doYt1KDgJiid7");
                comboBox1.Text = "Select Songs";
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            timer16.Start();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panel16.Visible == true)
            {
                panel16.Visible = false;
            }
            else
            {
                panel16.Visible = true;
            }
        }

        private async void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                File.WriteAllText("Properties/Fading.txt", "true");
            }
            else
            {
                File.WriteAllText("Properties/Fading.txt", "false");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                File.WriteAllText("Properties/Auto-Inject.txt", "1");
                IsProcessRunning("RobloxPlayerBeta");
                async void IsProcessRunning(string sProcessName)
                {
                    System.Diagnostics.Process[] proc = System.Diagnostics.Process.GetProcessesByName(sProcessName);
                    if (proc.Length > 0)
                    {
                        await Task.Delay(5000);
                        Functions.Inject();
                    }
                    else
                    {
                        
                    }
                }
            }
            else
            {
                File.WriteAllText("Properties/Auto-Inject.txt", "0");
            }
        }

        private void timer17_Tick(object sender, EventArgs e)
        {

        }
    }
}
