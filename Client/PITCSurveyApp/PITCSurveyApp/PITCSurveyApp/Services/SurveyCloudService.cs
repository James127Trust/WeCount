﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.WindowsAzure.MobileServices;

using PITCSurveyLib.Models;
using PITCSurveyLib;

namespace PITCSurveyApp.Services
{
    public static class SurveyCloudService
    {
        private const string AzureMobileAppUrl = "https://appname.azurewebsites.net";

        public static MobileServiceClient ApiClient;

        static SurveyCloudService()
        {
            ApiClient = new MobileServiceClient(AzureMobileAppUrl);
        }

        public static async Task<SurveyModel> GetLatestSurvey(int ID = 1)
        {
			/*
			var parameters = new Dictionary<string, string>{{"id", "1"}};

            try
            {
                var result = await ApiClient.InvokeApiAsync<SurveyModel>("Surveys", System.Net.Http.HttpMethod.Get, parameters);
                return result;
            }
            catch
            {
                return null;
            }
			*/

			// NOTE: ATY - Replaced original code above with call to new helper below.

			try
			{
				var API = new APIHelper();

				return await API.GetSurveyByIDAsync(ID);
			}
			catch (Exception)
			{
				// TODO: Return error to show to user?
				return null;
			}
        }

    }
}
