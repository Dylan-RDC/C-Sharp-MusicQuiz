namespace Group1_PRG281_Project
{
    partial class frmSinglePlayerEnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSinglePlayerEnd));
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReplay = new System.Windows.Forms.Button();
            this.lblP1Correct = new System.Windows.Forms.Label();
            this.lblP1Quesiton = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblSingleEndHeader = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightGray;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.btnExit);
            this.panel7.Controls.Add(this.btnReplay);
            this.panel7.Controls.Add(this.lblP1Correct);
            this.panel7.Controls.Add(this.lblP1Quesiton);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.lblSingleEndHeader);
            this.panel7.Location = new System.Drawing.Point(451, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(455, 722);
            this.panel7.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(264, 657);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 53);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReplay
            // 
            this.btnReplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnReplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplay.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnReplay.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnReplay.Location = new System.Drawing.Point(102, 377);
            this.btnReplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(262, 52);
            this.btnReplay.TabIndex = 10;
            this.btnReplay.Text = "PLAY AGAIN";
            this.btnReplay.UseVisualStyleBackColor = false;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // lblP1Correct
            // 
            this.lblP1Correct.AutoSize = true;
            this.lblP1Correct.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblP1Correct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblP1Correct.Location = new System.Drawing.Point(312, 309);
            this.lblP1Correct.Name = "lblP1Correct";
            this.lblP1Correct.Size = new System.Drawing.Size(129, 30);
            this.lblP1Correct.TabIndex = 5;
            this.lblP1Correct.Text = "\"Amount\" ";
            // 
            // lblP1Quesiton
            // 
            this.lblP1Quesiton.AutoSize = true;
            this.lblP1Quesiton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblP1Quesiton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblP1Quesiton.Location = new System.Drawing.Point(312, 251);
            this.lblP1Quesiton.Name = "lblP1Quesiton";
            this.lblP1Quesiton.Size = new System.Drawing.Size(129, 30);
            this.lblP1Quesiton.TabIndex = 4;
            this.lblP1Quesiton.Text = "\"Amount\" ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(29, 309);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(218, 30);
            this.label17.TabIndex = 2;
            this.label17.Text = "Correct answers: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(29, 251);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(267, 30);
            this.label16.TabIndex = 1;
            this.label16.Text = "Questions answered: ";
            // 
            // lblSingleEndHeader
            // 
            this.lblSingleEndHeader.AutoSize = true;
            this.lblSingleEndHeader.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.lblSingleEndHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.lblSingleEndHeader.Location = new System.Drawing.Point(129, 168);
            this.lblSingleEndHeader.Name = "lblSingleEndHeader";
            this.lblSingleEndHeader.Size = new System.Drawing.Size(192, 51);
            this.lblSingleEndHeader.TabIndex = 0;
            this.lblSingleEndHeader.Text = "Player 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.label3.Location = new System.Drawing.Point(144, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 43);
            this.label3.TabIndex = 1;
            this.label3.Text = "Scores";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Group1_PRG281_Project.Properties.Resources.Untitled_design;
            this.pictureBox1.Location = new System.Drawing.Point(80, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 720);
            this.panel1.TabIndex = 9;
            // 
            // frmSinglePlayerEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 720);
            this.ControlBox = false;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSinglePlayerEnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final Score";
            this.Load += new System.EventHandler(this.frmSinglePlayerEnd_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblP1Correct;
        private System.Windows.Forms.Label lblP1Quesiton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblSingleEndHeader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}