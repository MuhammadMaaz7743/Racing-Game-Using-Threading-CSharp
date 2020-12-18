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
    public partial class game1 : Form
    {
        static Random r;
        Thread player1thd = new Thread(new ThreadStart(player1));
        Thread player2thd = new Thread(new ThreadStart(player2));
        Thread player3thd = new Thread(new ThreadStart(player3));
        public static int countplayer1;
        public static int countplayer2;
        public static int countplayer3;
        public game1()
        {
            InitializeComponent();
            countplayer1 = 0;
            countplayer2 = 0;
            countplayer3 = 0;
            player1thd.IsBackground = true;
            player2thd.IsBackground = true;
            player3thd.IsBackground = true;
            r = new Random();
        }

        private void game1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
            countplayer1 = 0;
            countplayer2 = 0;
            countplayer3 = 0;
            player1thd = new Thread(new ThreadStart(player1));
            player1thd.IsBackground = true;
            player1thd.Start();
            player2thd = new Thread(new ThreadStart(player2));
            player2thd.IsBackground = true;
            player2thd.Start();
            player3thd = new Thread(new ThreadStart(player3));
            player3thd.IsBackground = true;
            player3thd.Start();
            timer1.Start();


        }
        public static void player1()
        {
            while (true)
            {
                Thread.Sleep(50);
                if (countplayer1 > 1100)
                {
                    break;
                }
                countplayer1 = countplayer1 + (1 + r.Next(6));
            }
        }

        public static void player2()
        {
            while (true)
            {
                Thread.Sleep(50);
                if (countplayer2 > 1100)
                {
                    break;
                }
                countplayer2 = countplayer2 + (1 + r.Next(6));
            }
        }
        public static void player3()
        {
            while (true)
            {
                Thread.Sleep(50);
                if (countplayer3 > 1100)
                {
                    break;
                }
                countplayer3 = countplayer3 + (1 + r.Next(6));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool check = false;
            if (countplayer1 > 1100)
            {
                timer1.Stop();
                countplayer1 = 0;
                countplayer2 = 0;
                countplayer3 = 0;
                check = true;
                int l = Int32.Parse(label2.Text);
                l++;
                label2.Text = l.ToString();
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                MessageBox.Show("player one won the match");
                button4.Enabled = true;
                button4.Text = "Restart Game";
                
            }
            if (countplayer2 > 1100)
            {
                timer1.Stop();
                countplayer1 = 0;
                countplayer2 = 0;
                countplayer3 = 0;
                check = true;
                int l = Int32.Parse(label4.Text);
                l++;
                label4.Text = l.ToString();
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                MessageBox.Show("player two won the match");
                button4.Enabled = true;
                button4.Text = "Restart Game";
            }
            if (countplayer3 > 1100)
            {
                timer1.Stop();
                countplayer1 = 0;
                countplayer2 = 0;
                countplayer3 = 0;
                check = true;
                int l = Int32.Parse(label6.Text);
                l++;
                label6.Text = l.ToString();
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                MessageBox.Show("player three won the match");
                button4.Enabled = true;
                button4.Text = "Restart Game";
            }
            if (check == false)
            {
                button1.Left = countplayer1;
                button2.Left = countplayer2;
                button3.Left = countplayer3;
            }

        }
    }
}
