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

        private void button4_Click(object sender, EventArgs e)
        {
            //string[] takimlar = { "Beşiktaş", "Fenerbahçe", "Galatasaray", "Trabzonspor" };
            //listBox1.Items.Add(takimlar[1]);

            int[] takimlar = { 1903,1905,1907,1961,1911,2020};

            for (int i = 0; i < takimlar.Length; i++)
            //Length uzunluguna alır
            {
                if(takimlar[i] % 2 == 0)
                {
                    listBox1.Items.Add(takimlar[i]);
                }
               
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] sayilar = {1,11,12,13,4,5,6,21,44,13,24};
            for (int i = 0; i < sayilar.Length; i++)
            {
                if(sayilar[i]>10 && sayilar[i] % 2 == 0)
                {
                    listBox2.Items.Add(sayilar[i]);
                }
               
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] kisiler = { "Ozanay", "Önder", "Mustafa", "Ersin", "Sinan", "Akif", "Emrah", "Ümit", "Utku" };
            foreach (string k in kisiler)
            {
                listBox3.Items.Add(k);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[]  sinavlar = { 70, 65, 85, 100, 90 };
            int toplam = 0;
            foreach (int x in sinavlar)
            {
                listBox4.Items.Add(x);
                toplam = toplam + x;                
            }
            label4.Text = toplam.ToString();

            int ort = toplam / sinavlar.Length;
            label5.Text = ort.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 1, 11, 12, 13, 4, 5, 6, 24, 44, 13};
            int toplam = 0;
            int elemansayısı = 0;
            foreach (int x in sayilar)
            {
                if(x % 4 == 0)
                {
                 toplam = toplam + x;
                listBox5.Items.Add(x);

                    elemansayısı++; //eleman sayısı 1 er artır
                    label7.Text = elemansayısı.ToString();
                }
            }
            label6.Text = toplam.ToString();       


        }
    }
}
