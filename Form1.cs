using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime_Kullanımı
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        DateTime bugun = DateTime.Now;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblDate.Text = bugun.Date.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblMon.Text = bugun.Month.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblDay.Text = bugun.Day.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblYear.Text = bugun.Year.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblDow.Text = bugun.DayOfWeek.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblDoy.Text = bugun.DayOfYear.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblTod.Text = bugun.TimeOfDay.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lblHour.Text = bugun.Hour.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lblMinute.Text = bugun.Minute.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            lblSec.Text = bugun.Second.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            lblMsec.Text = bugun.Millisecond.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            lblTicks.Text = bugun.Ticks.ToString();
        }
    }
}
