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
using AndroidX.Fragment.App;

namespace CbtXamarin.Fragments
{
    public class completedFragment : AndroidX.Fragment.App.DialogFragment
    {
        ImageView thisImage;
        TextView remarksTextView;
        TextView scoreTextView;
        Button goHomeButton;

        string image, score, remarks;

        public event EventHandler GoHome;
        public completedFragment (string _score, string _remarks, string _image)
        {
            image = _image;
            score = _score;
            remarks = _remarks;
        }
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            View view = inflater.Inflate(Resource.Layout.completed, container, false);

            thisImage = (ImageView)view.FindViewById(Resource.Id.image);
            remarksTextView = (TextView)view.FindViewById(Resource.Id.remarksTextView);
            scoreTextView = (TextView)view.FindViewById(Resource.Id.scoreText);
           // goHomeButton = (Button)view.FindViewById(Resource.Id.goHomeButton);
            goHomeButton = view.FindViewById<Button>(Resource.Id.goHomeButton);
            goHomeButton.Click += GoHomeButton_Click;

            remarksTextView.Text = remarks;
            scoreTextView.Text = score;

            if (image == "failed")
            {
                thisImage.SetImageResource(Resource.Drawable.sad);
            }

            return view;
        }

        private void GoHomeButton_Click(object sender, EventArgs e)
        {
           this.Dismiss();
            GoHome?.Invoke(this, new EventArgs());
        }

    }
}