using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1_AlekseiPant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Nine of Clovers";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "King of Clovers";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Ace of Diamonds";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Jack of Hearts";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Five of Spades";
        }

        private void label1_Click(object sender, EventArgs e)
        {
              
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
