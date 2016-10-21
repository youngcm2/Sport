using System;
using Xamarin.Forms;
using HockeyApp.iOS;
using Sport.Mobile.Shared;

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
	}
}
