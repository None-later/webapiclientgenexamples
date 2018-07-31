﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;


namespace FonlowAndroid.Droid
{
    [Activity(Label = "FonlowAndroid", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            var app = new App();
            var heroes = new MyAndroidVM.HeroesVM();
            app.MainPage.BindingContext = heroes;
            LoadApplication(app);

            heroes.Assign(MyAndroidVM.HeroesFunctions.LoadHeroes());
        }

        public override void SetContentView(View view)
        {
            base.SetContentView(view);
        }


    }
}

