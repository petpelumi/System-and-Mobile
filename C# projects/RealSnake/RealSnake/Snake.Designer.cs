namespace RealSnake
{
    partial class Snake
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
            this.lblScore = new System.Windows.Forms.Label();
            this.lblFood = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lblPlayagain = new System.Windows.Forms.Label();
            this.lblGO = new System.Windows.Forms.Label();
            this.lblhighscore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Oreos", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(1, 2);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(132, 21);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score : 0";
            // 
            // lblFood
            // 
            this.lblFood.BackColor = System.Drawing.Color.Maroon;
            this.lblFood.Location = new System.Drawing.Point(63, 84);
            this.lblFood.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(20, 20);
            this.lblFood.TabIndex = 1;
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(106)))), ((int)(((byte)(54)))));
            this.btnYes.Enabled = false;
            this.btnYes.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.Location = new System.Drawing.Point(163, 266);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(77, 41);
            this.btnYes.TabIndex = 2;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Visible = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(106)))), ((int)(((byte)(54)))));
            this.btnNo.Enabled = false;
            this.btnNo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(255, 266);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(85, 41);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Visible = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lblPlayagain
            // 
            this.lblPlayagain.AutoSize = true;
            this.lblPlayagain.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayagain.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayagain.ForeColor = System.Drawing.Color.White;
            this.lblPlayagain.Location = new System.Drawing.Point(87, 220);
            this.lblPlayagain.Name = "lblPlayagain";
            this.lblPlayagain.Size = new System.Drawing.Size(329, 31);
            this.lblPlayagain.TabIndex = 4;
            this.lblPlayagain.Text = "Do you wish to play again?";
            this.lblPlayagain.Visible = false;
            this.lblPlayagain.Click += new System.EventHandler(this.lblPlayagain_Click);
            // 
            // lblGO
            // 
            this.lblGO.AutoSize = true;
            this.lblGO.BackColor = System.Drawing.Color.Transparent;
            this.lblGO.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGO.ForeColor = System.Drawing.Color.White;
            this.lblGO.Location = new System.Drawing.Point(80, 123);
            this.lblGO.Name = "lblGO";
            this.lblGO.Size = new System.Drawing.Size(350, 73);
            this.lblGO.TabIndex = 5;
            this.lblGO.Text = "Game Over";
            this.lblGO.Visible = false;
            this.lblGO.Click += new System.EventHandler(this.lblGO_Click);
            // 
            // lblhighscore
            // 
            this.lblhighscore.AutoSize = true;
            this.lblhighscore.BackColor = System.Drawing.Color.Transparent;
            this.lblhighscore.Font = new System.Drawing.Font("TATU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhighscore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblhighscore.Location = new System.Drawing.Point(304, 6);
            this.lblhighscore.Name = "lblhighscore";
            this.lblhighscore.Size = new System.Drawing.Size(36, 17);
            this.lblhighscore.TabIndex = 6;
            this.lblhighscore.Text = "TS";
            // 
            // Snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.lblhighscore);
            this.Controls.Add(this.lblGO);
            this.Controls.Add(this.lblPlayagain);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.lblScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Snake";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Snake_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Snake_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Snake_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lblPlayagain;
        private System.Windows.Forms.Label lblGO;
        private System.Windows.Forms.Label lblhighscore;
    }
}

