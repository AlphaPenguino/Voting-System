namespace Voting_System
{
    partial class Adminlogin
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
            this.wordlbl = new System.Windows.Forms.Label();
            this.usname = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.wordlog = new System.Windows.Forms.TextBox();
            this.userlog = new System.Windows.Forms.TextBox();
            this.adminreg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(625, 98);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // wordlbl
            // 
            this.wordlbl.AutoSize = true;
            this.wordlbl.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordlbl.Location = new System.Drawing.Point(96, 397);
            this.wordlbl.Name = "wordlbl";
            this.wordlbl.Size = new System.Drawing.Size(61, 18);
            this.wordlbl.TabIndex = 16;
            this.wordlbl.Text = "Password";
            // 
            // usname
            // 
            this.usname.AutoSize = true;
            this.usname.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usname.Location = new System.Drawing.Point(96, 336);
            this.usname.Name = "usname";
            this.usname.Size = new System.Drawing.Size(66, 18);
            this.usname.TabIndex = 15;
            this.usname.Text = "Username";
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.Red;
            this.loginbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginbtn.Location = new System.Drawing.Point(452, 511);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(91, 42);
            this.loginbtn.TabIndex = 14;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            // 
            // wordlog
            // 
            this.wordlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordlog.Location = new System.Drawing.Point(86, 379);
            this.wordlog.Name = "wordlog";
            this.wordlog.Size = new System.Drawing.Size(470, 56);
            this.wordlog.TabIndex = 11;
            // 
            // userlog
            // 
            this.userlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlog.Location = new System.Drawing.Point(86, 317);
            this.userlog.Name = "userlog";
            this.userlog.Size = new System.Drawing.Size(470, 56);
            this.userlog.TabIndex = 10;
            // 
            // adminreg
            // 
            this.adminreg.AutoSize = true;
            this.adminreg.Location = new System.Drawing.Point(86, 511);
            this.adminreg.Name = "adminreg";
            this.adminreg.Size = new System.Drawing.Size(146, 16);
            this.adminreg.TabIndex = 13;
            this.adminreg.Text = "Create an Account here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 86);
            this.label1.TabIndex = 18;
            this.label1.Text = "Admin\r\n Login";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(323, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Admin";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Adminlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 645);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wordlbl);
            this.Controls.Add(this.usname);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.adminreg);
            this.Controls.Add(this.wordlog);
            this.Controls.Add(this.userlog);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Adminlogin";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label wordlbl;
        private System.Windows.Forms.Label usname;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.TextBox wordlog;
        private System.Windows.Forms.TextBox userlog;
        private System.Windows.Forms.Label adminreg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}