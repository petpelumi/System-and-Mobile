using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CbtXamarin.Fragments
{
    public class wrongFragment : AndroidX.Fragment.App.DialogFragment
    {
        string correctAnswer;
        Button nextButton;
        TextView correctAnswertextview;

        public event EventHandler NextQuestion;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public wrongFragment(string answer)
        {
            correctAnswer = answer;
            
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {

            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            View view = inflater.Inflate(Resource.Layout.wrong, container, false);
            //correctAnswertextview = view.FindViewById<TextView>(Resource.Id.correctAnswerText);
            correctAnswertextview = (TextView)view.FindViewById(Resource.Id.correctAnswerText);
            correctAnswertextview.Text = correctAnswer;
            // nextButton =.FindViewById<Button>(Resource.Id.correctAnswerText);
            nextButton = (Button)view.FindViewById(Resource.Id.NextButton);
            nextButton.Click += NextButton_Click;
            return view;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Dismiss();
            NextQuestion.Invoke(this, new EventArgs());
        }
    }
}