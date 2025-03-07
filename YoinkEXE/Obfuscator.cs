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
    public partial class Obfuscator : Form
    {
        private string Parsed;
        public Obfuscator()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Obfuscator_Load(object sender, EventArgs e)
        {

        }

        public string Obfusc(string Lua)
        {
            this.Parsed = string.Empty;
            byte[] bytes = Encoding.ASCII.GetBytes(Lua);
            for (int i = 0; i < (int)bytes.Length; i++)
            {
                byte num = bytes[i];
                this.Parsed = string.Concat(this.Parsed, int.Parse(num.ToString()), "\\");
            }
            string str = string.Concat("loadstring('\\", this.Parsed, "QWT");
            return str.Replace("\\QWT", "')()");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            this.richTextBox2.Text = this.Obfusc(this.richTextBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox1.Paste();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 9; i++)
            {
                base.Opacity -= 0.1;
                await Task.Delay(1);
            }
            base.Opacity = 1;
            try
            {
                base.Close();
            }
            catch
            {
            }
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Obfuscator.ReleaseCapture();
                Obfuscator.SendMessage(base.Handle, 161, 2, 0);
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
    }
}
