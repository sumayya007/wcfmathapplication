using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfTestApp.ServiceReference1;

namespace WcfTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 n1 = Convert.ToInt32(textBox1.Text.Trim());
            Int32 n2 = Convert.ToInt32(textBox2.Text.Trim());
            MathserviceClient proxy = new MathserviceClient();
            if (comboBox1.Text == "Add")
            {
                textBox3.Text=proxy.Add(n1, n2).ToString();
            }
            else if(comboBox1.Text == "Subtract")
            {
                textBox3.Text = proxy.Subtract(n1, n2).ToString();
            }
            else if (comboBox1.Text == "Multiply")
            {
                textBox3.Text = proxy.Multiply(n1, n2).ToString();
            }
            else
            {
                textBox3.Text = proxy.Devide(n1, n2).ToString();
            }
        }
    }
}
