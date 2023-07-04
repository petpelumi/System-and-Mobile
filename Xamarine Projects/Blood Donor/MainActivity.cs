using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Support.V7.Widget;
using Blood_Donor.Adapters;
using Blood_Donor.DataModels;
using System.Collections.Generic;


namespace Blood_Donor
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        List<donor> listOfDonors;
        DonorsAdapter donorsAdapter;
        RecyclerView donorsRecyclerView; 
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
          //  Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

           donorsRecyclerView = (RecyclerView)FindViewById(Resource.Id.donorsRecyclerView);
            CreateData();
            SetUpRecyclerView();
        }
       
        void CreateData()
        {
            listOfDonors = new List<donor>();
            listOfDonors.Add(new donor { Bloodgroup = "Ab+", City = "Ilorin", Country = "Nigeria", Email = "a@gmail.com", Fullname = "Ola Pelu", Phone ="0908877" });
            listOfDonors.Add(new donor { Bloodgroup = "O-", City = "Las Vagas", Country = "USA", Email = "c@gmail.com", Fullname = "Rita lawrence", Phone = "213444" });
            listOfDonors.Add(new donor { Bloodgroup = "B-", City = "Joannesberg", Country = "South Africa", Email = "k@gmail.com", Fullname = "Mbaka Weindi", Phone = "8376353" });
            listOfDonors.Add(new donor { Bloodgroup = "A+", City = "Accra", Country = "Ghana", Email = "j@gmail.com", Fullname = "Nancy WIla", Phone = "0383774" });
            listOfDonors.Add(new donor { Bloodgroup = "O+", City = "London", Country = "England", Email = "jgd@mail.com", Fullname = "patrick Beckam", Phone = "083837" });
            listOfDonors.Add(new donor { Bloodgroup = "AB-", City = "Brasila", Country = "Brazil", Email = "hhh@gmail.com", Fullname = "Roberto Alberto", Phone = "636363" });
        }

        void SetUpRecyclerView()
        {
            donorsRecyclerView.SetLayoutManager(new LinearLayoutManager(donorsRecyclerView.Context));
            donorsAdapter = new DonorsAdapter(listOfDonors);
            donorsRecyclerView.SetAdapter(donorsAdapter);


        }

    }
}