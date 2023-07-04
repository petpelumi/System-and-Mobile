using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AndroidX.AppCompat.Widget;
using CbtXamarin.DataModels;
using CbtXamarin.helpers;
using CbtXamarin.Fragments;
using Google.Android.Material.Snackbar;

namespace CbtXamarin.Ativities_file
{
    [Obsolete]
    [Activity(Label = "QuizActivity")]
    public class QuizActivity : AppCompatActivity
    {
      
        Toolbar toolbar;
        string QuizTopic;
        int quizPosition;

        double correctAnswerCount = 0;

        System.Timers.Timer countDown = new System.Timers.Timer();
        int timerCounter = 0;
        DateTime dateTime;

        //Radio Button 
        Android.Widget.RadioButton optionARadio, optionBRadio, optionCRadio, optionDRadio;
        //TextViews
        Android.Widget.TextView optionATextView, optionBTextView, optionCTextView, optionDtextView, questionTextView, quizPositionTextView, timeCounterTextView;
        //Button
        Android.Widget.Button proceedButton;
        //variables
        List<Question> quizQuestionList = new List<Question>();
        Quizhelpers quizHelper = new Quizhelpers();
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.quiz_page);

            QuizTopic = Intent.GetStringExtra("topic");
            // toolbar = (Toolbar)FindViewById(Resource.Id.quiz_toolbar);
            toolbar = FindViewById<Toolbar>(Resource.Id.quiz_toolbar);

            SetSupportActionBar(toolbar);
            SupportActionBar.Title = QuizTopic + " Quiz";

            AndroidX.AppCompat.App.ActionBar actionBar = SupportActionBar;
            actionBar.SetHomeAsUpIndicator(Resource.Drawable.outline_arrowback);
            actionBar.SetDisplayHomeAsUpEnabled(true);

            ConnectViews();  
            BeginQuiz();

