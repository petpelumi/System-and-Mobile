using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Blood_Donor.DataModels;
using System;
using System.Collections.Generic;

namespace Blood_Donor.Adapters
{
    internal class DonorsAdapter : RecyclerView.Adapter
    {
        public event EventHandler<DonorsAdapterClickEventArgs> ItemClick;
        public event EventHandler<DonorsAdapterClickEventArgs> ItemLongClick;
        List<donor> DonorsList;

        public DonorsAdapter(List<donor> data)
        {
            DonorsList = data;
        }

        // Create new views (invoked by the layout manager)
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {

            //Setup your layout here
            View itemView = null;
            //var id = Resource.Layout.__YOUR_ITEM_HERE;
            //itemView = LayoutInflater.From(parent.Context).
            //       Inflate(id, parent, false);

          
          itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.donor_row, parent, false);

            var vh = new DonorsAdapterViewHolder(itemView, OnClick, OnLongClick);
            return vh;
        }

        // Replace the contents of a view (invoked by the layout manager)
        public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
        {
            var donor = DonorsList[position];

            // Replace the contents of the view with that element
            var holder = viewHolder as DonorsAdapterViewHolder;
            holder.donorNameTextView.Text = donor.Fullname;
            holder.donorLocationTextview.Text = donor.City + ", " + donor.Country;
            //holder.TextView.Text = items[position];

            //Assign appropriate images to donor group

            if (donor.Bloodgroup == "AB-")
            {
                holder.donorGroupImageView.SetImageResource(Resource.Drawable.ab_negative);
            }
            if (donor.Bloodgroup == "AB+")
            {
                holder.donorGroupImageView.SetImageResource(Resource.Drawable.ab_positive);
            }
            if (donor.Bloodgroup == "O-")
            {
                holder.donorGroupImageView.SetImageResource(Resource.Drawable.o_negative);
            }
            if (donor.Bloodgroup == "O+")
            {
                holder.donorGroupImageView.SetImageResource(Resource.Drawable.o_positive);
            }
            if (donor.Bloodgroup == "A+")
            {
                holder.donorGroupImageView.SetImageResource(Resource.Drawable.ab_positive);
            }
            if (donor.Bloodgroup == "A-")
            {
                holder.donorGroupImageView.SetImageResource(Resource.Drawable.a_negative);
            }
            if (donor.Bloodgroup == "B-")
            {
                holder.donorGroupImageView.SetImageResource(Resource.Drawable.b_negative);
            }
            if (donor.Bloodgroup == "b+")
            {
                holder.donorGroupImageView.SetImageResource(Resource.Drawable.b_positive);
            }
        }

        public override int ItemCount => DonorsList.Count;

        void OnClick(DonorsAdapterClickEventArgs args) => ItemClick?.Invoke(this, args);
        void OnLongClick(DonorsAdapterClickEventArgs args) => ItemLongClick?.Invoke(this, args);

    }

    public class DonorsAdapterViewHolder : RecyclerView.ViewHolder
    {
        //public TextView TextView { get; set; }
        public TextView donorNameTextView;
        public TextView donorLocationTextview;
        public ImageView donorGroupImageView;
        public RelativeLayout callLayout;
        public RelativeLayout emailLayout;
        public RelativeLayout deleteLayout;



        public DonorsAdapterViewHolder(View itemView, Action<DonorsAdapterClickEventArgs> clickListener,
                            Action<DonorsAdapterClickEventArgs> longClickListener) : base(itemView)
        {
            //TextView = v;
            donorNameTextView = (TextView)itemView.FindViewById(Resource.Id.donorNameTextView);
            donorLocationTextview = itemView.FindViewById<TextView>(Resource.Id.donorLocationTextView);
            donorGroupImageView = (ImageView)itemView.FindViewById(Resource.Id.bloodGroupImageView);
            emailLayout = (RelativeLayout)itemView.FindViewById(Resource.Id.emailLayout);
            deleteLayout = (RelativeLayout)itemView.FindViewById(Resource.Id.deleteLayout);
            itemView.Click += (sender, e) => clickListener(new DonorsAdapterClickEventArgs { View = itemView, Position = AdapterPosition });
            itemView.LongClick += (sender, e) => longClickListener(new DonorsAdapterClickEventArgs { View = itemView, Position = AdapterPosition });
        }
    }

    public class DonorsAdapterClickEventArgs : EventArgs
    {
        public View View { get; set; }
        public int Position { get; set; }
    }
}