using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using CbtXamarin.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CbtXamarin.Ativities_file
{
    [Activity(Label = "QuizDescriptionActivity", Theme="@style/AppTheme")]
    public class QuizDescriptionActivity : AppCompatActivity
    {
        TextView quizTopicTextview;
        TextView descriptionTextView;
        ImageView quizImageView;
        Button   startQuizButton;
        
        //Variable
        string quizTopic;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SelectedTopic);
            quizTopicTextview = (TextView)FindViewById(Resource.Id.quizTopicText);
            descriptionTextView = (TextView)FindViewById(Resource.Id.quizImageDescriptionText);
            quizImageView = (ImageView)FindViewById(Resource.Id.quizImage);
            startQuizButton = (Button)FindViewById(Resource.Id.startQuizButton);
            
            startQuizButton.Click += StartQuizButton_Click;
            quizTopic = Intent.GetStringExtra("topic");
            quizTopicTextview.Text = quizTopic;

            quizImageView.SetImageResource(Getimage(quizTopic));

                //Retrieve description
            Quizhelpers quizhelpers = new Quizhelpers();
            descriptionTextView.Text = quizhelpers.GetTopicDescription(quizTopic);

        }

        private void StartQuizButton_Click(object sender, EventArgs e)
        {
           Intent intent = new Intent(this, typeof(QuizActivity));
            intent.PutExtra("topic", quizTopic);
            StartActivity(intent);
            Finish();
        }

        int Getimage(string topic)
        {
            int Imageint = 0;
            if (topic == "History")
            {
                Imageint = Resource.Drawable.history;
            }
            else if (topic == "Geography")
            {
                Imageint = Resource.Drawable.geography;
            }
            else if (topic == "Space")
            {
                Imageint = Resource.Drawable.space;
            }
            else if (topic == "Engineering")
            {
                Imageint = Resource.Drawable.engineering;
            }
            else if (topic == "Programing")
            {
                Imageint = Resource.Drawable.programming;
            }
            else if (topic == "Business")
            {
                Imageint = Resource.Drawable.business;
            }

            return Imageint;
        }
    }
}