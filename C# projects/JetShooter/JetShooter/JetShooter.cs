using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace JetShooter
{
    public partial class JetShooter : Form
    {
        WindowsMediaPlayer shootMedia;
        WindowsMediaPlayer backMedia;
        WindowsMediaPlayer Explosion;

        PictureBox[] Stars;
        int Backgroundspeed;
        Random rand;
        
        int Playerspeed;

        PictureBox[] munitions;
        int munitionspeed;

        PictureBox[] enemies;
        int enemiesSpeed;

        PictureBox[] Enemymunition;
        int enymymunitionspeed;

        PictureBox[] Planet;
        int Planetspeed;

        int score, level, difficulty;
        bool pause, gameover;

        public JetShooter()
        {
            InitializeComponent();
        }

        private void JetShooter_Load(object sender, EventArgs e)
        {
            pause = false;
            gameover = false;
            score = 0;
            level = 1;
            difficulty = 9;
            rand = new Random();
            shootMedia = new WindowsMediaPlayer();
            backMedia = new WindowsMediaPlayer();
            Explosion = new WindowsMediaPlayer();

            

            shootMedia.URL = (@"media\shooting.m4a");
            Explosion.URL = (@"media\bomb.m4a");
            backMedia.URL = (@"media\2019-09-19_-_Fight_Or_Flight_-_David_Fesliyan.mp3");

            shootMedia.settings.volume = 12;
            Explosion.settings.volume = 9;
            backMedia.settings.volume = 15;
            backMedia.settings.setMode("loop", true);

            backMedia.controls.play();

            Planet = new PictureBox[3];
            Image planet1 = Image.FromFile(@"myresources\galaxy.png");
            Image planet2 = Image.FromFile(@"myresources\galaxy 2.png");
            Image planet3 = Image.FromFile(@"myresources\galaxy 3.png");


                munitionspeed = 20;
                munitions = new PictureBox[3];
                Image munition = Image.FromFile(@"munitions\bullet.png");

                

                Image enem1 = Image.FromFile(@"myresources\jet1.png");
                Image enem2 = Image.FromFile(@"myresources\jet2.png");
                Image enem3 = Image.FromFile(@"myresources\jet4.png");
                Image enem4 = Image.FromFile(@"myresources\jet 6.png");

                enemies = new PictureBox[10];


                for (int i = 0; i < munitions.Length; i++ )
                {
                    munitions[i] = new PictureBox();
                    munitions[i].Image = munition;
                    munitions[i].Size = new Size(15,15);
                    munitions[i].BorderStyle = BorderStyle.None;
                    munitions[i].SizeMode = PictureBoxSizeMode.Zoom;
                    this.Controls.Add(munitions[i]);
                }

                for (int i = 0; i < enemies.Length; i++ )
                {
                    enemies[i] = new PictureBox();
                    enemies[i].Size = new Size(30, 30);
                    enemies[i].BorderStyle = BorderStyle.None;
                    enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                    enemies[i].Visible = false;
                    this.Controls.Add(enemies[i]);
                    enemies[i].Location = new Point((i + 1) * 50, -50);    
                }

                Enemymunition = new PictureBox[10];


                for (int i = 0; i < Enemymunition.Length; i++)
                {
                    Enemymunition[i] = new PictureBox();
                    Enemymunition[i].Size = new Size(1, 15);
                    Enemymunition[i].Visible = false;
                    Enemymunition[i].BackColor = Color.Yellow;
                    int x = rand.Next(0, 10);
                    Enemymunition[i].Location = new Point(enemies[x].Location.X, enemies[x].Location.Y - 20);
                    this.Controls.Add(Enemymunition[i]);
                }


                for (int i = 0; i < Planet.Length; i++)
                {
                    Planet[i] = new PictureBox();
                    Planet[i].Size = new Size(80, 80);
                    Planet[i].BorderStyle = BorderStyle.None;
                    Planet[i].SizeMode = PictureBoxSizeMode.Zoom;
                   // Planet[i].BackColor = BackColor.None;
                    //Planet[i].Visible = false;
                    this.Controls.Add(Planet[i]);
                    
                    Planet[i].Location = new Point(rand.Next(-50, 600), rand.Next(50, 500));
                }
                enemies[0].Image = enem4;
                enemies[1].Image = enem1;
                enemies[2].Image = enem3;
                enemies[3].Image = enem4;
                enemies[4].Image = enem2;
                enemies[5].Image = enem2;
                enemies[6].Image = enem4;
                enemies[7].Image = enem1;
                enemies[8].Image = enem3;
                enemies[9].Image = enem2;

                Planet[0].Image = planet1;
                Planet[1].Image = planet2;
                Planet[2].Image = planet3;

                

                Playerspeed = 4;
                Backgroundspeed = 4;
                enemiesSpeed = 4;
                enymymunitionspeed = 4;
                Planetspeed = 1;
                Stars = new PictureBox[12];
                
                
            for (int i = 0; i < Stars.Length; i++)
            {
                Stars[i] = new PictureBox();
                Stars[i].BorderStyle = BorderStyle.None;
                Stars[i].Location = new Point(rand.Next(10, 520), rand.Next(-10, 480));
                if (i % 2 == 1)
                {
                    Stars[i].Size = new Size(2, 2);
                    Stars[i].BackColor = Color.Wheat;
                }
                else
                {
                    Stars[i].Size = new Size(3, 3);
                    Stars[i].BackColor = Color.DarkGray;
                }
                this.Controls.Add(Stars[i]);
            }
             
        }

        private void MoveBGtimer_Tick(object sender, EventArgs e)
        {

            
            for (int i = 0; i <= Stars.Length/2; i++ )
            {
                Stars[i].Top += Backgroundspeed-2;
                if (Stars[i].Top >= this.Height)
                {
                    Stars[i].Top = -Stars[i].Height;
                }
            }

            for (int i = Stars.Length / 2; i < Stars.Length; i++)
            {
                Stars[i].Top += Backgroundspeed;
                if (Stars[i].Top >= this.Height)
                {
                    Stars[i].Top = -Stars[i].Height;
                }
            }
            for (int i = 0; i < Planet.Length; i++)
            {
                Planet[i].Top += Planetspeed  + 1;
                if (Planet[i].Top >= this.Height)
                {
                    Planet[i].Top = -Planet[i].Height;
                }
            }
            for (int i = Planet.Length / 2; i < Planet.Length; i++)
            {
                Planet[i].Top += Backgroundspeed -3;
                if (Planet[i].Top >= this.Height)
                {
                    Planet[i].Top = -Planet[i].Height;
                }
            }

            // for (int i = 0; i <= enemies.Length/2; i++ )
            //{
            //    enemies[i].Top += enemiesSpeed - 5;
            //    if (enemies[i].Top >= this.Height)
            //    {
            //        enemies[i].Top = -enemies[i].Height;
            //    }
            //}

            // for (int i = enemies.Length / 2; i < enemies.Length; i++)
            // {
            //     enemies[i].Top += enemiesSpeed;
            //     if (enemies[i].Top >= this.Height)
            //     {
            //         enemies[i].Top = -enemies[i].Height;
            //     }
            // }
        }

        private void leftMovetimer_Tick(object sender, EventArgs e)
        {
            if (Player.Left > 10)
            {
                Player.Left -= Playerspeed;
            }
        }

        private void rightMovetimer_Tick(object sender, EventArgs e)
        {
            if (Player.Left < 520)
            {
                Player.Left += Playerspeed;
            }
        }

        private void downMovetimer_Tick(object sender, EventArgs e)
        {
            if (Player.Top < 390)
            {
                Player.Top += Playerspeed;
            }
        }

        private void upMovetimer_Tick(object sender, EventArgs e)
        {
            if (Player.Top > 10)
            {
                Player.Top -= Playerspeed;
            }
        }

        private void JetShooter_KeyDown(object sender, KeyEventArgs e)
        {
            if(!pause)
            {
                if (e.KeyCode == Keys.Left)
                {
                    leftMovetimer.Start();
                }
                if (e.KeyCode == Keys.Right)
                {
                    rightMovetimer.Start();
                }
                if (e.KeyCode == Keys.Up)
                {
                    upMovetimer.Start();
                }
                if (e.KeyCode == Keys.Down)
                {
                    downMovetimer.Start();
                }
            }
        }

        private void JetShooter_KeyUp(object sender, KeyEventArgs e)
        {
            rightMovetimer.Stop();
                leftMovetimer.Stop();
                    upMovetimer.Stop();
                        downMovetimer.Stop();

                    if (e.KeyCode == Keys.Space)
                    {
                        if (!gameover)
                        {
                            if(pause)
                            {
                                StartTimer();
                                backMedia.controls.play();
                                label.Visible = false;
                                pause = false;
                            }
                            else
                            {
                                label.Location = new Point(this.Width/2-80, 150);
                                label.Text = "PAUSED";
                                backMedia.controls.pause();
                                label.Visible = true;
                                blowTimer.Stop();
                                StopTimer();
                                pause = true;
                            }
                        }
                    }
        }

        private void Movemunition_Tick(object sender, EventArgs e)
        {
            shootMedia.controls.play();
             for (int i = 0; i < munitions.Length; i++)
             {
                 if (munitions[i].Top > 0)
                 {
                     munitions[i].Visible = true;
                     munitions[i].Top -= munitionspeed;
                     Collision();
                     CollisionwithEnemyMunition();
                 }
                 else
                 {
                     munitions[i].Visible = false;
                     munitions[i].Location = new Point(Player.Location.X +20, Player.Location.Y  -i * 30);
                 }
             }
            
        }

        private void moveEnemies_Tick(object sender, EventArgs e)
        {
            moveEnemy(enemies, enemiesSpeed);
        }

        private void moveEnemy(PictureBox[] array, int speed)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Visible = true;
                array[i].Top += speed;
                if (array[i].Top > this.Height)
                {
                    array[i].Location = new Point((i +1 )* 50, -200);
                }
            }
        }
        
        private void Collision()
        {
            for (int i = 0; i < enemies.Length; i++ )
            {
                if (munitions[0].Bounds.IntersectsWith(enemies[i].Bounds) ||
                    munitions[1].Bounds.IntersectsWith(enemies[i].Bounds) || munitions[2].Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    Explosion.controls.play();
                    score += 1;
                    lblscore.Text = (score < 10)? "0" + score.ToString() : score.ToString();
                    if (score % 30 == 0)
                    {
                        level += 1;
                        lbllevel.Text = (level < 10)? "0" + level.ToString() : level.ToString();
                        if (enemiesSpeed <= 10 && enymymunitionspeed <= 10 && difficulty >= 0)
                        {
                            difficulty--;
                            enemiesSpeed++;
                            enymymunitionspeed++;
                        }
                        if (level == 10)
                        {
                            GameOver("NICE jOB");
                        }
                    }
                    enemies[i].Location = new Point((i + 1) * 50, -100);
                }
                    if (Player.Bounds.IntersectsWith(enemies[i].Bounds))
                    {
                        Explosion.settings.volume = 15;
                        Explosion.controls.play();
                        //imgblow.Visible = true;
                        Player.Visible = false;
                        GameOver("GAME OVER");
                    }
                }
            }
        private void GameOver(string str)
        {
            backMedia.controls.stop();
            label.Text = str;
            label.Location = new Point(200, 120);
            label.Visible = true;
            btnReplay.Visible = true;
            btnExit.Visible = true;
            //imgblow.Visible = false;
            blowTimer.Start();
            StopTimer();
        }
        private void StartTimer()
        {
            moveEnemies.Start();
            MoveBGtimer.Start();
            Movemunition.Start();
            EnemyMunitionTimer.Start();
            blowTimer.Stop();
        }
        private void StopTimer()
        {
            moveEnemies.Stop();
            MoveBGtimer.Stop();
            Movemunition.Stop();
            EnemyMunitionTimer.Stop();
            
            
        }

      

        private void EnemyMunitionTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Enemymunition.Length-difficulty; i++)
            {
                if(Enemymunition[i].Top < this.Height)
                {
                    Enemymunition[i].Visible = true;
                    Enemymunition[i].Top += enemiesSpeed;

                    CollisionwithEnemyMunition();
                }
                else
                {
                    Enemymunition[i].Visible = false;
                    int x = rand.Next(0, 10);
                    Enemymunition[i].Location = new Point(enemies[x].Location.X + 20, enemies[x].Location.Y + 30);
                }
            }
        }
        private void CollisionwithEnemyMunition()
        {
            for (int i = 0; i < Enemymunition.Length; i++)
            {

                if (Enemymunition[i].Bounds.IntersectsWith(Player.Bounds))
                {
                    Enemymunition[i].Visible = false;
                    Explosion.settings.volume = 40;
                    Explosion.controls.play();
                    imgblow.Visible = true;
                    Player.Visible = false;
                    GameOver("");
                    
                }
            }
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            blowTimer.Stop();
            InitializeComponent();
            JetShooter_Load(e, e);
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void blowTimer_Tick(object sender, EventArgs e)
        {
            imgblow.Visible = true;
            imgblow.Location = new Point(Player.Location.X, Player.Location.Y);
        }

       
    }
}