            countDown.Interval = 1000;
            countDown.Elapsed += CountDown_Elapsed;

        }

        private void CountDown_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timerCounter++;
            DateTime dt = new DateTime();
            dt = dateTime.AddSeconds(-1);

            var dateDifference = dateTime.Subtract(dt);
            dateTime = dateTime - dateDifference;

            RunOnUiThread(() =>
            {
                timeCounterTextView.Text = dateTime.ToString("mm:ss");
            });

            //End of quiz
            if (timerCounter == 120)
            {
                countDown.Enabled = false;
                CompleteQuiz(); 
            }
        }

        void ConnectViews()
        {
            //RedioButton
            optionARadio = (Android.Widget.RadioButton)FindViewById(Resource.Id.optionA_btn);
            optionBRadio = (Android.Widget.RadioButton)FindViewById(Resource.Id.optionB_btn);
            optionCRadio = (Android.Widget.RadioButton)FindViewById(Resource.Id.optionC_btn);
            optionDRadio = (Android.Widget.RadioButton)FindViewById(Resource.Id.optionD_btn);

            optionARadio.Click += OptionARadio_Click;
            optionBRadio.Click += OptionBRadio_Click;
            optionCRadio.Click += OptionCRadio_Click;
            optionDRadio.Click += OptionDRadio_Click;



            //TextViews
            optionATextView = (Android.Widget.TextView)FindViewById(Resource.Id.optionA_textview);
            optionBTextView = (Android.Widget.TextView)FindViewById(Resource.Id.optionB_textview);
            optionCTextView = (Android.Widget.TextView)FindViewById(Resource.Id.optionC_textview);
            optionDtextView = (Android.Widget.TextView)FindViewById(Resource.Id.optionD_textview);
            questionTextView = (Android.Widget.TextView)FindViewById(Resource.Id.quizQuestionTextView);
            quizPositionTextView = (Android.Widget.TextView)FindViewById(Resource.Id.quizPosition_textView);
            timeCounterTextView = (Android.Widget.TextView)FindViewById(Resource.Id.timeCounter_textView);

            //Button
            proceedButton = (Android.Widget.Button)FindViewById(Resource.Id.buttonProceed);
            proceedButton.Click += ProceedButton_Click;
        }

        private void ProceedButton_Click(object sender, EventArgs e)
        {
            if (!optionARadio.Checked && !optionDRadio.Checked && !optionBRadio.Checked && !optionCRadio.Checked)
            {
                Snackbar.Make((View)sender, "Please select an answer", Snackbar.LengthShort).Show();
                //Android.Widget.Toast.MakeText(this, "Please select an answer", Android.Widget.ToastLength.Short).Show();
            }
            //checks option A for Correct Answer
            else if (optionARadio.Checked)
            {
                if (optionATextView.Text == quizQuestionList[quizPosition - 1].Answer)
                {
                    correctAnswerCount++;
                    CorrectAnswer();
                }
                else
                {
                    WrongAnswer();
                }
            }
            //checks option B for Correct Answer
            else if (optionBRadio.Checked)
            {
                if (optionBTextView.Text == quizQuestionList[quizPosition - 1].Answer)
                {
                    correctAnswerCount++;
                    CorrectAnswer();
                }
                else
                {
                    WrongAnswer();
                }
            }

            //checks option C for Correct Answer
            else if (optionCRadio.Checked)
            {
                if (optionCTextView.Text == quizQuestionList[quizPosition - 1].Answer)
                {
                    correctAnswerCount++;
                    CorrectAnswer();
                }
                else
                {
                    WrongAnswer();
                }
            }

            //checks option D for Correct Answer
            else if (optionDRadio.Checked)
            {
                if (optionDtextView.Text == quizQuestionList[quizPosition - 1].Answer)
                {
                    correctAnswerCount++;
                    CorrectAnswer();
                }
                else
                {
                    WrongAnswer();
                }
            }

        }

        private void OptionDRadio_Click(object sender, EventArgs e)
        {
            clearOptionSelected();
            optionDRadio.Checked = true;
        }

        private void OptionCRadio_Click(object sender, EventArgs e)
        {
            clearOptionSelected();
            optionCRadio.Checked = true;
            
        }

        private void OptionBRadio_Click(object sender, EventArgs e)
        {
            clearOptionSelected();
            optionBRadio.Checked = true;
        }

        private void OptionARadio_Click(object sender, EventArgs e)
        {
            clearOptionSelected();
            optionARadio.Checked = true;
        }

        void clearOptionSelected()
        {
            optionARadio.Checked = false;
            optionBRadio.Checked = false;
            optionCRadio.Checked = false;
            optionDRadio.Checked = false;
        }

        void BeginQuiz()
        {
            quizPosition = 1;
            quizQuestionList = quizHelper.GetQuizQuestions(QuizTopic);
            questionTextView.Text = quizQuestionList[0].QuizQuestion;
            optionATextView.Text = quizQuestionList[0].OptionA;
            optionBTextView.Text = quizQuestionList[0].OptionB;
            optionCTextView.Text = quizQuestionList[0].OptionC;
            optionDtextView.Text = quizQuestionList[0].OptionD;

            quizPositionTextView.Text = "Question" + quizPosition.ToString() + "/" + quizQuestionList.Count();

            dateTime = new DateTime();
            dateTime = dateTime.AddMinutes(2);
            timeCounterTextView.Text = dateTime.ToString("mm:ss");

            countDown.Enabled = true;

        }

        void CorrectAnswer()
        {
            CorrectFragment correctFragment = new CorrectFragment();
            var trans = SupportFragmentManager.BeginTransaction();
            correctFragment.Cancelable = false;
            correctFragment.Show(trans, "Correct");
            correctFragment.NextQuestion += CorrectFragment_NextQuestion;

        }   

        void WrongAnswer()
        {
            wrongFragment wrongFragment = new wrongFragment(quizQuestionList[quizPosition - 1].Answer);

            var trans = SupportFragmentManager.BeginTransaction();
            wrongFragment.Cancelable = false;
            wrongFragment.Show(trans, "Incorrect");
            wrongFragment.NextQuestion += CorrectFragment_NextQuestion;
        }

        private void CorrectFragment_NextQuestion(object sender, EventArgs e)
        {
            //Next Question
            quizPosition++;
            if (quizPosition  > quizQuestionList.Count)
            {
                CompleteQuiz();
                return;
            }

            
            int indx = quizPosition - 1;
            clearOptionSelected();

            questionTextView.Text = quizQuestionList[indx].QuizQuestion;
            optionATextView.Text = quizQuestionList[indx].OptionA;
            optionBTextView.Text = quizQuestionList[indx].OptionB;
            optionCTextView.Text = quizQuestionList[indx].OptionC;
            optionDtextView.Text = quizQuestionList[indx].OptionD;

            quizPositionTextView.Text = "Question" + quizPosition.ToString() + "/" + quizQuestionList.Count.ToString();
        }

        void CompleteQuiz()
        {
            timeCounterTextView.Text = "00:00";
            countDown.Enabled = false;

            string score = correctAnswerCount.ToString() + "/" + quizQuestionList.Count.ToString();
            double percentage = correctAnswerCount / double.Parse(quizQuestionList.Count.ToString()) * 100;
            string remarks = "";
            string image = "";

            if(percentage > 50 && percentage < 70)
            {
                remarks = "Very Good Result, You\n Really Tried";
            }
            else if(percentage >= 70)
                {
                remarks = "Very Outstanding Result You\n Killed it!!";

                }
            else if (percentage == 50)
            {
                remarks = "You Really Made It, \n Average Result";
            }
            else if(percentage < 50)
            {
                remarks = "So Sad You Didn't Make It,\n But You Can Try Again";
                image = "failed";
            }

            completedFragment completedFragment = new completedFragment(remarks, score, image);
            completedFragment.Cancelable = false;
            var trans = SupportFragmentManager.BeginTransaction();
            completedFragment.Show(trans, "Complete");

            completedFragment.GoHome += (sender, args) =>
            {
                this.Finish();
            };
        }
    }

}