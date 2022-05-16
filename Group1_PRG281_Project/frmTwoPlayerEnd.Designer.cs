namespace Group1_PRG281_Project
{
    partial class frm2PlayerScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm2PlayerScore));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReplay = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblP2Correct = new System.Windows.Forms.Label();
            this.lblP2Question = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblP2Name = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblP1Correct = new System.Windows.Forms.Label();
            this.lblP1Quesiton = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblP1Name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPlayer2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.leaderBtn = new System.Windows.Forms.Button();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(263, 653);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 53);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReplay
            // 
            this.btnReplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnReplay.Enabled = false;
            this.btnReplay.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnReplay.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnReplay.Location = new System.Drawing.Point(102, 543);
            this.btnReplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(262, 52);
            this.btnReplay.TabIndex = 8;
            this.btnReplay.Text = "Play again";
            this.btnReplay.UseVisualStyleBackColor = false;
            this.btnReplay.Visible = false;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lblResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.lblResults.Location = new System.Drawing.Point(53, 19);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(360, 43);
            this.lblResults.TabIndex = 7;
            this.lblResults.Text = "And the winner is ...";
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.Controls.Add(this.lblP2Correct);
            this.panel8.Controls.Add(this.lblP2Question);
            this.panel8.Controls.Add(this.label19);
            this.panel8.Controls.Add(this.label18);
            this.panel8.Controls.Add(this.lblP2Name);
            this.panel8.Location = new System.Drawing.Point(18, 320);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(425, 200);
            this.panel8.TabIndex = 6;
            // 
            // lblP2Correct
            // 
            this.lblP2Correct.AutoSize = true;
            this.lblP2Correct.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblP2Correct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblP2Correct.Location = new System.Drawing.Point(291, 126);
            this.lblP2Correct.Name = "lblP2Correct";
            this.lblP2Correct.Size = new System.Drawing.Size(129, 30);
            this.lblP2Correct.TabIndex = 7;
            this.lblP2Correct.Text = "\"Amount\" ";
            // 
            // lblP2Question
            // 
            this.lblP2Question.AutoSize = true;
            this.lblP2Question.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblP2Question.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblP2Question.Location = new System.Drawing.Point(291, 75);
            this.lblP2Question.Name = "lblP2Question";
            this.lblP2Question.Size = new System.Drawing.Size(129, 30);
            this.lblP2Question.TabIndex = 6;
            this.lblP2Question.Text = "\"Amount\" ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(3, 126);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(218, 30);
            this.label19.TabIndex = 3;
            this.label19.Text = "Correct answers: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(3, 75);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(267, 30);
            this.label18.TabIndex = 3;
            this.label18.Text = "Questions answered: ";
            // 
            // lblP2Name
            // 
            this.lblP2Name.AutoSize = true;
            this.lblP2Name.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.lblP2Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.lblP2Name.Location = new System.Drawing.Point(111, 0);
            this.lblP2Name.Name = "lblP2Name";
            this.lblP2Name.Size = new System.Drawing.Size(192, 51);
            this.lblP2Name.TabIndex = 1;
            this.lblP2Name.Text = "Player 2";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightGray;
            this.panel7.Controls.Add(this.lblP1Correct);
            this.panel7.Controls.Add(this.lblP1Quesiton);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.lblP1Name);
            this.panel7.Location = new System.Drawing.Point(18, 101);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(425, 200);
            this.panel7.TabIndex = 5;
            // 
            // lblP1Correct
            // 
            this.lblP1Correct.AutoSize = true;
            this.lblP1Correct.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblP1Correct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblP1Correct.Location = new System.Drawing.Point(291, 130);
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
            this.lblP1Quesiton.Location = new System.Drawing.Point(291, 79);
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
            this.label17.Location = new System.Drawing.Point(3, 130);
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
            this.label16.Location = new System.Drawing.Point(3, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(267, 30);
            this.label16.TabIndex = 1;
            this.label16.Text = "Questions answered: ";
            // 
            // lblP1Name
            // 
            this.lblP1Name.AutoSize = true;
            this.lblP1Name.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.lblP1Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.lblP1Name.Location = new System.Drawing.Point(112, 0);
            this.lblP1Name.Name = "lblP1Name";
            this.lblP1Name.Size = new System.Drawing.Size(192, 51);
            this.lblP1Name.TabIndex = 0;
            this.lblP1Name.Text = "Player 1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btnPlayer2);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblResults);
            this.panel1.Controls.Add(this.btnReplay);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Location = new System.Drawing.Point(453, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 722);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnPlayer2
            // 
            this.btnPlayer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnPlayer2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnPlayer2.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnPlayer2.Location = new System.Drawing.Point(102, 543);
            this.btnPlayer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlayer2.Name = "btnPlayer2";
            this.btnPlayer2.Size = new System.Drawing.Size(262, 52);
            this.btnPlayer2.TabIndex = 10;
            this.btnPlayer2.Text = "Next Player";
            this.btnPlayer2.UseVisualStyleBackColor = false;
            this.btnPlayer2.Click += new System.EventHandler(this.btnPlayer2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.leaderBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(-2, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 720);
            this.panel2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.label3.Location = new System.Drawing.Point(151, 444);
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
            // leaderBtn
            // 
            this.leaderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.leaderBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.leaderBtn.ForeColor = System.Drawing.Color.AliceBlue;
            this.leaderBtn.Location = new System.Drawing.Point(89, 544);
            this.leaderBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.leaderBtn.Name = "leaderBtn";
            this.leaderBtn.Size = new System.Drawing.Size(262, 52);
            this.leaderBtn.TabIndex = 11;
            this.leaderBtn.Text = "Leaderboard";
            this.leaderBtn.UseVisualStyleBackColor = false;
            this.leaderBtn.Click += new System.EventHandler(this.leaderBtn_Click);
            // 
            // frm2PlayerScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 720);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm2PlayerScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Winner Screen";
            this.Load += new System.EventHandler(this.frm2PlayerScore_Load);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReplay;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblP2Correct;
        private System.Windows.Forms.Label lblP2Question;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblP2Name;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblP1Correct;
        private System.Windows.Forms.Label lblP1Quesiton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblP1Name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPlayer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button leaderBtn;
    }
}