using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    { 
       
        public Form1()
        {
            InitializeComponent();
           
        }

        public void btnRock_Click(object sender, EventArgs e)
        {
            txtResult.Text = "Rock";
       
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            txtResult.Text = "Paper";
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            txtResult.Text = "Scissors";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            string Player;
            string AI;
            int myAI;
           // bool playAgain = true;
           

          //  while (playAgain)
          //  {
             
                int Playerscore = 0;
                int AIscore = 0;



                while (Playerscore < 2 && AIscore < 2)
                {

                    Random rand = new Random();
                    myAI = rand.Next(1, 4);


                    switch (myAI)
                    {
                        case 1:
                            AI = "ROCK";
                            txtAI.Text = " AI CHOSE ROCK";
                            if ( txtResult.Text == "Rock")
                            {
                                txtDisplay.Text = "Draw";
                            }
                            else if (txtResult.Text == "Paper")
                            {
                                txtDisplay.Text = " You Win";
                                Playerscore++;
                            }
                            else if (txtResult.Text == "Scissors")
                            {
                                txtDisplay.Text = "AI Wins";
                                AIscore++;
                            }
                            
                            break;

                        case 2:
                            AI = "PAPER";
                            txtAI.Text = " AI CHOSE PAPER";
                            if (txtResult.Text == "Paper")
                            {
                                txtDisplay.Text = "Draw";
                            }
                            else if (txtResult.Text == "Rock")
                            {
                                txtDisplay.Text = "AI Wins";
                                AIscore++;
                            }
                            else if (txtResult.Text == "Scissors")
                            {
                                txtDisplay.Text = "You Win";
                                
                            }
                          
                            break;

                        case 3:
                            AI = "SCISSORS";
                           txtAI.Text = " AI CHOSE SCISSORS";
                            if (txtResult.Text == "Scissors")
                            {
                                txtDisplay.Text = "Draw";
                            }
                            else if (txtResult.Text == "Rock")
                            {
                                txtDisplay.Text = "You Win";
                                Playerscore++;
                            }
                            else if (txtResult.Text == "Paper")
                            {
                                txtDisplay.Text = "AI Win";
                                AIscore++;
                            }
                          
                            break;
                    }

                   // Console.WriteLine("\t\t\t Player Score:({0}) AI Score:({1})", Playerscore, AIscore);

                }
                if (Playerscore == 2)
                {
                    txtFinal.Text = "YOU WON!!!";
                }
                else if (AIscore == 2)
                {
                    txtFinal.Text = "AI WON!!!";
                }
            
            //}
        }
    
         
    }
}
