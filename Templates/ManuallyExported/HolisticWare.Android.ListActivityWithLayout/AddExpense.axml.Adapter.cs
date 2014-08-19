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
	public class AddExpenseAdapterCategory : BaseAdapter
	{
		List<Category> list_items;
		Activity activity;

		public AddExpenseAdapterCategory(Activity a)
		{
			activity = a;

			return;
		}


		# region    BaseAdapter Abstract Methods Implementations
		//-------------------------------------------------------------------------
		public override int Count
		{
			get
			{
				return list_items.Count; 
			}
		}

		public override Java.Lang.Object GetItem(int position)
		{
			// could wrap a Contact in a Java.Lang.Object
			// to return it here if needed
			return null;
		}

		public override long GetItemId(int position)
		{
			return position;
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			View v1 = new TextView(null)
							{
								Text = list_items[position].ToString()
							};
			return v1;


			# region    RowTemplate from AXML
			//-------------------------------------------------------------------------
			// null coalesce operator (if convertView exists use it if not inflate it)
			View view = 
				convertView 
				?? 
				activity.LayoutInflater.Inflate
										(
										  Resource.Layout.AddExpense // RowTemplate.axml
										, parent
										, false
										);
			//-------------------------------------------------------------------------
			# endregion RowTemplate from AXML
	

	
			return view;
		}
		//-------------------------------------------------------------------------
		# endregion BaseAdapter Abstract Methods Implementations
	

	}
}