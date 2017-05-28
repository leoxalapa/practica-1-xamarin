using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace lab1
{
    [Activity(Label = "lab1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
       
        Button button;
        TextView textviewDev;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            textviewDev = FindViewById<TextView>(Resource.Id.MyButton);
            button = FindViewById<Button>(Resource.Id.MyButton);
            button.Click += Button_Click;
            
        }

        private async void Button_Click(object sender, EventArgs e)
        {
            textviewDev.Text = "insertar nombre";
            string myDevice = Android.Provider.Settings.Secure.GetString(ContentResolver, Android.Provider.Settings.Secure.AndroidId);
            button.Text = "gracias por completar el labolatorio 1";
            throw new NotImplementedException();
        }
    }
}

