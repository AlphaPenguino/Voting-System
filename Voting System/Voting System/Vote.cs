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
    public partial class Vote : Form
    {
        public Vote()
        {
            InitializeComponent();
        }

        private void navigation_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }
    }
}
