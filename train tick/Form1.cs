using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace train_tick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }
        string num = "尚未選擇";
        string kind = "尚未選擇";
        string start = "尚未選擇";
        string end = "尚未選擇";















        private void get_ticket(string num, string kind, string start, string end)
        {
            textBox1.Clear();
            textBox1.Text += $"🪖 {kind}號列車由 {start} → {end}，已購買 {num} 張票 🎫\r\n";
            textBox1.Text += $"指揮官，部隊已整備完畢，準備出發！\r\n";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            num = "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {

            get_ticket(num, kind, start, end);
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;





        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
            num = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;
            num = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
            num = "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            button7.Enabled = true;
            button6.Enabled = true;
            kind = "自強";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button8.Enabled = true;
            button7.Enabled = false;
            button6.Enabled = true;
            kind = "莒光";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button8.Enabled = true;
            button7.Enabled = true;
            button6.Enabled = false;
            kind = "區間";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Enabled= false;
            button11.Enabled = true;
            button10.Enabled = true;
            start= "台北";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button12.Enabled = true;
            button11.Enabled = false;
            button10.Enabled = true;
            start = "台中";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button12.Enabled = true;
            button11.Enabled = true;
            button10.Enabled = false;
            start = "台南";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Enabled = false;
            button9.Enabled = true;
            button5.Enabled = true;
            end = "台北";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button13.Enabled = true;
            button9.Enabled = false;
            button5.Enabled = true;
            end = "台中";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button13.Enabled = true;
            button9.Enabled = true;
            button5.Enabled = false;
            end ="台南";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
