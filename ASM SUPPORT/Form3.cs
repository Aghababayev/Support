using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ASM_SUPPORT
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter yaz = new StreamWriter(@"\\azpbtfs01\asm2\ASM Shared\Catalog\PingInfoView_hosts.txt");
            yaz.WriteLine(pingbox.Text);
            yaz.Close();
            Process.Start(@"\\azpbtfs01\asm2\ASM Shared\Catalog\PingInfoView.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pingbox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Process proc in Process.GetProcessesByName("PingInfoView"))
            {
                proc.Kill();
                
            }

        }

    
       
    }
}
