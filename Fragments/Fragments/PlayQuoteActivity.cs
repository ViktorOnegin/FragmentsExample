using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Fragments
{
    [Activity(Label = "PlayQuoteActivity")]
    public class PlayQuoteActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var PlayID = Intent.Extras.GetInt("cuttent_play_id", 0);

            var detailsFrag = PlayQuoteFragment.NewInstance(PlayID);
            FragmentManager.BeginTransaction()
                .Add(Android.Resource.Id.Content, detailsFrag)
                .Commit();
        }
    }
}