using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Sockets;

namespace ASM_SUPPORT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            {
                webBrowser1.ScriptErrorsSuppressed = true;
                webBrowser1.Navigate("bravosupermarket.az");
                webBrowser1.ScriptErrorsSuppressed = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // bura form 1 in qapanma sualidir.
            DialogResult cavab = MessageBox.Show("Çıxmaq istədiyinizdən əminsinizmi?", "Çıxış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cavab == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            Form2.form3open();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult cavab = MessageBox.Show("Sistem yenidən başlasın?", "Yenidən başla", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cavab==DialogResult.Yes)
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();

                cmd.StandardInput.WriteLine("shutdown /f /r /t 0");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult cavab = MessageBox.Show("Sistemi söndürmək istədiyinizdən əminsinizmi?", "Söndür", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (cavab == DialogResult.Yes)
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();

                cmd.StandardInput.WriteLine("shutdown /f /s /t 0");
            }
        }

       
    }
}
