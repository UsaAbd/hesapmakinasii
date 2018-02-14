using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public string Islem = String.Empty;
        public double sayi1 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void ekle(object sender, EventArgs e)
        {
             textBox1.Text += (sender as Button).Text;
        }

        private void islem(object sender, EventArgs e)
        {
            Islem = (sender as Button).Text;
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            Islem = String.Empty;
        }

        private void buttonEsittir_Click(object sender, EventArgs e)
        {
            double sayi2 = Convert.ToDouble(textBox1.Text);

            double sonuc = 0;

            switch (Islem)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "x":
                    sonuc = sayi1 * sayi2;
                    break;
                case "/":
                    sonuc = sayi1 / sayi2;
                    break;
                default:
                    MessageBox.Show("İşlem seçmelisiniz!", "Hata");
                    break;
            }

            textBox1.Text = sonuc.ToString();
        }
    }
}
