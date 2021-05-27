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
    }
}
