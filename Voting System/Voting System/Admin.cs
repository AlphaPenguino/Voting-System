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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            admin_home ahome = new admin_home();
            ahome.Show();
            this.Hide();
        }
    }
}
