namespace Group1_PRG281_Project
{
    partial class frmSongGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSongGame));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnAristGuess = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSongScore = new System.Windows.Forms.Label();
            this.lblSongTimer = new System.Windows.Forms.Label();
            this.rbArtist4 = new System.Windows.Forms.RadioButton();
            this.rbArtist3 = new System.Windows.Forms.RadioButton();
            this.rbArtist2 = new System.Windows.Forms.RadioButton();
            this.rbArtist1 = new System.Windows.Forms.RadioButton();
            this.lblSongName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblArtistHeader = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnContinue);
            this.panel2.Controls.Add(this.btnAristGuess);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblArtistHeader);
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(648, 387);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(469, 326);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 42);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.LightGray;
            this.btnContinue.Enabled = false;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnContinue.ForeColor = System.Drawing.Color.Black;
            this.btnContinue.Location = new System.Drawing.Point(196, 281);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(233, 42);
            this.btnContinue.TabIndex = 13;
            this.btnContinue.Text = "End Turn";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Visible = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnAristGuess
            // 
            this.btnAristGuess.BackColor = System.Drawing.Color.LightGray;
            this.btnAristGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAristGuess.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnAristGuess.ForeColor = System.Drawing.Color.Black;
            this.btnAristGuess.Location = new System.Drawing.Point(196, 281);
            this.btnAristGuess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAristGuess.Name = "btnAristGuess";
            this.btnAristGuess.Size = new System.Drawing.Size(233, 42);
            this.btnAristGuess.TabIndex = 6;
            this.btnAristGuess.Text = "Begin";
            this.btnAristGuess.UseVisualStyleBackColor = false;
            this.btnAristGuess.EnabledChanged += new System.EventHandler(this.btnAristGuess_EnabledChanged);
            this.btnAristGuess.Click += new System.EventHandler(this.btnAristGuess_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblTime);
            this.panel3.Controls.Add(this.lblSongScore);
            this.panel3.Controls.Add(this.lblSongTimer);
            this.panel3.Controls.Add(this.rbArtist4);
            this.panel3.Controls.Add(this.rbArtist3);
            this.panel3.Controls.Add(this.rbArtist2);
            this.panel3.Controls.Add(this.rbArtist1);
            this.panel3.Controls.Add(this.lblSongName);
            this.panel3.Location = new System.Drawing.Point(88, 106);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 158);
            this.panel3.TabIndex = 5;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Underline);
            this.lblTime.Location = new System.Drawing.Point(353, 10);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(83, 21);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "Time Left";
            // 
            // lblSongScore
            // 
            this.lblSongScore.AutoSize = true;
            this.lblSongScore.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblSongScore.Location = new System.Drawing.Point(19, 10);
            this.lblSongScore.Name = "lblSongScore";
            this.lblSongScore.Size = new System.Drawing.Size(61, 21);
            this.lblSongScore.TabIndex = 9;
            this.lblSongScore.Text = "Score:";
            // 
            // lblSongTimer
            // 
            this.lblSongTimer.AutoSize = true;
            this.lblSongTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongTimer.Location = new System.Drawing.Point(375, 42);
            this.lblSongTimer.Name = "lblSongTimer";
            this.lblSongTimer.Size = new System.Drawing.Size(0, 25);
            this.lblSongTimer.TabIndex = 6;
            // 
            // rbArtist4
            // 
            this.rbArtist4.AutoSize = true;
            this.rbArtist4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rbArtist4.Location = new System.Drawing.Point(234, 110);
            this.rbArtist4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbArtist4.Name = "rbArtist4";
            this.rbArtist4.Size = new System.Drawing.Size(100, 27);
            this.rbArtist4.TabIndex = 8;
            this.rbArtist4.TabStop = true;
            this.rbArtist4.Text = "\"Artist4\"";
            this.rbArtist4.UseVisualStyleBackColor = true;
            // 
            // rbArtist3
            // 
            this.rbArtist3.AutoSize = true;
            this.rbArtist3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rbArtist3.Location = new System.Drawing.Point(22, 110);
            this.rbArtist3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbArtist3.Name = "rbArtist3";
            this.rbArtist3.Size = new System.Drawing.Size(100, 27);
            this.rbArtist3.TabIndex = 7;
            this.rbArtist3.TabStop = true;
            this.rbArtist3.Text = "\"Artist3\"";
            this.rbArtist3.UseVisualStyleBackColor = true;
            // 
            // rbArtist2
            // 
            this.rbArtist2.AutoSize = true;
            this.rbArtist2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rbArtist2.Location = new System.Drawing.Point(234, 65);
            this.rbArtist2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbArtist2.Name = "rbArtist2";
            this.rbArtist2.Size = new System.Drawing.Size(100, 27);
            this.rbArtist2.TabIndex = 6;
            this.rbArtist2.TabStop = true;
            this.rbArtist2.Text = "\"Artist2\"";
            this.rbArtist2.UseVisualStyleBackColor = true;
            // 
            // rbArtist1
            // 
            this.rbArtist1.AutoSize = true;
            this.rbArtist1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rbArtist1.Location = new System.Drawing.Point(22, 65);
            this.rbArtist1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbArtist1.Name = "rbArtist1";
            this.rbArtist1.Size = new System.Drawing.Size(100, 27);
            this.rbArtist1.TabIndex = 5;
            this.rbArtist1.TabStop = true;
            this.rbArtist1.Text = "\"Artist1\"";
            this.rbArtist1.UseVisualStyleBackColor = true;
            this.rbArtist1.CheckedChanged += new System.EventHandler(this.rbArtist1_CheckedChanged);
            // 
            // lblSongName
            // 
            this.lblSongName.AutoSize = true;
            this.lblSongName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblSongName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSongName.Location = new System.Drawing.Point(161, 10);
            this.lblSongName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(116, 21);
            this.lblSongName.TabIndex = 4;
            this.lblSongName.Text = "\"Song Name\"";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(68, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(478, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Choose the artist that made the displayed song";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArtistHeader
            // 
            this.lblArtistHeader.AutoSize = true;
            this.lblArtistHeader.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lblArtistHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.lblArtistHeader.Location = new System.Drawing.Point(188, 7);
            this.lblArtistHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArtistHeader.Name = "lblArtistHeader";
            this.lblArtistHeader.Size = new System.Drawing.Size(243, 47);
            this.lblArtistHeader.TabIndex = 0;
            this.lblArtistHeader.Text = "Music Trivia";
            this.lblArtistHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSongGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 380);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSongGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artist Guessing";
            this.Load += new System.EventHandler(this.frmSongGame_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAristGuess;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSongTimer;
        private System.Windows.Forms.RadioButton rbArtist4;
        private System.Windows.Forms.RadioButton rbArtist3;
        private System.Windows.Forms.RadioButton rbArtist2;
        private System.Windows.Forms.RadioButton rbArtist1;
        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblArtistHeader;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblSongScore;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnExit;
    }
}