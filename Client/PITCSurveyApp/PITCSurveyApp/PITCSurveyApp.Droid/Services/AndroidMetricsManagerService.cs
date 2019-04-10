using System;
using System.Collections.Generic;
using Microsoft.AppCenter.Analytics;
using PITCSurveyApp.Services;

[assembly: Xamarin.Forms.Dependency(typeof(PITCSurveyApp.Droid.AndroidMetricsManagerService))]

namespace PITCSurveyApp.Droid
{
    class AndroidMetricsManagerService : IMetricsManagerService
    {
        public void TrackEvent(string eventName)
        {
            Analytics.TrackEvent(eventName);
        }

        public void TrackException(string eventName, Exception ex)
        {
            var properties = new Dictionary<string, string>
            {
                {"error", ex.Message},
            };

            TrackEvent(eventName, properties, null);
        }

        public void TrackLatency(string eventName, TimeSpan latency)
        {
            var measurements = new Dictionary<string, double>
            {
                { "latency", latency.TotalMilliseconds },
            };

            TrackEvent(eventName, null, measurements);
        }

        public void TrackEvent(string eventName, Dictionary<string, string> properties, Dictionary<string, double> measurements)
        {
            Analytics.TrackEvent(eventName, properties);  // TODO: figure out what's in measurements and update interface
        }
    }
}