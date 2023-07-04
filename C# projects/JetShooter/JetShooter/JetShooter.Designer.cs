namespace JetShooter
{
    partial class JetShooter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JetShooter));
            this.MoveBGtimer = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.leftMovetimer = new System.Windows.Forms.Timer(this.components);
            this.rightMovetimer = new System.Windows.Forms.Timer(this.components);
            this.downMovetimer = new System.Windows.Forms.Timer(this.components);
            this.upMovetimer = new System.Windows.Forms.Timer(this.components);
            this.Movemunition = new System.Windows.Forms.Timer(this.components);
            this.moveEnemies = new System.Windows.Forms.Timer(this.components);
            this.EnemyMunitionTimer = new System.Windows.Forms.Timer(this.components);
            this.label = new System.Windows.Forms.Label();
            this.btnReplay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblscore = new System.Windows.Forms.Label();
            this.lbllevel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timershoot = new System.Windows.Forms.Timer(this.components);
            this.imgblow = new System.Windows.Forms.PictureBox();
            this.blowTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgblow)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveBGtimer
            // 
            this.MoveBGtimer.Enabled = true;
            this.MoveBGtimer.Interval = 10;
            this.MoveBGtimer.Tick += new System.EventHandler(this.MoveBGtimer_Tick);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(255, 399);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 50);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // leftMovetimer
            // 
            this.leftMovetimer.Interval = 5;
            this.leftMovetimer.Tick += new System.EventHandler(this.leftMovetimer_Tick);
            // 
            // rightMovetimer
            // 
            this.rightMovetimer.Interval = 5;
            this.rightMovetimer.Tick += new System.EventHandler(this.rightMovetimer_Tick);
            // 
            // downMovetimer
            // 
            this.downMovetimer.Interval = 5;
            this.downMovetimer.Tick += new System.EventHandler(this.downMovetimer_Tick);
            // 
            // upMovetimer
            // 
            this.upMovetimer.Interval = 5;
            this.upMovetimer.Tick += new System.EventHandler(this.upMovetimer_Tick);
            // 
            // Movemunition
            // 
            this.Movemunition.Enabled = true;
            this.Movemunition.Interval = 15;
            this.Movemunition.Tick += new System.EventHandler(this.Movemunition_Tick);
            // 
            // moveEnemies
            // 
            this.moveEnemies.Enabled = true;
            this.moveEnemies.Tick += new System.EventHandler(this.moveEnemies_Tick);
            // 
            // EnemyMunitionTimer
            // 
            this.EnemyMunitionTimer.Enabled = true;
            this.EnemyMunitionTimer.Interval = 20;
            this.EnemyMunitionTimer.Tick += new System.EventHandler(this.EnemyMunitionTimer_Tick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("1-2-3 GO!", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label.Location = new System.Drawing.Point(250, 107);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(107, 27);
            this.label.TabIndex = 1;
            this.label.Text = "label";
            this.label.Visible = false;
            // 
            // btnReplay
            // 
            this.btnReplay.Font = new System.Drawing.Font("1-2-3 GO!", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplay.Location = new System.Drawing.Point(245, 176);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(100, 38);
            this.btnReplay.TabIndex = 2;
            this.btnReplay.Text = "REPLAY";
            this.btnReplay.UseVisualStyleBackColor = true;
            this.btnReplay.Visible = false;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("1-2-3 GO!", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(245, 241);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 33);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.BackColor = System.Drawing.Color.Transparent;
            this.lblscore.Font = new System.Drawing.Font("04b03", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblscore.Location = new System.Drawing.Point(81, 15);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(0, 16);
            this.lblscore.TabIndex = 4;
            // 
            // lbllevel
            // 
            this.lbllevel.AutoSize = true;
            this.lbllevel.Font = new System.Drawing.Font("04b03", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllevel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbllevel.Location = new System.Drawing.Point(528, 13);
            this.lbllevel.Name = "lbllevel";
            this.lbllevel.Size = new System.Drawing.Size(24, 16);
            this.lbllevel.TabIndex = 5;
            this.lbllevel.Text = "01";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("04b03", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("04b03", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(477, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Level:";
            // 
            // timershoot
            // 
            this.timershoot.Enabled = true;
            this.timershoot.Interval = 2;
            // 
            // imgblow
            // 
            this.imgblow.Image = ((System.Drawing.Image)(resources.GetObject("imgblow.Image")));
            this.imgblow.Location = new System.Drawing.Point(236, 380);
            this.imgblow.Name = "imgblow";
            this.imgblow.Size = new System.Drawing.Size(78, 48);
            this.imgblow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgblow.TabIndex = 8;
            this.imgblow.TabStop = false;
            this.imgblow.Visible = false;
            // 
            // blowTimer
            // 
            this.blowTimer.Interval = 10;
            this.blowTimer.Tick += new System.EventHandler(this.blowTimer_Tick);
            // 
            // JetShooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.imgblow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbllevel);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReplay);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JetShooter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JetShooter";
            this.Load += new System.EventHandler(this.JetShooter_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.JetShooter_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.JetShooter_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgblow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MoveBGtimer;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer leftMovetimer;
        private System.Windows.Forms.Timer rightMovetimer;
        private System.Windows.Forms.Timer downMovetimer;
        private System.Windows.Forms.Timer upMovetimer;
        private System.Windows.Forms.Timer Movemunition;
        private System.Windows.Forms.Timer moveEnemies;
        private System.Windows.Forms.Timer EnemyMunitionTimer;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnReplay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Label lbllevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timershoot;
        private System.Windows.Forms.PictureBox imgblow;
        private System.Windows.Forms.Timer blowTimer;
    }
}

