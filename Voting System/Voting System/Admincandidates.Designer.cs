namespace Voting_System
{
    partial class Admincandidates
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
            this.adminnavigation = new System.Windows.Forms.Button();
            this.candidatespage = new System.Windows.Forms.Label();
            this.label2_ = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(625, 98);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // adminnavigation
            // 
            this.adminnavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.adminnavigation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminnavigation.Location = new System.Drawing.Point(12, 22);
            this.adminnavigation.Name = "adminnavigation";
            this.adminnavigation.Size = new System.Drawing.Size(47, 56);
            this.adminnavigation.TabIndex = 18;
            this.adminnavigation.Text = "___\r\n___\r\n___\r\n";
            this.adminnavigation.UseVisualStyleBackColor = false;
            // 
            // candidatespage
            // 
            this.candidatespage.AutoSize = true;
            this.candidatespage.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidatespage.Location = new System.Drawing.Point(25, 98);
            this.candidatespage.Name = "candidatespage";
            this.candidatespage.Size = new System.Drawing.Size(270, 54);
            this.candidatespage.TabIndex = 20;
            this.candidatespage.Text = "Candidates";
            // 
            // label2_
            // 
            this.label2_.AutoSize = true;
            this.label2_.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_.Location = new System.Drawing.Point(1, 133);
            this.label2_.Name = "label2_";
            this.label2_.Size = new System.Drawing.Size(610, 36);
            this.label2_.TabIndex = 21;
            this.label2_.Text = "___________________________________";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(474, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 35);
            this.button1.TabIndex = 22;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Admincandidates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 645);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.candidatespage);
            this.Controls.Add(this.label2_);
            this.Controls.Add(this.adminnavigation);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Admincandidates";
            this.Text = "Admincandidates";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button adminnavigation;
        private System.Windows.Forms.Label candidatespage;
        private System.Windows.Forms.Label label2_;
        private System.Windows.Forms.Button button1;
    }
}