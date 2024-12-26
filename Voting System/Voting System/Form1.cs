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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(emaillog.Text =="" && passlog.Text == "")
            {
                MessageBox.Show("Error. Account not Found.");
            }
            else
            {
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
            
        }
        private void emaillog_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emaillog.Text))
            {
                email_label.Visible = true;
            }
            else
            {
                email_label.Visible = false;
            }
        }

        private void passlog_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(passlog.Text))
            {
                passlabel.Visible = true;
            }
            else
            {
                passlabel.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adminlogin a1 = new Adminlogin();
            a1.Show();
            this.Hide();
        }
    }
}
