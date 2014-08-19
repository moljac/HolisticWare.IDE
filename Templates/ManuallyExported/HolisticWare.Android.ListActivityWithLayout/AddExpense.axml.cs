using System;
using System.Collections.Generic;
using System.Linq;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;


namespace $rootnamespace$
{
	[Activity
		(
		// 
		  Label = "$safeitemname$"
		)
	]
	public
		partial
		class
		$safeitemname$
		:
		ListActivity	// OnListItemClick override
		// Activity		// No OnListItemClick
	{
		string[] data;

		protected override void OnCreate(Bundle bundle_applicationState)
		{
			// Invoke the base class ctor to bind with Android Activity
			// if not problems might be expected!
			base.OnCreate(bundle_applicationState);

			// TODO Move this to controller
			data = new string[] 
			{ 
			  "Food"
			, "fuel"
			, "hjjh"
			, "Holidays"
			, "Rent"
			, "Uf I have no Hebrew chars?! Is it Hebrew?"
			, "Add new..."
			};

			SetContentView(Resource.Layout.$safeitemname$);


			// ListView from axml
			//ListView list = FindViewById<ListView>(Resource.Id.listView1);

			# region    Adapter definition
			//-------------------------------------------------------------------------
			ArrayAdapter adapter = new ArrayAdapter
										(
										  // Android context
										  this
										, // Row Template - AXML file name, 
										  // NOT: id of the element in AXMl
										  Resource.Layout.AddExpense_axml_ListView_RowTemplate
										, data
										);
			//-------------------------------------------------------------------------
			// Custom Adapter
			// AddExpenseListAdapter contactsAdapter = new AddExpenseListAdapter(this);
			//-------------------------------------------------------------------------
			# endregion Adapter definition
	
			# region    Adapter assigning
			//-------------------------------------------------------------------------
			ListAdapter = adapter;	// for classes derived from ListActivity
			//-------------------------------------------------------------------------
			// Custom Adapter
			// list.Adapter = adapter;
			//-------------------------------------------------------------------------
			# endregion Adapter assigning



			return;
		}

		protected override void OnListItemClick(ListView l, View v, int position, long id)
		{
			var t = data[position];
			global::Android.Widget.Toast.MakeText
											(
											  this
											, t
											, global::Android.Widget.ToastLength.Short
											).Show();

			// Start Activity #2
			Intent intent = new global::Android.Content.Intent(this, typeof(AddExpenseThin));
			// intent.SetClassName(this, typeof($safeitemname$).ToString());
			// Send some data to new activity
			intent.PutExtra("Category", t);
			StartActivity(intent);
			
			return;
		}
	}
}

