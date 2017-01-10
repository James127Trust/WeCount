﻿using System.Threading.Tasks;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Webkit;
using HockeyApp.Android;
using HockeyApp.Android.Metrics;
using Microsoft.WindowsAzure.MobileServices;
using PITCSurveyApp.Helpers;
using PITCSurveyApp.Services;

namespace PITCSurveyApp.Droid
{
    [Activity (Label = "PITC Survey App", Theme = "@style/MainTheme", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity, IAuthenticate
	{
        protected override void OnCreate (Bundle bundle)
		{
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate (bundle);

            CrashManager.Register(this, Settings.HockeyAppId);

            MetricsManager.Register(Application, Settings.HockeyAppId);
            MetricsManager.EnableUserMetrics();

            global::Xamarin.Forms.Forms.Init (this, bundle);
            App.Init(this);
            LoadApplication (new PITCSurveyApp.App ());
		}

	    public async Task<MobileServiceUser> AuthenticateAsync(MobileServiceAuthenticationProvider provider)
	    {
	        try
	        {
	            return await SurveyCloudService.ApiClient.LoginAsync(this, provider);
	        }
            catch
            {
                return null;
            }
	    }

        public Task LogoutAsync()
        {
            CookieManager.Instance.RemoveAllCookie();
            return SurveyCloudService.ApiClient.LogoutAsync();
        }
    }
}

