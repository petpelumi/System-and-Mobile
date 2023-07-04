using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealSnake
{
    public partial class Snake : Form
    {
        int sco;
        int top;
        int Cols = 25, Rows = 25, score = 0, dx = 0, dy = 0, front = 0, back = 0;
        Piece[] snake = new Piece[1250];
        
        
        
        List<int> available = new List<int>();
        bool[,] visit;

        Random rand = new Random();

        Timer timer = new Timer();

          
        public Snake()
        {
            InitializeComponent();
            initial();
            launchTimer();
        }

        private void launchTimer()
        {
            timer.Interval = 100;    
            timer.Tick += move;
            timer.Start();
            
        }

        private void move (object sender, EventArgs e)
        {
            int x = snake[front].Location.X, y = snake[front].Location.Y;
            if(dx == 0 && dy == 0 ) return;
            if (game_over(x + dx, y + dy))
            {
                timer.Stop();
                lblGO.Visible = true;
                lblPlayagain.Visible = true;
                btnYes.Enabled = true;
                btnYes.Visible = true;
                btnNo.Enabled = true;
                btnNo.Visible = true;
                return;
            }
            if(collisionFood(x + dx, y + dy))
            {
                score += 1;
                lblScore.Text = "Score : " + score.ToString();
                if (hits((y + dy) / 20, (x + dx) / 20)) return;
                Piece head = new Piece(x + dx, y + dy);
                front = (front - 1 + 1250) % 1250;
                snake[front] = head;
                visit[head.Location.Y / 20, head.Location.X / 20] = true;
                Controls.Add(head);
                randomFood();
                
                int DaddNum = 5;
                int AddNum = 4;
                int resultee = 0;
                for (int i = 0; i <= 100; i++)
                {
                    int rex = DaddNum + AddNum;
                    AddNum = rex;
                    resultee = AddNum;

                    
                    if (score == 4  || score == resultee  )
                    {
                        lblFood.Size = new Size(30, 30);
                        lblFood.BackColor = Color.Gold;
                        score = score + 1;
                    }
                    

                }

                 int increase = 5;
                int Addincrease = 6;
                int resulte = 0;
                for (int i = 0; i <= 100; i++)
                {
                    int rez = increase + Addincrease;
                    Addincrease = rez;
                    resulte = Addincrease;

                    if (score == 6 || score == resulte)
                    {

                        lblFood.BackColor = Color.Maroon;
                        lblFood.Size = new Size(20, 20);

                    }
            
                }
                   
                
                   
                if (score >= 5)
                    timer.Interval = 70;
                if (score >= 10)
                    timer.Interval = 60;
                if (score >= 15)
                    timer.Interval = 50;
                if (score >= 20)
                    timer.Interval = 40;
                if (score >= 25)
                    timer.Interval = 35;
                if (score >= 30)
                    timer.Interval = 30;
                if (score >= 35)
                    timer.Interval = 25;
                if (score >= 40)
                    timer.Interval = 20;
            }
            else 
            {
                if (hits((y + dy) / 20, (x + dx) / 20)) return;
                visit[snake[back].Location.Y / 20, snake[back].Location.X / 20] = false;
                front = (front - 1 + 1250) % 1250;
                snake[front] = snake[back];
                snake[front].Location = new Point(x + dx, y + dy);
                back = (back - 1 +1250) % 1250;
                visit[(y + dy) / 20, (x + dx) / 20] = true;
            }
        }

        private void randomFood()
        {
            available.Clear();
            for (int i = 0; i < Rows; i++)
            
                for (int j = 0; j < Cols; j++)
                    if (!visit[i, j]) available.Add(i * Cols + j);
                int idx = rand.Next(available.Count) % available.Count;
                lblFood.Left = (available[idx] * 20) % Width;
                lblFood.Top = (available[idx] * 20) / Width * 20;    
            
        }

        private bool hits(int x, int y)
        {
            if (visit[x, y])
            {
                timer.Stop();
                MessageBox.Show("Snake Hits his Body");
                lblGO.Visible = true;
                lblPlayagain.Visible = true;
                btnYes.Enabled = true;
                btnYes.Visible = true;
                btnNo.Enabled = true;
                btnNo.Visible = true;
                return true;
            }

            if(score > sco)
            {
                sco = score;
                lblhighscore.Text = "Top Score: " + sco;
                Topscore();
            }

            return false;
        }

        private bool collisionFood(int x, int y)
        {
            return x == lblFood.Location.X && y == lblFood.Location.Y;
        }

        private bool game_over(int x, int y)
        {
            return x < 0 || y < 0 || x > 490 || y > 480;
        }

        public void initial() 
        {
            visit = new bool[Rows, Cols];
            Piece head 
                = new Piece((rand.Next() % Cols) * 20, (rand.Next() % Rows) * 20);
            lblFood.Location
                = new Point((rand.Next() % Cols) * 20, (rand.Next() % Rows) * 20);
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                {
                    visit[i, j] = false;
                    available.Add(i * Cols + j);
                }
            visit[head.Location.Y / 20, head.Location.X / 20] = true;
            available.Remove(head.Location.Y / 20 * Cols + head.Location.X / 20);
            Controls.Add(head); snake[front] = head;
        }

        private void Snake_KeyDown(object sender, KeyEventArgs e)
        {
            dx = dy = 0;
            switch(e.KeyCode)
            {
                case Keys.Right:
                    dx = 20;
                    break;
                case Keys.Left:
                    dx = -20;
                    break;
                case Keys.Up:
                    dy = -20;
                    break;
                case Keys.Down:
                    dy = 20;
                    break;
            }
        }

        private void Snake_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Topscore()
    {
        Properties.Settings.Default.Highscore = sco.ToString();
        Properties.Settings.Default.Save();
    }


        private void btnYes_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Snake_Load(object sender, EventArgs e)
        {
            sco = int.Parse(this.Text = Properties.Settings.Default.Highscore);

            lblhighscore.Text = "Top Score: " + sco;
        }

        private void lblGO_Click(object sender, EventArgs e)
        {

        }

        private void lblPlayagain_Click(object sender, EventArgs e)
        {

        }
    }
}
