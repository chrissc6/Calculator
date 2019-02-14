using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            //var userInput = textBox1.Text;
            //var userInput2 = textBox2.Text;
            //var x = int.Parse(userInput);
            //var y = int.Parse(userInput2);
            //var z = x + y;
            //label1.Text = $"= {z}";

            //better way
            label1.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var userInput = textBox1.Text;
            var userInput2 = textBox2.Text;
            var x = int.Parse(userInput);
            var y = int.Parse(userInput2);
            var z = x - y;
            label1.Text = $"= {z}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var userInput = textBox1.Text;
            var userInput2 = textBox2.Text;
            var x = int.Parse(userInput);
            var y = int.Parse(userInput2);
            var z = x * y;
            label1.Text = $"= {z}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var userInput = textBox1.Text;
            var userInput2 = textBox2.Text;
            var x = int.Parse(userInput);
            var y = int.Parse(userInput2);
            if (y == 0)
            { label1.Text = "Result cannot be 0"; }
            else
            {
                var z = x / y;
                label1.Text = $"= {z}";
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(textBox1.Text) % int.Parse(textBox2.Text)).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
