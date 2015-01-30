using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using com.vasundharareddy.emojicon;
using Android.Support.V4.App;

namespace EmotIcons
{
    [Activity(Label = "Launcher", MainLauncher = true)]	
	public class MainActivity : Android.Support.V4.App.FragmentActivity
	{
        EmojiconEditText m_EditEmojicon;
        EmojiconTextView m_TextEmojicon;
        private Button btncopy;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			m_EditEmojicon = FindViewById<EmojiconEditText> (Resource.Id.editEmojicon);
			m_TextEmojicon = FindViewById<EmojiconTextView> (Resource.Id.txtEmojicon);
		    btncopy = FindViewById<Button>(Resource.Id.button1);
			Android.Support.V4.App.FragmentManager mgr = SupportFragmentManager;
			EmojiconsFragment.EmojiClicked += (e) => {
				EmojiconsFragment.Input(m_EditEmojicon,e);
			};
			EmojiconsFragment.EmojiconBackspaceClicked += (v) => {
				EmojiconsFragment.Backspace(m_EditEmojicon);
			};
			m_EditEmojicon.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) => {
				m_TextEmojicon.Text = e.Text.ToString();
			};

            btncopy.Click += btncopy_Click;
		}

        void btncopy_Click(object sender, EventArgs e)
        {
            string lbltext = m_TextEmojicon.Text;
            m_EditEmojicon.Text = "";
            m_EditEmojicon.Text = lbltext;
        }
	}
}


        