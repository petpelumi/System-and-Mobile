using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CbtForm
{
    public partial class ExamQuestions : Form
    {
        int count = 1;
        int score = 0;
        int numbering = 2;
        int seconds;
          int set;

          //private int quick = 1800;



          string[] Questions = { " What is the capital of Algeria ", "What is the capital of Albenia", 
                                  " What is the capital of Brazil",    " What is the capital of Belarus ",
                                  " What is the capital of Belgium",   " What is the capital of Costa Rica",
                                  " What is the capital of Egypt",     " What is the capital of Finland",
                                  " What is the capital of Cameroon",  " What is the capital of Hungary",
                                  " What is the capital of Isreal",    " What is the capital of Nigeria",
                                  " What is the capital of Kenya ",    " What is the capital of Senegal",
                                  " What is the capital of Mexico",    " What is the capital of Qarter",
                                  " What is the capital of Japan ",    " What is the capital of Norway ",
                                  " What is the capital of Peru ",     " What is the capital of Monaco" };
          string Answer;


        public ExamQuestions()
        {
            InitializeComponent();
        }

        private void txtQuestions_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ExamQuestions_Load(object sender, EventArgs e)
        {
            //int minute = 2;
            seconds = 120;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            //timer2 = new System.Windows.Forms.Timer();
            //timer2.Interval = 1;
            //timer2.Tick += new EventHandler(timer2_Tick);



            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

           
           


            Random Ask = new Random();
        Questionmix:


            set = Ask.Next(Questions.Length);


            if (Questions[set] == "o") { goto Questionmix; }

            txtQuestions.Text = Questions[set];
           

            if (count < 12) { 

            if (set == 0)
            {
               // this.timer1.ToString(); 

                radioButton1.Text = "Algiers";
                radioButton2.Text = "Belarus";
                radioButton3.Text = "Norway";
                radioButton4.Text = "Cairo";
                
               // if (Answer == "A") { score++; }
                
                Questions[0] = "o";


                //Console.Clear();
            }
            if (set == 1)
            {

                radioButton1.Text = "Algiers";
                radioButton2.Text = "Abuja";
                radioButton3.Text = "Tirana";
                radioButton4.Text = "Yaonde";

                //if (Answer == "C") { score++; }
                Questions[1] = "o";
                // Console.Clear();

            }
            if (set == 2)
            {

                radioButton1.Text = "Skopje";
                radioButton2.Text = "Ottawa";
                radioButton3.Text = "Uranus";
                radioButton4.Text = " Brasilia";
               // if (Answer == "D") { score++; }
                Questions[2] = "o";

                // Console.Clear();
            }
            if (set == 3)
            {

                radioButton1.Text = "Algiers";
                radioButton2.Text = " Minsk";
                radioButton3.Text = "Norway";
                radioButton4.Text = "Cairo";
                //if (Answer == "B") { score++; }
                Questions[3] = "o";

                // Console.Clear();
            }
            if (set == 4)
            {

                radioButton1.Text = "Algiers";
                radioButton2.Text = "Belarus";
                radioButton3.Text = "Brussels";
                radioButton4.Text = "Cairo";
                //if (Answer == "C") { score++; }
                Questions[4] = "o";

                // Console.Clear();
            }
            if (set == 5)
            {

                radioButton1.Text = "San Jose";
                radioButton2.Text = "Belarus";
                radioButton3.Text = "Norway";
                radioButton4.Text = "Cairo";
              //  if (Answer == "A") { score++; }
                Questions[5] = "o";

                // Console.Clear();
            }
            if (set == 6)
            {


                radioButton1.Text = "Algiers";
                radioButton2.Text = "Belarus";
                radioButton3.Text = "Norway";
                radioButton4.Text = "Cairo";
                //if (Answer == "D") { score++; }
                Questions[6] = "o";

                // Console.Clear();
            }
            if (set == 7)
            {

                radioButton1.Text = "Algiers";
                radioButton2.Text = "Helsinki";
                radioButton3.Text = "Norway";
                radioButton4.Text = "Cairo";
                //if (Answer == "B") { score++; }
                Questions[7] = "o";

                //Console.Clear();
            }
            if (set == 8)
            {


                radioButton1.Text = "Algiers";
                radioButton2.Text = "Belarus";
                radioButton3.Text = "Norway";
                radioButton4.Text = "Yaounde";
                //if (Answer == "D") { score++; }
                Questions[8] = "o";

                //Console.Clear();
            }
            if (set == 9)
            {


                radioButton1.Text = "Algiers";
                radioButton2.Text = "Budapest";
                radioButton3.Text = "Norway";
                radioButton4.Text = "Cairo";
                //if (Answer == "B") { score++; }
                Questions[9] = "o";

                // Console.Clear();
            }
            if (set == 10)
            {

                radioButton1.Text = "Algiers";
                radioButton2.Text = "Belarus";
                radioButton3.Text = "Norway";
                radioButton4.Text = "Jerusalem";
               // if (Answer == "D") { score++; }
                Questions[10] = "o";

                // Console.Clear();
            }
            if (set == 11)
            {


                radioButton1.Text = "Abuja";
                radioButton2.Text = "Belarus";
                radioButton3.Text = "Norway";
                radioButton4.Text = "Cairo";
                //if (Answer == "A") { score++; }
                Questions[11] = "o";

                // Console.Clear();
            }
            if (set == 12)
            {

                radioButton1.Text = "Algiers";
                radioButton2.Text = "Belarus";
                radioButton3.Text = " Nairobi";
                radioButton4.Text = "Cairo";
                //if (Answer == "C") { score++; }
                Questions[12] = "o";

                // Console.Clear();
            }
            if (set == 13)
            {


                radioButton1.Text = "Algiers";
                radioButton2.Text = "Dakar";
                radioButton3.Text = "Norway";
                radioButton4.Text = "Cairo";
                //if (Answer == "B") { score++; }
                Questions[13] = "o";

                // Console.Clear();
            }
            if (set == 14)
            {


                radioButton1.Text = "Algiers";
                radioButton2.Text = "Belarus";
                radioButton3.Text = "Mexico City";
                radioButton4.Text = "Cairo";
                //if (Answer == "C") { score++; }
                Questions[14] = "o";

                // Console.Clear();
            }
            if (set == 15)
            {

                radioButton1.Text = "Algiers";
                radioButton2.Text = "Belarus";
                radioButton3.Text = "Norway";
                radioButton4.Text = "Doha";
               // if (Answer == "D") { score++; }
                Questions[15] = "o";

                // Console.Clear();
            }
            if (set == 16)
            {

                radioButton1.Text = "Tokyo";
                radioButton2.Text = "Belarus";
                radioButton3.Text = "Norway";
                radioButton4.Text = "Cairo";
               // if (Answer == "A") { score++; }
                Questions[16] = "o";

                //Console.Clear();
            }
            if (set == 17)
            {


                radioButton1.Text = "Oslo";
                radioButton2.Text = "Belarus";
                radioButton3.Text = "Norway";
                radioButton4.Text = "Cairo";
                //if (Answer == "A") { score++; }
                Questions[17] = "o";

                // Console.Clear();
            }
            if (set == 18)
            {

                radioButton1.Text = "Algiers";
                radioButton2.Text = "Lima";
                radioButton3.Text = "Norway";
                radioButton4.Text = "Cairo";
                //if (Answer == "B") { score++; }
                Questions[18] = "o";

                // Console.Clear();
            }
            if (set == 19)
            {


                radioButton1.Text = "Algiers";
                radioButton2.Text = "Belarus";
                radioButton3.Text = "Monte Carlo";
                radioButton4.Text = "Cairo";
               // if (Answer == "C") { score++; }
                Questions[19] = "o";

                // Console.Clear();
            }


            timer1.Enabled = false;
            if (count == 10) { btnNext.Text = "Submit"; }

            if (count == 11)
            {
                timer1.Enabled = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                label5.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                txtQuestions.Visible = false;
                btnNext.Enabled = false;
                lblQuestion.Visible = false;
                timer2.Enabled = false;

                score = (score * 100) / 10;
                if (score < 5) {
                    // MessageBox.Show("\t\t\t\t\tYou scored " + score + "% " + " \n\t\t\tYour Score is Below Average Better luck next Time");
                    txtMessg.Visible = true;
                    txtMessg.Text = "\t\tYou scored " + score + "% " + " \n\t\tYour Score is Below Average Better luck next Time";
                  
                }
                else if (score >= 5)
                {
                    // MessageBox.Show(score + "% Congratulations you passed ");
                    txtMessg.Visible = true;
                    txtMessg.Text = score + "% Congratulations you passed ";
                    
                }

            }

            }
        }
        
        private void btnNext_Click(object sender, EventArgs e)
        {
            
            lblQuestion.Text = "QUESTION " + numbering++ + " Of 10";
            count++;
            if (radioButton1.Checked) { Answer = "A"; }
            if (radioButton2.Checked){Answer = "B";}
            if (radioButton3.Checked){Answer = "C";}
            if (radioButton4.Checked) { Answer = "D"; }


            if (set == 0) { if (Answer == "A") { score++;  } } 
            if (set == 1) { if (Answer == "C") { score++;  } }
            if (set == 2) { if (Answer == "D") { score++;  } }
            if (set == 3) { if (Answer == "B") { score++;  } }
            if (set == 4) { if (Answer == "C") { score++;  } }
            if (set == 5) { if (Answer == "A") { score++;  } }
            if (set == 6) { if (Answer == "D") { score++;  } }
            if (set == 7) { if (Answer == "B") { score++;  } }
            if (set == 8) { if (Answer == "D") { score++;  } }
            if (set == 9) { if (Answer == "B") { score++;  } }
            if (set == 10) { if (Answer == "D") { score++;  } }
            if (set == 11) { if (Answer == "A") { score++;  } }
            if (set == 12) { if (Answer == "C") { score++;  } }
            if (set == 13) { if (Answer == "B") { score++;  } }
            if (set == 14) { if (Answer == "C") { score++;  } }
            if (set == 15) { if (Answer == "D") { score++;  } }
            if (set == 16) { if (Answer == "A") { score++;  } }
            if (set == 17) { if (Answer == "A") { score++;  } }
            if (set == 18) { if (Answer == "B") { score++;  } }
            if (set == 19) { if (Answer == "C") { score++; } }          
         
            timer1.Enabled = true;
           
            //if (radioButton1.Checked == true) { score++; }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           seconds--;
           if (seconds >= 0)
           {
               int secondsLeft = seconds % 60;
               int minutesLeft = seconds / 60;
                lbtTime.Text = minutesLeft + ":" +  secondsLeft;
           }
         //  score = (score * 100) / 10;
            if (  seconds == 0){
                timer1.Enabled = false;
                timer2.Enabled = false;
             
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                label5.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                txtQuestions.Visible = false;
                btnNext.Enabled = false;
                lblQuestion.Visible = false;
                
                if (score < 5)
                {
                   // score = (score * 100) / 10;
                    txtMessg.Visible = true;
                    txtMessg.Text = score +  "% " + " \n\t\tYour Score is Below Average Better luck next Time";

                }
                else if (score >= 5)
                {
                   // score = (score * 100) / 10;
                    txtMessg.Visible = true;
                    txtMessg.Text = score + "% Congratulations you passed ";
                }

            }
        }
    }
}
            
