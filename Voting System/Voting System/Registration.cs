using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Voting_System
{
    public partial class Registration : Form
    {
        
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Email = email.Text;
            
            if(firstname.Text == "" || lastname.Text == "" || email.Text == "" || birth.Text =="" || contact.Text == "" || password.Text == "" || reenter.Text == "")
            {
                MessageBox.Show("Fields are not all completed yet.");
            }
            else
            {
                if (!Email.Contains("@") || !Email.Contains("."))
                {
                    MessageBox.Show("Please Enter a Valid Email");
                    email.Focus();
                }
                else
                {
                    if (password.Text == reenter.Text)
                    {
                        Form1 f1 = new Form1();
                        f1.Show();
                        this.Hide();
                        MessageBox.Show("Account Created");
                    }
                    else
                    {
                        MessageBox.Show("Re-Enetered password does not match Password");
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if(showpass.Checked)
            {
                password.PasswordChar = '\0';
                reenter.PasswordChar = '\0';
            } else
            {
                password.PasswordChar = '*';
                reenter.PasswordChar = '*';
            }
        }

        private void firstname_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstname.Text))
            {
                fn.Visible = true;
            }
            else
            {
                fn.Visible = false;
            }
        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lastname.Text))
            {
                ln.Visible = true;
            }
            else
            {
                ln.Visible = false;
            }
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(email.Text))
            {
                emailLb.Visible = true;
            }
            else
            {
                emailLb.Visible = false;
            }
        }

        private void contact_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(contact.Text))
            {
                cntct.Visible = true;
            }
            else
            {
                cntct.Visible = false;
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(password.Text))
            {
                passlbl.Visible = true;
            }
            else
            {
                passlbl.Visible = false;
            }
        }

        private void reenter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(reenter.Text))
            {
                rnpass.Visible = true;
            }
            else
            {
                rnpass.Visible = false;
            }
        }
    }
}
