using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atyarisii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsoluzaklik, ikinciatsoluzaklik, ucuncuatsoluzaklik;
        Random rast = new Random();

        private void Timer1_Tick(object sender, EventArgs e)
        {
            double san = Convert.ToDouble(label7.Text);
            san++;
            label7.Text = san.ToString();

            int birinciatgenislik = pictureBox1.Width;
            int ikinciatgenislik = pictureBox2.Width;
            int ucuncuatgenislik = pictureBox3.Width;

            int bitisuzakligi = label5.Left;

            pictureBox1.Left += rast.Next(5,16);
            pictureBox2.Left += rast.Next(5, 16);
            pictureBox3.Left += rast.Next(5, 16);

            
           


            if (pictureBox1.Left >pictureBox2.Left  && pictureBox1.Left > pictureBox3.Left  )
            {
                label6.Text = "1. at yarışta önde";
            }
            else if (pictureBox2.Left > pictureBox1.Left && pictureBox2.Left > pictureBox3.Left)
            {
                label6.Text = "2. at yarışta önde";
            }
            else if (pictureBox3.Left > pictureBox2.Left  && pictureBox1.Left < pictureBox3.Left )
            {
                label6.Text = "3. at yarışta önde";
            }
           

            if (birinciatgenislik + pictureBox1.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("1 numaralı at yarışı kazandı");
            }
            if (ikinciatgenislik + pictureBox2.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("2 numaralı at yarışı kazandı");
            }
            if (ucuncuatgenislik + pictureBox3.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("3 numaralı at yarışı kazandı");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsoluzaklik = pictureBox1.Left;
            ikinciatsoluzaklik = pictureBox2.Left;
            ucuncuatsoluzaklik = pictureBox3.Left;
        }
    }
}
