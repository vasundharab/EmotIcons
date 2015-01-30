
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

namespace EmotIcons
{
	[Activity (Label = "Launcher",MainLauncher=true)]			
	public class Launcher : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			StartActivity (typeof(MainActivity));
			// Create your application here
		}
	}
}

