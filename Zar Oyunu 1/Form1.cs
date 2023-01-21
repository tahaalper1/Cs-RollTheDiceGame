using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zar_Oyunu_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random sayı = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int zar1 = sayı.Next(1, 7);
            int zar2 = sayı.Next(1, 7);
            label3.Text = zar1.ToString();
            label4.Text = zar2.ToString();
        }
    }
}
