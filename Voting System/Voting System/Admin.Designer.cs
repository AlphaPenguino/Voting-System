namespace Voting_System
{
    partial class Admin
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.passlabel = new System.Windows.Forms.Label();
            this.userlabel = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.passlog = new System.Windows.Forms.TextBox();
            this.emaillog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Student"});
            this.comboBox1.Location = new System.Drawing.Point(259, 262);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 19;
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlabel.Location = new System.Drawing.Point(93, 391);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(61, 18);
            this.passlabel.TabIndex = 18;
            this.passlabel.Text = "Password";
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlabel.Location = new System.Drawing.Point(93, 330);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(66, 18);
            this.userlabel.TabIndex = 17;
            this.userlabel.Text = "Username";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Red;
            this.login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.login_btn.Location = new System.Drawing.Point(449, 505);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(91, 42);
            this.login_btn.TabIndex = 16;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // passlog
            // 
            this.passlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlog.Location = new System.Drawing.Point(83, 373);
            this.passlog.Name = "passlog";
            this.passlog.Size = new System.Drawing.Size(470, 56);
            this.passlog.TabIndex = 13;
            // 
            // emaillog
            // 
            this.emaillog.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillog.Location = new System.Drawing.Point(83, 311);
            this.emaillog.Name = "emaillog";
            this.emaillog.Size = new System.Drawing.Size(470, 56);
            this.emaillog.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(224, 132);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(186, 112);
            this.label1.TabIndex = 11;
            this.label1.Text = " Admin \r\n Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(625, 98);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 645);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.passlabel);
            this.Controls.Add(this.userlabel);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.passlog);
            this.Controls.Add(this.emaillog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label passlabel;
        private System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox passlog;
        private System.Windows.Forms.TextBox emaillog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}