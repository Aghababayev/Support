using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;


namespace ASM_SUPPORT
{
    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static void form3open()
        {
            Form3 frm3 = new Form3();
            frm3.Opacity = 0.7;
          
           frm3.Dock = DockStyle.Right;


            frm3.Show();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //\\azpbtfs01\asm2\ASM Shared\Catalog\internal.xlsx;  D:\C# projects\Bravo\Bravo\bin\Debug\Catalog\internal.xlsx; 
                string link = @"provider = Microsoft.ACE.OLEDB.12.0; 
                Data Source = \\azpbtfs01\asm2\ASM Shared\Catalog\internal.xlsx;
               Extended Properties = 'Excel 12.0 Xml'";
                OleDbConnection elaqe = new OleDbConnection(link);

                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Zəhmət olmasa ərazi seçin.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (comboBox1.Text != "")
                {
                    OleDbDataAdapter sehife = new OleDbDataAdapter("Select * from [" + comboBox1.Text + "$]", elaqe);
                    DataTable cedvel = new DataTable();
                    sehife.Fill(cedvel);
                    dataGridView1.DataSource = cedvel;
                    elaqe.Close();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Təəssüf ki bazada məlumat yoxdur");
            }
            

            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //\\azpbtfs01\asm2\ASM Shared\Catalog\Asmmarkets.txt    D:\C# projects\Bravo\Bravo\bin\Debug\Catalog\Asmmarkets.txt
            StreamReader oxu = File.OpenText(@"\\azpbtfs01\asm2\ASM Shared\Catalog\Asmmarkets.txt");
            string metin;
            while ((metin = oxu.ReadLine()) != null)
            {
                comboBox1.Items.Add(metin);
            }
            oxu.Close();
            int say = 0;
            say = (comboBox1.Items.Count) - 2;
            label2.Text = say.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            form3open();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
