using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace api_ilkders
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long tc = long.Parse(textBox4.Text);
            int yil = Convert.ToInt32(textBox3.Text);

            kimlik.KPSPublicSoapClient kontrol = new kimlik.KPSPublicSoapClient();

            bool durum = kontrol.TCKimlikNoDogrula(tc, textBox1.Text, textBox2.Text, yil);
            if(durum == true)
            {
                MessageBox.Show("Girilen bilgiler doğru");
            }
            else
            {
                MessageBox.Show("Girilen bilgiler yanlış");
            }

        }
    }
}
