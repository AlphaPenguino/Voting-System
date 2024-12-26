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
    public partial class Addcandidate : Form
    {
        public Addcandidate()
        {
            InitializeComponent();
        }

        private void Candidate_fn_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Cand_fn_lbl.Text))
            {
                Cand_fn_lbl.Visible = true;
            }
            else
            {
                Cand_fn_lbl.Visible = false;
            }
        }

        private void Candidate_ln_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Cand_ln_lbl.Text))
            {
                Cand_ln_lbl.Visible = true;
            }
            else
            {
                Cand_ln_lbl.Visible = false;
            }
        }

        private void Partyname_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(partylabel.Text))
            {
                partylabel.Visible = true;
            }
            else
            {
                partylabel.Visible = false;
            }
        }
    }
}
