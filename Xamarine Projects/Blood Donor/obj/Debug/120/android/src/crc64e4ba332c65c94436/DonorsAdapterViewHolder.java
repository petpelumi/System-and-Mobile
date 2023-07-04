package crc64e4ba332c65c94436;


public class DonorsAdapterViewHolder
	extends androidx.recyclerview.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Blood_Donor.Adapters.DonorsAdapterViewHolder, Blood Donor", DonorsAdapterViewHolder.class, __md_methods);
	}


	public DonorsAdapterViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == DonorsAdapterViewHolder.class)
			mono.android.TypeManager.Activate ("Blood_Donor.Adapters.DonorsAdapterViewHolder, Blood Donor", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
