using System;
using System.Windows.Forms;
namespace Basiccontrols
{
    public partial class Form1 : Form
    {
        string s1, s2, s3, s4;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            s4 = comboBox1.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            s1 = textBox1.Text;
            s2 = textBox2.Text;
            label9.Visible = true;
            label9.Text = (" Welcome!!! " + " Your roll number is " + s1 + " 
       Your name is " + s2 + " Your branch is " + s4);
        MessageBox.Show("Registered Successfully");
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                s3 = radioButton1.Text;
            }
            else
            {
                s3 = radioButton2.Text;
            }
            MessageBox.Show("Your Gender is " + s3);
        }
    }
}



//------------------------------------------------------------------

using System;
using System.Windows.Forms;
namespace Basiccontrols
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" You have selected " + textBox2.Text);
            int a = Convert.ToInt32(textBox3.Text);
            int b = Convert.ToInt32(textBox4.Text);
            int c = a * b;
            textBox5.Text = c.ToString();
            textBox5.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

        }
    }
}
