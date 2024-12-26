using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voting_System
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void home_label_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void vote_label_Click(object sender, EventArgs e)
        {
            Vote v = new Vote();
            v.Show();
            this.Hide();
        }

        private void settings_label_Click(object sender, EventArgs e)
        {

        }

        private void logout_label_Click(object sender, EventArgs e)
        {
            Form1 f1= new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
