using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;

namespace Income
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText incomePerHourEditText;
        EditText workHourEditText;
        EditText taxRateEditText;
        EditText savingsRateEditText;

        TextView workSummaryTextView;
        TextView grossIncomeTextView;
        TextView taxPayableTextView;
        TextView annualSavingTextView;
        TextView spendableIncomeTextView;

        Button calculateButton;
        RelativeLayout resultLayout;

        bool inputCalculated = false;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            ConnectViews();
        }
        void ConnectViews()
        {
            incomePerHourEditText = FindViewById<EditText>(Resource.Id.incomePerHour);
            workHourEditText = (EditText)FindViewById(Resource.Id.workHour);
            taxRateEditText = (EditText)FindViewById(Resource.Id.taxRate);
            savingsRateEditText = (EditText)FindViewById(Resource.Id.savingsRate);

            workSummaryTextView = (TextView)FindViewById(Resource.Id.Worksummartextview);
            grossIncomeTextView = (TextView)FindViewById(Resource.Id.GrossIncomeText);
            taxPayableTextView = (TextView)FindViewById(Resource.Id.AnnualTaxText);
            annualSavingTextView = (TextView)FindViewById(Resource.Id.AnnualSavingsText);
            spendableIncomeTextView = (TextView)FindViewById(Resource.Id.SpendableIncomeText);

            calculateButton = (Button)FindViewById(Resource.Id.calculateButton);
            resultLayout = (RelativeLayout)FindViewById(Resource.Id.ResultLayout);

            calculateButton.Click += CalculateButton_Click;
        }

        private void CalculateButton_Click(object sender, System.EventArgs e)
        {
            if(inputCalculated)
            {
                inputCalculated = false;
                calculateButton.Text = "Calculate";
                clearInput();
                return;
            }
            //Take inputs from user
            double incomeperhour = double.Parse(incomePerHourEditText.Text);
            double workhoursperday = double.Parse(workHourEditText.Text);
            double taxrate = double.Parse(taxRateEditText.Text);
            double savingsrate = double.Parse(savingsRateEditText.Text);

            double annualworkhoursummary = workhoursperday * 5 * 50; //assuming worker will take two weeks off from 52 weeks
            double annualincome = incomeperhour * workhoursperday * 5 * 50;
            double taxpayable = (taxrate / 100) * annualincome;
            double annualsavings = (savingsrate / 100) * annualincome;
            double spendablenincome = annualincome - annualsavings - taxpayable;


            //Display results of the calculations
            grossIncomeTextView.Text = "$" + annualincome.ToString("#,##") ;
            workSummaryTextView.Text = "$" + annualworkhoursummary.ToString("#,##");
            taxPayableTextView.Text = "$" + taxpayable.ToString("#,##");
            annualSavingTextView.Text = "$" + annualsavings.ToString("#,##");
            spendableIncomeTextView.Text = "$" + spendablenincome.ToString("#,##");

            resultLayout.Visibility = Android.Views.ViewStates.Visible;
            inputCalculated = true;
            calculateButton.Text = "clear";
        }

            void clearInput()
        {
            incomePerHourEditText.Text = "";
            workHourEditText.Text = "";
            taxRateEditText.Text = "";
            savingsRateEditText.Text = "";
            

            resultLayout.Visibility = Android.Views.ViewStates.Invisible;
        }
    }
}