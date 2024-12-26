namespace Voting_System
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emaillog = new System.Windows.Forms.TextBox();
            this.passlog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.email_label = new System.Windows.Forms.Label();
            this.passlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(625, 98);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(75, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 112);
            this.label1.TabIndex = 1;
            this.label1.Text = " Supreme Student \r\nGovernment Elections";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // emaillog
            // 
            this.emaillog.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillog.Location = new System.Drawing.Point(83, 309);
            this.emaillog.Name = "emaillog";
            this.emaillog.Size = new System.Drawing.Size(470, 56);
            this.emaillog.TabIndex = 2;
            this.emaillog.TextChanged += new System.EventHandler(this.emaillog_TextChanged);
            // 
            // passlog
            // 
            this.passlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlog.Location = new System.Drawing.Point(83, 371);
            this.passlog.Name = "passlog";
            this.passlog.Size = new System.Drawing.Size(470, 56);
            this.passlog.TabIndex = 3;
            this.passlog.TextChanged += new System.EventHandler(this.passlog_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Forgot Password?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Create an Account here";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Red;
            this.login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.login_btn.Location = new System.Drawing.Point(449, 503);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(91, 42);
            this.login_btn.TabIndex = 6;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.Location = new System.Drawing.Point(93, 328);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(40, 18);
            this.email_label.TabIndex = 7;
            this.email_label.Text = "Email";
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlabel.Location = new System.Drawing.Point(93, 389);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(61, 18);
            this.passlabel.TabIndex = 8;
            this.passlabel.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Student";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Admin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 645);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passlabel);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passlog);
            this.Controls.Add(this.emaillog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emaillog;
        private System.Windows.Forms.TextBox passlog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label passlabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

