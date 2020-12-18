using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace project_PNDC
{
    public partial class game2 : Form
    {
        public game2()
        {
            InitializeComponent();
        }

        Thread a;
        Thread b;
        Thread c;
        Random rdm;
        Boolean no1;
        Boolean no2;
        Boolean no3;

        private void game2_Load(object sender, EventArgs e)
        {
            rdm = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = new Thread(threadr);
            a.Start();
            no1 = a.IsAlive;
        }

        public void threadr()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Red, 4), new Rectangle(rdm.Next(0, this.Width), new Random().Next(0, this.Height), 20, 20));
                Thread.Sleep(100);
            }
            MessageBox.Show("completed red");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b = new Thread(threadb);
            b.Start();
            no2 = b.IsAlive;
        }

        public void threadb()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Blue, 4), new Rectangle(rdm.Next(0, this.Width), new Random().Next(0, this.Height), 20, 20));
                Thread.Sleep(100);
            }
            MessageBox.Show("completed blue");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c = new Thread(threadc);
            c.Start();
            no3 = c.IsAlive;
        }

        public void threadc()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Green, 4), new Rectangle(rdm.Next(0, this.Width), new Random().Next(0, this.Height), 20, 20));
                Thread.Sleep(100);
            }
            MessageBox.Show("completed green");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            // button clear
            if (no1 == true && no2 == true && no3 == true)
            {
                a.Abort();
                b.Abort();
                c.Abort();
            }
            else if (no1 == true && no2 == true && no3 == false)
            {
                a.Abort();
                b.Abort();
            }
            else if (no1 == true && no2 == false && no3 == false)
            {
                a.Abort();
            }
            else if (no1 == false && no2 == true&& no3 == true)
            {
                b.Abort();
                c.Abort();
            }
            else if (no1 == false && no2 == true && no3 == false)
            {
                b.Abort();
            }
            else if (no1 == false && no2 == false && no3 == true)
            {
                c.Abort();
            }
            else if (no1 == true && no2 == false && no3 == true)
            {
                a.Abort();
                c.Abort();
            }

            else
            {
                MessageBox.Show("No Thread has been generated...");
            }
            this.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // button stop
            if (no1 == true && no2 == true && no3 == true)
            {
                a.Abort();
                b.Abort();
                c.Abort();
            }
            else if (no1 == true && no2 == true && no3 == false)
            {
                a.Abort();
                b.Abort();
            }
            else if (no1 == true && no2 == false && no3 == false)
            {
                a.Abort();
            }
            else if (no1 == false && no2 == true && no3 == true)
            {
                b.Abort();
                c.Abort();
            }
            else if (no1 == false && no2 == true && no3 == false)
            {
                b.Abort();
            }
            else if (no1 == false && no2 == false && no3 == true)
            {
                c.Abort();
            }
            else if (no1 == true && no2 == false && no3 == true)
            {
                a.Abort();
                c.Abort();
            }
        
            else
            {
                MessageBox.Show("No Thread has been generated...");
            }
        }
    }
}
