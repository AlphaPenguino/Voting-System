namespace Voting_System
{
    partial class Registration
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
            this.button1 = new System.Windows.Forms.Button();
            this.firstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.birth = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.reenter = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.showpass = new System.Windows.Forms.CheckBox();
            this.ln = new System.Windows.Forms.Label();
            this.emailLb = new System.Windows.Forms.Label();
            this.cntct = new System.Windows.Forms.Label();
            this.passlbl = new System.Windows.Forms.Label();
            this.rnpass = new System.Windows.Forms.Label();
            this.fn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(454, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstname
            // 
            this.firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.Location = new System.Drawing.Point(75, 201);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(470, 41);
            this.firstname.TabIndex = 9;
            this.firstname.TextChanged += new System.EventHandler(this.firstname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(26, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "Create an Account";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(625, 98);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lastname
            // 
            this.lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.Location = new System.Drawing.Point(75, 248);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(470, 41);
            this.lastname.TabIndex = 14;
            this.lastname.TextChanged += new System.EventHandler(this.lastname_TextChanged);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(75, 342);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(470, 41);
            this.email.TabIndex = 15;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // birth
            // 
            this.birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth.Location = new System.Drawing.Point(75, 295);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(218, 41);
            this.birth.TabIndex = 16;
            // 
            // contact
            // 
            this.contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(324, 295);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(218, 41);
            this.contact.TabIndex = 17;
            this.contact.TextChanged += new System.EventHandler(this.contact_TextChanged);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(75, 389);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(470, 41);
            this.password.TabIndex = 18;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // reenter
            // 
            this.reenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reenter.Location = new System.Drawing.Point(75, 436);
            this.reenter.Name = "reenter";
            this.reenter.PasswordChar = '*';
            this.reenter.Size = new System.Drawing.Size(470, 41);
            this.reenter.TabIndex = 19;
            this.reenter.TextChanged += new System.EventHandler(this.reenter_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(357, 523);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 42);
            this.button2.TabIndex = 20;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // showpass
            // 
            this.showpass.AutoSize = true;
            this.showpass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showpass.Location = new System.Drawing.Point(423, 483);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(122, 20);
            this.showpass.TabIndex = 21;
            this.showpass.Text = "Show Password";
            this.showpass.UseVisualStyleBackColor = true;
            this.showpass.CheckedChanged += new System.EventHandler(this.showpass_CheckedChanged);
            // 
            // ln
            // 
            this.ln.AutoSize = true;
            this.ln.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln.Location = new System.Drawing.Point(83, 260);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(79, 19);
            this.ln.TabIndex = 23;
            this.ln.Text = "Last Name";
            // 
            // emailLb
            // 
            this.emailLb.AutoSize = true;
            this.emailLb.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLb.Location = new System.Drawing.Point(83, 353);
            this.emailLb.Name = "emailLb";
            this.emailLb.Size = new System.Drawing.Size(46, 19);
            this.emailLb.TabIndex = 24;
            this.emailLb.Text = "Email";
            // 
            // cntct
            // 
            this.cntct.AutoSize = true;
            this.cntct.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntct.Location = new System.Drawing.Point(331, 306);
            this.cntct.Name = "cntct";
            this.cntct.Size = new System.Drawing.Size(60, 19);
            this.cntct.TabIndex = 25;
            this.cntct.Text = "Contact";
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlbl.Location = new System.Drawing.Point(83, 402);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(71, 19);
            this.passlbl.TabIndex = 26;
            this.passlbl.Text = "Password";
            // 
            // rnpass
            // 
            this.rnpass.AutoSize = true;
            this.rnpass.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rnpass.Location = new System.Drawing.Point(83, 447);
            this.rnpass.Name = "rnpass";
            this.rnpass.Size = new System.Drawing.Size(132, 19);
            this.rnpass.TabIndex = 27;
            this.rnpass.Text = "Re-enter Password";
            // 
            // fn
            // 
            this.fn.AutoSize = true;
            this.fn.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fn.Location = new System.Drawing.Point(83, 213);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(80, 19);
            this.fn.TabIndex = 28;
            this.fn.Text = "First Name";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 645);
            this.Controls.Add(this.fn);
            this.Controls.Add(this.rnpass);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.cntct);
            this.Controls.Add(this.emailLb);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reenter);
            this.Controls.Add(this.password);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.birth);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Registration";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox birth;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox reenter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox showpass;
        private System.Windows.Forms.Label ln;
        private System.Windows.Forms.Label emailLb;
        private System.Windows.Forms.Label cntct;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.Label rnpass;
        private System.Windows.Forms.Label fn;
    }
}