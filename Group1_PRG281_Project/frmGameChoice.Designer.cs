namespace Group1_PRG281_Project
{
    partial class frmGameChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameChoice));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnArtistGame = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGenreGame = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnExit);
            this.panel4.Controls.Add(this.btnArtistGame);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.btnGenreGame);
            this.panel4.Location = new System.Drawing.Point(1, -4);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(723, 464);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(174, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Please choose your game type";
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(529, 316);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 53);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnArtistGame
            // 
            this.btnArtistGame.BackColor = System.Drawing.Color.LightGray;
            this.btnArtistGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtistGame.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnArtistGame.Location = new System.Drawing.Point(54, 227);
            this.btnArtistGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnArtistGame.Name = "btnArtistGame";
            this.btnArtistGame.Size = new System.Drawing.Size(262, 52);
            this.btnArtistGame.TabIndex = 5;
            this.btnArtistGame.Text = "Artist Mystery";
            this.btnArtistGame.UseVisualStyleBackColor = false;
            this.btnArtistGame.Click += new System.EventHandler(this.btnArtistGame_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(393, 140);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.MaximumSize = new System.Drawing.Size(300, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(286, 69);
            this.label11.TabIndex = 4;
            this.label11.Text = "Guess the genre: Recieve a artist name and guess their genre of music";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.label10.Location = new System.Drawing.Point(193, 13);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(356, 56);
            this.label10.TabIndex = 3;
            this.label10.Text = "Game Choice";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(50, 140);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.MaximumSize = new System.Drawing.Size(300, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(295, 69);
            this.label9.TabIndex = 2;
            this.label9.Text = "Guess the artist: Receive a song name and select which artist produces the song";
            // 
            // btnGenreGame
            // 
            this.btnGenreGame.BackColor = System.Drawing.Color.LightGray;
            this.btnGenreGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenreGame.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenreGame.Location = new System.Drawing.Point(396, 227);
            this.btnGenreGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenreGame.Name = "btnGenreGame";
            this.btnGenreGame.Size = new System.Drawing.Size(262, 52);
            this.btnGenreGame.TabIndex = 1;
            this.btnGenreGame.Text = "Genre Guessing";
            this.btnGenreGame.UseVisualStyleBackColor = false;
            this.btnGenreGame.Click += new System.EventHandler(this.btnGenreGame_Click);
            // 
            // frmGameChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 379);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGameChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Choice";
            this.Load += new System.EventHandler(this.frmGameChoice_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnArtistGame;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGenreGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}