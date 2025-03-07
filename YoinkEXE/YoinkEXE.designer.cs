using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yoink;
using YoinkEXE;

namespace Yoink
{
    partial class Exploit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exploit));
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.flatTextBox1 = new FlatUI.FlatTextBox();
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.bunifuElipse7 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.bunifuElipse8 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button11 = new System.Windows.Forms.Button();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.bunifuElipse9 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button12 = new System.Windows.Forms.Button();
            this.bunifuElipse10 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse11 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse12 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse13 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button13 = new System.Windows.Forms.Button();
            this.bunifuElipse14 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse16 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse15 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse17 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse18 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button17 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuElipse19 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.bunifuElipse20 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse21 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse22 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.bunifuElipse23 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button16 = new System.Windows.Forms.Button();
            this.bunifuElipse24 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.bunifuElipse25 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer9 = new System.Windows.Forms.Timer(this.components);
            this.timer10 = new System.Windows.Forms.Timer(this.components);
            this.timer11 = new System.Windows.Forms.Timer(this.components);
            this.timer12 = new System.Windows.Forms.Timer(this.components);
            this.timer13 = new System.Windows.Forms.Timer(this.components);
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.timer14 = new System.Windows.Forms.Timer(this.components);
            this.timer15 = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer16 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.webBrowser4 = new System.Windows.Forms.WebBrowser();
            this.panel16 = new System.Windows.Forms.Panel();
            this.button28 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.timer17 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel16.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(115, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Load File";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(581, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(121, 224);
            this.listBox1.TabIndex = 7;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 3;
            this.bunifuElipse1.TargetControl = this.button1;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 3;
            this.bunifuElipse2.TargetControl = this.button2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(321, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 38);
            this.button2.TabIndex = 20;
            this.button2.Text = "Save Script";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 3;
            this.bunifuElipse3.TargetControl = this.button3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(218, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 38);
            this.button3.TabIndex = 21;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 3;
            this.bunifuElipse4.TargetControl = this.listBox1;
            // 
            // flatTextBox1
            // 
            this.flatTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox1.FocusOnHover = false;
            this.flatTextBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatTextBox1.Hint = "";
            this.flatTextBox1.Location = new System.Drawing.Point(12, 36);
            this.flatTextBox1.MaxLength = 32767;
            this.flatTextBox1.Multiline = true;
            this.flatTextBox1.Name = "flatTextBox1";
            this.flatTextBox1.ReadOnly = false;
            this.flatTextBox1.Size = new System.Drawing.Size(563, 265);
            this.flatTextBox1.TabIndex = 8;
            this.flatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBox1.UseSystemPasswordChar = false;
            this.flatTextBox1.TextChanged += new System.EventHandler(this.flatTextBox1_TextChanged);
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 3;
            this.bunifuElipse5.TargetControl = this.flatTextBox1;
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 5;
            this.bunifuElipse6.TargetControl = this.button4;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(649, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 25);
            this.button4.TabIndex = 10;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // bunifuElipse7
            // 
            this.bunifuElipse7.ElipseRadius = 5;
            this.bunifuElipse7.TargetControl = this.button5;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(578, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 25);
            this.button5.TabIndex = 11;
            this.button5.Text = "Minimize";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // bunifuElipse8
            // 
            this.bunifuElipse8.ElipseRadius = 3;
            this.bunifuElipse8.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-9, -11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 41);
            this.panel1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(52, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 56;
            this.label4.Text = "waiting for roblox...";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(68, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(504, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Yoink is currently patched! Please wait for the new update!";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(12, 33);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 19);
            this.checkBox1.TabIndex = 57;
            this.checkBox1.Text = "TopMost";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(512, 307);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(92, 38);
            this.button11.TabIndex = 12;
            this.button11.Text = "Attach";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = null;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this;
            this.bunifuDragControl3.Vertical = true;
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(458, 112);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.fastColoredTextBox1.CharHeight = 14;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fastColoredTextBox1.ForeColor = System.Drawing.Color.White;
            this.fastColoredTextBox1.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.LineNumberColor = System.Drawing.Color.White;
            this.fastColoredTextBox1.Location = new System.Drawing.Point(5, 36);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(499, 265);
            this.fastColoredTextBox1.TabIndex = 19;
            this.fastColoredTextBox1.Text = resources.GetString("fastColoredTextBox1.Text");
            this.fastColoredTextBox1.Zoom = 100;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(12, 307);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(97, 38);
            this.button10.TabIndex = 18;
            this.button10.Text = "Execute";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(610, 307);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(92, 38);
            this.button7.TabIndex = 23;
            this.button7.Text = "Features";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // bunifuElipse9
            // 
            this.bunifuElipse9.ElipseRadius = 3;
            this.bunifuElipse9.TargetControl = this.button12;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(740, 100);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(133, 36);
            this.button12.TabIndex = 58;
            this.button12.Text = "Multiple ROBLOX";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // bunifuElipse10
            // 
            this.bunifuElipse10.ElipseRadius = 3;
            this.bunifuElipse10.TargetControl = this.button7;
            // 
            // bunifuElipse11
            // 
            this.bunifuElipse11.ElipseRadius = 3;
            this.bunifuElipse11.TargetControl = this.button2;
            // 
            // bunifuElipse12
            // 
            this.bunifuElipse12.ElipseRadius = 3;
            this.bunifuElipse12.TargetControl = this.button3;
            // 
            // bunifuElipse13
            // 
            this.bunifuElipse13.ElipseRadius = 3;
            this.bunifuElipse13.TargetControl = this.button13;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(740, 142);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(133, 36);
            this.button13.TabIndex = 59;
            this.button13.Text = "Re-Install ROBLOX";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // bunifuElipse14
            // 
            this.bunifuElipse14.ElipseRadius = 3;
            this.bunifuElipse14.TargetControl = this.fastColoredTextBox1;
            // 
            // bunifuElipse16
            // 
            this.bunifuElipse16.ElipseRadius = 3;
            this.bunifuElipse16.TargetControl = this.button10;
            // 
            // bunifuElipse15
            // 
            this.bunifuElipse15.ElipseRadius = 3;
            this.bunifuElipse15.TargetControl = this;
            // 
            // bunifuElipse17
            // 
            this.bunifuElipse17.ElipseRadius = 3;
            this.bunifuElipse17.TargetControl = this.button11;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick_1);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // bunifuElipse18
            // 
            this.bunifuElipse18.ElipseRadius = 5;
            this.bunifuElipse18.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.button17);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Location = new System.Drawing.Point(708, -8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 38);
            this.panel2.TabIndex = 56;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button17.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Location = new System.Drawing.Point(156, 12);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(38, 26);
            this.button17.TabIndex = 72;
            this.button17.Text = "<<<";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(218, 10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 25);
            this.button6.TabIndex = 57;
            this.button6.Text = "<<<";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(768, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 57;
            this.label3.Text = "Features";
            // 
            // bunifuElipse19
            // 
            this.bunifuElipse19.ElipseRadius = 3;
            this.bunifuElipse19.TargetControl = this.button6;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(740, 184);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(133, 36);
            this.button8.TabIndex = 63;
            this.button8.Text = "Kill ROBLOX";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(740, 58);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(133, 36);
            this.button9.TabIndex = 64;
            this.button9.Text = "Script Hub";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(740, 226);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(133, 36);
            this.button15.TabIndex = 65;
            this.button15.Text = "Yoink Updater";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // bunifuElipse20
            // 
            this.bunifuElipse20.ElipseRadius = 3;
            this.bunifuElipse20.TargetControl = this.button8;
            // 
            // bunifuElipse21
            // 
            this.bunifuElipse21.ElipseRadius = 3;
            this.bunifuElipse21.TargetControl = this.button9;
            // 
            // bunifuElipse22
            // 
            this.bunifuElipse22.ElipseRadius = 3;
            this.bunifuElipse22.TargetControl = this.button15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(744, 292);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 66;
            this.textBox1.Text = "Paste link here";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(741, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 57;
            this.label1.Text = "YouTube Link:";
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(744, 318);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(64, 27);
            this.button14.TabIndex = 67;
            this.button14.Text = "Play";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click_1);
            // 
            // bunifuElipse23
            // 
            this.bunifuElipse23.ElipseRadius = 3;
            this.bunifuElipse23.TargetControl = this.button14;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(752, 414);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(20, 20);
            this.webBrowser1.TabIndex = 68;
            this.webBrowser1.Visible = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(809, 318);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(64, 27);
            this.button16.TabIndex = 69;
            this.button16.Text = "Refresh";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // bunifuElipse24
            // 
            this.bunifuElipse24.ElipseRadius = 3;
            this.bunifuElipse24.TargetControl = this.button16;
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // webBrowser3
            // 
            this.webBrowser3.Location = new System.Drawing.Point(5, 36);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.Size = new System.Drawing.Size(570, 265);
            this.webBrowser3.TabIndex = 71;
            this.webBrowser3.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser3.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser3_DocumentCompleted);
            // 
            // bunifuElipse25
            // 
            this.bunifuElipse25.ElipseRadius = 3;
            this.bunifuElipse25.TargetControl = this.button17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(731, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 299);
            this.panel3.TabIndex = 72;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 299);
            this.panel6.TabIndex = 74;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 305);
            this.panel4.TabIndex = 73;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(-9, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 302);
            this.panel5.TabIndex = 74;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Controls.Add(this.panel12);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(733, 39);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 300);
            this.panel7.TabIndex = 73;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Gray;
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1, 300);
            this.panel12.TabIndex = 75;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Gray;
            this.panel13.Location = new System.Drawing.Point(-9, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1, 302);
            this.panel13.TabIndex = 74;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.Location = new System.Drawing.Point(-9, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1, 302);
            this.panel8.TabIndex = 74;
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(882, 37);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1, 299);
            this.panel9.TabIndex = 73;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Gray;
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Location = new System.Drawing.Point(879, 39);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1, 300);
            this.panel10.TabIndex = 73;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Gray;
            this.panel11.Location = new System.Drawing.Point(-9, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1, 302);
            this.panel11.TabIndex = 74;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(740, 440);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(30, 20);
            this.webBrowser2.TabIndex = 74;
            this.webBrowser2.Url = new System.Uri("http://google.com", System.UriKind.Absolute);
            this.webBrowser2.Visible = false;
            // 
            // timer8
            // 
            this.timer8.Tick += new System.EventHandler(this.timer8_Tick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(744, 388);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(30, 20);
            this.textBox2.TabIndex = 75;
            this.textBox2.Text = "https://iplogger.org/2nHhd5";
            // 
            // timer9
            // 
            this.timer9.Tick += new System.EventHandler(this.timer9_Tick);
            // 
            // timer11
            // 
            this.timer11.Tick += new System.EventHandler(this.timer11_Tick);
            // 
            // timer12
            // 
            this.timer12.Tick += new System.EventHandler(this.timer12_Tick);
            // 
            // timer13
            // 
            this.timer13.Tick += new System.EventHandler(this.timer13_Tick);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Gray;
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Location = new System.Drawing.Point(12, 360);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(884, 1);
            this.panel14.TabIndex = 77;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Gray;
            this.panel15.Location = new System.Drawing.Point(-9, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1, 302);
            this.panel15.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(317, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 78;
            this.label5.Text = "Features";
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.Color.White;
            this.button18.Location = new System.Drawing.Point(12, 389);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(133, 36);
            this.button18.TabIndex = 79;
            this.button18.Text = "Script Hub";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button19.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button19.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.Color.White;
            this.button19.Location = new System.Drawing.Point(151, 389);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(133, 36);
            this.button19.TabIndex = 80;
            this.button19.Text = "Multiple ROBLOX";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button20.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.ForeColor = System.Drawing.Color.White;
            this.button20.Location = new System.Drawing.Point(290, 389);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(133, 36);
            this.button20.TabIndex = 81;
            this.button20.Text = "Re-Install ROBLOX";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button21.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button21.FlatAppearance.BorderSize = 0;
            this.button21.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(429, 389);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(133, 36);
            this.button21.TabIndex = 82;
            this.button21.Text = "Kill ROBLOX";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button22.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button22.FlatAppearance.BorderSize = 0;
            this.button22.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.ForeColor = System.Drawing.Color.White;
            this.button22.Location = new System.Drawing.Point(12, 431);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(133, 36);
            this.button22.TabIndex = 83;
            this.button22.Text = "Yoink Updater";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button23.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button23.FlatAppearance.BorderSize = 0;
            this.button23.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button23.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.ForeColor = System.Drawing.Color.White;
            this.button23.Location = new System.Drawing.Point(640, 440);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(64, 27);
            this.button23.TabIndex = 87;
            this.button23.Text = "Refresh";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button24.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button24.FlatAppearance.BorderSize = 0;
            this.button24.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button24.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button24.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.ForeColor = System.Drawing.Color.White;
            this.button24.Location = new System.Drawing.Point(575, 440);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(64, 27);
            this.button24.TabIndex = 86;
            this.button24.Text = "Play";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(572, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 84;
            this.label6.Text = "YouTube Link:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(575, 390);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(129, 20);
            this.textBox3.TabIndex = 85;
            this.textBox3.Text = "Paste link here";
            this.textBox3.Click += new System.EventHandler(this.textBox3_Click);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button25.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button25.FlatAppearance.BorderSize = 0;
            this.button25.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.ForeColor = System.Drawing.Color.White;
            this.button25.Location = new System.Drawing.Point(151, 431);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(133, 36);
            this.button25.TabIndex = 88;
            this.button25.Text = "Coming Soon";
            this.button25.UseVisualStyleBackColor = false;
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button26.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button26.FlatAppearance.BorderSize = 0;
            this.button26.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button26.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button26.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.ForeColor = System.Drawing.Color.White;
            this.button26.Location = new System.Drawing.Point(290, 431);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(133, 36);
            this.button26.TabIndex = 89;
            this.button26.Text = "Lag Switch";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button27.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button27.FlatAppearance.BorderSize = 0;
            this.button27.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button27.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button27.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.ForeColor = System.Drawing.Color.White;
            this.button27.Location = new System.Drawing.Point(429, 431);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(133, 36);
            this.button27.TabIndex = 90;
            this.button27.Text = "Script Obfuscator";
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(581, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 91;
            this.label7.Text = "Get Raw Text (Links):";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(581, 280);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 92;
            this.textBox4.Click += new System.EventHandler(this.textBox4_Click);
            // 
            // timer14
            // 
            this.timer14.Tick += new System.EventHandler(this.timer14_Tick_1);
            // 
            // timer15
            // 
            this.timer15.Tick += new System.EventHandler(this.timer15_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(673, 372);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(10, 10);
            this.richTextBox1.TabIndex = 93;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Submit a Song",
            "Congratulations",
            "Ric Flair Drip",
            "Murder On My Mind",
            "Armed and Dangerous",
            "Fast",
            "Empty",
            "Old Town Road"});
            this.comboBox1.Location = new System.Drawing.Point(575, 413);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 21);
            this.comboBox1.TabIndex = 94;
            this.comboBox1.Text = "Select Songs";
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // timer16
            // 
            this.timer16.Tick += new System.EventHandler(this.timer16_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(474, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // webBrowser4
            // 
            this.webBrowser4.Location = new System.Drawing.Point(424, 322);
            this.webBrowser4.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser4.Name = "webBrowser4";
            this.webBrowser4.Size = new System.Drawing.Size(20, 20);
            this.webBrowser4.TabIndex = 76;
            this.webBrowser4.Url = new System.Uri("http://google.com", System.UriKind.Absolute);
            this.webBrowser4.Visible = false;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel16.Controls.Add(this.button28);
            this.panel16.Controls.Add(this.checkBox3);
            this.panel16.Controls.Add(this.checkBox2);
            this.panel16.Controls.Add(this.checkBox1);
            this.panel16.Controls.Add(this.label8);
            this.panel16.Location = new System.Drawing.Point(510, 169);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(192, 176);
            this.panel16.TabIndex = 96;
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button28.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button28.FlatAppearance.BorderSize = 0;
            this.button28.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button28.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button28.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button28.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button28.ForeColor = System.Drawing.Color.White;
            this.button28.Location = new System.Drawing.Point(140, 156);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(52, 20);
            this.button28.TabIndex = 97;
            this.button28.Text = "Close";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.White;
            this.checkBox3.Location = new System.Drawing.Point(100, 33);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(86, 19);
            this.checkBox3.TabIndex = 59;
            this.checkBox3.Text = "Auto-Inject";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(13, 66);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(63, 19);
            this.checkBox2.TabIndex = 58;
            this.checkBox2.Text = "Fading";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(42, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = " Settings";
            // 
            // timer17
            // 
            this.timer17.Tick += new System.EventHandler(this.timer17_Tick);
            // 
            // Exploit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(907, 474);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.webBrowser4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.webBrowser3);
            this.Controls.Add(this.fastColoredTextBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flatTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Exploit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yoink";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Exploit_Activated);
            this.Deactivate += new System.EventHandler(this.Exploit_Deactivate);
            this.Load += new System.EventHandler(this.Exploit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private async void button11_Click(object sender, EventArgs e)
        {
            if (label4.Text == "waiting for roblox...")
            {
                MessageBox.Show("Please open ROBLOX before injecting!", "Yoink");
            }
            else
            {
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

                    timer4.Start();
                    await Task.Delay(800);
                    Functions.Inject();
                    this.timer1.Start();

                    switch (Injector.DllInjector.GetInstance.Inject("RobloxPlayerBeta", string.Concat(AppDomain.CurrentDomain.BaseDirectory, Functions.exploitdllname)))
                    {
                        case Injector.DllInjectionResult.DllNotFound:
                            {
                                MessageBox.Show(string.Concat("couldn't find ", Functions.exploitdllname), "Dll was not found!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private FlatUI.FlatTextBox flatTextBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse7;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse8;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button11;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse9;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse10;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse11;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse12;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse13;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse14;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse16;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse15;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse17;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse18;
        private Label label2;
        private Button button13;
        private Button button12;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private Button button6;
        private Button button8;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse19;
        private Button button15;
        private Button button9;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse20;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse21;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse22;
        private Button button14;
        private Label label1;
        private TextBox textBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse23;
        private WebBrowser webBrowser1;
        private Button button16;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse24;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private WebBrowser webBrowser3;
        private Button button17;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse25;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel7;
        private Panel panel8;
        private Panel panel10;
        private Panel panel11;
        private Panel panel9;
        private Panel panel6;
        private WebBrowser webBrowser2;
        private System.Windows.Forms.Timer timer8;
        private TextBox textBox2;
        private System.Windows.Forms.Timer timer9;
        private System.Windows.Forms.Timer timer10;
        private System.Windows.Forms.Timer timer11;
        private System.Windows.Forms.Timer timer12;
        private System.Windows.Forms.Timer timer13;
        private Button button27;
        private Button button26;
        private Button button25;
        private Button button23;
        private Button button24;
        private Label label6;
        private TextBox textBox3;
        private Button button22;
        private Button button21;
        private Button button20;
        private Button button19;
        private Button button18;
        private Label label5;
        private Panel panel14;
        private Panel panel15;
        private Panel panel12;
        private Panel panel13;
        private System.Windows.Forms.Timer timer7;
        private CheckBox checkBox1;
        private TextBox textBox4;
        private Label label7;
        private System.Windows.Forms.Timer timer14;
        private System.Windows.Forms.Timer timer15;
        private RichTextBox richTextBox1;
        private ComboBox comboBox1;
        private System.Windows.Forms.Timer timer16;
        private Panel panel16;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private Label label8;
        private PictureBox pictureBox1;
        private WebBrowser webBrowser4;
        private Button button28;
        private System.Windows.Forms.Timer timer17;
    }
}