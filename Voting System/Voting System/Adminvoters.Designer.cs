namespace Voting_System
{
    partial class Adminvoters
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
            this.voterpage = new System.Windows.Forms.Label();
            this.adminnavigation = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2_ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // voterpage
            // 
            this.voterpage.AutoSize = true;
            this.voterpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voterpage.Location = new System.Drawing.Point(31, 96);
            this.voterpage.Name = "voterpage";
            this.voterpage.Size = new System.Drawing.Size(165, 54);
            this.voterpage.TabIndex = 18;
            this.voterpage.Text = "Voters";
            // 
            // adminnavigation
            // 
            this.adminnavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.adminnavigation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminnavigation.Location = new System.Drawing.Point(13, 16);
            this.adminnavigation.Name = "adminnavigation";
            this.adminnavigation.Size = new System.Drawing.Size(47, 56);
            this.adminnavigation.TabIndex = 17;
            this.adminnavigation.Text = "___\r\n___\r\n___\r\n";
            this.adminnavigation.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(625, 98);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label2_
            // 
            this.label2_.AutoSize = true;
            this.label2_.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_.Location = new System.Drawing.Point(7, 131);
            this.label2_.Name = "label2_";
            this.label2_.Size = new System.Drawing.Size(610, 36);
            this.label2_.TabIndex = 19;
            this.label2_.Text = "___________________________________";
            // 
            // Adminvoters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 645);
            this.Controls.Add(this.voterpage);
            this.Controls.Add(this.adminnavigation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2_);
            this.Name = "Adminvoters";
            this.Text = "Adminvoters";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label voterpage;
        private System.Windows.Forms.Button adminnavigation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2_;
    }
}