using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBox1.Location.X;//pictureboxın x kordinatını tanımlıyoruz
            int y = pictureBox1.Location.Y;// y kordinatını tanımlıyoruz.

            if (e.KeyCode == Keys.Right && pictureBox1.Right < label1.Left)//eğer klavyeden basılan tuş D ise;
            {
                x = x + 5;//x kordinatına doğru 5 pixel git
            }
            if (e.KeyCode == Keys.Left && pictureBox1.Left > label3.Right)
            {
                x = x - 5;
            }
            if (e.KeyCode == Keys.Up && pictureBox1.Top > label2.Bottom)
            {
                y = y - 5;
            }
            if (e.KeyCode == Keys.Down && pictureBox1.Bottom < label4.Top)
            {
                y = y + 5;
            }

          

            pictureBox1.Location = new Point(x,y);//Burası x,y olmalıdır bu sırayla olmalıdır.
            if (pictureBox1.Right >= label1.Left)
            {
                label1.BackColor = Color.Red;
            }
            if (pictureBox1.Top <= label2.Bottom)
            {
                label2.BackColor = Color.Yellow;
            }
            if (pictureBox1.Left <= label3.Right)
            {
                label3.BackColor = Color.Green;
            }
            if (pictureBox1.Bottom >= label4.Top)
            {
                label4.BackColor = Color.Blue;
            }
            
        }
    }
}
