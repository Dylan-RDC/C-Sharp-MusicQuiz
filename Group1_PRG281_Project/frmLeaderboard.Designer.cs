namespace Group1_PRG281_Project
{
    partial class frmLeaderboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeaderboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.loserScoreLbl = new System.Windows.Forms.Label();
            this.winnerScoreLbl = new System.Windows.Forms.Label();
            this.loserNameLbl = new System.Windows.Forms.Label();
            this.winnerNameLbl = new System.Windows.Forms.Label();
            this.lblWinnerLb = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 576);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.label3.Location = new System.Drawing.Point(79, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Leaderboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Group1_PRG281_Project.Properties.Resources.Untitled_design;
            this.pictureBox1.Location = new System.Drawing.Point(72, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Controls.Add(this.loserScoreLbl);
            this.panel6.Controls.Add(this.winnerScoreLbl);
            this.panel6.Controls.Add(this.loserNameLbl);
            this.panel6.Controls.Add(this.winnerNameLbl);
            this.panel6.Controls.Add(this.lblWinnerLb);
            this.panel6.Controls.Add(this.btnExit);
            this.panel6.ForeColor = System.Drawing.SystemColors.Control;
            this.panel6.Location = new System.Drawing.Point(406, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(399, 576);
            this.panel6.TabIndex = 10;
            // 
            // loserScoreLbl
            // 
            this.loserScoreLbl.AutoSize = true;
            this.loserScoreLbl.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.loserScoreLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loserScoreLbl.Location = new System.Drawing.Point(282, 174);
            this.loserScoreLbl.Name = "loserScoreLbl";
            this.loserScoreLbl.Size = new System.Drawing.Size(77, 23);
            this.loserScoreLbl.TabIndex = 11;
            this.loserScoreLbl.Text = "\"Score\"";
            // 
            // winnerScoreLbl
            // 
            this.winnerScoreLbl.AutoSize = true;
            this.winnerScoreLbl.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.winnerScoreLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.winnerScoreLbl.Location = new System.Drawing.Point(282, 134);
            this.winnerScoreLbl.Name = "winnerScoreLbl";
            this.winnerScoreLbl.Size = new System.Drawing.Size(77, 23);
            this.winnerScoreLbl.TabIndex = 10;
            this.winnerScoreLbl.Text = "\"Score\"";
            // 
            // loserNameLbl
            // 
            this.loserNameLbl.AutoSize = true;
            this.loserNameLbl.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.loserNameLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loserNameLbl.Location = new System.Drawing.Point(26, 174);
            this.loserNameLbl.Name = "loserNameLbl";
            this.loserNameLbl.Size = new System.Drawing.Size(83, 23);
            this.loserNameLbl.TabIndex = 9;
            this.loserNameLbl.Text = "\"Player\"";
            // 
            // winnerNameLbl
            // 
            this.winnerNameLbl.AutoSize = true;
            this.winnerNameLbl.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.winnerNameLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.winnerNameLbl.Location = new System.Drawing.Point(26, 134);
            this.winnerNameLbl.Name = "winnerNameLbl";
            this.winnerNameLbl.Size = new System.Drawing.Size(83, 23);
            this.winnerNameLbl.TabIndex = 8;
            this.winnerNameLbl.Text = "\"Player\"";
            // 
            // lblWinnerLb
            // 
            this.lblWinnerLb.AutoSize = true;
            this.lblWinnerLb.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnerLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.lblWinnerLb.Location = new System.Drawing.Point(123, 69);
            this.lblWinnerLb.Name = "lblWinnerLb";
            this.lblWinnerLb.Size = new System.Drawing.Size(153, 47);
            this.lblWinnerLb.TabIndex = 2;
            this.lblWinnerLb.Text = "Winner";
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(229, 276);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 42);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLeaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 330);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLeaderboard";
            this.Text = "Leaderboard";
            this.Load += new System.EventHandler(this.frmLeaderboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblWinnerLb;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label loserScoreLbl;
        private System.Windows.Forms.Label winnerScoreLbl;
        private System.Windows.Forms.Label loserNameLbl;
        private System.Windows.Forms.Label winnerNameLbl;
    }
}