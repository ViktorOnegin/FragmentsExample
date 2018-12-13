using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace Fragments
{
    public class TitlesFragment : ListFragment
    {
        int selectedPlayID;

        public TitlesFragment()
        {

        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
            ListAdapter = new ArrayAdapter<String>(Activity, Android.Resource.Layout.SimpleListItemActivated1, Shakespeare.Titles);

            if (savedInstanceState  != null)
            {
                selectedPlayID = savedInstanceState.GetInt("current_play_id", 0);

            }
        }

        public override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);
            outState.PutInt("current_play_id", selectedPlayID);
        }

        public override void OnListItemClick(ListView l, View v, int position, long id)
        {
            ShowPlayQuote(position);
        }

        void ShowPlayQuote(int PlayID)
        {
            var intent = new Intent(Activity, typeof(PlayQuoteActivity));
            intent.PutExtra("current_play_id", PlayID);
            StartActivity(intent);
        }
    }
}