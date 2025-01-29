using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Loan_System
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        bool menuExpand = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false) {
                flowLayoutPanel2.Height += 5;
                if(flowLayoutPanel2.Height >= 411)
                {
                    timer1.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                flowLayoutPanel2.Height -= 5;
                if (flowLayoutPanel2.Height <= 68)
                {
                    timer1.Stop();
                    menuExpand = false;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                flowLayoutPanel3.Height += 5;
                if (flowLayoutPanel3.Height >= 411)
                {
                    timer2.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                flowLayoutPanel3.Height -= 5;
                if (flowLayoutPanel3.Height <= 68)
                {
                    timer2.Stop();
                    menuExpand = false;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // timer2.Start();
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                flowLayoutPanel4.Height += 5;
                if (flowLayoutPanel4.Height >= 411)
                {
                    timer3.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                flowLayoutPanel4.Height -= 5;
                if (flowLayoutPanel4.Height <= 68)
                {
                    timer3.Stop();
                    menuExpand = false;
                }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                flowLayoutPanel5.Height += 5;
                if (flowLayoutPanel5.Height >= 411)
                {
                    timer4.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                flowLayoutPanel5.Height -= 5;
                if (flowLayoutPanel5.Height <= 68)
                {
                    timer4.Stop();
                    menuExpand = false;
                }
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                flowLayoutPanel6.Height += 5;
                if (flowLayoutPanel6.Height >= 411)
                {
                    timer5.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                flowLayoutPanel6.Height -= 5;
                if (flowLayoutPanel6.Height <= 68)
                {
                    timer5.Stop();
                    menuExpand = false;
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            timer5.Start();
        }
    }
}
