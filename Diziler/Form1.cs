using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] kisiler = { "Ali", "Ahmet", "Mehmet", "Aslı", "Hakan", "Ayşe", "Demet" };
            //label1.Text = kisiler[4]; //4.kişiyi yazdırdık
            int[] sayilar = { 2,5,1,3,4,6,8,9,13,11,15,14 };
            label1.Text = sayilar[3].ToString();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double[] ondaliklisayilar = {1.14,2.14,3.41,4.11,5.11};
            label2.Text = ondaliklisayilar[1].ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            char[] charharf =
                {'C','a','b','c','ç','d','e','f','g','ğ','h','ı','i', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' };
            label3.Text = charharf[27].ToString();
        
        }

        
    }
}
