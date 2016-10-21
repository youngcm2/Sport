using System;
using Xamarin.Forms;
using HockeyApp.iOS;
using Sport.Mobile.Shared;
using System.Collections.Generic;
using Foundation;
using System.Linq;

[assembly: Dependency(typeof(Sport.Mobile.iOS.HockeyApp))]

namespace Sport.Mobile.iOS
{
	public class HockeyApp: IHockeyApp
	{
		public HockeyApp()
		{
		}

		public void ShowFeedback()
		{
			var feedbackManager = BITHockeyManager.SharedHockeyManager.FeedbackManager;
			feedbackManager.ShowFeedbackListView();
		}

		public void TrackEvent(string eventName)
		{
			var metricsManager = BITHockeyManager.SharedHockeyManager.MetricsManager;

			metricsManager.TrackEvent(eventName);
		}

		public void TrackEvent(string eventName, IDictionary<string, string> properties, IDictionary<string, double> measurements)
		{
			var metricsManager = BITHockeyManager.SharedHockeyManager.MetricsManager;

			var props = properties ?? new Dictionary<string, string>();
			var meas = measurements ?? new Dictionary<string, double>();
			metricsManager.TrackEvent(eventName,
									  NSDictionary.FromObjectsAndKeys(props.Keys.ToArray(), props.Values.ToArray()),
			                          NSDictionary.FromObjectsAndKeys(meas.Keys.ToArray(), meas.Values.Cast<NSObject>().ToArray()));
		}
	}
}
