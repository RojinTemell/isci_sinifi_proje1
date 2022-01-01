using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            short cocuksay;
            decimal maass;
            cocuksay = Convert.ToInt16(textBox1.Text);
            maass=Convert.ToDecimal(textBox2.Text);
            Isci isci = new Isci(cocuksay,maass);
            isci.Kimlik_no = Convert.ToInt64(textBox3.Text);
           
            listBox1.Items.Add("kimlik numaranız:"+isci.Kimlik_no);
            listBox1.Items.Add("\ncocuk sayısı:" + cocuksay);
            listBox1.Items.Add("\nindirimsiz asgari ücretiniz:" + maass);
            listBox1.Items.Add("\nasgari ücret indiriminiz::" + isci.Asgari_gecim_indirimi);
            listBox1.Items.Add("\nasgari ücretiniz:"+ isci.Maas);



        }
    }
}
