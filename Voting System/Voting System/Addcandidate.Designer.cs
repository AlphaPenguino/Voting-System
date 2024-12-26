namespace Voting_System
{
    partial class Addcandidate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.adminnavigation = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.candidatespage = new System.Windows.Forms.Label();
            this.label2__ = new System.Windows.Forms.Label();
            this.Candidate_fn = new System.Windows.Forms.TextBox();
            this.Candidate_ln = new System.Windows.Forms.TextBox();
            this.Cand_fn_lbl = new System.Windows.Forms.Label();
            this.Cand_ln_lbl = new System.Windows.Forms.Label();
            this.positionlbl = new System.Windows.Forms.Label();
            this.Positiondd = new System.Windows.Forms.ComboBox();
            this.Partyname = new System.Windows.Forms.TextBox();
            this.Cand_cancel = new System.Windows.Forms.Button();
            this.Cand_add = new System.Windows.Forms.Button();
            this.partylabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // adminnavigation
            // 
            this.adminnavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.adminnavigation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminnavigation.Location = new System.Drawing.Point(15, 15);
            this.adminnavigation.Name = "adminnavigation";
            this.adminnavigation.Size = new System.Drawing.Size(47, 56);
            this.adminnavigation.TabIndex = 20;
            this.adminnavigation.Text = "___\r\n___\r\n___\r\n";
            this.adminnavigation.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(1, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(625, 98);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // candidatespage
            // 
            this.candidatespage.AutoSize = true;
            this.candidatespage.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidatespage.Location = new System.Drawing.Point(31, 92);
            this.candidatespage.Name = "candidatespage";
            this.candidatespage.Size = new System.Drawing.Size(384, 54);
            this.candidatespage.TabIndex = 22;
            this.candidatespage.Text = "Add a Candidate";
            // 
            // label2__
            // 
            this.label2__.AutoSize = true;
            this.label2__.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2__.Location = new System.Drawing.Point(7, 127);
            this.label2__.Name = "label2__";
            this.label2__.Size = new System.Drawing.Size(610, 36);
            this.label2__.TabIndex = 23;
            this.label2__.Text = "___________________________________";
            // 
            // Candidate_fn
            // 
            this.Candidate_fn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Candidate_fn.Location = new System.Drawing.Point(78, 216);
            this.Candidate_fn.Name = "Candidate_fn";
            this.Candidate_fn.Size = new System.Drawing.Size(454, 41);
            this.Candidate_fn.TabIndex = 24;
            this.Candidate_fn.TextChanged += new System.EventHandler(this.Candidate_fn_TextChanged);
            // 
            // Candidate_ln
            // 
            this.Candidate_ln.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Candidate_ln.Location = new System.Drawing.Point(78, 263);
            this.Candidate_ln.Name = "Candidate_ln";
            this.Candidate_ln.Size = new System.Drawing.Size(454, 41);
            this.Candidate_ln.TabIndex = 25;
            this.Candidate_ln.TextChanged += new System.EventHandler(this.Candidate_ln_TextChanged);
            // 
            // Cand_fn_lbl
            // 
            this.Cand_fn_lbl.AutoSize = true;
            this.Cand_fn_lbl.Location = new System.Drawing.Point(88, 228);
            this.Cand_fn_lbl.Name = "Cand_fn_lbl";
            this.Cand_fn_lbl.Size = new System.Drawing.Size(72, 16);
            this.Cand_fn_lbl.TabIndex = 26;
            this.Cand_fn_lbl.Text = "First Name";
            // 
            // Cand_ln_lbl
            // 
            this.Cand_ln_lbl.AutoSize = true;
            this.Cand_ln_lbl.Location = new System.Drawing.Point(90, 277);
            this.Cand_ln_lbl.Name = "Cand_ln_lbl";
            this.Cand_ln_lbl.Size = new System.Drawing.Size(72, 16);
            this.Cand_ln_lbl.TabIndex = 27;
            this.Cand_ln_lbl.Text = "Last Name";
            // 
            // positionlbl
            // 
            this.positionlbl.AutoSize = true;
            this.positionlbl.Location = new System.Drawing.Point(75, 328);
            this.positionlbl.Name = "positionlbl";
            this.positionlbl.Size = new System.Drawing.Size(55, 16);
            this.positionlbl.TabIndex = 28;
            this.positionlbl.Text = "Position";
            // 
            // Positiondd
            // 
            this.Positiondd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Positiondd.FormattingEnabled = true;
            this.Positiondd.Location = new System.Drawing.Point(78, 347);
            this.Positiondd.Name = "Positiondd";
            this.Positiondd.Size = new System.Drawing.Size(454, 44);
            this.Positiondd.TabIndex = 29;
            this.Positiondd.Text = "Select a Position";
            // 
            // Partyname
            // 
            this.Partyname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Partyname.Location = new System.Drawing.Point(78, 397);
            this.Partyname.Name = "Partyname";
            this.Partyname.Size = new System.Drawing.Size(454, 41);
            this.Partyname.TabIndex = 30;
            this.Partyname.TextChanged += new System.EventHandler(this.Partyname_TextChanged);
            // 
            // Cand_cancel
            // 
            this.Cand_cancel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Cand_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Cand_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cand_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cand_cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cand_cancel.Location = new System.Drawing.Point(349, 532);
            this.Cand_cancel.Name = "Cand_cancel";
            this.Cand_cancel.Size = new System.Drawing.Size(82, 30);
            this.Cand_cancel.TabIndex = 31;
            this.Cand_cancel.Text = "Cancel";
            this.Cand_cancel.UseVisualStyleBackColor = false;
            // 
            // Cand_add
            // 
            this.Cand_add.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Cand_add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Cand_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cand_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cand_add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Cand_add.Location = new System.Drawing.Point(450, 532);
            this.Cand_add.Name = "Cand_add";
            this.Cand_add.Size = new System.Drawing.Size(82, 30);
            this.Cand_add.TabIndex = 32;
            this.Cand_add.Text = "Add";
            this.Cand_add.UseVisualStyleBackColor = false;
            // 
            // partylabel
            // 
            this.partylabel.AutoSize = true;
            this.partylabel.Location = new System.Drawing.Point(90, 411);
            this.partylabel.Name = "partylabel";
            this.partylabel.Size = new System.Drawing.Size(38, 16);
            this.partylabel.TabIndex = 33;
            this.partylabel.Text = "Party";
            // 
            // Addcandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 645);
            this.Controls.Add(this.partylabel);
            this.Controls.Add(this.Cand_add);
            this.Controls.Add(this.Cand_cancel);
            this.Controls.Add(this.Partyname);
            this.Controls.Add(this.Positiondd);
            this.Controls.Add(this.positionlbl);
            this.Controls.Add(this.Cand_ln_lbl);
            this.Controls.Add(this.Cand_fn_lbl);
            this.Controls.Add(this.Candidate_ln);
            this.Controls.Add(this.Candidate_fn);
            this.Controls.Add(this.candidatespage);
            this.Controls.Add(this.label2__);
            this.Controls.Add(this.adminnavigation);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Addcandidate";
            this.Text = "Addcandidate";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adminnavigation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label candidatespage;
        private System.Windows.Forms.Label label2__;
        private System.Windows.Forms.TextBox Candidate_fn;
        private System.Windows.Forms.TextBox Candidate_ln;
        private System.Windows.Forms.Label Cand_fn_lbl;
        private System.Windows.Forms.Label Cand_ln_lbl;
        private System.Windows.Forms.Label positionlbl;
        private System.Windows.Forms.ComboBox Positiondd;
        private System.Windows.Forms.TextBox Partyname;
        private System.Windows.Forms.Button Cand_cancel;
        private System.Windows.Forms.Button Cand_add;
        private System.Windows.Forms.Label partylabel;
    }
}