using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using Android.Content;
using CbtXamarin.Ativities_file;
using AndroidX.DrawerLayout.Widget;
using Google.Android.Material.Navigation;
using Android.Views;

namespace CbtXamarin
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class MainActivity : AppCompatActivity
    {
        AndroidX.AppCompat.Widget.Toolbar toolbar;
        DrawerLayout drawerLayout;
        NavigationView navigationView;
      
    


        LinearLayout historylayout;
        LinearLayout geographylayout;
        LinearLayout spacelayout;
        LinearLayout engineeringlayout;
        LinearLayout programinglayout;
        LinearLayout businesslayout;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
       
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            toolbar = (AndroidX.AppCompat.Widget.Toolbar)FindViewById(Resource.Id.toolbar);
            drawerLayout = (DrawerLayout)FindViewById(Resource.Id.drawerLayout);
            navigationView = (NavigationView)FindViewById(Resource.Id.navview);
            navigationView.NavigationItemSelected += NavigationView_NavigationItemSelected;
            //setup toolbar

            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Topics";
            AndroidX.AppCompat.App.ActionBar actionBar = SupportActionBar;
            actionBar.SetHomeAsUpIndicator(Resource.Drawable.menuaction);
            actionBar.SetDisplayHomeAsUpEnabled(true);

            //view setup
            historylayout = (LinearLayout)FindViewById(Resource.Id.historylayout);
            geographylayout = (LinearLayout)FindViewById(Resource.Id.geographylayout);
            spacelayout = (LinearLayout)FindViewById(Resource.Id.spacelayout);
            engineeringlayout = (LinearLayout)FindViewById(Resource.Id.engineeringlayout);
            programinglayout = (LinearLayout)FindViewById(Resource.Id.programinglayout);
            businesslayout = (LinearLayout)FindViewById(Resource.Id.businesslayout);

            //view event handlers
            historylayout.Click += Historylayout_Click;
            geographylayout.Click += Geographylayout_Click;
            spacelayout.Click += Spacelayout_Click;
            engineeringlayout.Click += Engineeringlayout_Click;
            programinglayout.Click += Programinglayout_Click;
            businesslayout.Click += Businesslayout_Click;
        }

        private void NavigationView_NavigationItemSelected(object sender, NavigationView.NavigationItemSelectedEventArgs e)
        {
           if(e.MenuItem.ItemId == Resource.Id.navHistory)
            {
                // Do something
                InitHistory();
                drawerLayout.CloseDrawers();
            }
           else if(e.MenuItem.ItemId == Resource.Id.navGeography)
            {
                // Do something
                InitGeography();
                drawerLayout.CloseDrawers();
            }
            else if (e.MenuItem.ItemId == Resource.Id.navSpace)
            {
                // Do something
                InitSpace();
                drawerLayout.CloseDrawers();
            }
            else if (e.MenuItem.ItemId == Resource.Id.navEngineering)
            {
                // Do something
                InitEngineering();
                drawerLayout.CloseDrawers();
            }
            else if (e.MenuItem.ItemId == Resource.Id.navPrograming)
            {
                // Do something
                InitPrograming();
                drawerLayout.CloseDrawers();
            }
            else if (e.MenuItem.ItemId == Resource.Id.navBusiness)
            {
                // Do something
              InitBusiness();
                drawerLayout.CloseDrawers();
            }
        }

        private void Businesslayout_Click(object sender, System.EventArgs e)
        {
            InitBusiness();
        }

        private void Programinglayout_Click(object sender, System.EventArgs e)
        {
            InitPrograming(); 
        }

        private void Engineeringlayout_Click(object sender, System.EventArgs e)
        {
            InitEngineering();
        }

        private void Spacelayout_Click(object sender, System.EventArgs e)
        {
            InitSpace();
        }

        private void Geographylayout_Click(object sender, System.EventArgs e)
        {
            InitGeography();
        }

        private void Historylayout_Click(object sender, System.EventArgs e)
        {
            InitHistory();
        }

       void InitHistory()
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "History");
            StartActivity(intent); 
        }

        void InitGeography()
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "Geography");
            StartActivity(intent);
        }
        void InitSpace()
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "Space");
            StartActivity(intent);
        }
        void InitEngineering()
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "Engineering");
            StartActivity(intent);
        }
        void InitPrograming()
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "Programing");
            StartActivity(intent);
        }
        void InitBusiness()
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("topic", "Business");
            StartActivity(intent);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId) 
            {
                case Android.Resource.Id.Home:
                    drawerLayout.OpenDrawer((int)GravityFlags.Left);
                    return true;

                default:
                    return base.OnOptionsItemSelected(item);

            }
            
        }

    }
}