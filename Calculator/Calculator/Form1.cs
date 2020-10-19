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
        double sonuc;
        string opt = "";
        bool optdurum = false;
        bool move;
        int mouse_X, mouse_Y;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_X = e.X;
            mouse_Y = e.Y;
            move = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_X, MousePosition.Y - mouse_Y);
            }
        }

        

        private void islem(object sender, EventArgs e)
        {
            optdurum = true;
            Button deger = (Button)sender;
            string yeniopt = deger.Text;
            label1.Text = label1.Text + " " + textBox1.Text + " " + yeniopt; 
            switch (opt)
            {
                case "+": textBox1.Text = (sonuc + Double.Parse(textBox1.Text)).ToString(); break;
                case "-": textBox1.Text = (sonuc - Double.Parse(textBox1.Text)).ToString(); break;
                case "x": textBox1.Text = (sonuc * Double.Parse(textBox1.Text)).ToString(); break;
                case "/": textBox1.Text = (sonuc / Double.Parse(textBox1.Text)).ToString(); break;
            }
            sonuc = Double.Parse(textBox1.Text);
            textBox1.Text = sonuc.ToString();
            opt = yeniopt;
        }

        private void deger_rakam(object sender, EventArgs e)
        {
            if (textBox1.Text == "0"|| optdurum) textBox1.Clear();
            optdurum = false;
            Button deger = (Button)sender;
            textBox1.Text += deger.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            optdurum = true;
            switch (opt)
            {
                case "+": textBox1.Text = (sonuc + Double.Parse(textBox1.Text)).ToString(); break;
                case "-": textBox1.Text = (sonuc - Double.Parse(textBox1.Text)).ToString(); break;
                case "x": textBox1.Text = (sonuc * Double.Parse(textBox1.Text)).ToString(); break;
                case "/": textBox1.Text = (sonuc / Double.Parse(textBox1.Text)).ToString(); break;
            }
            sonuc = Double.Parse(textBox1.Text);
            textBox1.Text = sonuc.ToString();
            listBox1.Items.Add(textBox1.Text);
            opt = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
            opt = "";
            sonuc = 0;
            optdurum = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //245, 248
            
            if (button11.Text == "Geçmiş")
            {
                this.Size = new Size(507, 248);
                button11.Text = "Geçmişi Gizle";
            }
            else 
            { 
                this.Size = new Size(245, 248);
                button11.Text = "Geçmiş";
            }
        }
    }
}
