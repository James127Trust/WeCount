﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Foundation;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.WindowsAzure.MobileServices;
using PITCSurveyApp.Helpers;
using PITCSurveyApp.Services;
using UIKit;

namespace PITCSurveyApp.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate, IAuthenticate
    {
        public MobileServiceUser User
        {
            get { return SurveyCloudService.ApiClient.CurrentUser; }
            set { SurveyCloudService.ApiClient.CurrentUser = value; }
        }

        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            AppCenter.Start(UserSettings.AppCenterId,
                typeof(Analytics), typeof(Crashes));


            global::Xamarin.Forms.Forms.Init();
            App.Init(this);
            LoadApplication(new PITCSurveyApp.App());

            return base.FinishedLaunching(app, options);
        }

        public Task<MobileServiceUser> LoginAsync(MobileServiceAuthenticationProvider provider, IDictionary<string, string> parameters)
        {
            return SurveyCloudService.ApiClient.LoginAsync(
                UIApplication.SharedApplication.KeyWindow.RootViewController,
                provider,
                parameters);
        }

        public Task<MobileServiceUser> RefreshLoginAsync()
        {
            return SurveyCloudService.ApiClient.RefreshUserAsync();
        }

        public Task LogoutAsync()
        {
            foreach (var cookie in NSHttpCookieStorage.SharedStorage.Cookies)
            {
                NSHttpCookieStorage.SharedStorage.DeleteCookie(cookie);
            }

            return SurveyCloudService.ApiClient.LogoutAsync();
        }
    }
}
