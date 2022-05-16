namespace Group1_PRG281_Project
{
    partial class frmGenreGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenreGame));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblGScore = new System.Windows.Forms.Label();
            this.btnGenreAnswer = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblGenreQ = new System.Windows.Forms.Label();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.lblGenreTimer = new System.Windows.Forms.Label();
            this.lblArtistRules = new System.Windows.Forms.Label();
            this.lblGenreHeader = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.lblGenreTimer);
            this.panel1.Controls.Add(this.lblArtistRules);
            this.panel1.Controls.Add(this.lblGenreHeader);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 327);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnContinue);
            this.panel9.Controls.Add(this.lblTime);
            this.panel9.Controls.Add(this.lblGScore);
            this.panel9.Controls.Add(this.btnGenreAnswer);
            this.panel9.Controls.Add(this.lblTimer);
            this.panel9.Controls.Add(this.lblGenreQ);
            this.panel9.Controls.Add(this.cmbGenre);
            this.panel9.Location = new System.Drawing.Point(97, 114);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(451, 193);
            this.panel9.TabIndex = 6;
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.LightGray;
            this.btnContinue.Enabled = false;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnContinue.ForeColor = System.Drawing.Color.Black;
            this.btnContinue.Location = new System.Drawing.Point(109, 138);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(233, 42);
            this.btnContinue.TabIndex = 11;
            this.btnContinue.Text = "End Turn";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Visible = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(349, 14);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(83, 21);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Time Left";
            // 
            // lblGScore
            // 
            this.lblGScore.AutoSize = true;
            this.lblGScore.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGScore.Location = new System.Drawing.Point(12, 14);
            this.lblGScore.Name = "lblGScore";
            this.lblGScore.Size = new System.Drawing.Size(75, 21);
            this.lblGScore.TabIndex = 9;
            this.lblGScore.Text = "Score: 0";
            // 
            // btnGenreAnswer
            // 
            this.btnGenreAnswer.BackColor = System.Drawing.Color.LightGray;
            this.btnGenreAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenreAnswer.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenreAnswer.ForeColor = System.Drawing.Color.Black;
            this.btnGenreAnswer.Location = new System.Drawing.Point(109, 138);
            this.btnGenreAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenreAnswer.Name = "btnGenreAnswer";
            this.btnGenreAnswer.Size = new System.Drawing.Size(233, 42);
            this.btnGenreAnswer.TabIndex = 8;
            this.btnGenreAnswer.Text = "Begin";
            this.btnGenreAnswer.UseVisualStyleBackColor = false;
            this.btnGenreAnswer.EnabledChanged += new System.EventHandler(this.btnGenreAnswer_EnabledChanged);
            this.btnGenreAnswer.VisibleChanged += new System.EventHandler(this.btnGenreAnswer_VisibleChanged);
            this.btnGenreAnswer.Click += new System.EventHandler(this.btnGenreAnswer_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(376, 44);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 25);
            this.lblTimer.TabIndex = 7;
            // 
            // lblGenreQ
            // 
            this.lblGenreQ.AutoSize = true;
            this.lblGenreQ.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenreQ.Location = new System.Drawing.Point(167, 14);
            this.lblGenreQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenreQ.Name = "lblGenreQ";
            this.lblGenreQ.Size = new System.Drawing.Size(118, 21);
            this.lblGenreQ.TabIndex = 4;
            this.lblGenreQ.Text = "\"Artist Name\"";
            // 
            // cmbGenre
            // 
            this.cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenre.Enabled = false;
            this.cmbGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Items.AddRange(new object[] {
            "Afro Soul",
            "Blues",
            "Country",
            "Classical",
            "Dance",
            "Disco",
            "Dubstep",
            "EDM",
            "Funk",
            "Gospel",
            "Heavy Metal",
            "Hip Hop",
            "House",
            "House Amapiano",
            "Jazz",
            "Kwaito",
            "Maskandi",
            "Mbaqanga",
            "Pop",
            "Rap",
            "Reggae",
            "Rock",
            "Soul",
            "Techno",
            "Tsonga Disco"});
            this.cmbGenre.Location = new System.Drawing.Point(109, 70);
            this.cmbGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(233, 33);
            this.cmbGenre.TabIndex = 3;
            // 
            // lblGenreTimer
            // 
            this.lblGenreTimer.AutoSize = true;
            this.lblGenreTimer.Location = new System.Drawing.Point(424, 53);
            this.lblGenreTimer.Name = "lblGenreTimer";
            this.lblGenreTimer.Size = new System.Drawing.Size(0, 17);
            this.lblGenreTimer.TabIndex = 5;
            // 
            // lblArtistRules
            // 
            this.lblArtistRules.AutoSize = true;
            this.lblArtistRules.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblArtistRules.Location = new System.Drawing.Point(120, 62);
            this.lblArtistRules.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArtistRules.Name = "lblArtistRules";
            this.lblArtistRules.Size = new System.Drawing.Size(361, 23);
            this.lblArtistRules.TabIndex = 1;
            this.lblArtistRules.Text = "Select the genre of the display artist";
            this.lblArtistRules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGenreHeader
            // 
            this.lblGenreHeader.AutoSize = true;
            this.lblGenreHeader.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lblGenreHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.lblGenreHeader.Location = new System.Drawing.Point(133, 7);
            this.lblGenreHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenreHeader.Name = "lblGenreHeader";
            this.lblGenreHeader.Size = new System.Drawing.Size(352, 47);
            this.lblGenreHeader.TabIndex = 0;
            this.lblGenreHeader.Text = "Guess The Genre";
            this.lblGenreHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGenreGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 327);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGenreGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genre Guessing";
            this.Load += new System.EventHandler(this.frmGenreGame_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnGenreAnswer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblGenreQ;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.Label lblGenreTimer;
        private System.Windows.Forms.Label lblArtistRules;
        private System.Windows.Forms.Label lblGenreHeader;
        private System.Windows.Forms.Label lblGScore;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnContinue;
    }
}