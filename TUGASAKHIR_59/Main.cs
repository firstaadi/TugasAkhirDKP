using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUGASAKHIR_59
{
    public partial class Main : Form
    {
        private void DecToHex()
        {

            textBox2.Text = String.Empty;
            int decimalNumber, hasilBagi;
            int i = 1, j, temp = 0;
            char[] hexadecimalNumber = new char[80];
            char temp1;

            string masukan = textBox1.Text;
            int.TryParse(masukan, out decimalNumber);
            if (textBox1.Text != String.Empty)
            {
                hasilBagi = decimalNumber;
                while (hasilBagi != 0)
                {
                    temp = hasilBagi % 16;
                    if (temp < 10)
                        temp = temp + 48;
                    else
                        temp = temp + 55;
                    temp1 = Convert.ToChar(temp);
                    hexadecimalNumber[i++] = temp1;
                    hasilBagi = hasilBagi / 16;
                }


                textBox2.Text = textBox1.Text + " nilai hexanya adalah ";
                for (j = i - 1; j > 0; j--)
                {
                    textBox2.Text += hexadecimalNumber[j];
                }
            }
            else
            {
                textBox2.Text = "Masukan kosong";
            }


        }
        private void DecToBin()
        {
            textBox2.Text = String.Empty;
            int n, i;
            int[] a = new int[100];

            string masukan = textBox1.Text;
            int.TryParse(masukan, out n);
            if (textBox1.Text != String.Empty)
            {
                for (i = 0; n > 0; i++)
                {
                    a[i] = n % 2;
                    n = n / 2;
                }
                textBox2.Text = textBox1.Text + " nilai binernya adalah ";
                for (i = i - 1; i >= 0; i--)
                {
                    textBox2.Text += a[i];
                }
            }
            else
            {
                textBox2.Text = "Masukan kosong";
            }
            
        }
        private void DecToOctal()
        {
            textBox2.Text = String.Empty;
            int i = 1, j, nilai, hasilBagi;
            int[] nilaiOctal = new int[80];

            string masukan = textBox1.Text;
            int.TryParse(masukan, out nilai);
            if (textBox1.Text != String.Empty)
            {
                hasilBagi = nilai;
                while (hasilBagi != 0)
                {
                    nilaiOctal[i++] = hasilBagi % 8;
                    hasilBagi = hasilBagi / 8;
                }
                textBox2.Text = textBox1.Text + " nilai octalnya adalah ";
                for (j = i - 1; j > 0; j--)
                {
                    textBox2.Text += nilaiOctal[j];
                }
            }
            else
            {
                textBox2.Text = "Masukan kosong";
            }

        }
    

        public Main(string nama)
        {
            InitializeComponent();
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            label1.Text = "Selamat Datang\n " + nama;
            textBox2.ReadOnly = true;
            textBox1.MaxLength = 9;
            MaximizeBox = false;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DecToBin();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DecToHex();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DecToOctal();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch) && ch !=8)
            {
                e.Handled = true;
            }
        }
    }
}

