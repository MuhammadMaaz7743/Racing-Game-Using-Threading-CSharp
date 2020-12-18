using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_PNDC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game1 openform = new game1();
            openform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            game2 openform = new game2();
            openform.Show();
        }
    }
}
